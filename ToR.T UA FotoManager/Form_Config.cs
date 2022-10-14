using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToRT_UA_FotoManager
{
    public partial class Form_Config : Form
    {
        public Form_Config()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(ConfForm_FormClosing);
        }

        void ConfForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public void ApplyConfigs()
        {
            PhotoPath_Edit.Text = RegConf.Conf.ConfFm.PhotoPath.Value;
            CB_NumericMonth.Checked = RegConf.Conf.ConfFm.NumberToMonth.Value;
            CB_ShowAmount.Checked = RegConf.Conf.ConfFm.ShowDayImagesCount.Value;
            UpDo_YearStarts.Value = RegConf.Conf.ConfFm.StartYear.Value;
        }

        private void B_PhotoExplore_Click(object sender, EventArgs e)
        {
            Dialog_BrowseFolder.ShowDialog();
            if (!String.IsNullOrEmpty(Dialog_BrowseFolder.SelectedPath))
            {
                if (Directory.Exists(Dialog_BrowseFolder.SelectedPath))
                {
                    PhotoPath_Edit.Text = PsF.FixPath(Dialog_BrowseFolder.SelectedPath);
                    PhotoPath_Edit.Focus();
                }
            }
        }

        private void B_PhotoSave_Click(object sender, EventArgs e)
        {
            RegConf.Conf.ConfFm.PhotoPath.Value = PsF.FixPath(PhotoPath_Edit.Text);
            Path_Edit_TextChanged(PhotoPath_Edit, null);
            Program.MainMenuForm.UpdateSelDateState(true);
        }

        private void Path_Edit_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(PhotoPath_Edit.Text) && Directory.Exists(PhotoPath_Edit.Text))
            {
                PhotoPath_Edit.ForeColor = Color.Black;
                PhotoSave_B.Enabled = true;
                if (PhotoPath_Edit.Text.Equals(RegConf.Conf.ConfFm.PhotoPath.Value, StringComparison.OrdinalIgnoreCase))
                    PhotoSave_B.ImageIndex = 1;
                else
                    PhotoSave_B.ImageIndex = 2;
            }
            else
            {
                PhotoPath_Edit.ForeColor = Color.Red;
                PhotoSave_B.Enabled = false;
            }
        }
        private void PhotoPath_Edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
                B_PhotoSave_Click(PhotoSave_B, null);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            RegConf.Conf.ConfFm.StartYear.Value = (int)UpDo_YearStarts.Value;
        }
        void UpDo_YearStarts_LostFocus(object sender, System.EventArgs e)
        {
            PsF.Fill_DMYStrip(Program.MainMenuForm.YEA_Strip, Form_Main.TODDate.Year, RegConf.Conf.ConfFm.StartYear.Value);                 
        }

        private void CB_NumericMonth_CheckedChanged(object sender, EventArgs e)
        {
            RegConf.Conf.ConfFm.NumberToMonth.Value = CB_NumericMonth.Checked;  
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            RegConf.Conf.ConfFm.ShowDayImagesCount.Value = CB_ShowAmount.Checked;
        }

        private void Form_Config_Load(object sender, EventArgs e)
        {

        }
    }
}
