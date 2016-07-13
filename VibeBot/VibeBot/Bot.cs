using MetroFramework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;                      
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VibeBot
{
    class Bot
    {
        //features for audio editing: http://mpg123.de/features.shtml


        private String path = "";  
        public Bot(String path)
        {
            this.path = path;
        }

        public List<String> getFiles()
        {
            return Directory.GetFiles(path).ToList();
        }

        /// <summary>
        /// use lame to convert from wave to mp3
        /// </summary>
        public async void convert(bool deleteFile)
        {
            foreach (var file in getFiles())
            {
                try
                {

                    if (file.Contains(".wav"))
                    {
                        Process p = new Process();
                        p.StartInfo.FileName = "lame.exe";
                        p.StartInfo.Arguments = "-b 320 --resample 44.1 -m m \"" + file + "\" \"" + file.Replace(".wav", ".mp3") + "\"";
                        p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        p.Start();
                        p.WaitForExit();
                        if (deleteFile)
                        {
                            File.Delete(file);
                        }

                    }
                }
                catch
                {
                    MetroMessageBox.Show(Form.ActiveForm, file + " is used in another programm, or is not a .wav file", "Convert Error");
                }
            }
            await Task.Delay(1);
        }

        /// <summary>
        /// set the amplitude to given value
        /// </summary>
        public async void normazize(float db, bool reset)
        {
            foreach (string file in getFiles())
            {
                if (file.Contains(".mp3"))
                {
                    if (reset)
                    {
                        try
                        {
                            Process p = new Process();
                            p.StartInfo.FileName = "mp3gain.exe";
                            p.StartInfo.Arguments = " /c /r \"" + file;
                            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                            p.Start();
                            p.WaitForExit();
                        }
                        catch (Exception)
                        {
                            MetroMessageBox.Show(Form.ActiveForm, file + " is used in another programm!", "Normalizing Error");
                        }
                    }
                    else
                    {
                        if (db != 0)
                            try
                            {
                                #region param description
                                //  /c : ignore clipping
                                //  /r : apply Track gain of 89 db (default)
                                //  /p : preserve file modification time         
                                //  /d 2.0: makes it 91.0 dB (defaults to 89.0)
                                //  /Q for quiet mode 
                                //   \filename   without backslash no function!
                                //  alias mymp3gain = 'mp3gain -c -p -r -d 2.0'
                                #endregion
                                Process p = new Process();
                                p.StartInfo.FileName = "mp3gain.exe";
                                p.StartInfo.Arguments = " /c /g " + db + " /r \"" + file;
                                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                                p.Start();
                                p.WaitForExit();
                            }
                            catch (Exception)
                            {
                                MetroMessageBox.Show(Form.ActiveForm, file + " is used in another programm!", "Normalizing Error");
                            }
                    }
                }
            }
            await Task.Delay(1);
        }

        /// <summary>
        /// analyze files from directory
        /// </summary>
        /// <param name="path"></param>
        /// <returns>2D Array first dimension File Name, second dimension gain</returns>
        public async Task<List<KeyValuePair<String, float>>> analyze(String path,bool reanalyze)
        {
            List<string> files = getFiles();
            float gain = 0;
            int index = 0; List<KeyValuePair<String, float>> gainValue = new List<KeyValuePair<String, float>>();
            //get list of analyzed files    
            string tempFile = Path.GetTempPath() + "analyzedGain.tmp";   
            if (reanalyze)
            {   //if reanalyze equals true, the existing .tmp file would be cleaned up 
                File.WriteAllText(tempFile, String.Empty);
            }
            if (File.Exists(tempFile) && new FileInfo(tempFile).Length!=0 && reanalyze==false)
            {
                string line = "";
                using (StreamReader streamFile = new StreamReader(tempFile))
                {
                    while ((line = streamFile.ReadLine()) != null)
                    {
                        gainValue.Insert(index, new KeyValuePair<String, float>(line.Substring(0,line.IndexOf('#')-1), float.Parse(line.Substring(line.IndexOf('#')+1))));
                        index++;
                    }
                }
            }
            else
            {
                using (StreamWriter streamFile = new StreamWriter(tempFile))               
                {
                 //   File.Create(tempFile);
                    string track = "";
                    for (int i = 0; i < files.Count; i++)
                    {
                        if (files.ElementAt(i).Contains(".mp3"))
                        {
                            try
                            {
                                Process p = new Process();
                                p.StartInfo.FileName = "mp3gain.exe";
                                p.StartInfo.Arguments = "/q /s r \"" + files.ElementAt(i);    //\s r  force recalculation    /q  quiet mode
                                p.StartInfo.CreateNoWindow = true;
                                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                                p.StartInfo.UseShellExecute = false;
                                p.StartInfo.RedirectStandardOutput = true;        //allow console reading
                                p.Start();
                                string outputLine;
                                while ((outputLine = p.StandardOutput.ReadLine()) != null)
                                {    //search inside+ the console output from running process
                                    if (outputLine.Contains("dB change:"))
                                    {    //write captured data into variable
                                        gain = float.Parse(outputLine.Substring(32));
                                        break;
                                    }
                                }
                                p.WaitForExit();
                                TagLib.File fileTag = TagLib.File.Create(files.ElementAt(i));
                                try
                                {            //write file into keyvalue list
                                    track = fileTag.Tag.Performers[0] + "-" + fileTag.Tag.Title;
                                    gainValue.Insert(index, new KeyValuePair<string, float>(track, gain));
                                }
                                catch
                                {
                                    //no need to implement
                                }
                                index++;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                                MetroMessageBox.Show(Form.ActiveForm, files.ElementAt(i) + " is used in another programm!", "Analyze Error");
                            }
                            try
                            {
                                //write analyzed file into temp file
                                streamFile.WriteLine(track + "#" + gain);
                            }
                            catch { }
                        }
                    }
                }
            }
            await Task.Delay(1);
            return gainValue;
        }     


        /// <summary>
        /// get song information and write it into the metadata
        /// </summary>
        public async void tagging()
        {
            foreach (var file in getFiles())
            {
                String fileName = Path.GetFileNameWithoutExtension(file);
                try
                {
                    if (file.Contains(".mp3"))
                    {
                        TagLib.File filetoTag = TagLib.File.Create(file);
                        filetoTag.Tag.Title = fileName.Substring(fileName.IndexOf("-") + 2);
                        filetoTag.Tag.Performers = null;
                        filetoTag.Tag.Performers = new[] { fileName.Substring(0, fileName.IndexOf("-") - 1) };
                        filetoTag.Save();
                    }
                }
                catch
                {
                    MetroMessageBox.Show(Form.ActiveForm, fileName.Substring(fileName.IndexOf("-") + 1) + "\r\nFile format must be like: artist - title ", "Tagging error");
                }
            }
            await Task.Delay(1);
        }
    }
}
