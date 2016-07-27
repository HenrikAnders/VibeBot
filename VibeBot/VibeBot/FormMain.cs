using System;
using System.Threading.Tasks;
using MetroFramework.Forms;

using System.Linq;
using System.Globalization;
using MetroFramework;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Data;
using System.Collections.Generic;

namespace VibeBot
{
    public partial class VibeBot : MetroForm
    {
        Bot bot;
        bool singleFile = false;
        public VibeBot()
        {
            InitializeComponent();
            TopMost = false; // without the Messageboxes will bi hidden behind the main window
            tbState.Visible = true;
            pLoad.Visible = false;
            tbPath.Text = getPath();
            tbdB.Text = "6";
            pComplete.Visible = false;
            this.MaximizeBox = false;
         //   fillGrid(false);  //should wait until method is finished, but constructor can´t be asynch   
            tbAbout.Text = "About VibeBot \r\nThis program convert stereo wave files to stereo mp3 files.\r\nFiles are encoded with the samplerate of 44100 Hz (44.1kHz)\r\nThe result are 320kBits/s high quality audio files. The convertetd files\r\nwill be normalized at the given value, without any loss of data.\r\nAfter that, track artist and title is written into the metadata.\r\nThis is called tagging. Tagging will only be succsessfully, if the filename is in the required synthax.\r\nFor example: Dj Reverb - Hydra\r\n'Dj Reverb' is the artist and 'Hydra' the title, the elements \r\nare seperated by a hyphen. Keep the right order.";
            tabControl.SelectedTab = tabPage1;
            tabControl.DisableTab(tabempty);
        }

