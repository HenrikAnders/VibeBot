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
            tbStatus.Visible = true;  
            load.Visible = false;
            tbPath.Text = getPath();
            tbdB.Text = "6";
            picComplete.Visible = false;
        }

        private void Path_Click(object sender, EventArgs e)
        {
            tbPath.Text = "";
        }

        private async void bRun_Click_1(object sender, EventArgs e)
        {
            picComplete.Visible = false;
            bool isChecked= cbDelete.Checked;
            String path = tbPath.Text;

           // tbStatus.AppendText("Status: \r\n");
            Bot bot = new Bot(getPath());   

          //  tbStatus.AppendText("Converting from wave to mp3 \r\n");
            load.Visible = true;
            await Task.Run(() => bot.convert(isChecked));
              
         //   tbStatus.AppendText("normalizing and \r\n");
            await Task.Run(() => bot.normazize(float.Parse(tbdB.Text, CultureInfo.InvariantCulture.NumberFormat)));

           // tbStatus.AppendText("tagging");
            await Task.Run(() => bot.tagging());

            tbStatus.ForeColor = System.Drawing.Color.Blue;
            load.Visible = false;
            picComplete.Visible = true;
            await Task.Delay(1);
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
            else
            {
                try
                {     if (!string.IsNullOrEmpty(this.tbPath.Text) && Directory.Exists(this.tbPath.Text) && !Directory.GetAccessControl(this.tbPath.Text).AreAccessRulesProtected) {
                        //create the key
                        reg = Registry.CurrentUser;
                        regPath = tbPath.Text;
                        reg.SetValue("VibeBotPath", tbPath.Text);
                    }
                    else {
                        MetroMessageBox.Show(ActiveForm,"Access to the given path is denied","");
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
            }

            return regPath;
        }

        private void VibeBot_Load(object sender, EventArgs e)
        {
            String db = tbdB.Text;
        }

        private void tbDBTextChanged(object sender, EventArgs e)
        {
            lLevel.ForeColor = System.Drawing.Color.Black;
            try
            {
                double level = float.Parse(tbdB.Text, CultureInfo.InvariantCulture.NumberFormat) + 89;
                lLevel.Text = "Output level -> " + level + " dB";
            }
            catch (Exception)
            {
                lLevel.ForeColor = System.Drawing.Color.Red;
                lLevel.Text = "!Invalid input!";
            }
        }  

        private void tbPathTextChanged(object sender, EventArgs e)
        {
            bRun.Enabled= !string.IsNullOrEmpty(this.tbPath.Text) && Directory.Exists(this.tbPath.Text) && !Directory.GetAccessControl(this.tbPath.Text).AreAccessRulesProtected;
        }
    }
}
