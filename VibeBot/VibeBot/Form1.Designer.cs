namespace VibeBot
{
    partial class VibeBot 
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
            this.tbPath = new MetroFramework.Controls.MetroTextBox();
            this.bRun = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.load = new System.Windows.Forms.PictureBox();
            this.tbStatus = new MetroFramework.Controls.MetroTextBox();
            this.tbdB = new MetroFramework.Controls.MetroTextBox();
            this.lpath = new System.Windows.Forms.Label();
            this.lDb = new System.Windows.Forms.Label();
            this.lUnit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.load)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            // 
            // 
            // 
            this.tbPath.CustomButton.Image = null;
            this.tbPath.CustomButton.Location = new System.Drawing.Point(105, 2);
            this.tbPath.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tbPath.CustomButton.Name = "";
            this.tbPath.CustomButton.Size = new System.Drawing.Size(13, 13);
            this.tbPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPath.CustomButton.TabIndex = 1;
            this.tbPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPath.CustomButton.UseSelectable = true;
            this.tbPath.CustomButton.Visible = false;
            this.tbPath.Lines = new string[0];
            this.tbPath.Location = new System.Drawing.Point(87, 72);
            this.tbPath.Margin = new System.Windows.Forms.Padding(2);
            this.tbPath.MaxLength = 32767;
            this.tbPath.Name = "tbPath";
            this.tbPath.PasswordChar = '\0';
            this.tbPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPath.SelectedText = "";
            this.tbPath.SelectionLength = 0;
            this.tbPath.SelectionStart = 0;
            this.tbPath.Size = new System.Drawing.Size(121, 18);
            this.tbPath.TabIndex = 1;
            this.tbPath.UseSelectable = true;
            this.tbPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bRun
            // 
            this.bRun.Image = null;
            this.bRun.Location = new System.Drawing.Point(130, 206);
            this.bRun.Margin = new System.Windows.Forms.Padding(2);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(77, 19);
            this.bRun.TabIndex = 4;
            this.bRun.Text = "Run";
            this.bRun.UseSelectable = true;
            this.bRun.UseVisualStyleBackColor = true;
            this.bRun.Click += new System.EventHandler(this.bRun_Click_1);
            // 
            // load
            // 
            this.load.ImageLocation = "D:\\Visual Studio\\Repo\\VibeBot\\VibeBot\\Recources\\load.gif";
            this.load.InitialImage = global::VibeBot.Properties.Resources.load;
            this.load.Location = new System.Drawing.Point(115, 22);
            this.load.Margin = new System.Windows.Forms.Padding(2);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(26, 27);
            this.load.TabIndex = 5;
            this.load.TabStop = false;
            // 
            // tbStatus
            // 
            this.tbStatus.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.tbStatus.CustomButton.Image = null;
            this.tbStatus.CustomButton.Location = new System.Drawing.Point(3, 1);
            this.tbStatus.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tbStatus.CustomButton.Name = "";
            this.tbStatus.CustomButton.Size = new System.Drawing.Size(73, 73);
            this.tbStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbStatus.CustomButton.TabIndex = 1;
            this.tbStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbStatus.CustomButton.UseSelectable = true;
            this.tbStatus.CustomButton.Visible = false;
            this.tbStatus.Enabled = false;
            this.tbStatus.Lines = new string[0];
            this.tbStatus.Location = new System.Drawing.Point(10, 138);
            this.tbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.tbStatus.MaxLength = 32767;
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.PasswordChar = '\0';
            this.tbStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbStatus.SelectedText = "";
            this.tbStatus.SelectionLength = 0;
            this.tbStatus.SelectionStart = 0;
            this.tbStatus.Size = new System.Drawing.Size(77, 75);
            this.tbStatus.TabIndex = 6;
            this.tbStatus.UseSelectable = true;
            this.tbStatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbStatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbdB
            // 
            // 
            // 
            // 
            this.tbdB.CustomButton.Image = null;
            this.tbdB.CustomButton.Location = new System.Drawing.Point(7, 1);
            this.tbdB.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tbdB.CustomButton.Name = "";
            this.tbdB.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.tbdB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbdB.CustomButton.TabIndex = 1;
            this.tbdB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbdB.CustomButton.UseSelectable = true;
            this.tbdB.CustomButton.Visible = false;
            this.tbdB.Lines = new string[0];
            this.tbdB.Location = new System.Drawing.Point(87, 98);
            this.tbdB.Margin = new System.Windows.Forms.Padding(2);
            this.tbdB.MaxLength = 32767;
            this.tbdB.Name = "tbdB";
            this.tbdB.PasswordChar = '\0';
            this.tbdB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbdB.SelectedText = "";
            this.tbdB.SelectionLength = 0;
            this.tbdB.SelectionStart = 0;
            this.tbdB.Size = new System.Drawing.Size(23, 17);
            this.tbdB.TabIndex = 7;
            this.tbdB.UseSelectable = true;
            this.tbdB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbdB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lpath
            // 
            this.lpath.AutoSize = true;
            this.lpath.Location = new System.Drawing.Point(16, 72);
            this.lpath.Name = "lpath";
            this.lpath.Size = new System.Drawing.Size(66, 13);
            this.lpath.TabIndex = 10;
            this.lpath.Text = "Get file from:";
            // 
            // lDb
            // 
            this.lDb.AutoSize = true;
            this.lDb.Location = new System.Drawing.Point(16, 102);
            this.lDb.Name = "lDb";
            this.lDb.Size = new System.Drawing.Size(62, 13);
            this.lDb.TabIndex = 11;
            this.lDb.Text = "Adjust gain:";
            // 
            // lUnit
            // 
            this.lUnit.AutoSize = true;
            this.lUnit.Location = new System.Drawing.Point(125, 102);
            this.lUnit.Name = "lUnit";
            this.lUnit.Size = new System.Drawing.Size(20, 13);
            this.lUnit.TabIndex = 12;
            this.lUnit.Text = "dB";
            // 
            // VibeBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 244);
            this.Controls.Add(this.lUnit);
            this.Controls.Add(this.lDb);
            this.Controls.Add(this.lpath);
            this.Controls.Add(this.tbdB);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.load);
            this.Controls.Add(this.bRun);
            this.Controls.Add(this.tbPath);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(225, 244);
            this.MinimumSize = new System.Drawing.Size(225, 244);
            this.Name = "VibeBot";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "VibeBot";
            this.Load += new System.EventHandler(this.VibeBot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.load)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox tbPath;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton bRun;
        private System.Windows.Forms.PictureBox load;
        private MetroFramework.Controls.MetroTextBox tbStatus;
        private MetroFramework.Controls.MetroTextBox tbdB;
        private System.Windows.Forms.Label lpath;
        private System.Windows.Forms.Label lDb;
        private System.Windows.Forms.Label lUnit;
    }
}

