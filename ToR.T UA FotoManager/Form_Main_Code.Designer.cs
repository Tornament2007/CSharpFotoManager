namespace ToRT_UA_FotoManager
{
    partial class Form_Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Center);
            this.BOX_TOD = new System.Windows.Forms.GroupBox();
            this.TOD_Set_B = new System.Windows.Forms.Button();
            this.MainImageList = new System.Windows.Forms.ImageList(this.components);
            this.TOD_Copy_B = new System.Windows.Forms.Button();
            this.TOD_Open_B = new System.Windows.Forms.Button();
            this.TOD_Label = new System.Windows.Forms.Label();
            this.BOX_SEL = new System.Windows.Forms.GroupBox();
            this.SEL_Copy_B = new System.Windows.Forms.Button();
            this.SEL_CRE_B = new System.Windows.Forms.Button();
            this.YEA_B = new System.Windows.Forms.Button();
            this.YEA_Strip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MON_B = new System.Windows.Forms.Button();
            this.MON_Strip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DAY_B = new System.Windows.Forms.Button();
            this.DAY_Strip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SEL_DatePick = new System.Windows.Forms.DateTimePicker();
            this.Day_UpDo = new System.Windows.Forms.NumericUpDown();
            this.Mon_UpDo = new System.Windows.Forms.NumericUpDown();
            this.Yea_UpDo = new System.Windows.Forms.NumericUpDown();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.Main_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.MainMenuBar = new System.Windows.Forms.MenuStrip();
            this.MMI_ProgramPage = new System.Windows.Forms.ToolStripMenuItem();
            this.MMI_OPENprogFOLD = new System.Windows.Forms.ToolStripMenuItem();
            this.MMI_S1 = new System.Windows.Forms.ToolStripSeparator();
            this.MMI_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MMI_SettingsPage = new System.Windows.Forms.ToolStripMenuItem();
            this.MMI_Configs = new System.Windows.Forms.ToolStripMenuItem();
            this.CB_Tiles = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWindowPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BOX_Camera = new System.Windows.Forms.GroupBox();
            this.BUT_OpenCamera = new System.Windows.Forms.Button();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.StatusTimer = new System.Windows.Forms.Timer(this.components);
            this.MainMenuHELP = new System.Windows.Forms.HelpProvider();
            this.MainList_LV = new System.Windows.Forms.ListView();
            this.Strip_FileContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContestStrip_FileName = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyFile = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyFilePath = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyFileAsMedia = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BOX_Photos = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.B_REFILL = new System.Windows.Forms.Button();
            this.B_Filter = new System.Windows.Forms.Button();
            this.MainList_LB = new System.Windows.Forms.ListBox();
            this.PN_Count = new System.Windows.Forms.Panel();
            this.Coun_Label = new System.Windows.Forms.Label();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ImageDataBox = new System.Windows.Forms.GroupBox();
            this.VievListImgs = new System.Windows.Forms.ImageList(this.components);
            this.BOX_TOD.SuspendLayout();
            this.BOX_SEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Day_UpDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mon_UpDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yea_UpDo)).BeginInit();
            this.StatusBar.SuspendLayout();
            this.MainMenuBar.SuspendLayout();
            this.BOX_Camera.SuspendLayout();
            this.Strip_FileContext.SuspendLayout();
            this.BOX_Photos.SuspendLayout();
            this.PN_Count.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // BOX_TOD
            // 
            this.BOX_TOD.Controls.Add(this.TOD_Set_B);
            this.BOX_TOD.Controls.Add(this.TOD_Copy_B);
            this.BOX_TOD.Controls.Add(this.TOD_Open_B);
            this.BOX_TOD.Controls.Add(this.TOD_Label);
            this.BOX_TOD.Location = new System.Drawing.Point(6, 27);
            this.BOX_TOD.Name = "BOX_TOD";
            this.BOX_TOD.Size = new System.Drawing.Size(102, 76);
            this.BOX_TOD.TabIndex = 0;
            this.BOX_TOD.TabStop = false;
            this.BOX_TOD.Text = "Today";
            // 
            // TOD_Set_B
            // 
            this.MainMenuHELP.SetHelpString(this.TOD_Set_B, "Will set selected date to \"today\"");
            this.TOD_Set_B.ImageIndex = 9;
            this.TOD_Set_B.ImageList = this.MainImageList;
            this.TOD_Set_B.Location = new System.Drawing.Point(38, 15);
            this.TOD_Set_B.Name = "TOD_Set_B";
            this.MainMenuHELP.SetShowHelp(this.TOD_Set_B, true);
            this.TOD_Set_B.Size = new System.Drawing.Size(26, 26);
            this.TOD_Set_B.TabIndex = 9;
            this.TOD_Set_B.UseVisualStyleBackColor = true;
            this.TOD_Set_B.Click += new System.EventHandler(this.TOD_Set_B_Click);
            // 
            // MainImageList
            // 
            this.MainImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MainImageList.ImageStream")));
            this.MainImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.MainImageList.Images.SetKeyName(0, "Im0.png");
            this.MainImageList.Images.SetKeyName(1, "Im1.png");
            this.MainImageList.Images.SetKeyName(2, "Im2.png");
            this.MainImageList.Images.SetKeyName(3, "Im3.png");
            this.MainImageList.Images.SetKeyName(4, "Im4.png");
            this.MainImageList.Images.SetKeyName(5, "Im5.png");
            this.MainImageList.Images.SetKeyName(6, "Im6.png");
            this.MainImageList.Images.SetKeyName(7, "Im7.png");
            this.MainImageList.Images.SetKeyName(8, "Im8.png");
            this.MainImageList.Images.SetKeyName(9, "Im9.png");
            this.MainImageList.Images.SetKeyName(10, "Im10.png");
            // 
            // TOD_Copy_B
            // 
            this.MainMenuHELP.SetHelpString(this.TOD_Copy_B, "Copy to clipboard - Left click: full path to today folder; Right: short date form" +
        "at of today date.");
            this.TOD_Copy_B.ImageIndex = 2;
            this.TOD_Copy_B.ImageList = this.MainImageList;
            this.TOD_Copy_B.Location = new System.Drawing.Point(70, 15);
            this.TOD_Copy_B.Name = "TOD_Copy_B";
            this.MainMenuHELP.SetShowHelp(this.TOD_Copy_B, true);
            this.TOD_Copy_B.Size = new System.Drawing.Size(26, 26);
            this.TOD_Copy_B.TabIndex = 8;
            this.TOD_Copy_B.UseVisualStyleBackColor = true;
            this.TOD_Copy_B.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SEL_Copy_BMouseDown);
            // 
            // TOD_Open_B
            // 
            this.MainMenuHELP.SetHelpKeyword(this.TOD_Open_B, "");
            this.MainMenuHELP.SetHelpString(this.TOD_Open_B, "Will create or open today folder.");
            this.TOD_Open_B.ImageIndex = 0;
            this.TOD_Open_B.ImageList = this.MainImageList;
            this.TOD_Open_B.Location = new System.Drawing.Point(6, 15);
            this.TOD_Open_B.Name = "TOD_Open_B";
            this.MainMenuHELP.SetShowHelp(this.TOD_Open_B, true);
            this.TOD_Open_B.Size = new System.Drawing.Size(26, 26);
            this.TOD_Open_B.TabIndex = 7;
            this.TOD_Open_B.UseVisualStyleBackColor = true;
            this.TOD_Open_B.Click += new System.EventHandler(this.SEL_CRE_B_Click);
            // 
            // TOD_Label
            // 
            this.TOD_Label.AutoSize = true;
            this.TOD_Label.Location = new System.Drawing.Point(11, 52);
            this.TOD_Label.Name = "TOD_Label";
            this.TOD_Label.Size = new System.Drawing.Size(76, 13);
            this.TOD_Label.TabIndex = 0;
            this.TOD_Label.Text = "01.01.2016 вс";
            // 
            // BOX_SEL
            // 
            this.BOX_SEL.Controls.Add(this.SEL_Copy_B);
            this.BOX_SEL.Controls.Add(this.SEL_CRE_B);
            this.BOX_SEL.Controls.Add(this.YEA_B);
            this.BOX_SEL.Controls.Add(this.MON_B);
            this.BOX_SEL.Controls.Add(this.DAY_B);
            this.BOX_SEL.Controls.Add(this.SEL_DatePick);
            this.BOX_SEL.Controls.Add(this.Day_UpDo);
            this.BOX_SEL.Controls.Add(this.Mon_UpDo);
            this.BOX_SEL.Controls.Add(this.Yea_UpDo);
            this.BOX_SEL.Cursor = System.Windows.Forms.Cursors.Default;
            this.BOX_SEL.Location = new System.Drawing.Point(114, 27);
            this.BOX_SEL.Name = "BOX_SEL";
            this.BOX_SEL.Size = new System.Drawing.Size(243, 76);
            this.BOX_SEL.TabIndex = 1;
            this.BOX_SEL.TabStop = false;
            this.BOX_SEL.Text = "Selected";
            // 
            // SEL_Copy_B
            // 
            this.MainMenuHELP.SetHelpString(this.SEL_Copy_B, "Copy to clipboard - Left click: full path to selected folder; Right: short date f" +
        "ormat of selected date.");
            this.SEL_Copy_B.ImageIndex = 2;
            this.SEL_Copy_B.ImageList = this.MainImageList;
            this.SEL_Copy_B.Location = new System.Drawing.Point(6, 44);
            this.SEL_Copy_B.Name = "SEL_Copy_B";
            this.MainMenuHELP.SetShowHelp(this.SEL_Copy_B, true);
            this.SEL_Copy_B.Size = new System.Drawing.Size(26, 26);
            this.SEL_Copy_B.TabIndex = 6;
            this.SEL_Copy_B.UseVisualStyleBackColor = true;
            this.SEL_Copy_B.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SEL_Copy_BMouseDown);
            // 
            // SEL_CRE_B
            // 
            this.MainMenuHELP.SetHelpString(this.SEL_CRE_B, "Will create or open selected folder.");
            this.SEL_CRE_B.ImageIndex = 0;
            this.SEL_CRE_B.ImageList = this.MainImageList;
            this.SEL_CRE_B.Location = new System.Drawing.Point(6, 15);
            this.SEL_CRE_B.Name = "SEL_CRE_B";
            this.MainMenuHELP.SetShowHelp(this.SEL_CRE_B, true);
            this.SEL_CRE_B.Size = new System.Drawing.Size(26, 26);
            this.SEL_CRE_B.TabIndex = 5;
            this.SEL_CRE_B.UseVisualStyleBackColor = true;
            this.SEL_CRE_B.Click += new System.EventHandler(this.SEL_CRE_B_Click);
            // 
            // YEA_B
            // 
            this.YEA_B.ContextMenuStrip = this.YEA_Strip;
            this.MainMenuHELP.SetHelpString(this.YEA_B, "Left click: Open selected year folder; Right: Show list of years to select.");
            this.YEA_B.ImageIndex = 6;
            this.YEA_B.ImageList = this.MainImageList;
            this.YEA_B.Location = new System.Drawing.Point(164, 15);
            this.YEA_B.Name = "YEA_B";
            this.MainMenuHELP.SetShowHelp(this.YEA_B, true);
            this.YEA_B.Size = new System.Drawing.Size(55, 26);
            this.YEA_B.TabIndex = 4;
            this.YEA_B.Text = "2016";
            this.YEA_B.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.YEA_B.UseVisualStyleBackColor = true;
            this.YEA_B.Click += new System.EventHandler(this.SEL_DayButClick);
            // 
            // YEA_Strip
            // 
            this.YEA_Strip.Name = "YEA_Strip";
            this.YEA_Strip.Size = new System.Drawing.Size(61, 4);
            this.YEA_Strip.Opening += new System.ComponentModel.CancelEventHandler(this.DMY_Strip_Opening);
            // 
            // MON_B
            // 
            this.MON_B.ContextMenuStrip = this.MON_Strip;
            this.MainMenuHELP.SetHelpString(this.MON_B, "Left click: Open selected month folder; Right: Show list of months to select.");
            this.MON_B.ImageIndex = 6;
            this.MON_B.ImageList = this.MainImageList;
            this.MON_B.Location = new System.Drawing.Point(101, 15);
            this.MON_B.Name = "MON_B";
            this.MainMenuHELP.SetShowHelp(this.MON_B, true);
            this.MON_B.Size = new System.Drawing.Size(45, 26);
            this.MON_B.TabIndex = 3;
            this.MON_B.Text = "12";
            this.MON_B.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MON_B.UseVisualStyleBackColor = true;
            this.MON_B.Click += new System.EventHandler(this.SEL_DayButClick);
            // 
            // MON_Strip
            // 
            this.MON_Strip.Name = "MON_Strip";
            this.MON_Strip.Size = new System.Drawing.Size(61, 4);
            this.MON_Strip.Opening += new System.ComponentModel.CancelEventHandler(this.DMY_Strip_Opening);
            // 
            // DAY_B
            // 
            this.DAY_B.ContextMenuStrip = this.DAY_Strip;
            this.MainMenuHELP.SetHelpString(this.DAY_B, "Left click: Open selected day folder; Right: Show list of days to select.");
            this.DAY_B.ImageIndex = 6;
            this.DAY_B.ImageList = this.MainImageList;
            this.DAY_B.Location = new System.Drawing.Point(38, 15);
            this.DAY_B.Name = "DAY_B";
            this.MainMenuHELP.SetShowHelp(this.DAY_B, true);
            this.DAY_B.Size = new System.Drawing.Size(45, 26);
            this.DAY_B.TabIndex = 2;
            this.DAY_B.Text = "1";
            this.DAY_B.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DAY_B.UseVisualStyleBackColor = true;
            this.DAY_B.Click += new System.EventHandler(this.SEL_DayButClick);
            // 
            // DAY_Strip
            // 
            this.DAY_Strip.Name = "DAY_Strip";
            this.DAY_Strip.Size = new System.Drawing.Size(61, 4);
            this.DAY_Strip.Opening += new System.ComponentModel.CancelEventHandler(this.DMY_Strip_Opening);
            // 
            // SEL_DatePick
            // 
            this.SEL_DatePick.AccessibleName = "";
            this.SEL_DatePick.Cursor = System.Windows.Forms.Cursors.Default;
            this.SEL_DatePick.CustomFormat = " dddd dd.MM.yyyy";
            this.SEL_DatePick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SEL_DatePick.Location = new System.Drawing.Point(38, 46);
            this.SEL_DatePick.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.SEL_DatePick.Name = "SEL_DatePick";
            this.SEL_DatePick.Size = new System.Drawing.Size(196, 20);
            this.SEL_DatePick.TabIndex = 1;
            this.SEL_DatePick.Value = new System.DateTime(2016, 1, 3, 0, 0, 0, 0);
            this.SEL_DatePick.CloseUp += new System.EventHandler(this.DATA_Pick_CloseUp);
            this.SEL_DatePick.ValueChanged += new System.EventHandler(this.DATA_Pick_ValueChanged);
            // 
            // Day_UpDo
            // 
            this.Day_UpDo.Location = new System.Drawing.Point(41, 18);
            this.Day_UpDo.Name = "Day_UpDo";
            this.Day_UpDo.Size = new System.Drawing.Size(57, 20);
            this.Day_UpDo.TabIndex = 8;
            this.Day_UpDo.TabStop = false;
            this.Day_UpDo.Tag = "50";
            this.Day_UpDo.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Day_UpDo.ValueChanged += new System.EventHandler(this.DMY_UpDo_Changed);
            // 
            // Mon_UpDo
            // 
            this.Mon_UpDo.Location = new System.Drawing.Point(104, 18);
            this.Mon_UpDo.Name = "Mon_UpDo";
            this.Mon_UpDo.Size = new System.Drawing.Size(57, 20);
            this.Mon_UpDo.TabIndex = 9;
            this.Mon_UpDo.TabStop = false;
            this.Mon_UpDo.Tag = "50";
            this.Mon_UpDo.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Mon_UpDo.ValueChanged += new System.EventHandler(this.DMY_UpDo_Changed);
            // 
            // Yea_UpDo
            // 
            this.Yea_UpDo.Location = new System.Drawing.Point(167, 18);
            this.Yea_UpDo.Name = "Yea_UpDo";
            this.Yea_UpDo.Size = new System.Drawing.Size(67, 20);
            this.Yea_UpDo.TabIndex = 10;
            this.Yea_UpDo.TabStop = false;
            this.Yea_UpDo.Tag = "50";
            this.Yea_UpDo.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Yea_UpDo.ValueChanged += new System.EventHandler(this.DMY_UpDo_Changed);
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Main_Label,
            this.ProgressBar});
            this.StatusBar.Location = new System.Drawing.Point(0, 506);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(455, 22);
            this.StatusBar.TabIndex = 3;
            // 
            // Main_Label
            // 
            this.Main_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_Label.Name = "Main_Label";
            this.Main_Label.Size = new System.Drawing.Size(440, 17);
            this.Main_Label.Spring = true;
            this.Main_Label.Text = "Hello :P";
            // 
            // ProgressBar
            // 
            this.ProgressBar.AutoSize = false;
            this.ProgressBar.CausesValidation = false;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(120, 16);
            this.ProgressBar.Step = 1;
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.ToolTipText = "Progress";
            this.ProgressBar.Visible = false;
            // 
            // MainMenuBar
            // 
            this.MainMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MMI_ProgramPage,
            this.MMI_SettingsPage});
            this.MainMenuBar.Location = new System.Drawing.Point(0, 0);
            this.MainMenuBar.Name = "MainMenuBar";
            this.MainMenuBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainMenuBar.Size = new System.Drawing.Size(455, 24);
            this.MainMenuBar.TabIndex = 4;
            this.MainMenuBar.Text = "menuStrip1";
            // 
            // MMI_ProgramPage
            // 
            this.MMI_ProgramPage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MMI_OPENprogFOLD,
            this.MMI_S1,
            this.MMI_Exit});
            this.MMI_ProgramPage.Name = "MMI_ProgramPage";
            this.MMI_ProgramPage.Size = new System.Drawing.Size(65, 20);
            this.MMI_ProgramPage.Text = "Program";
            // 
            // MMI_OPENprogFOLD
            // 
            this.MMI_OPENprogFOLD.Image = global::ToRT_UA_FotoManager.Properties.Resources.MMI_3;
            this.MMI_OPENprogFOLD.Name = "MMI_OPENprogFOLD";
            this.MMI_OPENprogFOLD.Size = new System.Drawing.Size(186, 22);
            this.MMI_OPENprogFOLD.Text = "Open program folder";
            this.MMI_OPENprogFOLD.Click += new System.EventHandler(this.MMI_OPENprogFOLD_Click);
            // 
            // MMI_S1
            // 
            this.MMI_S1.Name = "MMI_S1";
            this.MMI_S1.Size = new System.Drawing.Size(183, 6);
            // 
            // MMI_Exit
            // 
            this.MMI_Exit.Image = global::ToRT_UA_FotoManager.Properties.Resources.MMI_2;
            this.MMI_Exit.Name = "MMI_Exit";
            this.MMI_Exit.Size = new System.Drawing.Size(186, 22);
            this.MMI_Exit.Text = "Exit";
            this.MMI_Exit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MMI_SettingsPage
            // 
            this.MMI_SettingsPage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MMI_Configs,
            this.CB_Tiles,
            this.saveWindowPositionToolStripMenuItem});
            this.MMI_SettingsPage.Name = "MMI_SettingsPage";
            this.MMI_SettingsPage.Size = new System.Drawing.Size(61, 20);
            this.MMI_SettingsPage.Text = "Settings";
            // 
            // MMI_Configs
            // 
            this.MMI_Configs.Image = global::ToRT_UA_FotoManager.Properties.Resources.MMI_0;
            this.MMI_Configs.Name = "MMI_Configs";
            this.MMI_Configs.Size = new System.Drawing.Size(186, 22);
            this.MMI_Configs.Text = "Configs";
            this.MMI_Configs.Click += new System.EventHandler(this.configsToolStripMenuItem_Click);
            // 
            // CB_Tiles
            // 
            this.CB_Tiles.CheckOnClick = true;
            this.CB_Tiles.Name = "CB_Tiles";
            this.CB_Tiles.Size = new System.Drawing.Size(186, 22);
            this.CB_Tiles.Text = "Show images as tiles";
            this.CB_Tiles.Click += new System.EventHandler(this.showImagesAsTilesToolStripMenuItem_Click);
            // 
            // saveWindowPositionToolStripMenuItem
            // 
            this.saveWindowPositionToolStripMenuItem.Image = global::ToRT_UA_FotoManager.Properties.Resources.MMI_1;
            this.saveWindowPositionToolStripMenuItem.Name = "saveWindowPositionToolStripMenuItem";
            this.saveWindowPositionToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveWindowPositionToolStripMenuItem.Text = "Save window bounds";
            this.saveWindowPositionToolStripMenuItem.Click += new System.EventHandler(this.saveWindowPositionToolStripMenuItem_Click);
            // 
            // BOX_Camera
            // 
            this.BOX_Camera.Controls.Add(this.BUT_OpenCamera);
            this.BOX_Camera.Location = new System.Drawing.Point(363, 27);
            this.BOX_Camera.Name = "BOX_Camera";
            this.BOX_Camera.Size = new System.Drawing.Size(86, 76);
            this.BOX_Camera.TabIndex = 7;
            this.BOX_Camera.TabStop = false;
            this.BOX_Camera.Text = "Camera";
            // 
            // BUT_OpenCamera
            // 
            this.BUT_OpenCamera.ImageIndex = 6;
            this.BUT_OpenCamera.ImageList = this.MainImageList;
            this.BUT_OpenCamera.Location = new System.Drawing.Point(6, 15);
            this.BUT_OpenCamera.Name = "BUT_OpenCamera";
            this.BUT_OpenCamera.Size = new System.Drawing.Size(75, 26);
            this.BUT_OpenCamera.TabIndex = 0;
            this.BUT_OpenCamera.Text = "Open";
            this.BUT_OpenCamera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BUT_OpenCamera.UseVisualStyleBackColor = true;
            // 
            // StatusTimer
            // 
            this.StatusTimer.Tick += new System.EventHandler(this.StatusTimer_Tick);
            // 
            // MainList_LV
            // 
            this.MainList_LV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainList_LV.ContextMenuStrip = this.Strip_FileContext;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Name = "listViewGroup1";
            this.MainList_LV.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.MainList_LV.HideSelection = false;
            this.MainList_LV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainList_LV.Location = new System.Drawing.Point(6, 40);
            this.MainList_LV.Name = "MainList_LV";
            this.MainMenuHELP.SetShowHelp(this.MainList_LV, true);
            this.MainList_LV.Size = new System.Drawing.Size(431, 211);
            this.MainList_LV.TabIndex = 10;
            this.MainList_LV.UseCompatibleStateImageBehavior = false;
            this.MainList_LV.Visible = false;
            // 
            // Strip_FileContext
            // 
            this.Strip_FileContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContestStrip_FileName,
            this.openToolStripMenuItem,
            this.editWithToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem});
            this.Strip_FileContext.Name = "Strip_FileContext";
            this.Strip_FileContext.Size = new System.Drawing.Size(135, 120);
            this.Strip_FileContext.Opening += new System.ComponentModel.CancelEventHandler(this.Strip_FileContext_Opening);
            // 
            // ContestStrip_FileName
            // 
            this.ContestStrip_FileName.Enabled = false;
            this.ContestStrip_FileName.Name = "ContestStrip_FileName";
            this.ContestStrip_FileName.Size = new System.Drawing.Size(134, 22);
            this.ContestStrip_FileName.Text = "\"FileName\"";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // editWithToolStripMenuItem
            // 
            this.editWithToolStripMenuItem.Name = "editWithToolStripMenuItem";
            this.editWithToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.editWithToolStripMenuItem.Text = "Edit with";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyFile,
            this.CopyFilePath,
            this.CopyFileAsMedia});
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // CopyFile
            // 
            this.CopyFile.Name = "CopyFile";
            this.CopyFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyFile.Size = new System.Drawing.Size(194, 22);
            this.CopyFile.Tag = "F";
            this.CopyFile.Text = "File";
            this.CopyFile.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // CopyFilePath
            // 
            this.CopyFilePath.Name = "CopyFilePath";
            this.CopyFilePath.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.CopyFilePath.Size = new System.Drawing.Size(194, 22);
            this.CopyFilePath.Tag = "FP";
            this.CopyFilePath.Text = "Full path";
            this.CopyFilePath.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // CopyFileAsMedia
            // 
            this.CopyFileAsMedia.Name = "CopyFileAsMedia";
            this.CopyFileAsMedia.Size = new System.Drawing.Size(194, 22);
            this.CopyFileAsMedia.Tag = "FN";
            this.CopyFileAsMedia.Text = "File Name";
            this.CopyFileAsMedia.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // BOX_Photos
            // 
            this.BOX_Photos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BOX_Photos.Controls.Add(this.textBox1);
            this.BOX_Photos.Controls.Add(this.B_REFILL);
            this.BOX_Photos.Controls.Add(this.B_Filter);
            this.BOX_Photos.Controls.Add(this.MainList_LB);
            this.BOX_Photos.Controls.Add(this.MainList_LV);
            this.BOX_Photos.Controls.Add(this.PN_Count);
            this.BOX_Photos.Location = new System.Drawing.Point(6, 106);
            this.BOX_Photos.Name = "BOX_Photos";
            this.BOX_Photos.Size = new System.Drawing.Size(443, 257);
            this.BOX_Photos.TabIndex = 9;
            this.BOX_Photos.TabStop = false;
            this.BOX_Photos.Text = "Photos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 20);
            this.textBox1.TabIndex = 14;
            // 
            // B_REFILL
            // 
            this.B_REFILL.ImageKey = "Im8.png";
            this.B_REFILL.ImageList = this.MainImageList;
            this.B_REFILL.Location = new System.Drawing.Point(6, 13);
            this.B_REFILL.Name = "B_REFILL";
            this.B_REFILL.Size = new System.Drawing.Size(26, 26);
            this.B_REFILL.TabIndex = 13;
            this.B_REFILL.UseVisualStyleBackColor = true;
            this.B_REFILL.Click += new System.EventHandler(this.B_REFILL_Click);
            // 
            // B_Filter
            // 
            this.B_Filter.Location = new System.Drawing.Point(282, 13);
            this.B_Filter.Name = "B_Filter";
            this.B_Filter.Size = new System.Drawing.Size(75, 26);
            this.B_Filter.TabIndex = 12;
            this.B_Filter.Text = "Filter...";
            this.B_Filter.UseVisualStyleBackColor = true;
            // 
            // MainList_LB
            // 
            this.MainList_LB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainList_LB.FormattingEnabled = true;
            this.MainList_LB.Location = new System.Drawing.Point(6, 40);
            this.MainList_LB.Name = "MainList_LB";
            this.MainList_LB.Size = new System.Drawing.Size(431, 212);
            this.MainList_LB.TabIndex = 9;
            this.MainList_LB.Click += new System.EventHandler(this.MainList_LB_Click);
            this.MainList_LB.SelectedIndexChanged += new System.EventHandler(this.MainList_LB_SelectedIndexChanged);
            this.MainList_LB.DoubleClick += new System.EventHandler(this.MainList_LB_DoubleClick);
            this.MainList_LB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainList_LB_MouseDown);
            // 
            // PN_Count
            // 
            this.PN_Count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_Count.Controls.Add(this.Coun_Label);
            this.PN_Count.Location = new System.Drawing.Point(359, 12);
            this.PN_Count.Name = "PN_Count";
            this.PN_Count.Size = new System.Drawing.Size(78, 35);
            this.PN_Count.TabIndex = 15;
            // 
            // Coun_Label
            // 
            this.Coun_Label.AutoSize = true;
            this.Coun_Label.Location = new System.Drawing.Point(3, 6);
            this.Coun_Label.Name = "Coun_Label";
            this.Coun_Label.Size = new System.Drawing.Size(43, 13);
            this.Coun_Label.TabIndex = 0;
            this.Coun_Label.Text = "Total: 0";
            this.Coun_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.IncludeSubdirectories = true;
            this.fileSystemWatcher.NotifyFilter = ((System.IO.NotifyFilters)((System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.DirectoryName)));
            this.fileSystemWatcher.SynchronizingObject = this;
            this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            this.fileSystemWatcher.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            this.fileSystemWatcher.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            // 
            // TrayIcon
            // 
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Visible = true;
            this.TrayIcon.Click += new System.EventHandler(this.TrayIcon_Click);
            // 
            // ImageDataBox
            // 
            this.ImageDataBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ImageDataBox.Location = new System.Drawing.Point(6, 369);
            this.ImageDataBox.Name = "ImageDataBox";
            this.ImageDataBox.Size = new System.Drawing.Size(443, 132);
            this.ImageDataBox.TabIndex = 10;
            this.ImageDataBox.TabStop = false;
            this.ImageDataBox.Text = "Image Data";
            // 
            // VievListImgs
            // 
            this.VievListImgs.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.VievListImgs.ImageSize = new System.Drawing.Size(128, 128);
            this.VievListImgs.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 528);
            this.Controls.Add(this.ImageDataBox);
            this.Controls.Add(this.BOX_Camera);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MainMenuBar);
            this.Controls.Add(this.BOX_SEL);
            this.Controls.Add(this.BOX_TOD);
            this.Controls.Add(this.BOX_Photos);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainMenuBar;
            this.Name = "Form_Main";
            this.MainMenuHELP.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToR.T_UA™ Foto Manager <Alpha> C# -  edition";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.BOX_TOD.ResumeLayout(false);
            this.BOX_TOD.PerformLayout();
            this.BOX_SEL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Day_UpDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mon_UpDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yea_UpDo)).EndInit();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.MainMenuBar.ResumeLayout(false);
            this.MainMenuBar.PerformLayout();
            this.BOX_Camera.ResumeLayout(false);
            this.Strip_FileContext.ResumeLayout(false);
            this.BOX_Photos.ResumeLayout(false);
            this.BOX_Photos.PerformLayout();
            this.PN_Count.ResumeLayout(false);
            this.PN_Count.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox BOX_TOD;
        private System.Windows.Forms.Label TOD_Label;
        public System.Windows.Forms.ImageList MainImageList;
        private System.Windows.Forms.GroupBox BOX_SEL;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel Main_Label;
        private System.Windows.Forms.MenuStrip MainMenuBar;
        private System.Windows.Forms.ToolStripMenuItem MMI_ProgramPage;
        private System.Windows.Forms.ToolStripMenuItem MMI_OPENprogFOLD;
        private System.Windows.Forms.DateTimePicker SEL_DatePick;
        private System.Windows.Forms.ToolStripSeparator MMI_S1;
        private System.Windows.Forms.ToolStripMenuItem MMI_Exit;
        private System.Windows.Forms.Button YEA_B;
        private System.Windows.Forms.Button MON_B;
        private System.Windows.Forms.Button DAY_B;
        private System.Windows.Forms.Button SEL_CRE_B;
        private System.Windows.Forms.Button TOD_Set_B;
        private System.Windows.Forms.Button TOD_Copy_B;
        private System.Windows.Forms.Button TOD_Open_B;
        private System.Windows.Forms.Button SEL_Copy_B;
        private System.Windows.Forms.ToolStripMenuItem MMI_SettingsPage;
        private System.Windows.Forms.ToolStripMenuItem MMI_Configs;
        private System.Windows.Forms.GroupBox BOX_Camera;
        private System.Windows.Forms.Button BUT_OpenCamera;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Timer StatusTimer;
        private System.Windows.Forms.HelpProvider MainMenuHELP;
        private System.Windows.Forms.NumericUpDown Day_UpDo;
        private System.Windows.Forms.NumericUpDown Mon_UpDo;
        private System.Windows.Forms.NumericUpDown Yea_UpDo;
        private System.Windows.Forms.GroupBox BOX_Photos;
        private System.Windows.Forms.ListView MainList_LV;
        private System.Windows.Forms.ListBox MainList_LB;
        private System.Windows.Forms.Button B_REFILL;
        private System.Windows.Forms.Button B_Filter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel PN_Count;
        private System.Windows.Forms.Label Coun_Label;
        private System.Windows.Forms.ContextMenuStrip Strip_FileContext;
        private System.Windows.Forms.ToolStripMenuItem ContestStrip_FileName;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyFile;
        private System.Windows.Forms.ToolStripMenuItem CopyFilePath;
        private System.Windows.Forms.ToolStripMenuItem CopyFileAsMedia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CB_Tiles;
        public System.Windows.Forms.ContextMenuStrip DAY_Strip;
        public System.Windows.Forms.ContextMenuStrip MON_Strip;
        public System.Windows.Forms.ContextMenuStrip YEA_Strip;
        private System.Windows.Forms.ToolStripMenuItem saveWindowPositionToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.GroupBox ImageDataBox;
        private System.Windows.Forms.ImageList VievListImgs;
    }
}

