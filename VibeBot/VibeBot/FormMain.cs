using System;
using System.Threading.Tasks;
using MetroFramework.Forms;
using Microsoft.Win32;
using System.Linq;
using System.Globalization;
using MetroFramework;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace VibeBot
{
    public partial class VibeBot : MetroForm
    {
        public VibeBot()
        {
            InitializeComponent();
            TopMost = false; // without the Messageboxes will bi hidden behind the main window
            tbStatus.Visible = true;
            pLoad.Visible = false;
            tbPath.Text = getPath();
            tbdB.Text = "6";
            picComplete.Visible = false;
            this.MaximizeBox = false;
            tbAbout.Visible = false;
        }

        private void Path_Click(object sender, EventArgs e)
        {
            picComplete.Visible = false;
            tbPath.Text = "";
            resetStatus();
        }

        private async void bRun_Click_1(object sender, EventArgs e)
        {
            if (Directory.GetFiles(setPath(), "*.wav").Length == 0 && Directory.GetFiles(setPath(), "*.mp3").Length == 0)
            {
                MetroMessageBox.Show(this, "No files found on the given path!     Make sure that there are wave or mp3 files!", "");
            }
            else
            {
                resetStatus();
                tbdB.Enabled = false;
                tbPath.Enabled = false;
                cbDelete.Enabled = false;
                cbReset.Enabled = false;
                picComplete.Visible = false;
                tbStatus.Text = "";

                Bot bot = new Bot(setPath());

                pLoad.Visible = true;
                await Task.Run(() => bot.convert(cbDelete.Checked));
                tbStatus.AppendText("Converted, ");

                await Task.Run(() => bot.normazize(float.Parse(tbdB.Text, CultureInfo.InvariantCulture.NumberFormat), cbReset.Checked));
                tbStatus.AppendText("normalized ");

                await Task.Run(() => bot.tagging());
                tbStatus.AppendText("and tagged is complete");

                tbStatus.ForeColor = System.Drawing.Color.Blue;
                pLoad.Visible = false;
                picComplete.Visible = true;

                tbdB.Enabled = true;
                tbPath.Enabled = true;
                cbDelete.Enabled = true;
                cbReset.Enabled = true;
            }
        }

        /// <summary>
        /// get path from registry, if it exsists
        /// </summary>
        /// <returns>String path</returns>
        public String getPath()
        {
            String regPath = "";
            RegistryKey reg = Registry.CurrentUser;
            if (reg.GetValueNames().Contains("VibeBotPath"))
            {   //if key exists--> get value
                regPath = (string)reg.GetValue("VibeBotPath");
            }
            return regPath;
        }

        /// <summary>
        /// get path from textbox if registry is empty
        /// </summary>
        /// <returns></returns>
        public String setPath()
        {
            RegistryKey reg = Registry.CurrentUser;
            String regPath = "";
            try
            {
                if (!string.IsNullOrEmpty(this.tbPath.Text) && Directory.Exists(this.tbPath.Text) && !Directory.GetAccessControl(this.tbPath.Text).AreAccessRulesProtected)
                {
                    //create the registry key with value path
                    reg = Registry.CurrentUser;
                    regPath = tbPath.Text;
                    reg.SetValue("VibeBotPath", tbPath.Text);
                }
                else
                {
                    MetroMessageBox.Show(ActiveForm, "Access to the given path is denied", "");
                }
            }
            catch { }
            finally
            {
                if (reg != null)
                {
                    reg.Dispose();
                    reg.Close();
                }
            }
            return regPath;
        }

        /// <summary>
        /// validate user input, used to set the button bRun.Enable = true/false
        /// </summary>
        /// <returns></returns>
        private bool validate()
        {
            bool bPath = !string.IsNullOrEmpty(this.tbPath.Text) && Directory.Exists(this.tbPath.Text) && !Directory.GetAccessControl(this.tbPath.Text).AreAccessRulesProtected;
            bool bDB = !lLevel.Text.Equals("!Invalid input!");
            tbPath.ForeColor = (bPath) ? System.Drawing.Color.Red : System.Drawing.Color.Red;
            return bPath && bDB;
        }

        private void pathTextChanged(object sender, EventArgs e)
        {
            picComplete.Visible = false;
            bRun.Enabled = validate();
        }

        private void tbDBTextChanged(object sender, EventArgs e)
        {
            resetStatus();
            picComplete.Visible = false;
            lLevel.ForeColor = System.Drawing.Color.Black;
            try
            {     //if it´s not a number show "Invalid input"
                double level = float.Parse(tbdB.Text, CultureInfo.InvariantCulture.NumberFormat) + 89;
                lLevel.ForeColor = System.Drawing.Color.Gray;
                lLevel.Text = "Output level -> " + level + " dB";
            }
            catch (Exception)
            {
                lLevel.ForeColor = System.Drawing.Color.Red;
                lLevel.Text = "!Invalid input!";
            }
            bRun.Enabled = validate();
        }

        private void folderBrowserClick(object sender, EventArgs e)
        {
            resetStatus();
            picComplete.Visible = false;
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = folderBrowser.SelectedPath;
            }
        }

        //invoke the analyze window
        private async void bAnalyze(object sender, EventArgs e)
        {                    
            picComplete.Visible = false;           
            await Task.Run(() => new FormAnalyze(setPath()));            
        }
        private void cbResetChecked(object sender, EventArgs e)
        {
            resetStatus();
            picComplete.Visible = false;
            tbdB.Text = cbReset.Checked ? "0" : "6";
            tbdB.Enabled = cbReset.Checked? false :true ;    //if checked, tbTextbox disabled
        }

        private void bInfo(object sender, EventArgs e)
        {
            tbStatus.Text = "";
            bEnglish.Visible = tbAbout.Visible ? false : true;//if info is shown, Button eng is also shown
            bDeutsch.Visible = tbAbout.Visible ? false : true;//if info is shown, Button deu is also shown
            tbAbout.Visible = tbAbout.Visible ? false: true; //if text alway shown, hide it      
            if (!tbAbout.Visible)
                resetStatus();
        }

        private void resetStatus() {
            tbStatus.Text = "   Converting from wav to mp3, normalizing and tagging";
        }

        private void cbEverwrite(object sender, EventArgs e)
        {
            resetStatus();

        }

        private void tbAboutClick(object sender, EventArgs e)
        {
            bEnglish.Visible = tbAbout.Visible ? false : true;//if info is shown, Button eng is also shown
            bDeutsch.Visible = tbAbout.Visible ? false : true;//if info is shown, Button deu is also shown
            tbAbout.Visible = false;
            resetStatus();
        }

        private void bEngClick(object sender, EventArgs e)
        {
            tbAbout.ForeColor = System.Drawing.Color.DimGray;
            tbAbout.Text = "About VibeBot \r\nThis program convert stereo wave files to stereo mp3 files.\r\nFiles are encoded with the samplerate of 44100 Hz (44.1kHz)\r\nThe result are 320kBits/s high quality audio files. The convertetd files\r\nwill be normalized at the given value, without any loss of data.\r\nAfter that, track artist and title is written into the metadata.\r\nThis is called tagging. Tagging will only be succsessfully, if the\r\nfilename is in the required synthax. For example: \r\nDj Reverb - Hydra\r\n'Dj Reverb' is the artist and 'Hydra' the title, the elements \r\nare seperated by a hyphen.";
        }

        private void bDeuClick(object sender, EventArgs e)
        {
            tbAbout.ForeColor = System.Drawing.Color.DimGray;
            tbAbout.Text = "Generelles über VibeBot \r\nDieses Programm wandelt stereo wave Dateien in stereo mp3 \r\nDateien um. Dateien werden mit einer Abtastrate von 44100 Hz (44.1Khz) gelesen. Das Resultat sind audio Dateien mit einer \r\nQualität von 320kBits/s. Die konvertierten Dateien werden mit dem eingebenen Wert verlustlos normalisiert. Danach wird der Liedname und der Komponist in den Metadaten gespeichert. Dies ist nur unter der folgenden Syntx möglich: Bsp. Dj Reverb - Hydra \r\n'Dj Reverb' ist der Komponist und 'Hydra' der Titel. Beide Elemente werden durch einen Bindestrich getrennt. Die Reihenfolge muss eingehalten werden";
        }

        private void formClick(object sender, EventArgs e)
        {
            tbAbout.Visible = tbAbout.Visible ? false : true; //if text alway shown, hide it      
        }
    }
}
