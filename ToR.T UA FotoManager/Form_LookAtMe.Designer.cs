namespace ToRT_UA_FotoManager
{
    partial class Form_LookAtMe
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
            this.LAM_MStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LAM_SStrip = new System.Windows.Forms.StatusStrip();
            this.LAM_SS_Progress = new System.Windows.Forms.ToolStripProgressBar();
            this.LAM_SS_MainLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LAM_SS_InfoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LAM_Image = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LAM_MStrip.SuspendLayout();
            this.LAM_SStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LAM_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // LAM_MStrip
            // 
            this.LAM_MStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.LAM_MStrip.Location = new System.Drawing.Point(0, 0);
            this.LAM_MStrip.Name = "LAM_MStrip";
            this.LAM_MStrip.Size = new System.Drawing.Size(384, 24);
            this.LAM_MStrip.TabIndex = 0;
            this.LAM_MStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePositionToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // savePositionToolStripMenuItem
            // 
            this.savePositionToolStripMenuItem.Name = "savePositionToolStripMenuItem";
            this.savePositionToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.savePositionToolStripMenuItem.Text = "Save position";
            this.savePositionToolStripMenuItem.Click += new System.EventHandler(this.savePositionToolStripMenuItem_Click);
            // 
            // LAM_SStrip
            // 
            this.LAM_SStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LAM_SS_Progress,
            this.LAM_SS_MainLabel,
            this.LAM_SS_InfoLabel});
            this.LAM_SStrip.Location = new System.Drawing.Point(0, 339);
            this.LAM_SStrip.Name = "LAM_SStrip";
            this.LAM_SStrip.Size = new System.Drawing.Size(384, 22);
            this.LAM_SStrip.TabIndex = 1;
            this.LAM_SStrip.Text = "statusStrip1";
            // 
            // LAM_SS_Progress
            // 
            this.LAM_SS_Progress.Name = "LAM_SS_Progress";
            this.LAM_SS_Progress.Size = new System.Drawing.Size(100, 16);
            this.LAM_SS_Progress.Visible = false;
            // 
            // LAM_SS_MainLabel
            // 
            this.LAM_SS_MainLabel.AutoSize = false;
            this.LAM_SS_MainLabel.Name = "LAM_SS_MainLabel";
            this.LAM_SS_MainLabel.Size = new System.Drawing.Size(523, 17);
            this.LAM_SS_MainLabel.Spring = true;
            // 
            // LAM_SS_InfoLabel
            // 
            this.LAM_SS_InfoLabel.Name = "LAM_SS_InfoLabel";
            this.LAM_SS_InfoLabel.Size = new System.Drawing.Size(0, 0);
            // 
            // LAM_Image
            // 
            this.LAM_Image.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LAM_Image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LAM_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAM_Image.Location = new System.Drawing.Point(0, 24);
            this.LAM_Image.Name = "LAM_Image";
            this.LAM_Image.Size = new System.Drawing.Size(384, 315);
            this.LAM_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LAM_Image.TabIndex = 2;
            this.LAM_Image.TabStop = false;
            this.LAM_Image.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.LAM_Image_MouseWheel);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 305);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(384, 34);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // Form_LookAtMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.LAM_Image);
            this.Controls.Add(this.LAM_MStrip);
            this.Controls.Add(this.LAM_SStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MainMenuStrip = this.LAM_MStrip;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form_LookAtMe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Look at me";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_LookAtMe_FormClosing);
            this.Load += new System.EventHandler(this.Form_LookAtMe_Load);
            this.LAM_MStrip.ResumeLayout(false);
            this.LAM_MStrip.PerformLayout();
            this.LAM_SStrip.ResumeLayout(false);
            this.LAM_SStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LAM_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip LAM_MStrip;
        private System.Windows.Forms.StatusStrip LAM_SStrip;
        private System.Windows.Forms.ToolStripProgressBar LAM_SS_Progress;
        private System.Windows.Forms.ToolStripStatusLabel LAM_SS_MainLabel;
        private System.Windows.Forms.ToolStripStatusLabel LAM_SS_InfoLabel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.PictureBox LAM_Image;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem savePositionToolStripMenuItem;

    }
}