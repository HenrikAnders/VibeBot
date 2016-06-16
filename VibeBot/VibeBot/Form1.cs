using System;
using System.Threading.Tasks;
using MetroFramework.Forms;
using Microsoft.Win32;
using System.Linq;
using System.Globalization;

namespace VibeBot
{
    public partial class VibeBot : MetroForm
    {
        public VibeBot()
        {
            InitializeComponent();
            tbStatus.Visible = false;
            load.Visible = false;
            tbPath.Text = getPath();
        }

        private void Path_Click(object sender, EventArgs e)
        {
            tbPath.Text = "";
        }

        private async void bRun_Click_1(object sender, EventArgs e)
        {
            String path = tbPath.Text;

            tbStatus.AppendText("Status: \r\n");
            Bot bot = new Bot(getPath()); 
            tbStatus.Visible = true;
                                                       
            tbStatus.AppendText("Converting\r\n");
            load.Visible = true;
            await Task.Run(() => bot.convert());         

           //tbStatus.AppendText("Normalize\r\n");
            await Task.Run(()=> bot.normazize(float.Parse(tbdB.Text, CultureInfo.InvariantCulture.NumberFormat)));

            tbStatus.AppendText("Tagging");
            await Task.Run(()=> bot.tagging());

                                     
            load.Visible = false;
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
                {
                    //create the key
                    reg = Registry.CurrentUser;
                    regPath = tbPath.Text;
                    reg.SetValue("VibeBotPath", tbPath.Text);
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
    }
}
