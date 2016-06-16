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
            this.lInfo = new MetroFramework.Drawing.Html.HtmlLabel();
            this.tbPath = new MetroFramework.Controls.MetroTextBox();
            this.bRun = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.load = new System.Windows.Forms.PictureBox();
            this.tbStatus = new MetroFramework.Controls.MetroTextBox();
            this.tbdB = new MetroFramework.Controls.MetroTextBox();
            this.lDb = new MetroFramework.Drawing.Html.HtmlLabel();
            this.lUnit = new MetroFramework.Drawing.Html.HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.load)).BeginInit();
            this.SuspendLayout();
            // 
            // lInfo
            // 
            this.lInfo.AutoScroll = true;
            this.lInfo.AutoScrollMinSize = new System.Drawing.Size(95, 25);
            this.lInfo.AutoSize = false;
            this.lInfo.BackColor = System.Drawing.SystemColors.Window;
            this.lInfo.Location = new System.Drawing.Point(14, 88);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(96, 28);
            this.lInfo.TabIndex = 0;
            this.lInfo.Text = "Get files from:";
            // 
            // tbPath
            // 
            // 
            // 
            // 
            this.tbPath.CustomButton.Image = null;
            this.tbPath.CustomButton.Location = new System.Drawing.Point(141, 2);
            this.tbPath.CustomButton.Name = "";
            this.tbPath.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.tbPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPath.CustomButton.TabIndex = 1;
            this.tbPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPath.CustomButton.UseSelectable = true;
            this.tbPath.CustomButton.Visible = false;
            this.tbPath.Lines = new string[0];
            this.tbPath.Location = new System.Drawing.Point(116, 88);
            this.tbPath.MaxLength = 32767;
            this.tbPath.Name = "tbPath";
            this.tbPath.PasswordChar = '\0';
            this.tbPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPath.SelectedText = "";
            this.tbPath.SelectionLength = 0;
            this.tbPath.SelectionStart = 0;
            this.tbPath.Size = new System.Drawing.Size(161, 22);
            this.tbPath.TabIndex = 1;
            this.tbPath.UseSelectable = true;
            this.tbPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bRun
            // 
            this.bRun.Image = null;
            this.bRun.Location = new System.Drawing.Point(174, 254);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(103, 23);
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
            this.load.Location = new System.Drawing.Point(116, 22);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(34, 33);
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
            this.tbStatus.CustomButton.Location = new System.Drawing.Point(13, 2);
            this.tbStatus.CustomButton.Name = "";
            this.tbStatus.CustomButton.Size = new System.Drawing.Size(87, 87);
            this.tbStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbStatus.CustomButton.TabIndex = 1;
            this.tbStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbStatus.CustomButton.UseSelectable = true;
            this.tbStatus.CustomButton.Visible = false;
            this.tbStatus.Enabled = false;
            this.tbStatus.Lines = new string[0];
            this.tbStatus.Location = new System.Drawing.Point(14, 170);
            this.tbStatus.MaxLength = 32767;
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.PasswordChar = '\0';
            this.tbStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbStatus.SelectedText = "";
            this.tbStatus.SelectionLength = 0;
            this.tbStatus.SelectionStart = 0;
            this.tbStatus.Size = new System.Drawing.Size(103, 92);
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
            this.tbdB.CustomButton.Location = new System.Drawing.Point(11, 1);
            this.tbdB.CustomButton.Name = "";
            this.tbdB.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tbdB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbdB.CustomButton.TabIndex = 1;
            this.tbdB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbdB.CustomButton.UseSelectable = true;
            this.tbdB.CustomButton.Visible = false;
            this.tbdB.Lines = new string[0];
            this.tbdB.Location = new System.Drawing.Point(116, 119);
            this.tbdB.MaxLength = 32767;
            this.tbdB.Name = "tbdB";
            this.tbdB.PasswordChar = '\0';
            this.tbdB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbdB.SelectedText = "";
            this.tbdB.SelectionLength = 0;
            this.tbdB.SelectionStart = 0;
            this.tbdB.Size = new System.Drawing.Size(31, 21);
            this.tbdB.TabIndex = 7;
            this.tbdB.UseSelectable = true;
            this.tbdB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbdB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lDb
            // 
            this.lDb.AutoScroll = true;
            this.lDb.AutoScrollMinSize = new System.Drawing.Size(94, 25);
            this.lDb.AutoSize = false;
            this.lDb.BackColor = System.Drawing.SystemColors.Window;
            this.lDb.Location = new System.Drawing.Point(14, 119);
            this.lDb.Name = "lDb";
            this.lDb.Size = new System.Drawing.Size(102, 45);
            this.lDb.TabIndex = 8;
            this.lDb.Text = "Increase gain:";
            // 
            // lUnit
            // 
            this.lUnit.AutoScroll = true;
            this.lUnit.AutoScrollMinSize = new System.Drawing.Size(27, 25);
            this.lUnit.AutoSize = false;
            this.lUnit.BackColor = System.Drawing.SystemColors.Window;
            this.lUnit.Location = new System.Drawing.Point(153, 117);
            this.lUnit.Name = "lUnit";
            this.lUnit.Size = new System.Drawing.Size(35, 33);
            this.lUnit.TabIndex = 9;
            this.lUnit.Text = "dB";
            // 
            // VibeBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.lUnit);
            this.Controls.Add(this.lDb);
            this.Controls.Add(this.tbdB);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.load);
            this.Controls.Add(this.bRun);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.lInfo);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "VibeBot";
            this.Text = "VibeBot";
            this.Load += new System.EventHandler(this.VibeBot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.load)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlLabel lInfo;
        private MetroFramework.Controls.MetroTextBox tbPath;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton bRun;
        private System.Windows.Forms.PictureBox load;
        private MetroFramework.Controls.MetroTextBox tbStatus;
        private MetroFramework.Controls.MetroTextBox tbdB;
        private MetroFramework.Drawing.Html.HtmlLabel lDb;
        private MetroFramework.Drawing.Html.HtmlLabel lUnit;
    }
}

