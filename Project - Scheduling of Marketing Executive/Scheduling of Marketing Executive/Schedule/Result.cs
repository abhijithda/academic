using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
 
namespace Schedule
{
	/// <summary>
	/// Summary description for Result.
	/// </summary>
	public class Result : System.Windows.Forms.Form
	{

		public DataSet dsRes = new DataSet("Result");
		public DataTable tabRes = new DataTable ("Result");
		public System.Windows.Forms.DataGrid dgRes;
		private System.Windows.Forms.GroupBox grpDetails;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblSymbols;
		private System.Windows.Forms.Button btnShowRes;
		private System.Windows.Forms.Label selAlgolbl;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Result()
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
			this.dgRes = new System.Windows.Forms.DataGrid();
			this.grpDetails = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblSymbols = new System.Windows.Forms.Label();
			this.btnShowRes = new System.Windows.Forms.Button();
			this.selAlgolbl = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgRes)).BeginInit();
			this.grpDetails.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgRes
			// 
			this.dgRes.AllowDrop = true;
			this.dgRes.AllowSorting = false;
			this.dgRes.DataMember = "";
			this.dgRes.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgRes.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgRes.Name = "dgRes";
			this.dgRes.ReadOnly = true;
			this.dgRes.Size = new System.Drawing.Size(752, 320);
			this.dgRes.TabIndex = 0;
			// 
			// grpDetails
			// 
			this.grpDetails.BackColor = System.Drawing.Color.YellowGreen;
			this.grpDetails.Controls.AddRange(new System.Windows.Forms.Control[] {
																					 this.label4,
																					 this.label3,
																					 this.label2,
																					 this.label1,
																					 this.lblSymbols});
			this.grpDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.grpDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grpDetails.Location = new System.Drawing.Point(0, 350);
			this.grpDetails.Name = "grpDetails";
			this.grpDetails.Size = new System.Drawing.Size(752, 104);
			this.grpDetails.TabIndex = 1;
			this.grpDetails.TabStop = false;
			this.grpDetails.Tag = "";
			this.grpDetails.Text = "Captions";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Crimson;
			this.label4.Location = new System.Drawing.Point(208, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(240, 16);
			this.label4.TabIndex = 34;
			this.label4.Text = "W : Customers Weekly Holiday";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Crimson;
			this.label3.Location = new System.Drawing.Point(40, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(160, 16);
			this.label3.TabIndex = 33;
			this.label3.Text = "H : Head Office Visit";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Crimson;
			this.label2.Location = new System.Drawing.Point(208, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(224, 16);
			this.label2.TabIndex = 32;
			this.label2.Text = "C : Company Weekly Holiday";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Crimson;
			this.label1.Location = new System.Drawing.Point(464, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 16);
			this.label1.TabIndex = 31;
			this.label1.Text = "G : General Holidays";
			// 
			// lblSymbols
			// 
			this.lblSymbols.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblSymbols.ForeColor = System.Drawing.Color.Crimson;
			this.lblSymbols.Location = new System.Drawing.Point(40, 16);
			this.lblSymbols.Name = "lblSymbols";
			this.lblSymbols.Size = new System.Drawing.Size(160, 16);
			this.lblSymbols.TabIndex = 30;
			this.lblSymbols.Text = "A : Allocated";
			// 
			// btnShowRes
			// 
			this.btnShowRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnShowRes.Location = new System.Drawing.Point(456, 328);
			this.btnShowRes.Name = "btnShowRes";
			this.btnShowRes.Size = new System.Drawing.Size(184, 23);
			this.btnShowRes.TabIndex = 2;
			this.btnShowRes.Text = "Show Results";
			this.btnShowRes.Click += new System.EventHandler(this.btnShowRes_Click);
			// 
			// selAlgolbl
			// 
			this.selAlgolbl.BackColor = System.Drawing.Color.YellowGreen;
			this.selAlgolbl.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.selAlgolbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.selAlgolbl.Location = new System.Drawing.Point(0, 326);
			this.selAlgolbl.Name = "selAlgolbl";
			this.selAlgolbl.Size = new System.Drawing.Size(752, 24);
			this.selAlgolbl.TabIndex = 3;
			// 
			// Result
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.YellowGreen;
			this.ClientSize = new System.Drawing.Size(752, 454);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnShowRes,
																		  this.selAlgolbl,
																		  this.grpDetails,
																		  this.dgRes});
			this.Name = "Result";
			this.Text = "Result";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Result_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgRes)).EndInit();
			this.grpDetails.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Result_Load(object sender, System.EventArgs e)
		{
			Form1.eval.Hide();
			if (Form1.alloc.schedule_customers())
			{
				setup_DataGrid();
				Form1.alloc.display_result();
			}
			switch(Form1.alloc.first_rank)
			{
				case 1:
					selAlgolbl.Text= "Heuristic: Systematic Approach.";
					break;

				case 2:
					selAlgolbl.Text= "Heuristic: First Day First Customer Approach.";
					break;

				case 3:
					selAlgolbl.Text= "Heuristic: Last Day First Customer Approach.";
					break;

				case 4:
					selAlgolbl.Text= "Heuristic: Random Days Approach.";
					break;

				case 5:
					selAlgolbl.Text= "Heuristic: Random Customers Approach.";
					break;

				case 6:
					selAlgolbl.Text= "Heuristic: Complete Random Approach.";
					break;
			}
		}

		void setup_DataGrid()
		{
			int i;
			for(i=0;i<Form1.alloc.totDays ;i++)
			{
				DataColumn dcRes = new DataColumn ((Form1.alloc.sdte.AddDays(i).ToString("d") ),typeof(string));
				tabRes.Columns.Add(dcRes);
			}
			///<summary>
			///Add total no. of customer visits for each day.
			///</summary>

			DataColumn dcRes1 = new DataColumn ("Total Visits/Day",typeof(string));
			tabRes.Columns.Add(dcRes1);

			dsRes.Tables.Add (tabRes);
			dgRes.SetDataBinding (dsRes,"Result");
		}

		private void btnShowRes_Click(object sender, System.EventArgs e)
		{
			HiddenResults h = new HiddenResults ();
			h.Show();
			h.Focus();
		}


//		private void btnExcel_Click(object sender, System.EventArgs e)
//		{
//			string Response;
//			Response.Clear();
//			Response.Buffer= true;
//			Response.ContentType = "application/vnd.ms-excel";
//			Response.Charset = "";
//			this.EnableViewState = false;
//
//			System.IO.StringWriter oStringWriter = new System.IO.StringWriter();
//			System.Web.UI.HtmlTextWriter oHtmlTextWriter = new System.Web.UI.HtmlTextWriter(oStringWriter);
//				
//			//this.ClearControls(DataGrid1);
//			dgRes.RenderControl(oHtmlTextWriter);
//			Response.Write(oStringWriter.ToString());
//			Response.End();
//		}

	}
}
