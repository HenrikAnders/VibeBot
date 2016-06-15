using System;       
using System.Threading.Tasks;  
using MetroFramework.Forms;  

namespace VibeBot
{
    public partial class VibeBot : MetroForm
    {
        public VibeBot()
        {
            InitializeComponent();
            tbStatus.Visible = false;
            load.Visible = false;
        }

        private void Path_Click(object sender, EventArgs e)
        {
            tbPath.Text = "";
        }

        private async void bRun_Click_1(object sender, EventArgs e)
        {
            tbStatus.AppendText("Status: \r\n \r\n");
            Bot bot = new Bot(tbPath.Text); 
            tbStatus.Visible = true;
                                                       
            tbStatus.AppendText("Converting\r\n");
            load.Visible = true;
            await Task.Run(() => bot.convert());         

           //tbStatus.AppendText("Normalize\r\n");
            //await Task.Run(()=> bot.normazize());

            tbStatus.AppendText("Tagging");
            await Task.Run(()=> bot.tagging());


            load.Visible = false;
            await Task.Delay(1);
        }
    }
}
