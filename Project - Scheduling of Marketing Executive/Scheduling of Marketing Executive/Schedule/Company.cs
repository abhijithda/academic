using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Schedule
{
	/// <summary>
	/// Summary description for Company.
	/// </summary>
	public class Company : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox gbSch;
		private System.Windows.Forms.Label lblsch;
		private System.Windows.Forms.DateTimePicker edate;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DateTimePicker sdate;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnDone;
		private System.Windows.Forms.GroupBox grpHol;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox cmbWeeklyOff;
		private System.Windows.Forms.GroupBox gbGenHol;
		private System.Windows.Forms.MonthCalendar calHol;
		private System.Windows.Forms.Label lblComHol;
		private System.Windows.Forms.DataGrid dg1;
		private System.Windows.Forms.Button btnAdd;
		private System.Data.DataColumn dc1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;


		public ArrayList hol = new ArrayList();
		public DataSet ds1 = new DataSet ("General Holidays");
		public DataTable tab = new DataTable("Holiday");
		private System.Windows.Forms.Button btnRem;
		private System.Windows.Forms.Button btnNextForm;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		public bool flag = false;



		public Company()
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
			this.gbSch = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.edate = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.sdate = new System.Windows.Forms.DateTimePicker();
			this.label10 = new System.Windows.Forms.Label();
			this.btnDone = new System.Windows.Forms.Button();
			this.lblsch = new System.Windows.Forms.Label();
			this.grpHol = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.cmbWeeklyOff = new System.Windows.Forms.ComboBox();
			this.gbGenHol = new System.Windows.Forms.GroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this.btnRem = new System.Windows.Forms.Button();
			this.calHol = new System.Windows.Forms.MonthCalendar();
			this.dg1 = new System.Windows.Forms.DataGrid();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lblComHol = new System.Windows.Forms.Label();
			this.dc1 = new System.Data.DataColumn();
			this.btnNextForm = new System.Windows.Forms.Button();
			this.gbSch.SuspendLayout();
			this.grpHol.SuspendLayout();
			this.gbGenHol.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
			this.SuspendLayout();
			// 
			// gbSch
			// 
			this.gbSch.Controls.AddRange(new System.Windows.Forms.Control[] {
																				this.label1,
																				this.edate,
																				this.label9,
																				this.sdate,
																				this.label10,
																				this.btnDone,
																				this.lblsch});
			this.gbSch.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbSch.Location = new System.Drawing.Point(0, 152);
			this.gbSch.Name = "gbSch";
			this.gbSch.Size = new System.Drawing.Size(688, 120);
			this.gbSch.TabIndex = 52;
			this.gbSch.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(264, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 24);
			this.label1.TabIndex = 19;
			this.label1.Text = "Time Period";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// edate
			// 
			this.edate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.edate.Location = new System.Drawing.Point(376, 56);
			this.edate.Name = "edate";
			this.edate.TabIndex = 12;
			this.edate.Value = new System.DateTime(2005, 5, 18, 0, 0, 0, 0);
			this.edate.ValueChanged += new System.EventHandler(this.edate_ValueChanged);
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(255)));
			this.label9.Location = new System.Drawing.Point(336, 56);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(32, 24);
			this.label9.TabIndex = 11;
			this.label9.Text = "to";
			// 
			// sdate
			// 
			this.sdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.sdate.Location = new System.Drawing.Point(120, 56);
			this.sdate.Name = "sdate";
			this.sdate.TabIndex = 10;
			this.sdate.Value = new System.DateTime(2005, 5, 18, 0, 0, 0, 0);
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(255)));
			this.label10.Location = new System.Drawing.Point(56, 56);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 24);
			this.label10.TabIndex = 9;
			this.label10.Text = "From";
			// 
			// btnDone
			// 
			this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnDone.Location = new System.Drawing.Point(48, 88);
			this.btnDone.Name = "btnDone";
			this.btnDone.TabIndex = 17;
			this.btnDone.Text = "&Done";
			this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
			// 
			// lblsch
			// 
			this.lblsch.BackColor = System.Drawing.Color.Transparent;
			this.lblsch.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblsch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblsch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblsch.ForeColor = System.Drawing.Color.Green;
			this.lblsch.Location = new System.Drawing.Point(3, 93);
			this.lblsch.Name = "lblsch";
			this.lblsch.Size = new System.Drawing.Size(682, 24);
			this.lblsch.TabIndex = 14;
			this.lblsch.Text = "The Scheduling is for the period of days : 0";
			this.lblsch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// grpHol
			// 
			this.grpHol.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.label3,
																				 this.label2,
																				 this.label8,
																				 this.comboBox1,
																				 this.cmbWeeklyOff});
			this.grpHol.Dock = System.Windows.Forms.DockStyle.Top;
			this.grpHol.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grpHol.Name = "grpHol";
			this.grpHol.Size = new System.Drawing.Size(688, 152);
			this.grpHol.TabIndex = 57;
			this.grpHol.TabStop = false;
			this.grpHol.Enter += new System.EventHandler(this.grpHol_Enter);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(255)));
			this.label3.Location = new System.Drawing.Point(64, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(160, 24);
			this.label3.TabIndex = 64;
			this.label3.Text = "Head Office Visit :";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(255)));
			this.label2.Location = new System.Drawing.Point(16, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(216, 24);
			this.label2.TabIndex = 63;
			this.label2.Text = "Company \"Weekly Off\" :";
			// 
			// label8
			// 
			this.label8.Dock = System.Windows.Forms.DockStyle.Top;
			this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(3, 22);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(682, 24);
			this.label8.TabIndex = 62;
			this.label8.Text = "Company Details";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBox1.Items.AddRange(new object[] {
														   "-- No Day --",
														   "Sunday",
														   "Monday",
														   "Tuesday",
														   "Wednesday",
														   "Thursday",
														   "Friday",
														   "Saturday"});
			this.comboBox1.Location = new System.Drawing.Point(248, 112);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(184, 24);
			this.comboBox1.TabIndex = 60;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// cmbWeeklyOff
			// 
			this.cmbWeeklyOff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbWeeklyOff.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbWeeklyOff.Items.AddRange(new object[] {
															  "-- No Day --",
															  "Sunday",
															  "Monday",
															  "Tuesday",
															  "Wednesday",
															  "Thursday",
															  "Friday",
															  "Saturday"});
			this.cmbWeeklyOff.Location = new System.Drawing.Point(248, 64);
			this.cmbWeeklyOff.Name = "cmbWeeklyOff";
			this.cmbWeeklyOff.Size = new System.Drawing.Size(184, 24);
			this.cmbWeeklyOff.TabIndex = 59;
			this.cmbWeeklyOff.SelectedIndexChanged += new System.EventHandler(this.cmbWeeklyOff_SelectedIndexChanged);
			// 
			// gbGenHol
			// 
			this.gbGenHol.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.label12,
																				   this.btnRem,
																				   this.calHol,
																				   this.dg1,
																				   this.btnAdd,
																				   this.lblComHol});
			this.gbGenHol.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbGenHol.Location = new System.Drawing.Point(0, 272);
			this.gbGenHol.Name = "gbGenHol";
			this.gbGenHol.Size = new System.Drawing.Size(688, 272);
			this.gbGenHol.TabIndex = 58;
			this.gbGenHol.TabStop = false;
			this.gbGenHol.Enter += new System.EventHandler(this.gbGenHol_Enter);
			// 
			// label12
			// 
			this.label12.Dock = System.Windows.Forms.DockStyle.Top;
			this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Crimson;
			this.label12.Location = new System.Drawing.Point(3, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(682, 24);
			this.label12.TabIndex = 44;
			this.label12.Text = "General Holidays";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnRem
			// 
			this.btnRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnRem.Location = new System.Drawing.Point(216, 208);
			this.btnRem.Name = "btnRem";
			this.btnRem.Size = new System.Drawing.Size(88, 23);
			this.btnRem.TabIndex = 43;
			this.btnRem.Text = "&Remove";
			this.btnRem.Click += new System.EventHandler(this.btnRem_Click);
			// 
			// calHol
			// 
			this.calHol.Location = new System.Drawing.Point(104, 48);
			this.calHol.Name = "calHol";
			this.calHol.TabIndex = 39;
			// 
			// dg1
			// 
			this.dg1.AlternatingBackColor = System.Drawing.Color.Lavender;
			this.dg1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dg1.BackgroundColor = System.Drawing.Color.LightGray;
			this.dg1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dg1.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
			this.dg1.CaptionForeColor = System.Drawing.Color.MidnightBlue;
			this.dg1.CaptionText = "General Holidays";
			this.dg1.DataMember = "";
			this.dg1.FlatMode = true;
			this.dg1.Font = new System.Drawing.Font("Tahoma", 8F);
			this.dg1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dg1.GridLineColor = System.Drawing.Color.Gainsboro;
			this.dg1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.dg1.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dg1.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.dg1.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
			this.dg1.LinkColor = System.Drawing.Color.Teal;
			this.dg1.Location = new System.Drawing.Point(344, 40);
			this.dg1.Name = "dg1";
			this.dg1.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
			this.dg1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dg1.SelectionBackColor = System.Drawing.Color.CadetBlue;
			this.dg1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
			this.dg1.Size = new System.Drawing.Size(216, 192);
			this.dg1.TabIndex = 42;
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(112, 208);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(88, 23);
			this.btnAdd.TabIndex = 40;
			this.btnAdd.Text = "&Add ";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lblComHol
			// 
			this.lblComHol.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblComHol.ForeColor = System.Drawing.Color.Green;
			this.lblComHol.Location = new System.Drawing.Point(24, 232);
			this.lblComHol.Name = "lblComHol";
			this.lblComHol.Size = new System.Drawing.Size(600, 32);
			this.lblComHol.TabIndex = 37;
			this.lblComHol.Text = "The number of Holidays ";
			this.lblComHol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnNextForm
			// 
			this.btnNextForm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnNextForm.ForeColor = System.Drawing.Color.DarkMagenta;
			this.btnNextForm.Location = new System.Drawing.Point(552, 552);
			this.btnNextForm.Name = "btnNextForm";
			this.btnNextForm.Size = new System.Drawing.Size(96, 23);
			this.btnNextForm.TabIndex = 59;
			this.btnNextForm.Text = "Step 2 ->";
			this.btnNextForm.Click += new System.EventHandler(this.btnNextForm_Click);
			// 
			// Company
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(688, 578);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnNextForm,
																		  this.gbGenHol,
																		  this.gbSch,
																		  this.grpHol});
			this.Name = "Company";
			this.Text = "Company";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Company_Load);
			this.gbSch.ResumeLayout(false);
			this.grpHol.ResumeLayout(false);
			this.gbGenHol.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void btnDone_Click(object sender, System.EventArgs e)
		{
			DateTime sd1 = new DateTime(sdate.Value.Year ,sdate.Value.Month ,sdate.Value.Day );
			DateTime ed1 = new DateTime(edate.Value.Year ,edate.Value.Month ,edate.Value.Day );

			Console.WriteLine ("Start : " + sd1);
			if ( sd1  > ed1 )
			{
				MessageBox.Show ("Scheduled interval is not proper.","Schedule Error",MessageBoxButtons.OK ,MessageBoxIcon.Error );
				return;
			}

			string sd = sdate.Value.ToString("d") ;
			string ed= edate.Value.ToString("d");
			int tmp =  (edate.Value.Subtract ( sdate.Value )).Days;
			tmp += 1;
			lblsch.Text ="The Total number of days : " + tmp;



			Form1.alloc.sdte = get_DateFromString(sd);
			Form1.alloc.edte = get_DateFromString(ed);
			Form1.alloc.totDays = tmp;


			///<summmary>
			///	Required : Try and Catch Statements.
			///	Explanation : 
			///		If the MinDate or MaxDate is Already assigned values, and
			/// again MinDate is assigned a value Less than MaxDate previously assigned
			/// then error will occur,even though current MaxDate value is higher. This 
			/// is because, while assigned the MaxDate still contains the Old value.
			/// </summary>

			try
			{
				calHol.MinDate = sdate.Value ;
			}
			catch
			{
			}
			try
			{
				calHol.MaxDate = edate.Value ;
			}
			catch
			{
			}
			try
			{
				calHol.MinDate = sdate.Value ;
			}
			catch
			{
			}
		}


		private void cmbWeeklyOff_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Form1.alloc.hol = cmbWeeklyOff.Text;
		}
		
		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Form1.alloc.head = comboBox1.Text;
		}


