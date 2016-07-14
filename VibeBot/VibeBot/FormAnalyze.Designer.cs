using System.Windows.Forms;

namespace VibeBot
{
    partial class FormAnalyze
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbStatus = new MetroFramework.Controls.MetroTextBox();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.bGear = new System.Windows.Forms.Button();
            this.gridAnalyze = new MetroFramework.Controls.MetroGrid();
            this.pLoad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnalyze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // tbStatus
            // 
            this.tbStatus.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.tbStatus.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.tbStatus.CustomButton.Image = null;
            this.tbStatus.CustomButton.Location = new System.Drawing.Point(404, 1);
            this.tbStatus.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStatus.CustomButton.Name = "";
            this.tbStatus.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.tbStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbStatus.CustomButton.TabIndex = 1;
            this.tbStatus.CustomButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tbStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbStatus.CustomButton.UseSelectable = true;
            this.tbStatus.CustomButton.Visible = false;
            this.tbStatus.Enabled = false;
            this.tbStatus.ForeColor = System.Drawing.Color.Black;
            this.tbStatus.Lines = new string[] {
        "   Analyze track gain"};
            this.tbStatus.Location = new System.Drawing.Point(-7, 276);
            this.tbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStatus.MaxLength = 32767;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.PasswordChar = '\0';
            this.tbStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbStatus.SelectedText = "";
            this.tbStatus.SelectionLength = 0;
            this.tbStatus.SelectionStart = 0;
            this.tbStatus.ShortcutsEnabled = true;
            this.tbStatus.Size = new System.Drawing.Size(442, 39);
            this.tbStatus.TabIndex = 7;
            this.tbStatus.Text = "   Analyze track gain";
            this.tbStatus.UseSelectable = true;
            this.tbStatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbStatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bGear
            // 
            this.bGear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bGear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bGear.FlatAppearance.BorderSize = 0;
            this.bGear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bGear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bGear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGear.ForeColor = System.Drawing.Color.White;
            this.bGear.Image = global::VibeBot.Properties.Resources.gearBack;
            this.bGear.Location = new System.Drawing.Point(300, 133);
            this.bGear.Name = "bGear";
            this.bGear.Size = new System.Drawing.Size(128, 169);
            this.bGear.TabIndex = 14;
            this.tooltip.SetToolTip(this.bGear, "Click to reanalyze");
            this.bGear.UseVisualStyleBackColor = true;
            this.bGear.Click += new System.EventHandler(this.bReanalyze);
            // 
            // gridAnalyze
            // 
            this.gridAnalyze.AllowUserToAddRows = false;
            this.gridAnalyze.AllowUserToDeleteRows = false;
            this.gridAnalyze.AllowUserToOrderColumns = true;
            this.gridAnalyze.AllowUserToResizeRows = false;
            this.gridAnalyze.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridAnalyze.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridAnalyze.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridAnalyze.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.gridAnalyze.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAnalyze.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridAnalyze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAnalyze.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridAnalyze.EnableHeadersVisualStyles = false;
            this.gridAnalyze.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridAnalyze.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridAnalyze.Location = new System.Drawing.Point(0, 76);
            this.gridAnalyze.Name = "gridAnalyze";
            this.gridAnalyze.ReadOnly = true;
            this.gridAnalyze.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAnalyze.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridAnalyze.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridAnalyze.RowTemplate.Height = 24;
            this.gridAnalyze.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridAnalyze.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAnalyze.Size = new System.Drawing.Size(294, 200);
            this.gridAnalyze.StandardTab = true;
            this.gridAnalyze.Style = MetroFramework.MetroColorStyle.White;
            this.gridAnalyze.TabIndex = 8;
            // 
            // pLoad
            // 
            this.pLoad.Image = global::VibeBot.Properties.Resources.load;
            this.pLoad.Location = new System.Drawing.Point(128, 23);
            this.pLoad.Name = "pLoad";
            this.pLoad.Size = new System.Drawing.Size(33, 32);
            this.pLoad.TabIndex = 9;
            this.pLoad.TabStop = false;
            this.pLoad.WaitOnLoad = true;
            // 
            // FormAnalyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(424, 300);
            this.Controls.Add(this.bGear);
            this.Controls.Add(this.pLoad);
            this.Controls.Add(this.gridAnalyze);
            this.Controls.Add(this.tbStatus);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(424, 300);
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FormAnalyze";
            this.Padding = new System.Windows.Forms.Padding(5, 60, 5, 5);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Analyze";
            this.TransparencyKey = System.Drawing.Color.AliceBlue;
            ((System.ComponentModel.ISupportInitialize)(this.gridAnalyze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLoad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox tbStatus;
        private MetroFramework.Controls.MetroGrid gridAnalyze;
        private System.Windows.Forms.PictureBox pLoad;
        private ToolTip tooltip;
        private Button bGear;
    }
}