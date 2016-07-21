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
            this.pLoad = new System.Windows.Forms.PictureBox();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.pGear = new System.Windows.Forms.PictureBox();
            this.cbReset = new System.Windows.Forms.CheckBox();
            this.lLevel = new System.Windows.Forms.Label();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.tbdB = new MetroFramework.Controls.MetroTextBox();
            this.tbPath = new MetroFramework.Controls.MetroTextBox();
            this.bSearchPath = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.pComplete = new System.Windows.Forms.PictureBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tapControl = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.bRun = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.lUnit = new System.Windows.Forms.Label();
            this.ldB = new System.Windows.Forms.Label();
            this.lPath = new System.Windows.Forms.Label();
            this.tabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.tabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.tbAbout = new System.Windows.Forms.TextBox();
            this.bDeutsch = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.bEnglish = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pComplete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tapControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pLoad
            // 
            this.pLoad.ErrorImage = global::VibeBot.Properties.Resources.load;
            this.pLoad.Image = global::VibeBot.Properties.Resources.load;
            this.pLoad.ImageLocation = "";
            this.pLoad.InitialImage = ((System.Drawing.Image)(resources.GetObject("pLoad.InitialImage")));
            this.pLoad.Location = new System.Drawing.Point(467, 20);
            this.pLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pLoad.Name = "pLoad";
            this.pLoad.Size = new System.Drawing.Size(52, 39);
            this.pLoad.TabIndex = 5;
            this.pLoad.TabStop = false;
            // 
            // pGear
            // 
            this.pGear.ErrorImage = global::VibeBot.Properties.Resources.Background;
            this.pGear.Image = global::VibeBot.Properties.Resources.gearmove;
            this.pGear.Location = new System.Drawing.Point(481, 284);
            this.pGear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pGear.Name = "pGear";
            this.pGear.Size = new System.Drawing.Size(51, 47);
            this.pGear.TabIndex = 18;
            this.pGear.TabStop = false;
            this.tooltip.SetToolTip(this.pGear, "Click, to open analyze window");
            this.pGear.Visible = false;
            this.pGear.Click += new System.EventHandler(this.bAnalyze);
            // 
            // cbReset
            // 
            this.cbReset.AutoSize = true;
            this.cbReset.BackColor = System.Drawing.Color.White;
            this.cbReset.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReset.Location = new System.Drawing.Point(2, 120);
            this.cbReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbReset.Name = "cbReset";
            this.cbReset.Size = new System.Drawing.Size(114, 17);
            this.cbReset.TabIndex = 30;
            this.cbReset.Text = "Set files to 89 db   ";
            this.cbReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tooltip.SetToolTip(this.cbReset, "set gain to 89 dB without loss of data");
            this.cbReset.UseVisualStyleBackColor = false;
            this.cbReset.CheckedChanged += new System.EventHandler(this.cbResetChecked);
            // 
            // lLevel
            // 
            this.lLevel.AutoSize = true;
            this.lLevel.BackColor = System.Drawing.Color.White;
            this.lLevel.ForeColor = System.Drawing.Color.SteelBlue;
            this.lLevel.Location = new System.Drawing.Point(207, 61);
            this.lLevel.Name = "lLevel";
            this.lLevel.Size = new System.Drawing.Size(76, 13);
            this.lLevel.TabIndex = 29;
            this.lLevel.Text = "Output level ->";
            this.tooltip.SetToolTip(this.lLevel, "Fixed base gain at 89 db, adjustable input value");
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.BackColor = System.Drawing.Color.White;
            this.cbDelete.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDelete.Location = new System.Drawing.Point(3, 91);
            this.cbDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(114, 17);
            this.cbDelete.TabIndex = 28;
            this.cbDelete.Text = "Only save the mp3";
            this.cbDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tooltip.SetToolTip(this.cbDelete, "when checking, wav files are deleted after converting");
            this.cbDelete.UseVisualStyleBackColor = false;
            this.cbDelete.CheckedChanged += new System.EventHandler(this.cbDeleteChecked);
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
            this.tbdB.Location = new System.Drawing.Point(103, 56);
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
            this.tbdB.TabIndex = 24;
            this.tooltip.SetToolTip(this.tbdB, "set new track value, without loosing level dynamic");
            this.tbdB.UseSelectable = true;
            this.tbdB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbdB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbdB.TextChanged += new System.EventHandler(this.tbDBTextChanged);
            // 
            // tbPath
            // 
            this.tbPath.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbPath.CustomButton.Image = null;
            this.tbPath.CustomButton.Location = new System.Drawing.Point(327, 2);
            this.tbPath.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPath.CustomButton.Name = "";
            this.tbPath.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.tbPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPath.CustomButton.TabIndex = 1;
            this.tbPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPath.CustomButton.UseSelectable = true;
            this.tbPath.CustomButton.Visible = false;
            this.tbPath.Lines = new string[0];
            this.tbPath.Location = new System.Drawing.Point(103, 21);
            this.tbPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPath.MaxLength = 32767;
            this.tbPath.Name = "tbPath";
            this.tbPath.PasswordChar = '\0';
            this.tbPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPath.SelectedText = "";
            this.tbPath.SelectionLength = 0;
            this.tbPath.SelectionStart = 0;
            this.tbPath.ShortcutsEnabled = true;
            this.tbPath.Size = new System.Drawing.Size(347, 22);
            this.tbPath.TabIndex = 23;
            this.tbPath.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tooltip.SetToolTip(this.tbPath, "Files in this directory will be prepaired");
            this.tbPath.UseSelectable = true;
            this.tbPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbPath.TextChanged += new System.EventHandler(this.pathTextChanged);
            // 
            // bSearchPath
            // 
            this.bSearchPath.Image = null;
            this.bSearchPath.Location = new System.Drawing.Point(467, 21);
            this.bSearchPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSearchPath.Name = "bSearchPath";
            this.bSearchPath.Size = new System.Drawing.Size(21, 22);
            this.bSearchPath.TabIndex = 33;
            this.bSearchPath.Text = "...";
            this.tooltip.SetToolTip(this.bSearchPath, "Search in filebowser");
            this.bSearchPath.UseSelectable = true;
            this.bSearchPath.UseVisualStyleBackColor = true;
            this.bSearchPath.Click += new System.EventHandler(this.folderBrowserClick);
            // 
            // pComplete
            // 
            this.pComplete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pComplete.Image = global::VibeBot.Properties.Resources.Complete;
            this.pComplete.Location = new System.Drawing.Point(-24, 0);
            this.pComplete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pComplete.Name = "pComplete";
            this.pComplete.Size = new System.Drawing.Size(541, 10);
            this.pComplete.TabIndex = 16;
            this.pComplete.TabStop = false;
            this.pComplete.Visible = false;
            // 
            // folderBrowser
            // 
            this.folderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowser.ShowNewFolderButton = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VibeBot.Properties.Resources.questionMark;
            this.pictureBox1.Location = new System.Drawing.Point(436, 290);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 27);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.bInfo);
            // 
            // tapControl
            // 
            this.tapControl.Controls.Add(this.tabPage1);
            this.tapControl.Controls.Add(this.tabPage2);
            this.tapControl.Controls.Add(this.tabPage3);
            this.tapControl.Location = new System.Drawing.Point(-4, 49);
            this.tapControl.Name = "tapControl";
            this.tapControl.SelectedIndex = 0;
            this.tapControl.Size = new System.Drawing.Size(521, 268);
            this.tapControl.TabIndex = 24;
            this.tapControl.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tapControl.UseSelectable = true;
            this.tapControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bSearchPath);
            this.tabPage1.Controls.Add(this.bRun);
            this.tabPage1.Controls.Add(this.cbReset);
            this.tabPage1.Controls.Add(this.lLevel);
            this.tabPage1.Controls.Add(this.cbDelete);
            this.tabPage1.Controls.Add(this.lUnit);
            this.tabPage1.Controls.Add(this.ldB);
            this.tabPage1.Controls.Add(this.lPath);
            this.tabPage1.Controls.Add(this.tbdB);
            this.tabPage1.Controls.Add(this.tbPath);
            this.tabPage1.HorizontalScrollbarBarColor = true;
            this.tabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage1.HorizontalScrollbarSize = 10;
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(513, 226);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.VerticalScrollbarBarColor = true;
            this.tabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage1.VerticalScrollbarSize = 10;
            // 
            // bRun
            // 
            this.bRun.Image = null;
            this.bRun.Location = new System.Drawing.Point(385, 197);
            this.bRun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(103, 23);
            this.bRun.TabIndex = 32;
            this.bRun.Text = "Run";
            this.bRun.UseSelectable = true;
            this.bRun.UseVisualStyleBackColor = true;
            this.bRun.Click += new System.EventHandler(this.bRun_Click_1);
            // 
            // lUnit
            // 
            this.lUnit.AutoSize = true;
            this.lUnit.BackColor = System.Drawing.Color.White;
            this.lUnit.Location = new System.Drawing.Point(140, 60);
            this.lUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lUnit.Name = "lUnit";
            this.lUnit.Size = new System.Drawing.Size(18, 17);
            this.lUnit.TabIndex = 27;
            this.lUnit.Text = "dB";
            this.lUnit.UseCompatibleTextRendering = true;
            // 
            // ldB
            // 
            this.ldB.AutoSize = true;
            this.ldB.BackColor = System.Drawing.Color.White;
            this.ldB.Location = new System.Drawing.Point(4, 61);
            this.ldB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ldB.Name = "ldB";
            this.ldB.Size = new System.Drawing.Size(94, 13);
            this.ldB.TabIndex = 26;
            this.ldB.Text = "Gain manipulation:";
            // 
            // lPath
            // 
            this.lPath.AutoSize = true;
            this.lPath.BackColor = System.Drawing.Color.White;
            this.lPath.Location = new System.Drawing.Point(4, 30);
            this.lPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPath.Name = "lPath";
            this.lPath.Size = new System.Drawing.Size(71, 13);
            this.lPath.TabIndex = 25;
            this.lPath.Text = "Get files from:";
            // 
            // tabPage2
            // 
            this.tabPage2.HorizontalScrollbarBarColor = true;
            this.tabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage2.HorizontalScrollbarSize = 10;
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(513, 226);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Analyze";
            this.tabPage2.VerticalScrollbarBarColor = true;
            this.tabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage2.VerticalScrollbarSize = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbAbout);
            this.tabPage3.Controls.Add(this.bDeutsch);
            this.tabPage3.Controls.Add(this.bEnglish);
            this.tabPage3.HorizontalScrollbarBarColor = true;
            this.tabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage3.HorizontalScrollbarSize = 10;
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(513, 226);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "About";
            this.tabPage3.VerticalScrollbarBarColor = true;
            this.tabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage3.VerticalScrollbarSize = 10;
            // 
            // tbAbout
            // 
            this.tbAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAbout.ForeColor = System.Drawing.Color.DimGray;
            this.tbAbout.Location = new System.Drawing.Point(6, 15);
            this.tbAbout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAbout.Multiline = true;
            this.tbAbout.Name = "tbAbout";
            this.tbAbout.Size = new System.Drawing.Size(504, 184);
            this.tbAbout.TabIndex = 36;
            this.tbAbout.Text = resources.GetString("tbAbout.Text");
            // 
            // bDeutsch
            // 
            this.bDeutsch.Image = null;
            this.bDeutsch.Location = new System.Drawing.Point(452, 194);
            this.bDeutsch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDeutsch.Name = "bDeutsch";
            this.bDeutsch.Size = new System.Drawing.Size(36, 27);
            this.bDeutsch.TabIndex = 34;
            this.bDeutsch.Text = "De";
            this.bDeutsch.UseSelectable = true;
            this.bDeutsch.UseVisualStyleBackColor = true;
            this.bDeutsch.Click += new System.EventHandler(this.bDeuClick);
            // 
            // bEnglish
            // 
            this.bEnglish.Image = null;
            this.bEnglish.Location = new System.Drawing.Point(409, 194);
            this.bEnglish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEnglish.Name = "bEnglish";
            this.bEnglish.Size = new System.Drawing.Size(37, 27);
            this.bEnglish.TabIndex = 33;
            this.bEnglish.Text = "Eng";
            this.bEnglish.UseSelectable = true;
            this.bEnglish.UseVisualStyleBackColor = true;
            this.bEnglish.Click += new System.EventHandler(this.bEngClick);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.ErrorImage = global::VibeBot.Properties.Resources.Background;
            this.pictureBox.ImageLocation = "VibeBot.Properties.Resources.Background";
            this.pictureBox.InitialImage = global::VibeBot.Properties.Resources.Background;
            this.pictureBox.Location = new System.Drawing.Point(-430, 49);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(750, 10);
            this.pictureBox.TabIndex = 35;
            this.pictureBox.TabStop = false;
            this.tooltip.SetToolTip(this.pictureBox, "Show analysation");
            // 
            // VibeBot
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(511, 316);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.pLoad);
            this.Controls.Add(this.tapControl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pGear);
            this.Controls.Add(this.pComplete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(511, 316);
            this.MinimumSize = new System.Drawing.Size(511, 316);
            this.Name = "VibeBot";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Text = "VibeBot";
            ((System.ComponentModel.ISupportInitialize)(this.pLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pComplete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tapControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox pLoad;
        private ToolTip tooltip;
        private PictureBox pComplete;
        private FolderBrowserDialog folderBrowser;
        private PictureBox pGear;
        private PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTabControl tapControl;
        private MetroFramework.Controls.MetroTabPage tabPage1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton bSearchPath;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton bRun;
        private CheckBox cbReset;
        private Label lLevel;
        private CheckBox cbDelete;
        private Label lUnit;
        private Label ldB;
        private Label lPath;
        private MetroFramework.Controls.MetroTextBox tbdB;
        public MetroFramework.Controls.MetroTextBox tbPath;
        private MetroFramework.Controls.MetroTabPage tabPage3;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton bDeutsch;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton bEnglish;
        private MetroFramework.Controls.MetroTabPage tabPage2;
        private TextBox tbAbout;
        private PictureBox pictureBox;
    }
}

