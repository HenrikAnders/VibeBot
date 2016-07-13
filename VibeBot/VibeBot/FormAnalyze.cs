using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VibeBot
{
    public partial class FormAnalyze : MetroForm
    {
        string path = "";
        public FormAnalyze(string path)
        {
            this.path = path;
            InitializeComponent();
            pGearBack.Visible = true;
            pGearBackBlack.Visible = false;
            fillGrid(false);   //should wait until method is finished, but constructor can´t be asynch  
            this.ShowDialog();
        }
        /// <summary>
        /// fill the dataGridView
        /// </summary>
        /// <param name="reanalyze">indicates whether the values have to be recalculated</param>
        private async Task fillGrid(bool reanalyze)
        {
            pLoad.Visible = true;
            gridAnalyze.Visible = false;
            DataTable dt = new DataTable();
            dt.Columns.Add("Track");
            dt.Columns.Add("Gain");
            Bot bot = new Bot(path);
            foreach (KeyValuePair<string, float> kvp in await bot.analyze(path, reanalyze))
            {
                DataRow row = dt.NewRow();
                row["Track"] = kvp.Key;
                row["Gain"] = (kvp.Value + 87);
                dt.Rows.Add(row);
            }
            gridAnalyze.DataSource = dt;
            gridAnalyze.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridAnalyze.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            gridAnalyze.EnableHeadersVisualStyles = false;
            gridAnalyze.RowHeadersVisible = false;
            pLoad.Visible = false;
            gridAnalyze.Visible = true;
        }

        private async void bReanalyze(object sender, EventArgs e)
        {                      //click Listener
            Console.Write("drück");
            await fillGrid(true);
        }

        private void bVisualDown(object sender, MouseEventArgs e)
        {       //mouseButton down listener  
            pGearBackBlack.Visible = true;
            pGearBack.SendToBack();
            tbStatus.SendToBack();
        }

        private async void bVisualUp(object sender, MouseEventArgs e)
        {   //mouseButton up listener 
            pGearBackBlack.Visible = false;
            pGearBackBlack.SendToBack();
            tbStatus.SendToBack();
            await fillGrid(true);
        }                                      
    }
}
