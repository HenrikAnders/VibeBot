using MetroFramework;
using System;                      
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
     
        /// <summary>
        /// use lame to convert from wave to mp3
        /// </summary>
        public async void convert(bool deleteFile)
        {     
                foreach (var file in Directory.GetFiles(path).ToList())
                {
                    if (file.Contains(".wav"))
                    {              
                        Process p = new Process();
                        p.StartInfo.FileName = "lame.exe";
                        p.StartInfo.Arguments = "-b 32 --resample 22.05 -m m \"" + file + "\" \"" + file.Replace(".wav", ".mp3") + "\"";
                        p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        p.Start();
                        p.WaitForExit();
                        if (deleteFile)
                        {
                            File.Delete(file);
                        }
                    }
                }
            await Task.Delay(1);
        }

        /// <summary>
        /// set the amplitude to given value
        /// </summary>
        public async void normazize(float db)
        {   
                foreach (string file in Directory.GetFiles(path))
                {
                    if (file.Contains(".mp3"))
                    {
                        try
                        {
                            //https://wiki.ubuntuusers.de/MP3Gain/
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
                            p.StartInfo.Arguments = " /c /d " + db+" /r \"" + file;
                            //p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;        
                            p.Start();
                            p.WaitForExit();
                        }
                        catch (Exception)
                        {
                            MetroMessageBox.Show(Form.ActiveForm, file+" is used in another programm!");
                        }
                    }

                }
           
            await Task.Delay(1);
        }

        /// <summary>
        /// get song information and write it into the metadata
        /// </summary>
        public async void tagging()
        {          
                foreach (var file in Directory.GetFiles(path))
                {
                    try
                    {
                        if (file.Contains(".mp3"))
                        {
                            TagLib.File filetoTag = TagLib.File.Create(file);
                            String fileName = Path.GetFileNameWithoutExtension(file);
                            filetoTag.Tag.Title = fileName.Substring(fileName.IndexOf("-") + 2);
                            filetoTag.Tag.Performers = null;
                            filetoTag.Tag.Performers = new[] { fileName.Substring(0, fileName.IndexOf("-") - 1) };
                            filetoTag.Save();
                        }
                    }
                    catch
                    {
                        MetroMessageBox.Show(Form.ActiveForm, "Unknow file format of file: " + file);
                    }
                }
            await Task.Delay(1);
        }                                    
    }
}
