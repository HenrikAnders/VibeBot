using MetroFramework.Forms;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace VibeBot
{
    public partial class FormSettings : MetroForm
    {
        string path = "";
        public FormSettings(string path)
        {
            this.path = path;
            InitializeComponent();
            pGearBack.Visible = true;
            fillGrid();
        }

        private async void fillGrid()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Track");
            dt.Columns.Add("Gain");
            Bot bot = new Bot(path);
            List<KeyValuePair<string, float>> analyzeValues = await bot.analyze(path);
            foreach (KeyValuePair<string, float> kvp in analyzeValues)
            {
                DataRow row = dt.NewRow();
                row["Track"] = kvp.Key;
                row["Gain"] = (kvp.Value + 87);
                dt.Rows.Add(row);
            }
            gridAnalyze.DataSource = dt;
            gridAnalyze.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridAnalyze.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            gridAnalyze.EnableHeadersVisualStyles = false;
            gridAnalyze.RowHeadersVisible = false;
        }
    }
}
