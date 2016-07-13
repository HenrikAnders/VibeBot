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
            this.pGearBack = new System.Windows.Forms.PictureBox();
            this.gridAnalyze = new MetroFramework.Controls.MetroGrid();
            this.pLoad = new System.Windows.Forms.PictureBox();
            this.pGearBackBlack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pGearBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnalyze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGearBackBlack)).BeginInit();
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
            this.tbStatus.CustomButton.Location = new System.Drawing.Point(393, 1);
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
            this.tbStatus.Size = new System.Drawing.Size(431, 39);
            this.tbStatus.TabIndex = 7;
            this.tbStatus.Text = "   Analyze track gain";
            this.tbStatus.UseSelectable = true;
            this.tbStatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbStatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pGearBack
            // 
            this.pGearBack.Image = global::VibeBot.Properties.Resources.gearBack;
            this.pGearBack.Location = new System.Drawing.Point(285, 136);
            this.pGearBack.Name = "pGearBack";
            this.pGearBack.Size = new System.Drawing.Size(139, 164);
            this.pGearBack.TabIndex = 13;
            this.pGearBack.TabStop = false;
            this.tooltip.SetToolTip(this.pGearBack, "Reanalyze files");
            this.pGearBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bVisualDown);
            this.pGearBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bVisualUp);
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
            this.gridAnalyze.Size = new System.Drawing.Size(279, 200);
            this.gridAnalyze.StandardTab = true;
            this.gridAnalyze.Style = MetroFramework.MetroColorStyle.White;
            this.gridAnalyze.TabIndex = 8;
            // 
            // pLoad
            // 
            this.pLoad.Image = global::VibeBot.Properties.Resources.load;
            this.pLoad.Location = new System.Drawing.Point(46, 83);
            this.pLoad.Name = "pLoad";
            this.pLoad.Size = new System.Drawing.Size(33, 32);
            this.pLoad.TabIndex = 9;
            this.pLoad.TabStop = false;
            // 
            // pGearBackBlack
            // 
            this.pGearBackBlack.Image = global::VibeBot.Properties.Resources.gearBackBlack;
            this.pGearBackBlack.Location = new System.Drawing.Point(288, 161);
            this.pGearBackBlack.Name = "pGearBackBlack";
            this.pGearBackBlack.Size = new System.Drawing.Size(138, 144);
            this.pGearBackBlack.TabIndex = 12;
            this.pGearBackBlack.TabStop = false;
            this.pGearBackBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bVisualDown);
            this.pGearBackBlack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bVisualUp);
            // 
            // FormAnalyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 300);
            this.Controls.Add(this.pGearBack);
            this.Controls.Add(this.pGearBackBlack);
            this.Controls.Add(this.pLoad);
            this.Controls.Add(this.gridAnalyze);
            this.Controls.Add(this.tbStatus);
            this.MaximumSize = new System.Drawing.Size(424, 300);
            this.Name = "FormAnalyze";
            this.Text = "Analyze";
            ((System.ComponentModel.ISupportInitialize)(this.pGearBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnalyze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGearBackBlack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox tbStatus;
        private MetroFramework.Controls.MetroGrid gridAnalyze;
        private System.Windows.Forms.PictureBox pLoad;
        private System.Windows.Forms.PictureBox pGearBack;
        private System.Windows.Forms.PictureBox pGearBackBlack;
        private ToolTip tooltip;
    }
}