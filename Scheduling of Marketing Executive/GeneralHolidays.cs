using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Schedule
{
	/// <summary>
	/// Summary description for GeneralHolidays.
	/// </summary>
	public class GeneralHolidays : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnRem;
		private System.Windows.Forms.MonthCalendar calHol;
		private System.Windows.Forms.Label lblComHol;
		private System.Windows.Forms.Label label12;

		public ArrayList hol = new ArrayList();
		public DataSet ds1 = new DataSet ("General Holidays");
		public DataTable tab = new DataTable("Holiday");
		public bool flag = false;

		private System.Windows.Forms.DataGrid dg1;
		private System.Data.DataColumn dc1;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public GeneralHolidays()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			setup_DataGrid();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
			this.dg1 = new System.Windows.Forms.DataGrid();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnRem = new System.Windows.Forms.Button();
			this.calHol = new System.Windows.Forms.MonthCalendar();
			this.lblComHol = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.dc1 = new System.Data.DataColumn();
			((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
			this.SuspendLayout();
			// 
			// dg1
			// 
			this.dg1.CaptionText = "General Holidays";
			this.dg1.DataMember = "";
			this.dg1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dg1.Location = new System.Drawing.Point(360, 56);
			this.dg1.Name = "dg1";
			this.dg1.Size = new System.Drawing.Size(216, 192);
			this.dg1.TabIndex = 36;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(80, 224);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(88, 23);
			this.btnAdd.TabIndex = 34;
			this.btnAdd.Text = "&Add ";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnRem
			// 
			this.btnRem.Location = new System.Drawing.Point(184, 224);
			this.btnRem.Name = "btnRem";
			this.btnRem.Size = new System.Drawing.Size(88, 23);
			this.btnRem.TabIndex = 35;
			this.btnRem.Text = "&Remove";
			this.btnRem.Click += new System.EventHandler(this.btnRem_Click);
			// 
			// calHol
			// 
			this.calHol.Location = new System.Drawing.Point(72, 56);
			this.calHol.Name = "calHol";
			this.calHol.TabIndex = 33;
			// 
			// lblComHol
			// 
			this.lblComHol.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblComHol.ForeColor = System.Drawing.Color.Green;
			this.lblComHol.Location = new System.Drawing.Point(0, 264);
			this.lblComHol.Name = "lblComHol";
			this.lblComHol.Size = new System.Drawing.Size(600, 32);
			this.lblComHol.TabIndex = 31;
			this.lblComHol.Text = "The number of Holidays ";
			this.lblComHol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.Dock = System.Windows.Forms.DockStyle.Top;
			this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Crimson;
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(600, 24);
			this.label12.TabIndex = 32;
			this.label12.Text = "General Holidays";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// GeneralHolidays
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(600, 318);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnRem,
																		  this.calHol,
																		  this.lblComHol,
																		  this.label12,
																		  this.dg1,
																		  this.btnAdd});
			this.Name = "GeneralHolidays";
			this.Text = "SME - General Holidays";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.GeneralHolidays_Load);
			((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void GeneralHolidays_Load(object sender, System.EventArgs e)
		{
//			Form1
		}		
	}
}
