using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Schedule
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem mnuFile;
		private System.Windows.Forms.MenuItem mnuNew;
		private System.Windows.Forms.MenuItem mnuHelp;
		private System.Windows.Forms.MenuItem mnuAbt;
		private System.Windows.Forms.MenuItem mnuVer;
		private System.Windows.Forms.MenuItem mnuExit;
		private System.Windows.Forms.GroupBox grpMain;
		private System.Windows.Forms.LinkLabel linkLabelCom;
		private System.Windows.Forms.LinkLabel linkLabelCus;
	
		//		public int [,] a;
		//		public static int totDays,totCus;
		//		public static int head,hol;
		//		public static int maxVisDay;
		//		int[] NVis,NCus;		//No. of Customers and Visits for each type of Priority..
		//		static int NumTypes;	//No. of Priorities.
		//		int [] CusInterval;

		public static Allocate alloc;
		public static Company company ;
		public static CustomerTypes CusTypes ;
		public static Result result = new Result();
		
		public static Customer[] customer;
		private System.Windows.Forms.LinkLabel linkLabelResult;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
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

			alloc = new Allocate ();
			company = new Company();
			CusTypes = new CustomerTypes ();
//			result = new Result();

			company.MdiParent = this;
			CusTypes.MdiParent = this;
			result.MdiParent = this;
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
			this.label1 = new System.Windows.Forms.Label();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.mnuFile = new System.Windows.Forms.MenuItem();
			this.mnuNew = new System.Windows.Forms.MenuItem();
			this.mnuExit = new System.Windows.Forms.MenuItem();
			this.mnuHelp = new System.Windows.Forms.MenuItem();
			this.mnuAbt = new System.Windows.Forms.MenuItem();
			this.mnuVer = new System.Windows.Forms.MenuItem();
			this.grpMain = new System.Windows.Forms.GroupBox();
			this.linkLabelResult = new System.Windows.Forms.LinkLabel();
			this.linkLabelCus = new System.Windows.Forms.LinkLabel();
			this.linkLabelCom = new System.Windows.Forms.LinkLabel();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.grpMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Black;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(712, 48);
			this.label1.TabIndex = 1;
			this.label1.Text = "Scheduling of Marketing Executive ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mnuFile,
																					  this.mnuHelp});
			// 
			// mnuFile
			// 
			this.mnuFile.Index = 0;
			this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.mnuNew,
																					this.mnuExit});
			this.mnuFile.Text = "&File";
			// 
			// mnuNew
			// 
			this.mnuNew.Index = 0;
			this.mnuNew.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				   this.menuItem1,
																				   this.menuItem2});
			this.mnuNew.Text = "&Start";
			this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
			// 
			// mnuExit
			// 
			this.mnuExit.Index = 1;
			this.mnuExit.Text = "E&xit";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
			// 
			// mnuHelp
			// 
			this.mnuHelp.Index = 1;
			this.mnuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.mnuAbt,
																					this.mnuVer});
			this.mnuHelp.Text = "H&elp";
			// 
			// mnuAbt
			// 
			this.mnuAbt.Index = 0;
			this.mnuAbt.Text = "About";
			this.mnuAbt.Click += new System.EventHandler(this.mnuAbt_Click);
			// 
			// mnuVer
			// 
			this.mnuVer.Index = 1;
			this.mnuVer.Text = "Version";
			this.mnuVer.Click += new System.EventHandler(this.mnuVer_Click);
			// 
			// grpMain
			// 
			this.grpMain.BackColor = System.Drawing.Color.RosyBrown;
			this.grpMain.Controls.AddRange(new System.Windows.Forms.Control[] {
																				  this.linkLabelResult,
																				  this.linkLabelCus,
																				  this.linkLabelCom});
			this.grpMain.Dock = System.Windows.Forms.DockStyle.Left;
			this.grpMain.Location = new System.Drawing.Point(0, 48);
			this.grpMain.Name = "grpMain";
			this.grpMain.Size = new System.Drawing.Size(152, 438);
			this.grpMain.TabIndex = 3;
			this.grpMain.TabStop = false;
			this.grpMain.Visible = false;
			// 
			// linkLabelResult
			// 
			this.linkLabelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabelResult.Location = new System.Drawing.Point(8, 336);
			this.linkLabelResult.Name = "linkLabelResult";
			this.linkLabelResult.Size = new System.Drawing.Size(136, 23);
			this.linkLabelResult.TabIndex = 2;
			this.linkLabelResult.TabStop = true;
			this.linkLabelResult.Text = "Result";
			this.linkLabelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkLabelResult.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelResult_LinkClicked);
			// 
			// linkLabelCus
			// 
			this.linkLabelCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabelCus.Location = new System.Drawing.Point(8, 208);
			this.linkLabelCus.Name = "linkLabelCus";
			this.linkLabelCus.Size = new System.Drawing.Size(136, 23);
			this.linkLabelCus.TabIndex = 1;
			this.linkLabelCus.TabStop = true;
			this.linkLabelCus.Text = "Customer Details";
			this.linkLabelCus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkLabelCus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCus_LinkClicked);
			// 
			// linkLabelCom
			// 
			this.linkLabelCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabelCom.Location = new System.Drawing.Point(8, 80);
			this.linkLabelCom.Name = "linkLabelCom";
			this.linkLabelCom.Size = new System.Drawing.Size(136, 23);
			this.linkLabelCom.TabIndex = 0;
			this.linkLabelCom.TabStop = true;
			this.linkLabelCom.Text = "Company Details";
			this.linkLabelCom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkLabelCom.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCom_LinkClicked);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.Text = "Application";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.Text = "Heuristics Comparision";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(712, 486);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.grpMain,
																		  this.label1});
			this.IsMdiContainer = true;
			this.MaximizeBox = false;
			this.Menu = this.mainMenu1;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "SME - Scheduling Of Marketing Executive";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.grpMain.ResumeLayout(false);
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
			//				Allocate alloc = new Allocate();
		}

		private void mnuAbt_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show (this,"Developed by\n\t - \n\tAbhijith D.A.\t1PI01IS001\n\t Deepak V.\t1PI01IS022\n\t Mahesh M.P.\t1PI01IS042","About",0);
		}

		private void mnuExit_Click(object sender, System.EventArgs e)
		{
			this.Close() ;
		}

		private void linkLabelCom_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			company.Show ();
			company.Focus ();
		}

		private void mnuNew_Click(object sender, System.EventArgs e)
		{
		}


		private void linkLabelCus_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			CusTypes.Show ();
			CusTypes.Focus();
		}


		private void linkLabelResult_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			result.Show();
			result.Focus();
		}

		private void mnuVer_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(this,"SME first Verson\n Developed at IISC and PESIT","Version");
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			grpMain.Visible = true;
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			SMEHeuCom sm = new SMEHeuCom ();
			sm.Show ();
		}


	}
}
