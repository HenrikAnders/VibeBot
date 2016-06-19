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
        private String path = "";
        public Bot(String path)
        {
            this.path = path;
        }
        /// <summary>
        /// return a list with wave or flag files
        /// </summary>
        /// <param name="path">path were files come from</param>
        /// <returns></returns>
        private void grabMP3(String path)
        {                                      
            List<byte[]> files = new List<byte[]>();
            List<String> fileNamesmp3 = Directory.GetFiles(path).ToList();
            fileNamesmp3 = fileNamesmp3.Where(o => fileNamesmp3.Contains(".mp3")).ToList();

            foreach (String file in fileNamesmp3)
            {
                Clipboard.SetAudio(File.ReadAllBytes(path + "\\" + file));
            }           
        }

        /// <summary>
        /// return a list with mp3 files
        /// </summary>
        /// <param name="path">path were files come from</param>
        /// <returns></returns>
        private void grabNonConvertedData()
        {
            List<byte[]> files = new List<byte[]>();
            List<String> fileNamesmp3 = Directory.GetFiles(path).ToList();
            fileNamesmp3 = fileNamesmp3.Where(o => fileNamesmp3.Contains(".wav") || fileNamesmp3.Contains(".flag")).ToList();

            foreach (String file in fileNamesmp3)
            {
                Clipboard.SetAudio(File.ReadAllBytes(path + "\\" + file));
            }
        }

        /// <summary>
        /// invoke the mp3 to wave
        /// </summary>
        public async void convert()
        {
            #region old grab
            //grabNonConvertedData();
            //Process.Start(@"D:\Programme\Download\Mp3converter.exe");    //Name?!      
            //var proc = Process.GetProcessesByName("mp3Converter").FirstOrDefault();  //mp3converter?!Name
            //if (proc != null && proc.MainWindowHandle != IntPtr.Zero)
            //    SetForegroundWindow(proc.MainWindowHandle);  
            //SendKeys.Send("^v");    //control and v  paste files into app
            //SendKeys.Send("^a");    //control and a highlight all
            //SendKeys.Send("");      // run converting     
            //killProcess("Mp3Converter");
            #endregion
            
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
                    File.Delete(file);
                }
            }
            await Task.Delay(1);
        }

        /// <summary>
        /// set the amplitude to 95db
        /// </summary>
        public async void normazize(double db)
        {      //http://pclosmag.com/html/Issues/201304/page11.html
            db =(db == 0) ? db  :  6.0;    // if (bd==0)  db0=6.0 else {db=db}
            foreach (string file in Directory.GetFiles(path))
            {
                if ( file.Contains(".mp3"))
                {
                    #region param description
                    // -c : ignore clipping
                    //-p  : preserve file modification time
                    // -r : apply Track gain
                    // -d 2.0: makes it 91.0 dB (defaults to 89.0)
                    //  alias mymp3gain = 'mp3gain -c -p -r -d 2.0'
                    #endregion
                    Process p =new Process();
                    p.StartInfo.FileName = "mp3gain.exe";       
                    p.StartInfo.Arguments = "-d 6 -r " + file; // /Q for quiet mode, but no Normalizing     always do space between "" and file
                  //  p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    // Process p =  Process.Start("mp3gain.exe", "-d 6 -r " + file); hat funktioniert aber nicht versteckt
                    p.Start();
                    p.WaitForExit();
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
                if (file.Contains(".mp3"))
                {
                    ;
                    TagLib.File filetoTag = TagLib.File.Create( file);
                    String fileName = Path.GetFileNameWithoutExtension(file);
                    filetoTag.Tag.Title =  fileName.Substring(fileName.IndexOf("-") + 2) ;
                    filetoTag.Tag.Performers = null;
                    filetoTag.Tag.Performers = new[] { fileName.Substring(0, fileName.IndexOf("-") - 1) } ;
                    filetoTag.Save();   
                }
            }
            await Task.Delay(1);
        } 

        /// <summary>
        /// Kills a given process
        /// </summary>
        /// <param name="process">process Name</param>
        private void killProcess(String process)
        {
            foreach (var proc in Process.GetProcessesByName(process))
            {
                proc.Kill();  
            }
        }                                     
    }
}
