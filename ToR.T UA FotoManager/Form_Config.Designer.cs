namespace ToRT_UA_FotoManager
{
    partial class Form_Config
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Config));
            this.BOX_PhotoFolder = new System.Windows.Forms.GroupBox();
            this.PhotoSave_B = new System.Windows.Forms.Button();
            this.ConfImageList = new System.Windows.Forms.ImageList(this.components);
            this.PhotoExplore_B = new System.Windows.Forms.Button();
            this.PhotoPath_Edit = new System.Windows.Forms.TextBox();
            this.Dialog_BrowseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.BOX_Misc = new System.Windows.Forms.GroupBox();
            this.CB_ShowAmount = new System.Windows.Forms.CheckBox();
            this.CB_NumericMonth = new System.Windows.Forms.CheckBox();
            this.UpDo_YearStarts = new System.Windows.Forms.NumericUpDown();
            this.Label_YeatStart = new System.Windows.Forms.Label();
            this.BOX_PhotoFolder.SuspendLayout();
            this.BOX_Misc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDo_YearStarts)).BeginInit();
            this.SuspendLayout();
            // 
            // BOX_PhotoFolder
            // 
            this.BOX_PhotoFolder.Controls.Add(this.PhotoSave_B);
            this.BOX_PhotoFolder.Controls.Add(this.PhotoExplore_B);
            this.BOX_PhotoFolder.Controls.Add(this.PhotoPath_Edit);
            this.BOX_PhotoFolder.Location = new System.Drawing.Point(12, 12);
            this.BOX_PhotoFolder.Name = "BOX_PhotoFolder";
            this.BOX_PhotoFolder.Size = new System.Drawing.Size(417, 51);
            this.BOX_PhotoFolder.TabIndex = 0;
            this.BOX_PhotoFolder.TabStop = false;
            this.BOX_PhotoFolder.Text = "Photo folder";
            // 
            // PhotoSave_B
            // 
            this.PhotoSave_B.Enabled = false;
            this.PhotoSave_B.ImageIndex = 2;
            this.PhotoSave_B.ImageList = this.ConfImageList;
            this.PhotoSave_B.Location = new System.Drawing.Point(6, 15);
            this.PhotoSave_B.Name = "PhotoSave_B";
            this.PhotoSave_B.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PhotoSave_B.Size = new System.Drawing.Size(26, 26);
            this.PhotoSave_B.TabIndex = 2;
            this.PhotoSave_B.UseVisualStyleBackColor = true;
            this.PhotoSave_B.Click += new System.EventHandler(this.B_PhotoSave_Click);
            // 
            // ConfImageList
            // 
            this.ConfImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ConfImageList.ImageStream")));
            this.ConfImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ConfImageList.Images.SetKeyName(0, "Im1.png");
            this.ConfImageList.Images.SetKeyName(1, "Im2.png");
            this.ConfImageList.Images.SetKeyName(2, "Im3.png");
            // 
            // PhotoExplore_B
            // 
            this.PhotoExplore_B.Location = new System.Drawing.Point(348, 15);
            this.PhotoExplore_B.Name = "PhotoExplore_B";
            this.PhotoExplore_B.Size = new System.Drawing.Size(63, 27);
            this.PhotoExplore_B.TabIndex = 1;
            this.PhotoExplore_B.Text = "Explore...";
            this.PhotoExplore_B.UseVisualStyleBackColor = true;
            this.PhotoExplore_B.Click += new System.EventHandler(this.B_PhotoExplore_Click);
            // 
            // PhotoPath_Edit
            // 
            this.PhotoPath_Edit.Location = new System.Drawing.Point(38, 19);
            this.PhotoPath_Edit.Name = "PhotoPath_Edit";
            this.PhotoPath_Edit.ReadOnly = true;
            this.PhotoPath_Edit.Size = new System.Drawing.Size(304, 20);
            this.PhotoPath_Edit.TabIndex = 0;
            this.PhotoPath_Edit.TextChanged += new System.EventHandler(this.Path_Edit_TextChanged);
            this.PhotoPath_Edit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PhotoPath_Edit_KeyDown);
            // 
            // Dialog_BrowseFolder
            // 
            this.Dialog_BrowseFolder.Description = "Select your photo folder";
            this.Dialog_BrowseFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // BOX_Misc
            // 
            this.BOX_Misc.Controls.Add(this.CB_ShowAmount);
            this.BOX_Misc.Controls.Add(this.CB_NumericMonth);
            this.BOX_Misc.Controls.Add(this.UpDo_YearStarts);
            this.BOX_Misc.Controls.Add(this.Label_YeatStart);
            this.BOX_Misc.Location = new System.Drawing.Point(12, 69);
            this.BOX_Misc.Name = "BOX_Misc";
            this.BOX_Misc.Size = new System.Drawing.Size(417, 93);
            this.BOX_Misc.TabIndex = 1;
            this.BOX_Misc.TabStop = false;
            this.BOX_Misc.Text = " Misc";
            // 
            // CB_ShowAmount
            // 
            this.CB_ShowAmount.AutoSize = true;
            this.CB_ShowAmount.Location = new System.Drawing.Point(9, 46);
            this.CB_ShowAmount.Name = "CB_ShowAmount";
            this.CB_ShowAmount.Size = new System.Drawing.Size(214, 17);
            this.CB_ShowAmount.TabIndex = 4;
            this.CB_ShowAmount.Text = "Show amount of readable files in day list";
            this.CB_ShowAmount.UseVisualStyleBackColor = true;
            this.CB_ShowAmount.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CB_NumericMonth
            // 
            this.CB_NumericMonth.AutoSize = true;
            this.CB_NumericMonth.Location = new System.Drawing.Point(9, 69);
            this.CB_NumericMonth.Name = "CB_NumericMonth";
            this.CB_NumericMonth.Size = new System.Drawing.Size(175, 17);
            this.CB_NumericMonth.TabIndex = 3;
            this.CB_NumericMonth.Text = "Add numeric month in month list";
            this.CB_NumericMonth.UseVisualStyleBackColor = true;
            this.CB_NumericMonth.CheckedChanged += new System.EventHandler(this.CB_NumericMonth_CheckedChanged);
            // 
            // UpDo_YearStarts
            // 
            this.UpDo_YearStarts.Cursor = System.Windows.Forms.Cursors.Default;
            this.UpDo_YearStarts.Location = new System.Drawing.Point(104, 20);
            this.UpDo_YearStarts.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.UpDo_YearStarts.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.UpDo_YearStarts.Name = "UpDo_YearStarts";
            this.UpDo_YearStarts.Size = new System.Drawing.Size(58, 20);
            this.UpDo_YearStarts.TabIndex = 2;
            this.UpDo_YearStarts.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.UpDo_YearStarts.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.UpDo_YearStarts.LostFocus += new System.EventHandler(this.UpDo_YearStarts_LostFocus);
            // 
            // Label_YeatStart
            // 
            this.Label_YeatStart.AutoSize = true;
            this.Label_YeatStart.Location = new System.Drawing.Point(6, 22);
            this.Label_YeatStart.Name = "Label_YeatStart";
            this.Label_YeatStart.Size = new System.Drawing.Size(78, 13);
            this.Label_YeatStart.TabIndex = 1;
            this.Label_YeatStart.Text = "Start year from:";
            // 
            // Form_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 328);
            this.Controls.Add(this.BOX_Misc);
            this.Controls.Add(this.BOX_PhotoFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configs";
            this.Load += new System.EventHandler(this.Form_Config_Load);
            this.BOX_PhotoFolder.ResumeLayout(false);
            this.BOX_PhotoFolder.PerformLayout();
            this.BOX_Misc.ResumeLayout(false);
            this.BOX_Misc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDo_YearStarts)).EndInit();
            this.ResumeLayout(false);

        }       

        #endregion

        private System.Windows.Forms.GroupBox BOX_PhotoFolder;
        private System.Windows.Forms.Button PhotoSave_B;
        private System.Windows.Forms.Button PhotoExplore_B;
        private System.Windows.Forms.TextBox PhotoPath_Edit;
        private System.Windows.Forms.FolderBrowserDialog Dialog_BrowseFolder;
        private System.Windows.Forms.ImageList ConfImageList;
        private System.Windows.Forms.GroupBox BOX_Misc;
        private System.Windows.Forms.Label Label_YeatStart;
        private System.Windows.Forms.NumericUpDown UpDo_YearStarts;
        private System.Windows.Forms.CheckBox CB_NumericMonth;
        private System.Windows.Forms.CheckBox CB_ShowAmount;
    }
}