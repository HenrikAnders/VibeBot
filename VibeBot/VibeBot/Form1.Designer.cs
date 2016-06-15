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
            ((System.ComponentModel.ISupportInitialize)(this.load)).BeginInit();
            this.SuspendLayout();
            // 
            // lInfo
            // 
            this.lInfo.AutoScroll = true;
            this.lInfo.AutoScrollMinSize = new System.Drawing.Size(91, 25);
            this.lInfo.AutoSize = false;
            this.lInfo.BackColor = System.Drawing.SystemColors.Window;
            this.lInfo.Location = new System.Drawing.Point(20, 80);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(96, 28);
            this.lInfo.TabIndex = 0;
            this.lInfo.Text = "Get files from";
            // 
            // tbPath
            // 
            // 
            // 
            // 
            this.tbPath.CustomButton.Image = null;
            this.tbPath.CustomButton.Location = new System.Drawing.Point(234, 2);
            this.tbPath.CustomButton.Name = "";
            this.tbPath.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.tbPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPath.CustomButton.TabIndex = 1;
            this.tbPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPath.CustomButton.UseSelectable = true;
            this.tbPath.CustomButton.Visible = false;
            this.tbPath.Lines = new string[] {
        "C:\\Users\\uidj5635\\Desktop"};
            this.tbPath.Location = new System.Drawing.Point(23, 114);
            this.tbPath.MaxLength = 32767;
            this.tbPath.Name = "tbPath";
            this.tbPath.PasswordChar = '\0';
            this.tbPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPath.SelectedText = "";
            this.tbPath.SelectionLength = 0;
            this.tbPath.SelectionStart = 0;
            this.tbPath.Size = new System.Drawing.Size(254, 22);
            this.tbPath.TabIndex = 1;
            this.tbPath.Text = "C:\\Users\\uidj5635\\Desktop";
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
            this.load.Location = new System.Drawing.Point(134, 156);
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
            this.tbStatus.Location = new System.Drawing.Point(174, 156);
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
            // VibeBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.load);
            this.Controls.Add(this.bRun);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.lInfo);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "VibeBot";
            this.Text = "VibeBot";
            ((System.ComponentModel.ISupportInitialize)(this.load)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlLabel lInfo;
        private MetroFramework.Controls.MetroTextBox tbPath;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton bRun;
        private System.Windows.Forms.PictureBox load;
        private MetroFramework.Controls.MetroTextBox tbStatus;
    }
}

