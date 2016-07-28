using MetroFramework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace VibeBot
{
    class Bot
    {
        //features for audio editing: http://mpg123.de/features.shtml


        private String path = "";
        List<string> lMp3Files = new List<string>();
        List<string> lWavFiles = new List<string>();
        bool singleFile = false;
        public Bot(String path)
        {
            this.path = path;
            setmp3List();
            setWavList();
        }

        public void setmp3List()
        {
            if (this.path.Contains(".mp3"))     //check if single file
            {
                lMp3Files.Add(path);
                singleFile = true;
            }
            else if(!singleFile && Directory.GetFiles(path).Where(s => (s.Contains(".mp3"))).Count() != 0)
            {
                lMp3Files.AddRange( Directory.GetFiles(path).ToList().Where(s=>(s.Contains(".mp3"))));//get all mp3 files from path
            }
        }        
        public void setWavList()
        {
            if (this.path.Contains(".wav"))     //check if single file
            {
                lWavFiles.Add(path);
                singleFile = true;
            }
            else if (!singleFile && Directory.GetFiles(path).Where(s => (s.Contains(".wav"))).Count() !=0)
            {
                lWavFiles.AddRange(Directory.GetFiles(path).ToList().Where(s => (s.Contains(".wav"))));//get all mp3 files from path
            }
        }

        /// <summary>
        /// use lame to convert from wave to mp3
        /// </summary>
        public void convert(bool deleteFile)
        {
            foreach (var file in lWavFiles)
            {
                try
                {   
                        Process p = new Process();
                        p.StartInfo.FileName = "lame.exe";
                        //-b 320 kbits  samplerate 44100 -m s => Stereo  
                        p.StartInfo.Arguments = " -b 320 --resample 44.1 -m s \"" + file + "\" \"" + file.Replace(".wav", ".mp3") + "\"";
                        p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        p.Start();
                        p.WaitForExit();
                        if (deleteFile)
                        {
                            File.Delete(file);
                        }    
                }
                catch
                {
                    MetroMessageBox.Show(Form.ActiveForm, file + " is used in another programm, or is not a .wav file", "Convert Error");
                }
            }                       
        }

        /// <summary>
        /// set the amplitude to given value
        /// </summary>
        public  void normalyze(float db, bool reset)
        {
            foreach (string file in lMp3Files)
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
          //  await Task.Delay(1);
        }

        /// <summary>
        /// analyze files from directory
        /// </summary>
        /// <param name="path"></param>
        /// <returns>2D Array first dimension File Name, second dimension gain</returns>
        public  List<KeyValuePair<String, String>> analyze(String path, bool reanalyze)
        {
         

            string gain = "";
            int index = 0; List<KeyValuePair<String, string>> gainValue = new List<KeyValuePair<String, string>>();
            if (lMp3Files.Count>=1)      //only do analyzing if list !=empty   
            {//get list of analyzed files    
                string tempFile = Path.GetTempPath() + "analyzedGain.tmp";
                if (reanalyze)
                {   //if reanalyze equals true, the existing .tmp file would be cleaned up 
                    File.WriteAllText(tempFile, String.Empty);
                }
                #region get already analyzed files
                if (File.Exists(tempFile) && new FileInfo(tempFile).Length != 0 && reanalyze == false)
                {
                    string line = "";
                    using (StreamReader streamFile = new StreamReader(tempFile))
                    {
                        while ((line = streamFile.ReadLine()) != null)
                        {
                            gainValue.Insert(index, new KeyValuePair<String, String>(line.Substring(0, line.IndexOf('#') - 1), line.Substring(line.IndexOf('#') + 1)));
                            index++;
                        }
                    }
                }
                #endregion
                else
                {  
                    #region analyze files
                    using (StreamWriter streamFile = new StreamWriter(tempFile))
                    {
                        //   File.Create(tempFile);
                        string track = "";                                                        
                        for (int i = 0; i < lMp3Files.Count; i++)
                        {
                            
                                try
                                {
                                    Process p = new Process();
                                    p.StartInfo.FileName = "mp3gain.exe";
                                    p.StartInfo.Arguments = "/q /s r \"" + lMp3Files.ElementAt(i);    //  /q  quiet mode  \s r  force recalculation   
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
                                            float fgain= float.Parse(outputLine.Substring(32))+87;
                                            gain = fgain.ToString();
                                           // break;
                                        }
                                        if (outputLine.Contains("clipping"))
                                        {
                                            gain = "!" + gain;
                                            break;
                                        }

                                    }
                                    p.WaitForExit();      
                                    try
                                    {   //write file into keyvalue list
                                        track = Path.GetFileNameWithoutExtension(lMp3Files.ElementAt(i));
                                        gainValue.Insert(index, new KeyValuePair<string, string>(track, gain));
                                    }
                                    catch
                                    { //no need to implement 
                                    }
                                    index++;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e);
                                    MetroMessageBox.Show(Form.ActiveForm, lMp3Files.ElementAt(i) + " is used in another programm!", "Analyze Error");
                                }
#endregion
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
            else
            {    //write error into list if no mp3 files found
                gainValue.Insert(0, new KeyValuePair<string, string>("! No files found !"," "));
            }                          
            return gainValue;
        }    

        /// <summary>
        /// get song information and write it into the metadata
        /// </summary>
        public void tagging()
        {
            foreach (var file in lMp3Files)
            {
                String fileName = Path.GetFileNameWithoutExtension(file);
                try
                {   
                        TagLib.File filetoTag = TagLib.File.Create(file);
                        filetoTag.Tag.Title = fileName.Substring(fileName.IndexOf("-") + 1);
                        filetoTag.Tag.Performers = null;
                        filetoTag.Tag.Performers = new[] { fileName.Substring(0, fileName.IndexOf("-") ) };
                        filetoTag.Save();       
                }
                catch
                {
                    MetroMessageBox.Show(Form.ActiveForm, fileName.Substring(fileName.IndexOf("-") + 1) + "\r\nFile format must be like: artist - title ", "Tagging error");
                }
            }                      
        }

        public void deleteSelection(String element) {     
            foreach (String file in lMp3Files)
            {  //get the path from file in directory and delete it
                if (file.Contains(element))
                {
                    FileSystem.DeleteFile(file, UIOption.OnlyErrorDialogs,  RecycleOption.SendToRecycleBin);
                }
            }
        }
    }
}
                                                                   