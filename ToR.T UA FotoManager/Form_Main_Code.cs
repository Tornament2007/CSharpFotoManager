using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace ToRT_UA_FotoManager
{
    public partial class Form_Main : Form
    {
        private Timer Timer_ImageSelector;
        private Timer Timer_ListUpdater;
        public static ImageList ViewImgsLst;

        public class SuppFiles
        {
            public static string[] SuppIMG_Files = { ".bmp",".jpg",".jpe",".jfif",".jpeg",
            ".gif",".tif",".tiff",".png",".icon",".ico",".emf",".wmf" };
            public static string[] SuppVid_Files = { ".mov", ".avi" };

            public static bool isSuppImg(string incFile)
            {
                return Array.IndexOf(SuppIMG_Files, Path.GetExtension(incFile).ToLower()) > -1;
            }
            public static bool isSuppVid(string incFile)
            {
                return Array.IndexOf(SuppVid_Files, Path.GetExtension(incFile).ToLower()) > -1;
            }
        }

        public string[] AttrName = {"Name", "Theme", "Rating", "Tags",
            "Description", "Author", "Camera"};

        public static class TODDate
        {
            public static bool Exists = Directory.Exists(Path_Day);

            public static DateTime Date { get { return DateTime.Now; } }
            public static int Day { get { return DateTime.Now.Day; } }
            public static int Month { get { return DateTime.Now.Month; } }
            public static int Year { get { return DateTime.Now.Year; } }
            public static string Path_Day
            {
                get
                {
                    return @String.Concat(RegConf.Conf.ConfFm.PhotoPath.Value, Date.ToString("yyyy"), "\\",
                        Date.ToString("MM"), "\\", Date.ToString("dd.MM.yy"), "\\");
                }
            }
        }

        public static class SELDate
        {
            static public bool Exists = Directory.Exists(Path_Day);
            static public int last_Day = 1;
            static public int last_Mon = 1;
            static public int last_Yea = 2000;
            public static DateTime Date;
            static public string Path_Yea { get { return @String.Concat(RegConf.Conf.ConfFm.PhotoPath.Value + Date.ToString("yyyy") + Path.DirectorySeparatorChar); } }
            static public string Path_Mon { get { return @String.Concat(Path_Yea + Date.ToString("MM") + Path.DirectorySeparatorChar); } }
            static public string Path_Day { get { return @String.Concat(Path_Mon + Date.ToString("dd.MM.yy") + Path.DirectorySeparatorChar); } }
            static public void SetByYear(int Year)
            {
                Form_Main.SELDate.Date = Form_Main.SELDate.Date.AddYears(Year - Form_Main.SELDate.Date.Year);
            }
            static public void SetByMonth(int Month)
            {
                Form_Main.SELDate.Date = Form_Main.SELDate.Date.AddMonths(Month - Form_Main.SELDate.Date.Month);
            }
            static public void SetByDay(int Day)
            {
                Form_Main.SELDate.Date = Form_Main.SELDate.Date.AddDays(Day - Form_Main.SELDate.Date.Day);
            }

        }

        public static class ScanedFolderList
        {
            static public List<string> IMGfiles = new List<string>(); // list for supported image files
            static public List<string> VIDfiles = new List<string>(); // list for supported video files
            /// <summary> Last incomed Path </summary>
            static string LincPath;
            /// <summary> Last filled ListHolder items count </summary>
            static public int LFillCount;
            /// <summary> Refill IMG/VID lists from incPath incomed path  </summary>
            /// <param name="incPath"> Source path.</param>
            /// <param name="CountParams"> Filter options. "IMG" - images only. "VID" - videos only. "" - any (Default).</param>
            /// <returns> Returns count of valid files.</returns>
            static public int Refill(string incPath, string CountParams = "") // fill listS from incoming path
            {
                if (CountParams == "")
                {
                    LincPath = incPath;
                    IMGfiles.Clear();
                    VIDfiles.Clear();
                }
                if (!Directory.Exists(incPath)) return -1;
                int trueCount = 0;
                string[] files = Directory.GetFiles(incPath, "*", SearchOption.TopDirectoryOnly);
                for (int i = 0; i < files.Length; i++)
                {
                    if (SuppFiles.isSuppImg(files[i]))
                    {
                        if (CountParams == "")
                            IMGfiles.Add(@files[i]);
                        if (CountParams == "" || CountParams.Contains("IMG"))
                            trueCount++;
                    }
                    else
                        if (SuppFiles.isSuppVid(files[i]))
                    {
                        if (CountParams == "")
                            VIDfiles.Add(@files[i]);
                        if (CountParams == "" || CountParams.Contains("VID"))
                            trueCount++;
                    }
                }
                return trueCount;
            }
            /// <summary> Refill IMG/VID lists from LAST incomed path.</summary>         
            static public void Update()
            {
                Refill(LincPath);
            }
            /// <summary> Fill Dest ListBox and ListViev with last scaned files  </summary>
            /// <param name="useViewBox"> True - will fill "Dest_LV".</param>
            /// <param name="Dest_LB"> ListBox wich will be filled.</param>
            /// <param name="Dest_LV"> ListView wich will be filled.</param>
            /// <param name="incParams"> Filter options. "IMG" - images only. "VID" - videos only. "" - any (Default).</param>
            static public void FillListHolder(bool useViewBox, ListBox Dest_LB, ListView Dest_LV, string incParams = "")
            {
                LFillCount = 0;
                Dest_LB.Items.Clear();
                if (!Directory.Exists(LincPath))
                {
                    Dest_LB.Tag = -1;
                    Dest_LB.Items.Add(String.Concat(SELDate.Date.ToString("dd.MM.yy") + " not exists")); //MessageTo
                    return;
                }
                Dest_LB.Tag = 1;
                if (incParams == "" || incParams.Contains("IMG")) for (int i = 0; i < IMGfiles.Count; i++)
                    {
                        Dest_LB.Items.Add(IMGfiles[i]);
                        LFillCount++;
                    }

                if (incParams == "" || incParams.Contains("VID")) for (int i = 0; i < VIDfiles.Count; i++)
                    {
                        Dest_LB.Items.Add(VIDfiles[i]);
                        LFillCount++;
                    }
                if (useViewBox)
                    FillViewHolder(Dest_LB, Dest_LV);
            }
            static public void FillViewHolder(ListBox Source_LB, ListView Dest_LV)
            {
                Dest_LV.Clear();

                int itemsC = Source_LB.Items.Count;
                Dest_LV.Tag = Dest_LV.ToString();
                if (itemsC == 0)
                {
                    Dest_LV.Tag = "";
                    return;
                }
                for (int i = 0; i < itemsC; i++)
                {
                    string FileName = Source_LB.Items[i].ToString();
                    if (!File.Exists(FileName))
                    {
                        //stop
                        Dest_LV.Tag = "";
                        Dest_LV.Clear();
                        break;
                    }
                    ListViewItem VItem = new ListViewItem(Path.GetFileName(Source_LB.Items[i].ToString()));
                    VItem.ImageIndex = i;
                    Dest_LV.Items.Add(VItem);
                }
                ViewImgsLst.Images.Clear();
                for (int i = 0; i < Dest_LV.Items.Count; i++)
                {
                    try
                    {
                        Image.GetThumbnailImageAbort myCallback =
                        new Image.GetThumbnailImageAbort(ThumbnailCallback);
                        Bitmap myBitmap = new Bitmap(Source_LB.Items[i].ToString());
                        Image myThumbnail = myBitmap.GetThumbnailImage(
                        128, 128, myCallback, IntPtr.Zero);
                        ViewImgsLst.Images.Add(myThumbnail);
                    }
                    catch { }
                }
            }
        }
        static public bool ThumbnailCallback()
        {
            return false;
        }

        public static class Camera
        {
            static List<char> CameraDrive = new List<char>();
            static List<string> CameraName = new List<string>();

            static bool HasFotos(char Drive)
            {
                if (Directory.Exists(String.Format("{0}:{1}", Drive, Path.DirectorySeparatorChar)))
                {
                    string[] Dirs = Directory.GetDirectories(String.Format("{0}:{1}", Drive, Path.DirectorySeparatorChar));
                    string corrDirs = "DCIM,";
                    for (int i = 0; i < Dirs.Length; i++)
                    {
                        if (corrDirs.Contains(Path.GetFileName(Dirs[i]).ToString().ToUpper()))
                        {
                            return true;
                        }
                    }
                }
                return false;
            }

            static public void AddDrive(char Drive, string Name)
            {
                if (!HasFotos(Drive)) return;
                Program.MainMenuForm.SetMainStatus(String.Format("Camera drive \"{0}:{1}\" found", Drive, Path.DirectorySeparatorChar)); //messageTo
                CameraDrive.Add(Drive);
                CameraName.Add(Name);
            }
            static public void RemDrive(char Drive)
            {
                if (CameraDrive.Count > 0 && CameraDrive.IndexOf(Drive) != -1)
                {
                    CameraName.RemoveAt(CameraDrive.IndexOf(Drive));
                    CameraDrive.RemoveAt(CameraDrive.IndexOf(Drive));
                }
            }
        }

        public class USBDeviceInfo
        {
            public const int WM_DEVICECHANGE = 0x0219;
            public const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
            public const int DBT_DEVICEARRIVAL = 0x8000;
            public const uint DBT_DEVTYP_VOLUME = 0x00000002;

            [StructLayout(LayoutKind.Sequential)]
            public struct DEV_BROADCAST_HDR
            {
                public uint dbch_size;
                public uint dbch_devicetype;
                public uint dbch_reserved;
            }

            [StructLayout(LayoutKind.Sequential)]
            public struct DEV_BROADCAST_VOLUME
            {
                public uint dbcv_size;
                public uint dbcv_devicetype;
                public uint dbcv_reserved;
                public uint dbcv_unitmask;
                public ushort dbcv_flags;
            }
        }

        protected override void WndProc(ref Message msg) // catch windows messages
        {
            base.WndProc(ref msg);
            if (msg.Msg != USBDeviceInfo.WM_DEVICECHANGE) return;
            if (msg.WParam.ToInt32() == USBDeviceInfo.DBT_DEVICEARRIVAL || msg.WParam.ToInt32() == USBDeviceInfo.DBT_DEVICEREMOVECOMPLETE)
            {
                var dbhARRIVAL = (USBDeviceInfo.DEV_BROADCAST_HDR)Marshal.PtrToStructure(msg.LParam, typeof(USBDeviceInfo.DEV_BROADCAST_HDR));
                Program.MainMenuForm.SetMainStatus(dbhARRIVAL.dbch_devicetype.ToString());
                if (dbhARRIVAL.dbch_devicetype == USBDeviceInfo.DBT_DEVTYP_VOLUME)
                {
                    var dbv =
                        (USBDeviceInfo.DEV_BROADCAST_VOLUME)Marshal.PtrToStructure(msg.LParam, typeof(USBDeviceInfo.DEV_BROADCAST_VOLUME));

                    int DriveLetter = 0;
                    // Далее ищем установленный бит и получаем нужную букву
                    while ((dbv.dbcv_unitmask & (1 << DriveLetter)) != dbv.dbcv_unitmask && DriveLetter != 32)
                        DriveLetter++;

                    // Буква USB dev                            
                    switch (msg.WParam.ToInt32())
                    {
                        case USBDeviceInfo.DBT_DEVICEARRIVAL:
                            Camera.AddDrive((char)('A' + DriveLetter), Convert.ToString((char)('A' + DriveLetter)));// get somehow name
                            break;
                        case USBDeviceInfo.DBT_DEVICEREMOVECOMPLETE:
                            Camera.RemDrive((char)('A' + DriveLetter));
                            break;
                    }
                }
            }
        }

        public Form_Main()
        {
            InitializeComponent();
            //this.FormClosing += new FormClosingEventHandler(Form_Main_Closing);
        }

        //void Form_Main_Closing(object sender, FormClosingEventArgs e) { Properties.Settings.Default.Save();  }

        private void SEL_DayButClick(object sender, EventArgs e)
        {//for all buttons Day Month Year
            Button IncomingB = sender as Button;
            string WPath;
            switch (IncomingB.Name.Substring(0, 1))
            {
                case "Y": WPath = SELDate.Path_Yea; break;
                case "M": WPath = SELDate.Path_Mon; break;
                default: WPath = SELDate.Path_Day; break; //"D"
            }
            if (Directory.Exists(WPath))
            {
                System.Diagnostics.Process.Start("explorer", WPath);
                SetMainStatus(String.Format("Opening: \"{0}\"", WPath)); //messageTo
            }
            else
            {
                SetMainStatus(String.Format("Folder \"{0}\" not exists", WPath)); //messageTo
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void UpdateButtonsState()
        {
            // Icons update for sel Buttons
            YEA_B.ImageIndex = MainIL_Names.NExist;
            MON_B.ImageIndex = MainIL_Names.NExist;
            DAY_B.ImageIndex = MainIL_Names.NExist;
            SEL_CRE_B.ImageIndex = MainIL_Names.Folder_Create;

            if (Directory.Exists(SELDate.Path_Yea))
            {
                YEA_B.ImageIndex = MainIL_Names.Exist;
                if (Directory.Exists(SELDate.Path_Mon))
                {
                    MON_B.ImageIndex = MainIL_Names.Exist;
                    if (Directory.Exists(SELDate.Path_Day))
                    {
                        DAY_B.ImageIndex = MainIL_Names.Exist;
                        SEL_CRE_B.ImageIndex = MainIL_Names.Folder_Open;
                    }
                }
            }
            if (Directory.Exists(TODDate.Path_Day)) TOD_Open_B.ImageIndex = MainIL_Names.Folder_Open;
            else TOD_Open_B.ImageIndex = MainIL_Names.Folder_Create;
        }

        private void DATA_Pick_ValueChanged(object sender, EventArgs e)
        {
            DAY_B.Text = SEL_DatePick.Value.Date.ToString("dd");
            MON_B.Text = SEL_DatePick.Value.Date.ToString("MM");
            YEA_B.Text = SEL_DatePick.Value.Date.ToString("yyyy");
            SELDate.Date = SEL_DatePick.Value.Date;
            UpdateButtonsState();
            MasterFill();
        }

        /// <summary> Update or Refill lists, and write them to the main ListHolder </summary>
        /// <param name="Update"> True - will use last scaned folder as source. False - Selected folder as source.</param>
        public void MasterFill(bool Update = false, bool saveSelection = false)
        {
            string lastSel;
            if (saveSelection)
            {
                if (MainList_LB.SelectedIndex > -1)
                {
                    lastSel = MainList_LB.SelectedItem.ToString();
                }
                else saveSelection = false;
            }
            if (Update)
                ScanedFolderList.Update();
            else
                ScanedFolderList.Refill(SELDate.Path_Day);
            ScanedFolderList.FillListHolder(CB_Tiles.Checked, MainList_LB, MainList_LV);
            if (Directory.Exists(SELDate.Path_Day)) Coun_Label.Text = String.Format("Total: {0}", ScanedFolderList.LFillCount); //messageTo
            else Coun_Label.Text = "Total: Empty"; //String.Format("Total: {0}", ScanedFolderList.LFillCount);

            GC.Collect();
        }

        private void DATA_Pick_CloseUp(Object sender, EventArgs e)
        {
            if (DateTime.DaysInMonth(SEL_DatePick.Value.Year, SEL_DatePick.Value.Month) != DateTime.DaysInMonth(SELDate.last_Yea, SELDate.last_Mon))
            {
                PsF.Fill_DMYStrip(DAY_Strip, DateTime.DaysInMonth(SEL_DatePick.Value.Year, SEL_DatePick.Value.Month));
            }

            if (SELDate.last_Yea != SEL_DatePick.Value.Year)
            {
                //PsF.UpdateDateState(MON_Strip, MainImageList);
                //PsF.UpdateDateState(DAY_Strip, MainImageList);
            }
            else if (SELDate.last_Mon != SEL_DatePick.Value.Month)
            {
                //PsF.UpdateDateState(DAY_Strip, MainImageList);
            }
            SELDate.last_Day = SEL_DatePick.Value.Day;
            SELDate.last_Mon = SEL_DatePick.Value.Month;
            SELDate.last_Yea = SEL_DatePick.Value.Year;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(this.Width, SystemInformation.VirtualScreen.Height);
            this.MinimumSize = new Size(this.Width, this.Height);
            ApplyConfigs();

            SEL_DatePick.Value = TODDate.Date;
            TOD_Label.Text = TODDate.Date.ToString("ddd dd.MM.yyyy");

            PsF.Fill_DMYStrip(YEA_Strip, TODDate.Year, RegConf.Conf.ConfFm.StartYear.Value);
            PsF.Fill_DMYStrip(MON_Strip, 12);
            PsF.Fill_DMYStrip(DAY_Strip, DateTime.DaysInMonth(SEL_DatePick.Value.Year, SEL_DatePick.Value.Month));

            UpdateSelDateState();
            fileSystemWatcher.Path = RegConf.Conf.ConfFm.PhotoPath.Value;

            Timer_ImageSelector = new Timer();
            Timer_ImageSelector.Interval = 50;
            Timer_ImageSelector.Tick += new EventHandler(Timer_ImageSelector_Tick);
            Timer_ListUpdater = new Timer();
            Timer_ListUpdater.Interval = 1500;
            Timer_ListUpdater.Tick += new EventHandler(Timer_ListUpdater_Tick);

            ViewImgsLst = new ImageList();
            ViewImgsLst.ColorDepth = ColorDepth.Depth32Bit;
            ViewImgsLst.ImageSize = new Size(128, 128); // options dependet
            MainList_LV.LargeImageList = ViewImgsLst;
        }

        private void Timer_ImageSelector_Tick(object sender, EventArgs e)
        {
            // prevent constant image loading on scrolling
            MainList_LB_Click(MainList_LB, e);
            Timer_ImageSelector.Stop();
        }

        private void Timer_ListUpdater_Tick(object sender, EventArgs e)
        {
            MasterFill(false, true);
            Timer_ListUpdater.Stop();
        }

        private void ApplyConfigs()
        {
            if (RegConf.Conf.MainFm.PosX.Value == -1)
            {
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.StartPosition = FormStartPosition.Manual;
                this.SetDesktopLocation(RegConf.Conf.MainFm.PosX.Value, RegConf.Conf.MainFm.PosY.Value);
                if (RegConf.Conf.MainFm.Height.Value != -1)
                    this.Height = RegConf.Conf.MainFm.Height.Value;
            }
            Program.ConfigForm.ApplyConfigs();
            Program.LookAtMeForm.ApplyConfigs();
        }

        public void UpdateSelDateState(bool FullUpdate = false)
        {
            UpateDatePick();
            if (FullUpdate) DATA_Pick_ValueChanged(SEL_DatePick, null);
        }

        public void UpateDatePick(bool reversUpadate = false)
        {
            if (reversUpadate)
            {
                SEL_DatePick.Value = SELDate.Date;
            }
            DATA_Pick_CloseUp(SEL_DatePick, null);
        }

        private void configsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.ConfigForm.Visible)
                Program.ConfigForm.Focus();
            else
                Program.ConfigForm.Show();
        }

        private void MMI_OPENprogFOLD_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer", Application.StartupPath);
        }

        private void SEL_Copy_BMouseDown(object sender, MouseEventArgs e)
        {
            string MessageText = "";
            if (e.Button == MouseButtons.Right)
            {
                if ((sender as Button).Name.Substring(0, 1) == "S")
                    MessageText = SEL_DatePick.Value.ToString("dd.MM.yy");
                else
                    MessageText = TODDate.Date.ToString("dd.MM.yy");
            }
            else if (e.Button == MouseButtons.Left)
            {

                if ((sender as Button).Name.Substring(0, 1) == "S")
                    MessageText = SELDate.Path_Day;
                else
                    MessageText = TODDate.Path_Day;
            }
            Clipboard.Clear();
            Clipboard.SetText(MessageText);
            SetMainStatus(MessageText, true);
        }

        private void SEL_CRE_B_Click(object sender, EventArgs e)
        {
            string PathToWork = SELDate.Path_Day;
            if ((sender as Button).Name.Substring(0, 1) == "T")
                PathToWork = TODDate.Path_Day;
            if (Directory.Exists(PathToWork))
            {
                System.Diagnostics.Process.Start("explorer", PathToWork);
                SetMainStatus(String.Format("Opening: \"{0}\"", PathToWork));//messageTo
            }
            else
            {
                Directory.CreateDirectory(PathToWork);
                if (Directory.Exists(PathToWork))
                {
                    SetMainStatus(String.Format("Folder created: \"{0}\"", PathToWork));//messageTo
                    UpdateButtonsState();
                    MasterFill();
                }
                else
                    SetMainStatus(String.Format("Folder not created: \"{0}\"", PathToWork));//messageTo
            }
        }

        private void TOD_Set_B_Click(object sender, EventArgs e)
        {
            SEL_DatePick.Value = TODDate.Date;
            UpateDatePick();
        }


        public void SetMainStatus(string text, bool ClipCheck = false, int StayTime = 2500)
        {
            StatusTimer.Stop();
            if (ClipCheck && Clipboard.GetText() == text)
            {
                text = String.Format(" \"{0}\"  Copied", Clipboard.GetText());//messageTo
            }
            Main_Label.Text = text;
            StatusTimer.Interval = StayTime;
            StatusTimer.Start();
            //Sleep(StayTime); // if modular ??
        }

        private void StatusTimer_Tick(object sender, EventArgs e)
        {
            StatusTimer.Stop();
            Main_Label.Text = "Hello! ;)";//messageTo
        }

        void DMY_UpDo_Changed(object sender, EventArgs e)
        {
            if ((sender as NumericUpDown).Value == 50) return;
            int num = 1;
            DateTime EndDate = TODDate.Date;
            if ((sender as NumericUpDown).Value < 50)
            {
                num = -1;
                EndDate = new DateTime(RegConf.Conf.ConfFm.StartYear.Value, 1, 1);
            }
            (sender as NumericUpDown).Value = 50;

            if ((sender as NumericUpDown).Name.Substring(0, 1) == "D" & ModifierKeys.Equals(Keys.Control))
                if (num == -1)
                {
                    EndDate = new DateTime(SELDate.Date.Year, SELDate.Date.Month, 1);
                }
                else
                {
                    EndDate = new DateTime(SELDate.Date.Year, SELDate.Date.Month, DateTime.DaysInMonth(SELDate.Date.Year, SELDate.Date.Month));
                }

            bool Continue = true;
            while (Continue)
            {
                if (!ModifierKeys.Equals(Keys.Shift))
                    if (num == -1) { if (SELDate.Date <= EndDate) Continue = false; }
                    else
                    { if (SELDate.Date >= EndDate) Continue = false; }
                if (!Continue) { SELDate.Date = EndDate; break; }
                switch ((sender as NumericUpDown).Name.Substring(0, 1))
                {
                    case "Y": SELDate.Date = SELDate.Date.AddYears(num); break;
                    case "M": SELDate.Date = SELDate.Date.AddMonths(num); break;
                    case "D": SELDate.Date = SELDate.Date.AddDays(num); break;
                }
                if (Directory.Exists(SELDate.Path_Day) | ModifierKeys.Equals(Keys.Shift)) break;
            }
            SEL_DatePick.Value = SELDate.Date;
        }        

        private void B_REFILL_Click(object sender, EventArgs e)
        {
            MasterFill(true);
        }

        void DMY_Strip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //load list when only opening. So do not update when date is changing
            PsF.UpdateDateState(sender as ContextMenuStrip, MainImageList);
        }

        private void showImagesAsTilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //switch Tile or List image showing
            MainList_LB.Visible = !CB_Tiles.Checked;
            MainList_LV.Visible = CB_Tiles.Checked;
            MasterFill(true, true);
        }

        private void MainList_LB_Click(object sender, EventArgs e)
        {
            if (MainList_LB.SelectedItems.Count < 1) return;
            if (File.Exists(MainList_LB.SelectedItem.ToString()))
            {
                Program.LookAtMeForm.ShowImage(this, MainList_LB);
            } else
            {
                MasterFill(false);
            }
        }

        private void MainList_LB_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Right))
            {
                if (MainList_LB.IndexFromPoint(e.X, e.Y) < 0) return;
                MainList_LB.SelectedIndex = MainList_LB.IndexFromPoint(e.X, e.Y);
                Strip_FileContext.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void MainList_LB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Timer_ImageSelector.Start();
        }

        private void saveWindowPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegConf.Conf.MainFm.PosX.Value = this.DesktopLocation.X;
            RegConf.Conf.MainFm.PosY.Value = this.DesktopLocation.Y;
            RegConf.Conf.MainFm.Height.Value = this.Size.Height;            
        }

        private void Strip_FileContext_Opening(object sender, CancelEventArgs e)
        {
            ContestStrip_FileName.Text = String.Format("\"{0}\"", Path.GetFileName(MainList_LB.SelectedItem.ToString()));
            ContestStrip_FileName.Tag = @MainList_LB.SelectedItem.ToString();
        }

        private void fileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            if (Path.GetDirectoryName(e.FullPath) + Path.DirectorySeparatorChar != SELDate.Path_Day) return;          
            Timer_ListUpdater.Stop(); //timer reset
            Timer_ListUpdater.Start();
        }

        private void TrayIcon_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;
            this.TopMost = true;
            this.Focus();
            this.BringToFront();
            this.TopMost = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetMainStatus(String.Format("Opening \"{0}\"", MainList_LB.SelectedItem.ToString())); //messageTo
            System.Diagnostics.Process.Start(MainList_LB.SelectedItem.ToString());
        }

        private void MainList_LB_DoubleClick(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch ((sender as ToolStripMenuItem).Tag.ToString())
            {
                case "F": Clipboard.SetImage(Image.FromFile(MainList_LB.SelectedItem.ToString())); break;
                case "FP": Clipboard.SetText(MainList_LB.SelectedItem.ToString()); break;
                case "FN": Clipboard.SetText(Path.GetFileName(MainList_LB.SelectedItem.ToString())); break;
            }
        }
    }
}