        private async void bRun_Click_1(object sender, EventArgs e)
        {
            if (validate())
            {
                if (singleFile)
                {
                    if (Directory.GetFiles(this.tbPath.Text, "*.wav").Length == 0 && Directory.GetFiles(this.tbPath.Text, "*.mp3").Length == 0)
                    {
                        MetroMessageBox.Show(this, "No files found on the given path!     Make sure that there are wave or mp3 files!", "");
                    }
                }
                else
                {
                    resetStatus();
                    tbdB.Enabled = false;
                    tbPath.Enabled = false;
                    cbDelete.Enabled = false;
                    cbReset.Enabled = false;
                    pComplete.Visible = false;
                    tbState.Text = "";

                    bot = new Bot(setPath(tbPath.Text));
                    tbState.AppendText("Info:");

                    pLoad.Visible = true;
                    await Task.Run(() => bot.convert(cbDelete.Checked));
                    tbState.AppendText(" Converted \u221A, ");

                    await Task.Run(() => bot.normazize(float.Parse(tbdB.Text, CultureInfo.InvariantCulture.NumberFormat), cbReset.Checked));
                    tbState.AppendText("normalized \u221A");

                    await Task.Run(() => bot.tagging());
                    tbState.AppendText(", tagged \u221A");

                    tbState.ForeColor = System.Drawing.Color.Blue;
                    pLoad.Visible = false;
                    pComplete.Visible = true;

                    tbdB.Enabled = true;
                    tbPath.Enabled = true;
                    cbDelete.Enabled = true;
                    cbReset.Enabled = true;
                }
            }
            else { MetroMessageBox.Show(this, "No mp3/wav files found on the given path!", ""); }
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
        public String setPath(String path)
        {
            RegistryKey reg = Registry.CurrentUser;
            String regPath = "";
            try
            {
                if (!string.IsNullOrEmpty(path) && Directory.Exists(path) && !Directory.GetAccessControl(path).AreAccessRulesProtected)
                {
                    //create the registry key with value path
               //     reg = Registry.CurrentUser;
                    regPath = tbPath.Text;
                    reg.SetValue("VibeBotPath", tbPath.Text);
                }
                else if (singleFile && !File.GetAccessControl(path).AreAccessRulesProtected && !string.IsNullOrEmpty(path))
                {
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
            bool bPath = false;
            if ((this.tbPath.Text.Contains(".mp3") || this.tbPath.Text.Contains(".wav"))&& File.Exists(this.tbPath.Text))     //check if single file
            {
                bPath = !File.GetAccessControl(this.tbPath.Text).AreAccessRulesProtected;
                singleFile = true;
            }
            else
            {
                bPath = !string.IsNullOrEmpty(this.tbPath.Text) && Directory.Exists(this.tbPath.Text) && !Directory.GetAccessControl(this.tbPath.Text).AreAccessRulesProtected;
                singleFile = false;
            }


            bool bDB = !lLevel.Text.Equals("!Invalid input!");
            tbPath.ForeColor = (bPath) ? System.Drawing.Color.Red : System.Drawing.Color.Red;
            return bPath && bDB;
        }

        private void pathTextChanged(object sender, EventArgs e)
        {
            pComplete.Visible = false;
            bRun.Enabled = validate();
        }

        private void tbDBTextChanged(object sender, EventArgs e)
        {
            resetStatus();
            pComplete.Visible = false;
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
            pComplete.Visible = false;
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = folderBrowser.SelectedPath;
            }
        }

        private void cbResetChecked(object sender, EventArgs e)
        {
            resetStatus();
            pComplete.Visible = false;
            tbdB.Text = cbReset.Checked ? "0" : "6";
            tbdB.Enabled = cbReset.Checked ? false : true;    //if checked, tbTextbox disabled
        }

        private void bInfo(object sender, EventArgs e)
        {
            tbState.Text = "";
            bEnglish.Visible = tbAbout.Visible ? false : true;//if info is shown, Button eng is also shown
            bDeutsch.Visible = tbAbout.Visible ? false : true;//if info is shown, Button deu is also shown
            tbAbout.Visible = tbAbout.Visible ? false : true; //if text alway shown, hide it      
            if (!tbAbout.Visible)
                resetStatus();
        }
        /// <summary>
        /// clear the tbState info field
        /// </summary>
        private void resetStatus()
        {
            tbState.Text = "   ";
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
            tbAbout.Text = "About VibeBot \r\nThis program convert stereo wave files to stereo mp3 files.\r\nFiles are encoded with the samplerate of 44100 Hz (44.1kHz)\r\nThe result are 320kBits/s high quality audio files. The convertetd files\r\nwill be normalized at the given value, without any loss of data.\r\nAfter that, track artist and title is written into the metadata.\r\nThis is called tagging. Tagging will only be succsessfully, if the filename is in the required synthax.\r\nFor example: Dj Reverb - Hydra\r\n'Dj Reverb' is the artist and 'Hydra' the title, the elements \r\nare seperated by a hyphen. Keep the right order.";
        }

        private void bDeuClick(object sender, EventArgs e)
        {
            tbAbout.ForeColor = System.Drawing.Color.DimGray;
            tbAbout.Text = "Generelles über VibeBot \r\nDieses Programm wandelt stereo wave Dateien in stereo mp3 \r\nDateien um. Dateien werden mit einer Abtastrate von 44100 Hz (44.1Khz) gelesen.\r\nDas Resultat sind audio Dateien mit einer Qualität von 320kBits/s. Die konvertierten Dateien\r\nwerden mit dem eingebenen Wert verlustlos normalisiert. Danach wird der Liedname und der Komponist\r\nin den Metadaten gespeichert. Dies ist nur unter der folgenden Syntx möglich: \r\nBsp. Dj Reverb - Hydra \r\n'Dj Reverb' ist der Komponist und 'Hydra' der Titel. Beide Elemente werden durch \r\neinen Bindestrich getrennt. Die Reihenfolge muss eingehalten werden.";
        }

        private void cbDeleteChecked(object sender, EventArgs e)
        {
            pComplete.Visible = false;
            resetStatus();
        }

        /// <summary>
        /// fill the dataGridView
        /// </summary>
        /// <param name="reanalyze">indicates whether the values have to be recalculated</param>
        private async Task<DataTable> fillGrid(bool reanalyze)
        {
            DataTable dt = new DataTable();
            DataRow row;
            dt.Columns.Add("Track");
            dt.Columns.Add("Gain");
            if (validate())
            {
                bot = new Bot(tbPath.Text);
                foreach (KeyValuePair<string, string> kvp in await bot.analyze(this.tbPath.Text, reanalyze))
                {
                    row = dt.NewRow();
                    row["Track"] = kvp.Key;
                    if (kvp.Value.Contains("!"))
                    {
                        gridAnalyze.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkRed;
                        row["Gain"] = kvp.Value.Remove(0, 1);   //delete the char '!'
                    }
                    else
                    {
                        row["Gain"] = (kvp.Value);
                    }             
                    dt.Rows.Add(row); 
                }
            }
            else
            {
                row = dt.NewRow();
                row["Track"] = " !No files found on the given path! ";
                dt.Rows.Add(row);
            }
            await Task.Delay(1);
            return dt;
        }

        private async void bReanalyze(object sender, EventArgs e)
        {   //click Listener    
            //  animation();  //no function...don´t no why 
            pComplete.Visible = false;      
            gridAnalyze.Visible = false;         
            lArrow.Visible = false;
            pArrow.Visible = false;
            pLoad.Visible = true;
            gridAnalyze.DataSource = await Task.Run(() => fillGrid(true));
            //do all GridView stuff in here because from other Task is no access to gridview
            gridAnalyze.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//adjust header size to overall table   
            gridAnalyze.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;   //headers gray
            gridAnalyze.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;   //header letters black
            this.gridAnalyze.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.gridAnalyze.DefaultCellStyle.SelectionForeColor = gridAnalyze.DefaultCellStyle.ForeColor;
            gridAnalyze.EnableHeadersVisualStyles = false;
            gridAnalyze.RowHeadersVisible = false;    
            gridAnalyze.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            gridAnalyze.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);//optimize cell size
            pLoad.Visible = false;
            gridAnalyze.Visible = true;
            // tbState.SendToBack();
        }

        private void deleteListener(object sender, KeyEventArgs e)
        {   //button "del" listener   KeyPress   
            bot = new Bot(setPath(this.tbPath.Text));
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow item in gridAnalyze.SelectedRows)
                {
                    bot.deleteSelection(item.Cells["Track"].Value.ToString());
                    gridAnalyze.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void dragEnter(object sender, DragEventArgs e)
        {    //occours, if user hover with item over tapControl   
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void DropItem(object sender, DragEventArgs e)
        {     //occours, if user drops Item into tapControl
            if (e.Data.GetDataPresent(DataFormats.FileDrop)){
                string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);        
                FileInfo fileInfo = new FileInfo(file.ElementAt(0));        
                tbPath.Text = fileInfo.Directory.FullName + @"\" + fileInfo.Name;
                setPath(fileInfo.Directory.FullName+""+ fileInfo.Name);
                tbState.Text = fileInfo.Name;
            }
        }
    }
}
