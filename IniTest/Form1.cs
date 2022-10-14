using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Ini;

namespace IniTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.TextBox lname;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.name = new System.Windows.Forms.TextBox();
			this.lname = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// name
			// 
			this.name.Location = new System.Drawing.Point(8, 8);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(184, 20);
			this.name.TabIndex = 0;
			this.name.Text = "Name";
			// 
			// lname
			// 
			this.lname.Location = new System.Drawing.Point(8, 40);
			this.lname.Name = "lname";
			this.lname.Size = new System.Drawing.Size(184, 20);
			this.lname.TabIndex = 1;
			this.lname.Text = "Last Name";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(208, 70);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.lname,
																		  this.name});
			this.Name = "Form1";
			this.Text = "Form1";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			IniFile ini = new IniFile("C:\\test.ini");
			ini.IniWriteValue("Info","Name",name.Text);
			ini.IniWriteValue("Info","LastName",lname.Text);
		}
		private void Form1_Load(object sender, System.EventArgs e)
		{
			IniFile ini = new IniFile("C:\\test.ini");
			name.Text= ini.IniReadValue("Info","Name");
			lname.Text = ini.IniReadValue("Info","LastName");
		}
	}
}
