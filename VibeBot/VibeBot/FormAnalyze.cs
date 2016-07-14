﻿using MetroFramework.Forms;
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
        private async Task fillGrid(bool reanalyze)
        {
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
        }

        private async void bReanalyze(object sender, EventArgs e)
        {   //click Listener    
            //  animation();  //   no function...don´t no why       
            gridAnalyze.Visible = false;
            pLoad.Visible = true;      
            await fillGrid(true);    
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
    }
}
