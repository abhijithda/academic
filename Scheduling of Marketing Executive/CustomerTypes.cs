using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Schedule
{
	/// <summary>
	/// Summary description for CustomerTypes.
	/// </summary>
	public class CustomerTypes : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBoxPriNo;
		private System.Windows.Forms.Button btnDone;
		private System.Windows.Forms.TextBox txtPriNo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBoxForType;
		private System.Windows.Forms.Label lblType;
		private System.Windows.Forms.Button btnNextType;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtNoCus;
		private System.Windows.Forms.TextBox txtNoVis;
		private System.Windows.Forms.GroupBox groupBoxCusDetails;
		private System.Windows.Forms.Button btnNextCus;
		private System.Windows.Forms.Label lblCusDetails;
		private System.Windows.Forms.DataGrid dgPri;
		private System.Windows.Forms.DataGrid dgCus;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private static int index_cnt = 0;	//For Priorities Vis and no. of Customers.
		private static int index = 0;		//For CustomersId's and closure days.
		public DataSet dsPri = new DataSet ("Priorities");
		public DataTable tabPri = new DataTable("Priority");
		public DataSet dsCus = new DataSet ("Customers");
		private System.Windows.Forms.TextBox txtCusId;
		private System.Windows.Forms.ComboBox cmbCusHol;
		private System.Windows.Forms.TextBox txtMaxVis;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnNextForm;
		private System.Windows.Forms.GroupBox grpMaxVis;
		public DataTable tabCus = new DataTable("Customer");

		public CustomerTypes()
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
			this.groupBoxPriNo = new System.Windows.Forms.GroupBox();
			this.btnDone = new System.Windows.Forms.Button();
			this.txtPriNo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBoxForType = new System.Windows.Forms.GroupBox();
			this.lblType = new System.Windows.Forms.Label();
			this.txtNoVis = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnNextType = new System.Windows.Forms.Button();
			this.txtNoCus = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBoxCusDetails = new System.Windows.Forms.GroupBox();
			this.cmbCusHol = new System.Windows.Forms.ComboBox();
			this.txtCusId = new System.Windows.Forms.TextBox();
			this.lblCusDetails = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnNextCus = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.dgPri = new System.Windows.Forms.DataGrid();
			this.dgCus = new System.Windows.Forms.DataGrid();
			this.grpMaxVis = new System.Windows.Forms.GroupBox();
			this.txtMaxVis = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnNextForm = new System.Windows.Forms.Button();
			this.groupBoxPriNo.SuspendLayout();
			this.groupBoxForType.SuspendLayout();
			this.groupBoxCusDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgPri)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgCus)).BeginInit();
			this.grpMaxVis.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxPriNo
			// 
			this.groupBoxPriNo.Controls.AddRange(new System.Windows.Forms.Control[] {
																						this.btnDone,
																						this.txtPriNo,
																						this.label1});
			this.groupBoxPriNo.Location = new System.Drawing.Point(80, 16);
			this.groupBoxPriNo.Name = "groupBoxPriNo";
			this.groupBoxPriNo.Size = new System.Drawing.Size(528, 56);
			this.groupBoxPriNo.TabIndex = 19;
			this.groupBoxPriNo.TabStop = false;
			// 
			// btnDone
			// 
			this.btnDone.Enabled = false;
			this.btnDone.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnDone.ForeColor = System.Drawing.Color.DarkMagenta;
			this.btnDone.Location = new System.Drawing.Point(432, 16);
			this.btnDone.Name = "btnDone";
			this.btnDone.TabIndex = 21;
			this.btnDone.Text = "&Done";
			this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
			// 
			// txtPriNo
			// 
			this.txtPriNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtPriNo.Location = new System.Drawing.Point(344, 16);
			this.txtPriNo.MaxLength = 2;
			this.txtPriNo.Name = "txtPriNo";
			this.txtPriNo.Size = new System.Drawing.Size(48, 23);
			this.txtPriNo.TabIndex = 20;
			this.txtPriNo.Text = "";
			this.txtPriNo.TextChanged += new System.EventHandler(this.txtPriNo_TextChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(332, 27);
			this.label1.TabIndex = 19;
			this.label1.Text = "Enter the no. of Types of Customers required :";
			// 
			// groupBoxForType
			// 
			this.groupBoxForType.Controls.AddRange(new System.Windows.Forms.Control[] {
																						  this.lblType,
																						  this.txtNoVis,
																						  this.label3,
																						  this.btnNextType,
																						  this.txtNoCus,
																						  this.label2});
			this.groupBoxForType.Location = new System.Drawing.Point(24, 96);
			this.groupBoxForType.Name = "groupBoxForType";
			this.groupBoxForType.Size = new System.Drawing.Size(280, 160);
			this.groupBoxForType.TabIndex = 20;
			this.groupBoxForType.TabStop = false;
			this.groupBoxForType.Visible = false;
			// 
			// lblType
			// 
			this.lblType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblType.ForeColor = System.Drawing.Color.Crimson;
			this.lblType.Location = new System.Drawing.Point(80, 16);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(140, 23);
			this.lblType.TabIndex = 24;
			this.lblType.Text = "For Type : 1";
			// 
			// txtNoVis
			// 
			this.txtNoVis.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtNoVis.Location = new System.Drawing.Point(176, 56);
			this.txtNoVis.Name = "txtNoVis";
			this.txtNoVis.Size = new System.Drawing.Size(88, 23);
			this.txtNoVis.TabIndex = 23;
			this.txtNoVis.Text = "";
			this.txtNoVis.TextChanged += new System.EventHandler(this.txtNoVis_TextChanged);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(16, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(140, 23);
			this.label3.TabIndex = 22;
			this.label3.Text = "no. of Visits :";
			// 
			// btnNextType
			// 
			this.btnNextType.Enabled = false;
			this.btnNextType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnNextType.ForeColor = System.Drawing.Color.DarkMagenta;
			this.btnNextType.Location = new System.Drawing.Point(184, 128);
			this.btnNextType.Name = "btnNextType";
			this.btnNextType.TabIndex = 21;
			this.btnNextType.Text = "&Next";
			this.btnNextType.Click += new System.EventHandler(this.btnNextType_Click);
			// 
			// txtNoCus
			// 
			this.txtNoCus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtNoCus.Location = new System.Drawing.Point(176, 88);
			this.txtNoCus.Name = "txtNoCus";
			this.txtNoCus.Size = new System.Drawing.Size(88, 23);
			this.txtNoCus.TabIndex = 20;
			this.txtNoCus.Text = "";
			this.txtNoCus.TextChanged += new System.EventHandler(this.txtNoCus_TextChanged);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(16, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 23);
			this.label2.TabIndex = 19;
			this.label2.Text = "no. of Customers :";
			// 
			// groupBoxCusDetails
			// 
			this.groupBoxCusDetails.Controls.AddRange(new System.Windows.Forms.Control[] {
																							 this.cmbCusHol,
																							 this.txtCusId,
																							 this.lblCusDetails,
																							 this.label5,
																							 this.btnNextCus,
																							 this.label6});
			this.groupBoxCusDetails.ForeColor = System.Drawing.Color.Blue;
			this.groupBoxCusDetails.Location = new System.Drawing.Point(24, 280);
			this.groupBoxCusDetails.Name = "groupBoxCusDetails";
			this.groupBoxCusDetails.Size = new System.Drawing.Size(280, 168);
			this.groupBoxCusDetails.TabIndex = 21;
			this.groupBoxCusDetails.TabStop = false;
			this.groupBoxCusDetails.Visible = false;
			// 
			// cmbCusHol
			// 
			this.cmbCusHol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCusHol.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbCusHol.Items.AddRange(new object[] {
														   "-- No Day --",
														   "Sunday",
														   "Monday",
														   "Tuesday",
														   "Wednesday",
														   "Thursday",
														   "Friday",
														   "Saturday"});
			this.cmbCusHol.Location = new System.Drawing.Point(128, 96);
			this.cmbCusHol.Name = "cmbCusHol";
			this.cmbCusHol.Size = new System.Drawing.Size(136, 24);
			this.cmbCusHol.TabIndex = 60;
			// 
			// txtCusId
			// 
			this.txtCusId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtCusId.Location = new System.Drawing.Point(176, 56);
			this.txtCusId.Name = "txtCusId";
			this.txtCusId.Size = new System.Drawing.Size(88, 23);
			this.txtCusId.TabIndex = 25;
			this.txtCusId.Text = "";
			this.txtCusId.TextChanged += new System.EventHandler(this.txtCusId_TextChanged);
			// 
			// lblCusDetails
			// 
			this.lblCusDetails.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblCusDetails.ForeColor = System.Drawing.Color.Crimson;
			this.lblCusDetails.Location = new System.Drawing.Point(48, 16);
			this.lblCusDetails.Name = "lblCusDetails";
			this.lblCusDetails.Size = new System.Drawing.Size(192, 23);
			this.lblCusDetails.TabIndex = 24;
			this.lblCusDetails.Text = "For Type 1 ,Cus 1 :";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(8, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(168, 23);
			this.label5.TabIndex = 22;
			this.label5.Text = "Customer Name/ID :";
			// 
			// btnNextCus
			// 
			this.btnNextCus.Enabled = false;
			this.btnNextCus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnNextCus.ForeColor = System.Drawing.Color.DarkMagenta;
			this.btnNextCus.Location = new System.Drawing.Point(184, 136);
			this.btnNextCus.Name = "btnNextCus";
			this.btnNextCus.TabIndex = 21;
			this.btnNextCus.Text = "N&ext";
			this.btnNextCus.Click += new System.EventHandler(this.btnNextCus_Click);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Blue;
			this.label6.Location = new System.Drawing.Point(8, 88);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 48);
			this.label6.TabIndex = 19;
			this.label6.Text = "Customer Closure Day :";
			// 
			// dgPri
			// 
			this.dgPri.AlternatingBackColor = System.Drawing.Color.Lavender;
			this.dgPri.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dgPri.BackgroundColor = System.Drawing.Color.LightGray;
			this.dgPri.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgPri.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
			this.dgPri.CaptionForeColor = System.Drawing.Color.MidnightBlue;
			this.dgPri.CaptionText = "Priorities";
			this.dgPri.DataMember = "";
			this.dgPri.FlatMode = true;
			this.dgPri.Font = new System.Drawing.Font("Tahoma", 8F);
			this.dgPri.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dgPri.GridLineColor = System.Drawing.Color.Gainsboro;
			this.dgPri.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.dgPri.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dgPri.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.dgPri.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
			this.dgPri.LinkColor = System.Drawing.Color.Teal;
			this.dgPri.Location = new System.Drawing.Point(328, 88);
			this.dgPri.Name = "dgPri";
			this.dgPri.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
			this.dgPri.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dgPri.ReadOnly = true;
			this.dgPri.SelectionBackColor = System.Drawing.Color.CadetBlue;
			this.dgPri.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
			this.dgPri.Size = new System.Drawing.Size(344, 144);
			this.dgPri.TabIndex = 43;
			this.dgPri.Visible = false;
			this.dgPri.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dgPri_Navigate);
			// 
			// dgCus
			// 
			this.dgCus.AlternatingBackColor = System.Drawing.Color.LightGray;
			this.dgCus.BackColor = System.Drawing.Color.Gainsboro;
			this.dgCus.BackgroundColor = System.Drawing.Color.Silver;
			this.dgCus.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgCus.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
			this.dgCus.CaptionForeColor = System.Drawing.Color.MidnightBlue;
			this.dgCus.CaptionText = "Customers";
			this.dgCus.DataMember = "";
			this.dgCus.FlatMode = true;
			this.dgCus.Font = new System.Drawing.Font("Tahoma", 8F);
			this.dgCus.ForeColor = System.Drawing.Color.Black;
			this.dgCus.GridLineColor = System.Drawing.Color.DimGray;
			this.dgCus.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.dgCus.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dgCus.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.dgCus.HeaderForeColor = System.Drawing.Color.White;
			this.dgCus.LinkColor = System.Drawing.Color.MidnightBlue;
			this.dgCus.Location = new System.Drawing.Point(320, 264);
			this.dgCus.Name = "dgCus";
			this.dgCus.ParentRowsBackColor = System.Drawing.Color.DarkGray;
			this.dgCus.ParentRowsForeColor = System.Drawing.Color.Black;
			this.dgCus.ReadOnly = true;
			this.dgCus.SelectionBackColor = System.Drawing.Color.CadetBlue;
			this.dgCus.SelectionForeColor = System.Drawing.Color.White;
			this.dgCus.Size = new System.Drawing.Size(344, 224);
			this.dgCus.TabIndex = 44;
			this.dgCus.Visible = false;
			// 
			// grpMaxVis
			// 
			this.grpMaxVis.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.txtMaxVis,
																					this.label4});
			this.grpMaxVis.Location = new System.Drawing.Point(24, 504);
			this.grpMaxVis.Name = "grpMaxVis";
			this.grpMaxVis.Size = new System.Drawing.Size(496, 48);
			this.grpMaxVis.TabIndex = 45;
			this.grpMaxVis.TabStop = false;
			this.grpMaxVis.Visible = false;
			// 
			// txtMaxVis
			// 
			this.txtMaxVis.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtMaxVis.Location = new System.Drawing.Point(400, 16);
			this.txtMaxVis.MaxLength = 2;
			this.txtMaxVis.Name = "txtMaxVis";
			this.txtMaxVis.Size = new System.Drawing.Size(48, 23);
			this.txtMaxVis.TabIndex = 20;
			this.txtMaxVis.Text = "";
			this.txtMaxVis.TextChanged += new System.EventHandler(this.txtMaxVis_TextChanged);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(12, 13);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(364, 27);
			this.label4.TabIndex = 19;
			this.label4.Text = "Enter the Maximum no. of visits allowed in a day :";
			// 
			// btnNextForm
			// 
			this.btnNextForm.Enabled = false;
			this.btnNextForm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnNextForm.ForeColor = System.Drawing.Color.DarkMagenta;
			this.btnNextForm.Location = new System.Drawing.Point(568, 520);
			this.btnNextForm.Name = "btnNextForm";
			this.btnNextForm.Size = new System.Drawing.Size(96, 23);
			this.btnNextForm.TabIndex = 46;
			this.btnNextForm.Text = "Step 3 ->";
			this.btnNextForm.Click += new System.EventHandler(this.btnNextForm_Click);
			// 
			// CustomerTypes
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(696, 606);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnNextForm,
																		  this.grpMaxVis,
																		  this.dgCus,
																		  this.dgPri,
																		  this.groupBoxCusDetails,
																		  this.groupBoxForType,
																		  this.groupBoxPriNo});
			this.Name = "CustomerTypes";
			this.Text = "CustomerTypes";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.groupBoxPriNo.ResumeLayout(false);
			this.groupBoxForType.ResumeLayout(false);
			this.groupBoxCusDetails.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgPri)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgCus)).EndInit();
			this.grpMaxVis.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnDone_Click(object sender, System.EventArgs e)
		{
			try
			{
				int tmp = int.Parse(txtPriNo.Text);
				if(tmp<=0)
					MessageBox.Show (this,"Positive Numbers Only. (Not more than 99)");
				else
				{
					Form1.alloc.set_NPriorities (tmp);
					Form1.alloc.NCus = new int [Form1.alloc.NumTypes];
					Form1.alloc.NVis = new int [Form1.alloc.NumTypes];
					btnNextType.Enabled = true;
					txtPriNo.ReadOnly = true;
					groupBoxForType.Visible = true;
				}
			}
			catch
			{
				MessageBox.Show (this,"Enter Only Positive Number. (Not more than 99)");
			}
		}

		private void txtPriNo_TextChanged(object sender, System.EventArgs e)
		{
			if(txtPriNo.Text != "")
				btnDone.Enabled = true;
			else
				btnDone.Enabled = false;
		}

		private void btnNextType_Click(object sender, System.EventArgs e)
		{
			int tmp;
			try
			{
				 tmp = int.Parse(txtNoCus.Text);
				if(tmp<=0)
				{
					MessageBox.Show (this,"Enter only Positive Numbers");
					return;
				}
				Form1.alloc.NCus[index_cnt] = tmp;

			}
			catch 
			{
				MessageBox.Show (this,"Enter only Positive Numbers");
				return;
			}

			try
			{
				tmp = int.Parse(txtNoVis.Text);
				if(tmp<=0)
				{
					MessageBox.Show (this,"Enter only Positive Numbers");
					return;
				}

				Form1.alloc.NVis[index_cnt] = int.Parse (txtNoVis.Text);
			}
			catch 
			{
				MessageBox.Show (this,"Enter only Positive Numbers");
				return;
			}

			txtNoCus.Clear ();
			txtNoVis.Clear ();

			DataRow r1;
			r1 = tabPri.NewRow ();
			r1["#"] = index_cnt + 1;
			r1["Customers"] = Form1.alloc.NCus[index_cnt];
			r1["Visits"] = Form1.alloc.NVis[index_cnt];
			tabPri.Rows.Add (r1);
			dgPri.Refresh();
		
			if(index_cnt >= Form1.alloc.NumTypes-1 )
			{
				btnNextType.Enabled = false;
				txtNoCus.Enabled = false;
				txtNoVis.Enabled = false;
				groupBoxCusDetails.Visible = true;

				///<summary>
				///Here we find the Total no. of Customers.
				///and create so many Customer (Structures).
				///</summary>
				Form1.alloc.totCus = 0;
				for(int i=0;i<Form1.alloc.NumTypes;i++)
					Form1.alloc.totCus += Form1.alloc.NCus[i];
				Form1.customer = new Customer[Form1.alloc.totCus] ;
			}

			index_cnt++;
			if(index_cnt < Form1.alloc.NumTypes )
				lblType.Text = "For Type : " + (index_cnt+1);
			dgPri.Visible = true;
		}


		void setup_DataGrid()
		{
			DataColumn dcPriNo = new DataColumn ("#",typeof(int));
			DataColumn dcPriVis = new DataColumn ("Visits",typeof(int));
			DataColumn dcPriCus = new DataColumn ("Customers",typeof(int));
			tabPri.Columns.Add(dcPriNo);
			tabPri.Columns.Add(dcPriVis);
			tabPri.Columns.Add(dcPriCus);
			dsPri.Tables.Add (tabPri);
			dgPri.SetDataBinding (dsPri,"Priority");

			DataColumn dcCusNo = new DataColumn ("#",typeof(int));
			DataColumn dcCusType = new DataColumn("Type",typeof(int));
			DataColumn dcCusID = new DataColumn ("Name/Id",typeof(string));
			DataColumn dcCusClose = new DataColumn ("Closure Day",typeof(string));

			tabCus.Columns.Add(dcCusNo);
			tabCus.Columns.Add(dcCusType);
			tabCus.Columns.Add(dcCusID);
			tabCus.Columns.Add(dcCusClose);

			dsCus.Tables.Add (tabCus);
			dgCus.SetDataBinding (dsCus,"Customer");
		}

		private void btnNextCus_Click(object sender, System.EventArgs e)
		{
			dgCus.Visible = true;

			Form1.customer[index].cus_Id = txtCusId.Text;
			Form1.customer[index].cus_Hol = cmbCusHol.Text;
			Form1.customer[index].cus_Type = Form1.alloc.check_CusType(index) + 1;

			txtCusId.Clear ();

			DataRow r1;
			r1 = tabCus.NewRow ();
			r1["#"] = index + 1;
			r1["Name/Id"] = Form1.customer[index].cus_Id;
			r1["Closure Day"] = Form1.customer[index].cus_Hol;
			r1["Type"] = Form1.customer[index].cus_Type;
			tabCus.Rows.Add (r1);
			dgCus.Refresh();
		
			if(index >= Form1.alloc.totCus - 1)
			{
				btnNextCus.Enabled = false;
				txtCusId.Enabled = false;
				cmbCusHol.Enabled = false;
				grpMaxVis.Visible = true;
				return;
			}

			///<summary>
			///Here u should give "index + 1", so as to display the next Customer
			///type, in the label
			///</summary>.
			int tmp =Form1.alloc.check_CusType(index + 1);
			lblCusDetails.Text = "For Type " + (tmp + 1);
			int tmp1 = Form1.alloc.check_CusPosInType(index + 1);
			lblCusDetails.Text  += " , Customer " + (tmp1 + 1);

			index++;

		}

		private void txtCusId_TextChanged(object sender, System.EventArgs e)
		{
			if(txtCusId.Text == "" )
				btnNextCus.Enabled = false;
			else
				btnNextCus.Enabled = true;
		}

		private void txtNoVis_TextChanged(object sender, System.EventArgs e)
		{
			if(txtPriNo.Text == "" || txtNoVis.Text == "")
				btnNextType.Enabled = false;
			else
				btnNextType.Enabled = true;
		}

		private void txtNoCus_TextChanged(object sender, System.EventArgs e)
		{
			if(txtPriNo.Text == "" || txtNoVis.Text == "")
				btnNextType.Enabled = false;
			else
				btnNextType.Enabled = true;
		}

		private void dgPri_Navigate(object sender, System.Windows.Forms.NavigateEventArgs ne)
		{
		
		}

		private void txtMaxVis_TextChanged(object sender, System.EventArgs e)
		{
			if(txtMaxVis.Text.Trim() == "")
				btnNextForm.Enabled = false;
			else
				btnNextForm.Enabled = true;

		}

		private void btnNextForm_Click(object sender, System.EventArgs e)
		{
			try
			{
				int tmp = int.Parse (txtMaxVis.Text);
				if(tmp <= 0)
				{
					MessageBox.Show (this,"Enter Positive no.s greater than 0");
					return;
				}
				Form1.alloc.maxVisDay = tmp;
			}
			catch
			{
				MessageBox.Show (this,"Enter Positive no.s greater than 0");
				return;
			}

//			Result result = new Result();
//			result.MdiParent = this;
			Form1.result.Show();
		}

	}
}
