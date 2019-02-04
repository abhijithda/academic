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
		private System.Windows.Forms.Label lblSymbols;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
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
			this.lblSymbols = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgRes)).BeginInit();
			this.SuspendLayout();
			// 
			// dgRes
			// 
			this.dgRes.AllowSorting = false;
			this.dgRes.DataMember = "";
			this.dgRes.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgRes.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgRes.Name = "dgRes";
			this.dgRes.ReadOnly = true;
			this.dgRes.Size = new System.Drawing.Size(640, 296);
			this.dgRes.TabIndex = 0;
			// 
			// lblSymbols
			// 
			this.lblSymbols.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblSymbols.ForeColor = System.Drawing.Color.Crimson;
			this.lblSymbols.Location = new System.Drawing.Point(24, 320);
			this.lblSymbols.Name = "lblSymbols";
			this.lblSymbols.Size = new System.Drawing.Size(160, 16);
			this.lblSymbols.TabIndex = 25;
			this.lblSymbols.Text = "A : Allocated";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Crimson;
			this.label1.Location = new System.Drawing.Point(432, 320);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 16);
			this.label1.TabIndex = 26;
			this.label1.Text = "G : General Holidays";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Crimson;
			this.label2.Location = new System.Drawing.Point(192, 320);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(224, 16);
			this.label2.TabIndex = 27;
			this.label2.Text = "C : Company Weekly Holiday";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Crimson;
			this.label3.Location = new System.Drawing.Point(24, 352);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(160, 16);
			this.label3.TabIndex = 28;
			this.label3.Text = "H : Head Office Visit";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Crimson;
			this.label4.Location = new System.Drawing.Point(192, 352);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(240, 16);
			this.label4.TabIndex = 29;
			this.label4.Text = "W : Customers Weekly Holiday";
			// 
			// Result
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.YellowGreen;
			this.ClientSize = new System.Drawing.Size(640, 382);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label4,
																		  this.label3,
																		  this.label2,
																		  this.label1,
																		  this.lblSymbols,
																		  this.dgRes});
			this.Name = "Result";
			this.Text = "Result";
			this.Load += new System.EventHandler(this.Result_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgRes)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Result_Load(object sender, System.EventArgs e)
		{
			if (Form1.alloc.schedule_customers())
			{
				setup_DataGrid();
				Form1.alloc.display_result();
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
			dsRes.Tables.Add (tabRes);
			dgRes.SetDataBinding (dsRes,"Result");
		}

	}
}
