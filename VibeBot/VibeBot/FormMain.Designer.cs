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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pLoad = new System.Windows.Forms.PictureBox();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.pGear = new System.Windows.Forms.PictureBox();
            this.cbReset = new System.Windows.Forms.CheckBox();
            this.lLevel = new System.Windows.Forms.Label();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.tbdB = new MetroFramework.Controls.MetroTextBox();
            this.tbPath = new MetroFramework.Controls.MetroTextBox();
            this.bSearchPath = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.bGear = new System.Windows.Forms.Button();
            this.gridAnalyze = new MetroFramework.Controls.MetroGrid();
            this.pComplete = new System.Windows.Forms.PictureBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.bRun = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.lUnit = new System.Windows.Forms.Label();
            this.ldB = new System.Windows.Forms.Label();
            this.lPath = new System.Windows.Forms.Label();
            this.tbState = new System.Windows.Forms.TextBox();
            this.tabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.pArrow = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbAnaStatus = new MetroFramework.Controls.MetroTextBox();
            this.tabempty = new MetroFramework.Controls.MetroTabPage();
            this.tabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.tbAbout = new System.Windows.Forms.TextBox();
            this.bDeutsch = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.bEnglish = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.bAnalyze = new System.Windows.Forms.Button();
            this.lArrow = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnalyze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pComplete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
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
            // 
            // cbReset
            // 
            this.cbReset.AutoSize = true;
            this.cbReset.BackColor = System.Drawing.Color.White;
            this.cbReset.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.74F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbReset.Location = new System.Drawing.Point(1, 130);
            this.cbReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbReset.Name = "cbReset";
            this.cbReset.Size = new System.Drawing.Size(139, 20);
            this.cbReset.TabIndex = 30;
            this.cbReset.Text = "Set files to 89 db     ";
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
            this.lLevel.Location = new System.Drawing.Point(231, 62);
            this.lLevel.Name = "lLevel";
            this.lLevel.Size = new System.Drawing.Size(101, 17);
            this.lLevel.TabIndex = 29;
            this.lLevel.Text = "Output level ->";
            this.tooltip.SetToolTip(this.lLevel, "Fixed base gain at 89 db, adjustable input value");
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.BackColor = System.Drawing.Color.White;
            this.cbDelete.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.74F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbDelete.Location = new System.Drawing.Point(2, 97);
            this.cbDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(137, 20);
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
            this.tbdB.Location = new System.Drawing.Point(124, 56);
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
            this.tbPath.CustomButton.Location = new System.Drawing.Point(324, 2);
            this.tbPath.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPath.CustomButton.Name = "";
            this.tbPath.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.tbPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPath.CustomButton.TabIndex = 1;
            this.tbPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPath.CustomButton.UseSelectable = true;
            this.tbPath.CustomButton.Visible = false;
            this.tbPath.Lines = new string[0];
            this.tbPath.Location = new System.Drawing.Point(125, 20);
            this.tbPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPath.MaxLength = 32767;
            this.tbPath.Name = "tbPath";
            this.tbPath.PasswordChar = '\0';
            this.tbPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPath.SelectedText = "";
            this.tbPath.SelectionLength = 0;
            this.tbPath.SelectionStart = 0;
            this.tbPath.ShortcutsEnabled = true;
            this.tbPath.Size = new System.Drawing.Size(344, 22);
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
            this.bSearchPath.Location = new System.Drawing.Point(467, 20);
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
            this.pictureBox.Visible = false;
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
            this.bGear.Location = new System.Drawing.Point(390, 60);
            this.bGear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bGear.Name = "bGear";
            this.bGear.Size = new System.Drawing.Size(127, 163);
            this.bGear.TabIndex = 18;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAnalyze.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridAnalyze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAnalyze.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridAnalyze.EnableHeadersVisualStyles = false;
            this.gridAnalyze.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridAnalyze.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridAnalyze.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridAnalyze.Location = new System.Drawing.Point(0, -1);
            this.gridAnalyze.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridAnalyze.Name = "gridAnalyze";
            this.gridAnalyze.ReadOnly = true;
            this.gridAnalyze.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAnalyze.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridAnalyze.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridAnalyze.RowTemplate.Height = 24;
            this.gridAnalyze.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridAnalyze.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAnalyze.Size = new System.Drawing.Size(336, 202);
            this.gridAnalyze.StandardTab = true;
            this.gridAnalyze.Style = MetroFramework.MetroColorStyle.White;
            this.gridAnalyze.TabIndex = 16;
            this.gridAnalyze.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tooltip.SetToolTip(this.gridAnalyze, "Files from directory");
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
            // tabControl
            // 
            this.tabControl.AllowDrop = true;
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabempty);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(-2, 52);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeftLayout = true;
            this.tabControl.SelectedIndex = 1;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(521, 268);
            this.tabControl.Style = MetroFramework.MetroColorStyle.Blue;
            this.tabControl.TabIndex = 24;
            this.tabControl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.tabControl.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabControl.UseSelectable = true;
            this.tabControl.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropItem);
            this.tabControl.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnter);
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
            this.tabPage1.Controls.Add(this.tbState);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.HorizontalScrollbarBarColor = true;
            this.tabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage1.HorizontalScrollbarSize = 10;
            this.tabPage1.Location = new System.Drawing.Point(4, 75);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(513, 189);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.VerticalScrollbarBarColor = true;
            this.tabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage1.VerticalScrollbarSize = 10;
            // 
            // bRun
            // 
            this.bRun.Image = null;
            this.bRun.Location = new System.Drawing.Point(385, 191);
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
            this.lUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lUnit.Location = new System.Drawing.Point(157, 61);
            this.lUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lUnit.Name = "lUnit";
            this.lUnit.Size = new System.Drawing.Size(22, 20);
            this.lUnit.TabIndex = 27;
            this.lUnit.Text = "dB";
            this.lUnit.UseCompatibleTextRendering = true;
            // 
            // ldB
            // 
            this.ldB.AutoSize = true;
            this.ldB.BackColor = System.Drawing.Color.White;
            this.ldB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.74F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ldB.Location = new System.Drawing.Point(4, 61);
            this.ldB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ldB.Name = "ldB";
            this.ldB.Size = new System.Drawing.Size(118, 16);
            this.ldB.TabIndex = 26;
            this.ldB.Text = "Gain manipulation:";
            // 
            // lPath
            // 
            this.lPath.AutoSize = true;
            this.lPath.BackColor = System.Drawing.Color.White;
            this.lPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lPath.Location = new System.Drawing.Point(4, 26);
            this.lPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPath.Name = "lPath";
            this.lPath.Size = new System.Drawing.Size(88, 16);
            this.lPath.TabIndex = 25;
            this.lPath.Text = "Get files from:";
            // 
            // tbState
            // 
            this.tbState.BackColor = System.Drawing.Color.White;
            this.tbState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbState.Enabled = false;
            this.tbState.ForeColor = System.Drawing.Color.White;
            this.tbState.Location = new System.Drawing.Point(3, 207);
            this.tbState.Name = "tbState";
            this.tbState.ShortcutsEnabled = false;
            this.tbState.Size = new System.Drawing.Size(387, 16);
            this.tbState.TabIndex = 34;
            this.tbState.Text = "Info:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lArrow);
            this.tabPage2.Controls.Add(this.pArrow);
            this.tabPage2.Controls.Add(this.gridAnalyze);
            this.tabPage2.Controls.Add(this.bGear);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.tbAnaStatus);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.HorizontalScrollbarBarColor = true;
            this.tabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage2.HorizontalScrollbarSize = 10;
            this.tabPage2.Location = new System.Drawing.Point(4, 41);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(513, 223);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Analyze";
            this.tabPage2.ToolTipText = "Analyze Track Gain";
            this.tabPage2.VerticalScrollbarBarColor = true;
            this.tabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage2.VerticalScrollbarSize = 10;
            // 
            // pArrow
            // 
            this.pArrow.Image = global::VibeBot.Properties.Resources.arrow;
            this.pArrow.Location = new System.Drawing.Point(265, 116);
            this.pArrow.Name = "pArrow";
            this.pArrow.Size = new System.Drawing.Size(145, 36);
            this.pArrow.TabIndex = 19;
            this.pArrow.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VibeBot.Properties.Resources.load;
            this.pictureBox2.Location = new System.Drawing.Point(128, -80);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 32);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.WaitOnLoad = true;
            // 
            // tbAnaStatus
            // 
            this.tbAnaStatus.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.tbAnaStatus.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.tbAnaStatus.CustomButton.Image = null;
            this.tbAnaStatus.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.tbAnaStatus.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAnaStatus.CustomButton.Name = "";
            this.tbAnaStatus.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.tbAnaStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAnaStatus.CustomButton.TabIndex = 1;
            this.tbAnaStatus.CustomButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tbAnaStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAnaStatus.CustomButton.UseSelectable = true;
            this.tbAnaStatus.CustomButton.Visible = false;
            this.tbAnaStatus.Enabled = false;
            this.tbAnaStatus.ForeColor = System.Drawing.Color.Black;
            this.tbAnaStatus.Lines = new string[] {
        "   Analyze track gain"};
            this.tbAnaStatus.Location = new System.Drawing.Point(-5, 201);
            this.tbAnaStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAnaStatus.MaxLength = 32767;
            this.tbAnaStatus.Name = "tbAnaStatus";
            this.tbAnaStatus.PasswordChar = '\0';
            this.tbAnaStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAnaStatus.SelectedText = "";
            this.tbAnaStatus.SelectionLength = 0;
            this.tbAnaStatus.SelectionStart = 0;
            this.tbAnaStatus.ShortcutsEnabled = true;
            this.tbAnaStatus.Size = new System.Drawing.Size(532, 39);
            this.tbAnaStatus.TabIndex = 15;
            this.tbAnaStatus.Text = "   Analyze track gain";
            this.tbAnaStatus.UseSelectable = true;
            this.tbAnaStatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAnaStatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabempty
            // 
            this.tabempty.BackColor = System.Drawing.Color.White;
            this.tabempty.CausesValidation = false;
            this.tabempty.HorizontalScrollbarBarColor = true;
            this.tabempty.HorizontalScrollbarHighlightOnWheel = false;
            this.tabempty.HorizontalScrollbarSize = 10;
            this.tabempty.Location = new System.Drawing.Point(4, 75);
            this.tabempty.Name = "tabempty";
            this.tabempty.Size = new System.Drawing.Size(513, 189);
            this.tabempty.Style = MetroFramework.MetroColorStyle.White;
            this.tabempty.TabIndex = 3;
            this.tabempty.Text = "                                                                             ";
            this.tabempty.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabempty.UseVisualStyleBackColor = true;
            this.tabempty.VerticalScrollbarBarColor = false;
            this.tabempty.VerticalScrollbarHighlightOnWheel = false;
            this.tabempty.VerticalScrollbarSize = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbAbout);
            this.tabPage3.Controls.Add(this.bDeutsch);
            this.tabPage3.Controls.Add(this.bEnglish);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.HorizontalScrollbarBarColor = true;
            this.tabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage3.HorizontalScrollbarSize = 10;
            this.tabPage3.Location = new System.Drawing.Point(4, 75);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(513, 189);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "About";
            this.tabPage3.ToolTipText = "Read information";
            this.tabPage3.VerticalScrollbarBarColor = true;
            this.tabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage3.VerticalScrollbarSize = 10;
            // 
            // tbAbout
            // 
            this.tbAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAbout.ForeColor = System.Drawing.Color.DimGray;
            this.tbAbout.Location = new System.Drawing.Point(6, 6);
            this.tbAbout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAbout.Multiline = true;
            this.tbAbout.Name = "tbAbout";
            this.tbAbout.Size = new System.Drawing.Size(504, 184);
            this.tbAbout.TabIndex = 36;
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
            // bAnalyze
            // 
            this.bAnalyze.Location = new System.Drawing.Point(0, 0);
            this.bAnalyze.Name = "bAnalyze";
            this.bAnalyze.Size = new System.Drawing.Size(75, 23);
            this.bAnalyze.TabIndex = 0;
            // 
            // lArrow
            // 
            this.lArrow.AutoSize = true;
            this.lArrow.Location = new System.Drawing.Point(258, 126);
            this.lArrow.Name = "lArrow";
            this.lArrow.Size = new System.Drawing.Size(109, 19);
            this.lArrow.TabIndex = 20;
            this.lArrow.Text = "Klick to reanalyze";
            // 
            // VibeBot
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(511, 316);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.pLoad);
            this.Controls.Add(this.tabControl);
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
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropItem);
            ((System.ComponentModel.ISupportInitialize)(this.pLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnalyze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pComplete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox pLoad;
        private ToolTip tooltip;
        private PictureBox pComplete;
        private FolderBrowserDialog folderBrowser;
        private PictureBox pGear;
        private PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTabControl tabControl;
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
        public  MetroFramework.Controls.MetroTextBox tbPath;
        private MetroFramework.Controls.MetroTabPage tabPage3;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton bDeutsch;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton bEnglish;
        private MetroFramework.Controls.MetroTabPage tabPage2;
        private TextBox tbAbout;
        private PictureBox pictureBox;
        private Button bGear;
        private Button bAnalyze;
        private PictureBox pictureBox2;
        private MetroFramework.Controls.MetroGrid gridAnalyze;
        private MetroFramework.Controls.MetroTextBox tbAnaStatus;
        private System.Windows.Forms.TextBox tbState;
        private MetroFramework.Controls.MetroTabPage tabempty;
        private PictureBox pArrow;
        private MetroFramework.Controls.MetroLabel lArrow;
    }
}

