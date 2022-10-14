using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ToRT_UA_FotoManager
{
    static class PsF
    {
        /// <summary> Fill Day/Month/Year Strip with info depending on 'sender'</summary>
        /// <param name="sender"> Object to fill.</param>
        public static void Fill_DMYStrip(object sender, int MaxValue, int MinValue = 0)
        {
            if (MaxValue < MinValue) return;
            ContextMenuStrip DestList = sender as ContextMenuStrip;
            if (DestList.Name.Substring(0, 1) == "Y") MinValue -= 1;
            DestList.Items.Clear();
            for (int i = 1; i <= (MaxValue - MinValue); i++)
            {
                ToolStripMenuItem TempItem = new ToolStripMenuItem();
                TempItem.Name = DestList.Name.Substring(0, 1) + "ListItem" + Convert.ToString(i);

                TempItem.Tag = MinValue + i;
                if (DestList.Name.Substring(0, 1) == "M")
                {
                    TempItem.Text = new DateTime(2000, i, 1).ToString("MMMM");
                    TempItem.Text = TempItem.Text.Substring(0, 1).ToUpper() + TempItem.Text.Substring(1, TempItem.Text.Length - 1);
                    if (RegConf.Conf.ConfFm.NumberToMonth.Value)
                        TempItem.Text = TempItem.Tag.ToString() + " " + TempItem.Text;
                }
                else
                    TempItem.Text = Convert.ToString(TempItem.Tag);
                TempItem.Click += new EventHandler(DateB_Click);
                DestList.Items.Add(TempItem);
            }
        }

        /// <summary> Master procedure for DMYStrip Click's</summary>
        private static void DateB_Click(object sender, EventArgs e)
        {
            switch ((sender as ToolStripMenuItem).Name.Substring(0, 1))
            {
                case "Y": Form_Main.SELDate.SetByYear(Convert.ToInt32((sender as ToolStripMenuItem).Tag)); break;                    
                case "M": Form_Main.SELDate.SetByMonth(Convert.ToInt32((sender as ToolStripMenuItem).Tag)); break;                    
                default: Form_Main.SELDate.SetByDay(Convert.ToInt32((sender as ToolStripMenuItem).Tag)); break;//"D"                    
            }
            Program.MainMenuForm.UpateDatePick(true);
        }

        /// <summary> Updates DMYStrip items states using given ImageList </summary>
        /// <param name="Obj"> Object to update.</param>
        /// <param name="ImgList"> ImageList, images of wich will be used.</param>
        /// <param name="Specific"> Index of specific item to update.</param>
        public static void UpdateDateState(ContextMenuStrip Obj, ImageList ImgList, int Specific = -1)
        {
            string BasePath;
            string AddPart = "";
            string FPart = "";
            switch (Obj.Name.Substring(0, 1))
            {
                case "Y": BasePath = RegConf.Conf.ConfFm.PhotoPath.Value;
                    break;
                case "M": BasePath = Form_Main.SELDate.Path_Yea;
                    break;
                default: BasePath = Form_Main.SELDate.Path_Mon; //"D"
                    AddPart = Form_Main.SELDate.Date.ToString(".MM.yy");
                    break;
            }
            int forTo = Obj.Items.Count;
            int forFrom = 0;
            if (Specific != -1)
            {
                forTo = Specific;
                forFrom = forTo++;
            }
            for (int i = forFrom; i < forTo; i++)
            {
                int value = Convert.ToInt32(Obj.Items[i].Tag);
                if (i < 10) FPart = value.ToString("00");
                else FPart = value.ToString();
                if (Directory.Exists(BasePath + FPart + AddPart + Path.DirectorySeparatorChar))
                {
                    Obj.Items[i].Image = ImgList.Images[MainIL_Names.Exist];
                }
                else
                {
                    Obj.Items[i].Image = ImgList.Images[MainIL_Names.NExist];//Properties.Resources.Im7 as Bitmap;
                }
                if (Obj.Name.Substring(0, 1) == "D")
                {
                    if (Directory.Exists(BasePath + FPart + AddPart + Path.DirectorySeparatorChar) && RegConf.Conf.ConfFm.ShowDayImagesCount.Value)
                        Obj.Items[i].Text = String.Concat(String.Concat(Obj.Items[i].Tag.ToString(),"  | ",Form_Main.ScanedFolderList.Refill(BasePath + FPart + AddPart + Path.DirectorySeparatorChar, "IMGVID")));
                    else
                        Obj.Items[i].Text = Obj.Items[i].Tag.ToString();
                }
            }
        }

        /// <summary> Fix given path by adding 'DirectorySeparatorChar' in the end.</summary>
        public static string FixPath(string path)
        {
            if (path.Substring(path.Length - 1, 1) != Convert.ToString(Path.DirectorySeparatorChar))
                return String.Concat(path + Path.DirectorySeparatorChar);
            else
                return path;
        }
    }
}