/// <summary>
/// For only General Holidays Section.
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>

		void setup_DataGrid()
		{
			dg1.CaptionText = "General Holidays";
			DataColumn dc1 = new DataColumn ("Holiday",typeof(DateTime));
			tab.Columns.Add(dc1);
			ds1.Tables.Add (tab);
			dg1.SetDataBinding (ds1,"Holiday");
		}
		
		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			calHol.AddBoldedDate (calHol.SelectionStart.Date );
			calHol.UpdateBoldedDates ();
			string tmp = calHol.SelectionStart.ToString ("d");
			if(hol.Contains(tmp))
				return;
			hol.Add(tmp);
			lblComHol.Text = "Total no. of General Holidays : " + hol.Count ;

			update_DataGrid();
		}


		void update_DataGrid()
		{
			sort_Holidays();
			tab.Rows.Clear ();
			DataRow r1;
			for(int i=0;i<hol.Count ;i++)
			{
				r1 = tab.NewRow ();
				r1["Holiday"] = hol[i];
				tab.Rows.Add (r1);
			}
			dg1.Refresh();
		}

		void sort_Holidays()
		{
			int i,j,val;
			string str;
			//			DateTime[] ar ;
			//			hol.ToArray (DateTime[] ar);
			//			= new DateTime(1,1,1)[hol.Count ];

			//			for(i=0;i<hol.Count ;i++)
			
				
			for(i=0;i<hol.Count-1 ;i++)
				for(j=i+1;j<hol.Count ;j++)
				{
					DateTime tmp1,tmp2;
					str = hol[i].ToString ();
					string[] s1 = str.Split ('/');
					string[] stmp = s1[2].Split ();
					tmp1 = new DateTime (int.Parse (stmp[0]),int.Parse (s1[0]),int.Parse(s1[1]));
					str = "Abhijith DA";
					str = hol[j].ToString ();
					s1 = str.Split ('/');
					stmp = s1[2].Split ();
					tmp2 =new DateTime (int.Parse (stmp[0]),int.Parse (s1[0]),int.Parse(s1[1]));

					val = tmp1.CompareTo (tmp2);
					if(val > 0)
					{
						hol[j] = tmp1.ToString ("d");
						hol[i] = tmp2.ToString ("d");
					}
				}
		}

		private void edate_ValueChanged(object sender, System.EventArgs e)
		{
		
		}

		private void btnRem_Click(object sender, System.EventArgs e)
		{
			calHol.RemoveBoldedDate(calHol.SelectionStart );
			calHol.UpdateBoldedDates();
			string tmp = calHol.SelectionStart.ToString ("d");
			if(hol.Contains(tmp) == false)
				return;
            
			hol.Remove(tmp);
			lblComHol.Text = "Total no. of General Holidays : " + hol.Count ;		
			update_DataGrid();
		}

		public DateTime get_DateFromString(string str)
		{
			string[] s1 = str.Split ('/');
			string[] stmp = s1[2].Split ();
			return new DateTime (int.Parse (stmp[0]),int.Parse (s1[0]),int.Parse(s1[1]));
		}

		private void btnNextForm_Click(object sender, System.EventArgs e)
		{
			if(cmbWeeklyOff.Text.Trim() == "")
			{
				MessageBox.Show("Select the Company Weekly Off");
				return;
			}
			if(comboBox1.Text.Trim() == "")
			{
				MessageBox.Show("Select the Company Head Office visit for the Marketing Executive");
				return;
			}
			Form1.alloc.hol = cmbWeeklyOff.Text;
			Form1.alloc.head = comboBox1.Text;

			Form1.CusTypes.Show ();
		}

		private void gbGenHol_Enter(object sender, System.EventArgs e)
		{
		}

		private void grpHol_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void Company_Load(object sender, System.EventArgs e)
		{
			if(Form1.dateflag == false)
			{
				sdate.Value = DateTime.Today;
				edate.Value = DateTime.Today;
				Form1.dateflag = true;
			}
		}


	}
}
