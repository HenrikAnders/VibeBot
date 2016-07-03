using System;
using System.Threading.Tasks;
using MetroFramework.Forms;
using Microsoft.Win32;
using System.Linq;
using System.Globalization;
using MetroFramework;
using System.IO;

namespace VibeBot
{
    public partial class VibeBot : MetroForm
    {
        public VibeBot()
        {
            InitializeComponent();
            TopMost = false; // without the Messageboxes will bi hidden behind the main window
            tbStatus.Visible = true;
            load.Visible = false;
            tbPath.Text = getPath();
            tbdB.Text = "6";
            picComplete.Visible = false;
            this.MaximizeBox = false;
        }

        private void Path_Click(object sender, EventArgs e)
        {
            tbPath.Text = "";
        }

        private async void bRun_Click_1(object sender, EventArgs e)
        {
            if (Directory.GetFiles(setPath(), "*.wav").Length == 0 && Directory.GetFiles(setPath(), "*.mp3").Length == 0)
            {
                MetroMessageBox.Show(this, "No files found on the given path!     Make sure that there are wave or mp3 files!", "");
            }
            else
            {
                tbdB.Enabled = false;
                tbPath.Enabled = false;
                cbDelete.Enabled = false;
                picComplete.Visible = false;
                bool isChecked = cbDelete.Checked;
                String path = tbPath.Text;
                tbStatus.Text = "";

                Bot bot = new Bot(setPath());
                
                load.Visible = true;
                await Task.Run(() => bot.convert(isChecked));
                tbStatus.AppendText("Converted, ");
                
                await Task.Run(() => bot.normazize(float.Parse(tbdB.Text, CultureInfo.InvariantCulture.NumberFormat)));
                tbStatus.AppendText("normalized ");
                
                await Task.Run(() => bot.tagging());
                tbStatus.AppendText("and tagged");

                tbStatus.ForeColor = System.Drawing.Color.Blue;
                load.Visible = false;
                picComplete.Visible = true;
                await Task.Delay(1);

                tbdB.Enabled = true;
                tbPath.Enabled = true;
                cbDelete.Enabled = true;
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
                    //create the key
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
            bool bPath= !string.IsNullOrEmpty(this.tbPath.Text) && Directory.Exists(this.tbPath.Text) && !Directory.GetAccessControl(this.tbPath.Text).AreAccessRulesProtected  ;
            bool bDB= !lLevel.Text.Equals("!Invalid input!");
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
            picComplete.Visible = false;
            lLevel.ForeColor = System.Drawing.Color.Black;
            try
            {     //if it´s not a number show "Invalid input"
                double level = float.Parse(tbdB.Text, CultureInfo.InvariantCulture.NumberFormat) + 89;
                lLevel.Text = "Output level -> " + level + " dB";         
            }
            catch (Exception)
            {
                lLevel.ForeColor = System.Drawing.Color.Red;
                lLevel.Text = "!Invalid input!";
            }
            bRun.Enabled = validate();
        }
    }
}
