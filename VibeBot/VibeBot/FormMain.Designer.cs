using System.IO;
using System.Windows.Forms;

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
        {   if (File.Exists(Path.GetTempPath() + "analyzedGain.tmp"))   //delete tempfile, before disposing
                File.Delete(Path.GetTempPath() + "analyzedGain.tmp");
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VibeBot));
            this.tbPath = new MetroFramework.Controls.MetroTextBox();
            this.bRun = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.tbStatus = new MetroFramework.Controls.MetroTextBox();
            this.tbdB = new MetroFramework.Controls.MetroTextBox();
            this.lPath = new System.Windows.Forms.Label();
            this.ldB = new System.Windows.Forms.Label();
            this.lUnit = new System.Windows.Forms.Label();
            this.pLoad = new System.Windows.Forms.PictureBox();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lLevel = new System.Windows.Forms.Label();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.pGear = new System.Windows.Forms.PictureBox();
            this.bSearchPath = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cbReset = new System.Windows.Forms.CheckBox();
            this.picComplete = new System.Windows.Forms.PictureBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbAbout = new System.Windows.Forms.TextBox();
            this.bDeutsch = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.bEnglish = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            ((System.ComponentModel.ISupportInitialize)(this.pLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComplete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbPath.CustomButton.Image = null;
            this.tbPath.CustomButton.Location = new System.Drawing.Point(232, 2);
            this.tbPath.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPath.CustomButton.Name = "";
            this.tbPath.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.tbPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPath.CustomButton.TabIndex = 1;
            this.tbPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPath.CustomButton.UseSelectable = true;
            this.tbPath.CustomButton.Visible = false;
            this.tbPath.Lines = new string[0];
            this.tbPath.Location = new System.Drawing.Point(139, 94);
            this.tbPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPath.MaxLength = 32767;
            this.tbPath.Name = "tbPath";
            this.tbPath.PasswordChar = '\0';
            this.tbPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPath.SelectedText = "";
            this.tbPath.SelectionLength = 0;
            this.tbPath.SelectionStart = 0;
            this.tbPath.ShortcutsEnabled = true;
            this.tbPath.Size = new System.Drawing.Size(252, 22);
            this.tbPath.TabIndex = 1;
            this.tbPath.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tooltip.SetToolTip(this.tbPath, "Files in this directory will be prepaired");
            this.tbPath.UseSelectable = true;
            this.tbPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbPath.TextChanged += new System.EventHandler(this.pathTextChanged);
            // 
            // bRun
            // 
            this.bRun.Image = null;
            this.bRun.Location = new System.Drawing.Point(288, 236);
            this.bRun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(103, 23);
            this.bRun.TabIndex = 4;
            this.bRun.Text = "Run";
            this.bRun.UseSelectable = true;
            this.bRun.UseVisualStyleBackColor = true;
            this.bRun.Click += new System.EventHandler(this.bRun_Click_1);
            // 
            // tbStatus
            // 
            this.tbStatus.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.tbStatus.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.tbStatus.CustomButton.Image = null;
            this.tbStatus.CustomButton.Location = new System.Drawing.Point(397, 1);
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
        "   Converting from wav to mp3, normalizing and tagging"};
            this.tbStatus.Location = new System.Drawing.Point(-4, 276);
            this.tbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStatus.MaxLength = 32767;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.PasswordChar = '\0';
            this.tbStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbStatus.SelectedText = "";
            this.tbStatus.SelectionLength = 0;
            this.tbStatus.SelectionStart = 0;
            this.tbStatus.ShortcutsEnabled = true;
            this.tbStatus.Size = new System.Drawing.Size(435, 39);
            this.tbStatus.TabIndex = 6;
            this.tbStatus.Text = "   Converting from wav to mp3, normalizing and tagging";
            this.tbStatus.UseSelectable = true;
            this.tbStatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbStatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbStatus.Click += new System.EventHandler(this.formClick);
            // 
            // tbdB
            // 
            // 
            // 
            // 
            this.tbdB.CustomButton.Image = null;
            this.tbdB.CustomButton.Location = new System.Drawing.Point(11, 1);
            this.tbdB.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbdB.CustomButton.Name = "";
            this.tbdB.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tbdB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbdB.CustomButton.TabIndex = 1;
            this.tbdB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbdB.CustomButton.UseSelectable = true;
            this.tbdB.CustomButton.Visible = false;
            this.tbdB.Lines = new string[0];
            this.tbdB.Location = new System.Drawing.Point(139, 124);
            this.tbdB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbdB.MaxLength = 32767;
            this.tbdB.Name = "tbdB";
            this.tbdB.PasswordChar = '\0';
            this.tbdB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbdB.SelectedText = "";
            this.tbdB.SelectionLength = 0;
            this.tbdB.SelectionStart = 0;
            this.tbdB.ShortcutsEnabled = true;
            this.tbdB.Size = new System.Drawing.Size(31, 21);
            this.tbdB.TabIndex = 7;
            this.tooltip.SetToolTip(this.tbdB, "set new track value, without loosing level dynamic");
            this.tbdB.UseSelectable = true;
            this.tbdB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbdB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbdB.TextChanged += new System.EventHandler(this.tbDBTextChanged);
            // 
            // lPath
            // 
            this.lPath.AutoSize = true;
            this.lPath.Location = new System.Drawing.Point(9, 98);
            this.lPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPath.Name = "lPath";
            this.lPath.Size = new System.Drawing.Size(96, 17);
            this.lPath.TabIndex = 10;
            this.lPath.Text = "Get files from:";
            // 
            // ldB
            // 
            this.ldB.AutoSize = true;
            this.ldB.Location = new System.Drawing.Point(9, 129);
            this.ldB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ldB.Name = "ldB";
            this.ldB.Size = new System.Drawing.Size(126, 17);
            this.ldB.TabIndex = 11;
            this.ldB.Text = "Gain manipulation:";
            // 
            // lUnit
            // 
            this.lUnit.AutoSize = true;
            this.lUnit.Location = new System.Drawing.Point(176, 128);
            this.lUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lUnit.Name = "lUnit";
            this.lUnit.Size = new System.Drawing.Size(21, 20);
            this.lUnit.TabIndex = 12;
            this.lUnit.Text = "dB";
            this.lUnit.UseCompatibleTextRendering = true;
            // 
            // pLoad
            // 
            this.pLoad.ErrorImage = global::VibeBot.Properties.Resources.load;
            this.pLoad.Image = global::VibeBot.Properties.Resources.load;
            this.pLoad.ImageLocation = "";
            this.pLoad.InitialImage = ((System.Drawing.Image)(resources.GetObject("pLoad.InitialImage")));
            this.pLoad.Location = new System.Drawing.Point(368, 41);
            this.pLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pLoad.Name = "pLoad";
            this.pLoad.Size = new System.Drawing.Size(33, 28);
            this.pLoad.TabIndex = 5;
            this.pLoad.TabStop = false;
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDelete.Location = new System.Drawing.Point(8, 159);
            this.cbDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(148, 21);
            this.cbDelete.TabIndex = 13;
            this.cbDelete.Text = "Only save the mp3";
            this.cbDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tooltip.SetToolTip(this.cbDelete, "when checking, wav files are deleted after converting");
            this.cbDelete.UseVisualStyleBackColor = true;
            this.cbDelete.Click += new System.EventHandler(this.cbEverwrite);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.ErrorImage = global::VibeBot.Properties.Resources.Background;
            this.pictureBox.ImageLocation = "VibeBot.Properties.Resources.Background";
            this.pictureBox.InitialImage = global::VibeBot.Properties.Resources.Background;
            this.pictureBox.Location = new System.Drawing.Point(0, 62);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(401, 18);
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            this.tooltip.SetToolTip(this.pictureBox, "Show analysation");
            this.pictureBox.Click += new System.EventHandler(this.formClick);
            // 
            // lLevel
            // 
            this.lLevel.AutoSize = true;
            this.lLevel.ForeColor = System.Drawing.Color.SteelBlue;
            this.lLevel.Location = new System.Drawing.Point(219, 128);
            this.lLevel.Name = "lLevel";
            this.lLevel.Size = new System.Drawing.Size(101, 17);
            this.lLevel.TabIndex = 15;
            this.lLevel.Text = "Output level ->";
            this.tooltip.SetToolTip(this.lLevel, "Fixed base gain at 89 db, adjustable input value");
            // 
            // pGear
            // 
            this.pGear.ErrorImage = global::VibeBot.Properties.Resources.Background;
            this.pGear.Image = global::VibeBot.Properties.Resources.gearmove;
            this.pGear.Location = new System.Drawing.Point(397, 278);
            this.pGear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pGear.Name = "pGear";
            this.pGear.Size = new System.Drawing.Size(51, 47);
            this.pGear.TabIndex = 18;
            this.pGear.TabStop = false;
            this.tooltip.SetToolTip(this.pGear, "Click, to open analyze window");
            this.pGear.Click += new System.EventHandler(this.bAnalyze);
            // 
            // bSearchPath
            // 
            this.bSearchPath.Image = null;
            this.bSearchPath.Location = new System.Drawing.Point(397, 94);
            this.bSearchPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSearchPath.Name = "bSearchPath";
            this.bSearchPath.Size = new System.Drawing.Size(21, 22);
            this.bSearchPath.TabIndex = 17;
            this.bSearchPath.Text = "...";
            this.tooltip.SetToolTip(this.bSearchPath, "Search in filebowser");
            this.bSearchPath.UseSelectable = true;
            this.bSearchPath.UseVisualStyleBackColor = true;
            this.bSearchPath.Click += new System.EventHandler(this.folderBrowserClick);
            // 
            // cbReset
            // 
            this.cbReset.AutoSize = true;
            this.cbReset.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReset.Location = new System.Drawing.Point(7, 188);
            this.cbReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbReset.Name = "cbReset";
            this.cbReset.Size = new System.Drawing.Size(148, 21);
            this.cbReset.TabIndex = 19;
            this.cbReset.Text = "Set files to 89 db   ";
            this.cbReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tooltip.SetToolTip(this.cbReset, "when checking, wav files are deleted after converting");
            this.cbReset.UseVisualStyleBackColor = true;
            this.cbReset.CheckedChanged += new System.EventHandler(this.cbResetChecked);
            // 
            // picComplete
            // 
            this.picComplete.Image = global::VibeBot.Properties.Resources.Complete;
            this.picComplete.Location = new System.Drawing.Point(-5, 0);
            this.picComplete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picComplete.Name = "picComplete";
            this.picComplete.Size = new System.Drawing.Size(433, 10);
            this.picComplete.TabIndex = 16;
            this.picComplete.TabStop = false;
            this.picComplete.Visible = false;
            this.picComplete.Click += new System.EventHandler(this.formClick);
            // 
            // folderBrowser
            // 
            this.folderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowser.ShowNewFolderButton = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VibeBot.Properties.Resources.questionMark;
            this.pictureBox1.Location = new System.Drawing.Point(357, 279);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 27);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.bInfo);
            // 
            // tbAbout
            // 
            this.tbAbout.ForeColor = System.Drawing.Color.DimGray;
            this.tbAbout.Location = new System.Drawing.Point(1, 94);
            this.tbAbout.Multiline = true;
            this.tbAbout.Name = "tbAbout";
            this.tbAbout.Size = new System.Drawing.Size(427, 183);
            this.tbAbout.TabIndex = 21;
            this.tbAbout.Text = resources.GetString("tbAbout.Text");
            this.tbAbout.Click += new System.EventHandler(this.tbAboutClick);
            // 
            // bDeutsch
            // 
            this.bDeutsch.Image = null;
            this.bDeutsch.Location = new System.Drawing.Point(318, 278);
            this.bDeutsch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDeutsch.Name = "bDeutsch";
            this.bDeutsch.Size = new System.Drawing.Size(33, 22);
            this.bDeutsch.TabIndex = 22;
            this.bDeutsch.Text = "De";
            this.bDeutsch.UseSelectable = true;
            this.bDeutsch.UseVisualStyleBackColor = true;
            this.bDeutsch.Visible = false;
            this.bDeutsch.Click += new System.EventHandler(this.bDeuClick);
            // 
            // bEnglish
            // 
            this.bEnglish.Image = null;
            this.bEnglish.Location = new System.Drawing.Point(279, 278);
            this.bEnglish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEnglish.Name = "bEnglish";
            this.bEnglish.Size = new System.Drawing.Size(33, 22);
            this.bEnglish.TabIndex = 23;
            this.bEnglish.Text = "Eng";
            this.bEnglish.UseSelectable = true;
            this.bEnglish.UseVisualStyleBackColor = true;
            this.bEnglish.Visible = false;
            this.bEnglish.Click += new System.EventHandler(this.bEngClick);
            // 
            // VibeBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 300);
            this.Controls.Add(this.bEnglish);
            this.Controls.Add(this.bDeutsch);
            this.Controls.Add(this.tbAbout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbReset);
            this.Controls.Add(this.pGear);
            this.Controls.Add(this.bSearchPath);
            this.Controls.Add(this.pLoad);
            this.Controls.Add(this.picComplete);
            this.Controls.Add(this.lLevel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.cbDelete);
            this.Controls.Add(this.lUnit);
            this.Controls.Add(this.ldB);
            this.Controls.Add(this.lPath);
            this.Controls.Add(this.tbdB);
            this.Controls.Add(this.bRun);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.tbStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(424, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "VibeBot";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Text = "VibeBot";
            this.Click += new System.EventHandler(this.formClick);
            ((System.ComponentModel.ISupportInitialize)(this.pLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComplete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MetroFramework.Controls.MetroTextBox tbPath;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton bRun;
        public System.Windows.Forms.PictureBox pLoad;
        private MetroFramework.Controls.MetroTextBox tbStatus;
        private MetroFramework.Controls.MetroTextBox tbdB;
        private System.Windows.Forms.Label lPath;
        private System.Windows.Forms.Label ldB;
        private System.Windows.Forms.Label lUnit;
        private System.Windows.Forms.CheckBox cbDelete;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lLevel;
        private ToolTip tooltip;
        private PictureBox picComplete;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton bSearchPath;
        private FolderBrowserDialog folderBrowser;
        private PictureBox pGear;
        private CheckBox cbReset;
        private PictureBox pictureBox1;
        private TextBox tbAbout;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton bDeutsch;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton bEnglish;
    }
}

