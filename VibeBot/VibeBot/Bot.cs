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
        bool found = true;
        private String path = "";
        public Bot(String path)
        {
            this.path = path;
            if (Directory.GetFiles(path).Count()==0)
            {
                found = false;
                MetroMessageBox.Show(Form.ActiveForm,"No files found on the given path!     Make sure that there a wave or mp3 files!","");
            }
        }
     
        /// <summary>
        /// invoke the mp3 to wave
        /// </summary>
        public async void convert(bool deleteFile)
        {
            if (found) //true, if there are files to edit
                foreach (var file in Directory.GetFiles(path).ToList())
                {
                    if (file.Contains(".flag") || file.Contains(".wav"))
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
        /// set the amplitude to 95db
        /// </summary>
        public async void normazize(float db)
        {      //http://pclosmag.com/html/Issues/201304/page11.html     

            if (found)
                foreach (string file in Directory.GetFiles(path))
                {
                    if (file.Contains(".mp3"))
                    {
                        try
                        {
                            //https://wiki.ubuntuusers.de/MP3Gain/
                            #region param description
                            // -c : ignore clipping
                            //-p  : preserve file modification time
                            // -r : apply Track gain of 89 db (default)
                            // -d 2.0: makes it 91.0 dB (defaults to 89.0)
                            //  alias mymp3gain = 'mp3gain -c -p -r -d 2.0'
                            #endregion
                            Process p = new Process();
                            p.StartInfo.FileName = "mp3gain.exe";
                            p.StartInfo.Arguments = " /c /r /d " + db+" " + file;
                            // /Q for quiet mode, but no Normalizing     always do space between "" and file
                            // p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                            // Process p =  Process.Start("mp3gain.exe", "-d 6 -r " + file); //hat funktioniert aber nicht versteckt
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
            if (found)
                foreach (var file in Directory.GetFiles(path))
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
            await Task.Delay(1);
        }                                    
    }
}
