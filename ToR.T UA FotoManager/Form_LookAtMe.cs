using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ToRT_UA_FotoManager
{
    public partial class Form_LookAtMe : Form
    {
        static ListBox Working_LB; // link on working ListBox
        string LastImagePath;

        public Form_LookAtMe()
        {
            InitializeComponent();
        }

        public void ApplyConfigs()
        {
            this.SetDesktopLocation(RegConf.Conf.LookAtMe.PosX.Value, RegConf.Conf.LookAtMe.PosY.Value);
            this.Width = RegConf.Conf.LookAtMe.Width.Value;
            this.Height = RegConf.Conf.LookAtMe.Height.Value;
        }


        private void Form_LookAtMe_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private int RenderImage(string ImagePath)
        {
            if (ImagePath.Equals(LastImagePath,StringComparison.OrdinalIgnoreCase) 
                || !File.Exists(ImagePath)) return 0;
            LAM_SS_MainLabel.Text = string.Format("{0} \"{1}\"", "Loading", ImagePath); //mesageTo
            if (Form_Main.SuppFiles.isSuppImg(ImagePath)) // Images
            {
                try
                {
                    using (var bmpTemp = new Bitmap(ImagePath))
                    {
                        LAM_Image.Image = new Bitmap(bmpTemp);
                    }

                    //using (FileStream stream = new FileStream(ImagePath, FileMode.Open, FileAccess.Read))
                    //{LAM_Image.Image = Image.FromStream(stream);}
                    
                    //Image image = Image.FromFile(ImagePath);
					//if (image == null) return 0;
					////LAM_Image.Image = null;
					////LAM_Image.Refresh();						
                    //LAM_Image.Image = image;                    
                }
                catch (Exception e)
                {
                    MessageBox.Show(String.Format("{0} Exception caught.", e));
                    //Console.WriteLine("{0} Exception caught.", e); //messageTo
                    return 0;
                }
                LAM_SS_MainLabel.Text = string.Format("\"{0}\"", ImagePath); //mesageTo
                LAM_SS_InfoLabel.Text = string.Format("{0} x {1}", LAM_Image.Image.Width, LAM_Image.Image.Height);
            }
            else // videos
            {
                try
                {
                    LAM_Image.Image = Properties.Resources.IMG_ND;

                    //LAM_Image.Image = JockerSoft.Media.FrameGrabber.GetFrameFromVideo(ImagePath, 0.2d);
                    //var jpgStream = new System.IO.MemoryStream();
                    //(new NReco.VideoConverter.FFMpegConverter()).GetVideoThumbnail(ImagePath,jpgStream);
                    //var image = Image.FromStream(jpgStream);
                    //LAM_Image.Image = image;
                }
                catch (Exception e)
                {
                    MessageBox.Show(String.Format( "{0} Exception caught.", e));
                    //Console.WriteLine("{0} Exception caught.", e); //messageTo
                    return 0;
                }

                LAM_SS_MainLabel.Text = string.Format("\"{0}\"", ImagePath); //mesageTo
                LAM_SS_InfoLabel.Text = string.Format("{0} x {1}", "?", "?");
            }
            GC.Collect();
            LastImagePath = ImagePath;
            return 1;
        }

        public bool ShowImage(Form FSender, ListBox Sender_LB)
        {
            if (Sender_LB != Working_LB) Working_LB = Sender_LB;
            int result = -1;
            if (Working_LB.SelectedItem != null) {
                result = RenderImage(Working_LB.SelectedItem.ToString());
            }

            if (!this.Visible)
            {
                this.Show();
                this.BringToFront();
                FSender.BringToFront();
            }
            else
                FSender.BringToFront();
            if (Working_LB.CanFocus)
                Working_LB.Focus();
            switch (result)
            {
                default: return false; // any other reason
                case 0: return false;  // image not loaded
                case 1: return true;   // image loaded
            }
        }

        private void savePositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegConf.Conf.LookAtMe.Width.Value = this.Width;
            RegConf.Conf.LookAtMe.Height.Value = this.Height;
            RegConf.Conf.LookAtMe.PosX.Value = this.DesktopLocation.X;
            RegConf.Conf.LookAtMe.PosY.Value = this.DesktopLocation.Y;
        }

        private void LAM_Image_MouseWheel(object sender, MouseEventArgs e)
        {                      
            if (e.Delta != 0)
            {
                int NextIndex = Working_LB.SelectedIndex + e.Delta / 120 * -1;
                if (NextIndex < 0) NextIndex = Working_LB.Items.Count-1;
                if (NextIndex >= Working_LB.Items.Count) NextIndex = 0;
                Working_LB.SelectedIndex = NextIndex; 
            }
        }

        private void Form_LookAtMe_Load(object sender, EventArgs e)
        {

        }
    }
}
