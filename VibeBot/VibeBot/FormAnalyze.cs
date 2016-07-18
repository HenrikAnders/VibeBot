using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;       
using System.Threading.Tasks;
using System.Windows.Forms;     

namespace VibeBot
{
    public partial class FormAnalyze : MetroForm
    {
        string path = "";
        Bot bot;
        public  FormAnalyze(string path)
        {                
            this.path = path;   
            InitializeComponent();          
            pLoad.Visible = true;
            fillGrid(false);  //should wait until method is finished, but constructor can´t be asynch  
            ShowDialog();     
        }

        /// <summary>
        /// fill the dataGridView
        /// </summary>
        /// <param name="reanalyze">indicates whether the values have to be recalculated</param>
        private async Task<DataTable> fillGrid(bool reanalyze)
        {
            DataTable dt = new DataTable();
            DataRow row ;
            dt.Columns.Add("Track");
            dt.Columns.Add("Gain");
             bot  = new Bot(path);
            foreach (KeyValuePair<string, float> kvp in await bot.analyze(path, reanalyze))
            {
                row = dt.NewRow();
                row["Track"] = kvp.Key;         
                row["Gain"] = (kvp.Value + 87);
                dt.Rows.Add(row);
            }                         
            if (!reanalyze)
            {
                gridAnalyze.DataSource = dt;
                gridAnalyze.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //adjust header size to overall table
                gridAnalyze.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;   //headers gray
                gridAnalyze.EnableHeadersVisualStyles = false;
                gridAnalyze.RowHeadersVisible = false;
                gridAnalyze.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);//optimize cell size
                pLoad.Visible = false;
            }
            await Task.Delay(1);
            return dt;
        }

        private async void bReanalyze(object sender, EventArgs e)
        {   //click Listener    
            //  animation();  //no function...don´t no why       
            gridAnalyze.Visible = false;
            pLoad.Visible = true;
            gridAnalyze.DataSource = await Task.Run(() => fillGrid(true));
            //do all GridView stuff in here because from other Task is no access to gridview
            gridAnalyze.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//adjust header size to overall table
            gridAnalyze.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;     //headers gray
            gridAnalyze.EnableHeadersVisualStyles = false;
            gridAnalyze.RowHeadersVisible = false;
            gridAnalyze.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);//optimize cell size
            pLoad.Visible = false;          
            gridAnalyze.Visible = true;
        }  

        private void animation()
        {   //pictures have to be set      
            //pGearBack.SendToBack();
            //tbStatus.SendToBack();
            //pGearBackBlack.Visible = true;
            //Thread.Sleep(500);
            //pGearBackBlack.Visible = false;
            //pGearBackBlack.SendToBack();
            //tbStatus.SendToBack();  
        }
        

        private void deleteListener(object sender, KeyEventArgs e)
        {   //button "del" listener   KeyPress   
            bot = new Bot(path);
            if (e.KeyCode == Keys.Delete)
            {         
                foreach (DataGridViewRow item in gridAnalyze.SelectedRows)
                {                                                                
                     bot.deleteSelection(item.Cells["Track"].Value.ToString());
                     gridAnalyze.Rows.RemoveAt(item.Index);
                }
            }
        }
    }
}
