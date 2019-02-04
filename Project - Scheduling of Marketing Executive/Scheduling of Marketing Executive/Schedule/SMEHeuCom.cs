using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Schedule
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class SMEHeuCom : System.Windows.Forms.Form 
	{
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		int count=0;
		public AlgosTest c;
		public int sample_input_count;
		private int [] penaltyAlgo1;
		private int [] penaltyAlgo2;
		private int [] penaltyAlgo3;
		private int [] penaltyAlgo4;
		private int [] penaltyAlgo5;
		private int [] penaltyAlgo6;

		private int [] best_heuristic_solution;

		private double [] rd_Algo1;
		private double [] rd_Algo2;
		private double [] rd_Algo3;
		private double [] rd_Algo4;
		private double [] rd_Algo5;
		private double [] rd_Algo6;

		private double maxrd_Algo1;
		private double maxrd_Algo2;
		private double maxrd_Algo3;
		private double maxrd_Algo4;
		private double maxrd_Algo5;
		private double maxrd_Algo6;

		private double avgrd_Algo1;
		private double avgrd_Algo2;
		private double avgrd_Algo3;
		private double avgrd_Algo4;
		private double avgrd_Algo5;
		private double avgrd_Algo6;

		private double [] temp;

		private int [] rank_Algo1;
		private int [] rank_Algo2;
		private int [] rank_Algo3;
		private int [] rank_Algo4;
		private int [] rank_Algo5;
		private int [] rank_Algo6;

		private int [] rank_count_Algo1;
		private int [] rank_count_Algo2;
		private int [] rank_count_Algo3;
		private int [] rank_count_Algo4;
		private int [] rank_count_Algo5;
		private int [] rank_count_Algo6;

		private double weighted_avg_Algo1;
		private double weighted_avg_Algo2;
		private double weighted_avg_Algo3;
		private double weighted_avg_Algo4;
		private double weighted_avg_Algo5;
		private double weighted_avg_Algo6;

		private double avg_rank_Algo1;
		private double avg_rank_Algo2;
		private double avg_rank_Algo3;
		private double avg_rank_Algo4;
		private double avg_rank_Algo5;
		private double avg_rank_Algo6;


		private System.ComponentModel.IContainer components;

		private int penalty_avg_algo1,penalty_avg_algo2,penalty_avg_algo3,penalty_avg_algo4,penalty_avg_algo5,penalty_avg_algo6;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.Label label4;
		public System.Windows.Forms.Label label5;
		public System.Windows.Forms.Label label6;
		public System.Windows.Forms.TextBox t1;
		public System.Windows.Forms.TextBox t2;
		public System.Windows.Forms.TextBox t3;
		public System.Windows.Forms.TextBox t4;
		public System.Windows.Forms.TextBox t5;
		public System.Windows.Forms.TextBox t6;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		public System.Windows.Forms.TextBox ard4;
		public System.Windows.Forms.TextBox ard2;
		public System.Windows.Forms.TextBox ard1;
		public System.Windows.Forms.TextBox ard5;
		public System.Windows.Forms.TextBox ard3;
		public System.Windows.Forms.TextBox ard6;
		public System.Windows.Forms.TextBox mrd4;
		public System.Windows.Forms.TextBox mrd2;
		public System.Windows.Forms.TextBox mrd1;
		public System.Windows.Forms.TextBox mrd5;
		public System.Windows.Forms.TextBox mrd3;
		public System.Windows.Forms.TextBox mrd6;
		public System.Windows.Forms.TextBox ar4;
		public System.Windows.Forms.TextBox ar2;
		public System.Windows.Forms.TextBox ar1;
		public System.Windows.Forms.TextBox ar5;
		public System.Windows.Forms.TextBox ar3;
		public System.Windows.Forms.TextBox ar6;
		public System.Windows.Forms.TextBox wa4;
		public System.Windows.Forms.TextBox wa2;
		public System.Windows.Forms.TextBox wa1;
		public System.Windows.Forms.TextBox wa5;
		public System.Windows.Forms.TextBox wa3;
		public System.Windows.Forms.TextBox wa6;
		private System.Windows.Forms.GroupBox groupBox6;
		public System.Windows.Forms.TextBox ep4;
		public System.Windows.Forms.TextBox ep2;
		public System.Windows.Forms.TextBox ep1;
		public System.Windows.Forms.TextBox ep5;
		public System.Windows.Forms.TextBox ep3;
		public System.Windows.Forms.TextBox ep6;
		private System.Windows.Forms.Label selAlgolbl;
		public System.Windows.Forms.Label label8;
		public System.Windows.Forms.Label label9;
		public System.Windows.Forms.Label label10;
		public System.Windows.Forms.Label label11;
		public System.Windows.Forms.Label label12;
		public System.Windows.Forms.Label label13;
		public System.Windows.Forms.Label label14;
		public System.Windows.Forms.Label label15;
		public System.Windows.Forms.Label label16;
		public System.Windows.Forms.Label label18;
		public System.Windows.Forms.Label label19;
		public System.Windows.Forms.Label label35;
		public System.Windows.Forms.Label label29;
		public System.Windows.Forms.Label label32;
		public System.Windows.Forms.Label label33;
		public System.Windows.Forms.Label label34;
		public System.Windows.Forms.Label label36;
		public System.Windows.Forms.Label label37;
		public System.Windows.Forms.Label label23;
		public System.Windows.Forms.Label label26;
		public System.Windows.Forms.Label label27;
		public System.Windows.Forms.Label label28;
		public System.Windows.Forms.Label label30;
		public System.Windows.Forms.Label label31;
		public System.Windows.Forms.Label label17;
		public System.Windows.Forms.Label label20;
		public System.Windows.Forms.Label label21;
		public System.Windows.Forms.Label label22;
		public System.Windows.Forms.Label label24;
		public System.Windows.Forms.Label label25;
		public System.Windows.Forms.Label label7;


		public SMEHeuCom()
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
			this.label1 = new System.Windows.Forms.Label();
			this.t1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.t2 = new System.Windows.Forms.TextBox();
			this.t3 = new System.Windows.Forms.TextBox();
			this.t4 = new System.Windows.Forms.TextBox();
			this.t5 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.t6 = new System.Windows.Forms.TextBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.ard4 = new System.Windows.Forms.TextBox();
			this.ard2 = new System.Windows.Forms.TextBox();
			this.ard1 = new System.Windows.Forms.TextBox();
			this.ard5 = new System.Windows.Forms.TextBox();
			this.ard3 = new System.Windows.Forms.TextBox();
			this.ard6 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.mrd4 = new System.Windows.Forms.TextBox();
			this.mrd2 = new System.Windows.Forms.TextBox();
			this.mrd1 = new System.Windows.Forms.TextBox();
			this.mrd5 = new System.Windows.Forms.TextBox();
			this.mrd3 = new System.Windows.Forms.TextBox();
			this.mrd6 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.ar4 = new System.Windows.Forms.TextBox();
			this.ar2 = new System.Windows.Forms.TextBox();
			this.ar1 = new System.Windows.Forms.TextBox();
			this.ar5 = new System.Windows.Forms.TextBox();
			this.ar3 = new System.Windows.Forms.TextBox();
			this.ar6 = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.wa4 = new System.Windows.Forms.TextBox();
			this.wa2 = new System.Windows.Forms.TextBox();
			this.wa1 = new System.Windows.Forms.TextBox();
			this.wa5 = new System.Windows.Forms.TextBox();
			this.wa3 = new System.Windows.Forms.TextBox();
			this.wa6 = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.ep4 = new System.Windows.Forms.TextBox();
			this.ep2 = new System.Windows.Forms.TextBox();
			this.ep1 = new System.Windows.Forms.TextBox();
			this.ep5 = new System.Windows.Forms.TextBox();
			this.ep3 = new System.Windows.Forms.TextBox();
			this.ep6 = new System.Windows.Forms.TextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.label37 = new System.Windows.Forms.Label();
			this.selAlgolbl = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(816, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Heuristics Comparision";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// t1
			// 
			this.t1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.t1.ForeColor = System.Drawing.Color.Blue;
			this.t1.Location = new System.Drawing.Point(176, 24);
			this.t1.MaxLength = 5;
			this.t1.Name = "t1";
			this.t1.ReadOnly = true;
			this.t1.Size = new System.Drawing.Size(56, 23);
			this.t1.TabIndex = 1;
			this.t1.Text = "";
			this.t1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Black;
			this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Yellow;
			this.label2.Location = new System.Drawing.Point(8, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(176, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Systematic Method";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Lime;
			this.button1.Location = new System.Drawing.Point(56, 48);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 24);
			this.button1.TabIndex = 10;
			this.button1.Text = "Evaluate";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Black;
			this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Yellow;
			this.label3.Location = new System.Drawing.Point(8, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(176, 16);
			this.label3.TabIndex = 11;
			this.label3.Text = "First Day First Customer";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Black;
			this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Yellow;
			this.label4.Location = new System.Drawing.Point(8, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(176, 16);
			this.label4.TabIndex = 12;
			this.label4.Text = "Last Day First Customer";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Black;
			this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Yellow;
			this.label5.Location = new System.Drawing.Point(8, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(176, 16);
			this.label5.TabIndex = 13;
			this.label5.Text = "Random Days";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Black;
			this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Yellow;
			this.label6.Location = new System.Drawing.Point(8, 120);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(176, 16);
			this.label6.TabIndex = 14;
			this.label6.Text = "Random Customers";
			// 
			// t2
			// 
			this.t2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.t2.ForeColor = System.Drawing.Color.Blue;
			this.t2.Location = new System.Drawing.Point(176, 48);
			this.t2.MaxLength = 5;
			this.t2.Name = "t2";
			this.t2.ReadOnly = true;
			this.t2.Size = new System.Drawing.Size(56, 23);
			this.t2.TabIndex = 15;
			this.t2.Text = "";
			this.t2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// t3
			// 
			this.t3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.t3.ForeColor = System.Drawing.Color.Blue;
			this.t3.Location = new System.Drawing.Point(176, 72);
			this.t3.MaxLength = 5;
			this.t3.Name = "t3";
			this.t3.ReadOnly = true;
			this.t3.Size = new System.Drawing.Size(56, 23);
			this.t3.TabIndex = 16;
			this.t3.Text = "";
			this.t3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// t4
			// 
			this.t4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.t4.ForeColor = System.Drawing.Color.Blue;
			this.t4.Location = new System.Drawing.Point(176, 96);
			this.t4.MaxLength = 5;
			this.t4.Name = "t4";
			this.t4.ReadOnly = true;
			this.t4.Size = new System.Drawing.Size(56, 23);
			this.t4.TabIndex = 17;
			this.t4.Text = "";
			this.t4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// t5
			// 
			this.t5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.t5.ForeColor = System.Drawing.Color.Blue;
			this.t5.Location = new System.Drawing.Point(176, 120);
			this.t5.MaxLength = 5;
			this.t5.Name = "t5";
			this.t5.ReadOnly = true;
			this.t5.Size = new System.Drawing.Size(56, 23);
			this.t5.TabIndex = 18;
			this.t5.Text = "";
			this.t5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Black;
			this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Yellow;
			this.label7.Location = new System.Drawing.Point(8, 144);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(176, 16);
			this.label7.TabIndex = 19;
			this.label7.Text = "Complete Random";
			// 
			// t6
			// 
			this.t6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.t6.ForeColor = System.Drawing.Color.Blue;
			this.t6.Location = new System.Drawing.Point(176, 144);
			this.t6.MaxLength = 5;
			this.t6.Name = "t6";
			this.t6.ReadOnly = true;
			this.t6.Size = new System.Drawing.Size(56, 23);
			this.t6.TabIndex = 20;
			this.t6.Text = "";
			this.t6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(200, 56);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(296, 16);
			this.progressBar1.TabIndex = 23;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.t4,
																					this.t2,
																					this.t1,
																					this.t5,
																					this.t3,
																					this.t6,
																					this.label5,
																					this.label6,
																					this.label2,
																					this.label3,
																					this.label7,
																					this.label4});
			this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.Lime;
			this.groupBox1.Location = new System.Drawing.Point(24, 104);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(240, 176);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Avg Penalty";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.ard4,
																					this.ard2,
																					this.ard1,
																					this.ard5,
																					this.ard3,
																					this.ard6,
																					this.label8,
																					this.label9,
																					this.label10,
																					this.label11,
																					this.label12,
																					this.label13});
			this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.Lime;
			this.groupBox2.Location = new System.Drawing.Point(280, 104);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(240, 176);
			this.groupBox2.TabIndex = 25;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Avg Relative Deviation";
			// 
			// ard4
			// 
			this.ard4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ard4.ForeColor = System.Drawing.Color.Blue;
			this.ard4.Location = new System.Drawing.Point(176, 96);
			this.ard4.MaxLength = 5;
			this.ard4.Name = "ard4";
			this.ard4.ReadOnly = true;
			this.ard4.Size = new System.Drawing.Size(56, 23);
			this.ard4.TabIndex = 17;
			this.ard4.Text = "";
			this.ard4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ard2
			// 
			this.ard2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ard2.ForeColor = System.Drawing.Color.Blue;
			this.ard2.Location = new System.Drawing.Point(176, 48);
			this.ard2.MaxLength = 5;
			this.ard2.Name = "ard2";
			this.ard2.ReadOnly = true;
			this.ard2.Size = new System.Drawing.Size(56, 23);
			this.ard2.TabIndex = 15;
			this.ard2.Text = "";
			this.ard2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ard1
			// 
			this.ard1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ard1.ForeColor = System.Drawing.Color.Blue;
			this.ard1.Location = new System.Drawing.Point(176, 24);
			this.ard1.MaxLength = 5;
			this.ard1.Name = "ard1";
			this.ard1.ReadOnly = true;
			this.ard1.Size = new System.Drawing.Size(56, 23);
			this.ard1.TabIndex = 1;
			this.ard1.Text = "";
			this.ard1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ard5
			// 
			this.ard5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ard5.ForeColor = System.Drawing.Color.Blue;
			this.ard5.Location = new System.Drawing.Point(176, 120);
			this.ard5.MaxLength = 5;
			this.ard5.Name = "ard5";
			this.ard5.ReadOnly = true;
			this.ard5.Size = new System.Drawing.Size(56, 23);
			this.ard5.TabIndex = 18;
			this.ard5.Text = "";
			this.ard5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ard3
			// 
			this.ard3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ard3.ForeColor = System.Drawing.Color.Blue;
			this.ard3.Location = new System.Drawing.Point(176, 72);
			this.ard3.MaxLength = 5;
			this.ard3.Name = "ard3";
			this.ard3.ReadOnly = true;
			this.ard3.Size = new System.Drawing.Size(56, 23);
			this.ard3.TabIndex = 16;
			this.ard3.Text = "";
			this.ard3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ard6
			// 
			this.ard6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ard6.ForeColor = System.Drawing.Color.Blue;
			this.ard6.Location = new System.Drawing.Point(176, 144);
			this.ard6.MaxLength = 5;
			this.ard6.Name = "ard6";
			this.ard6.ReadOnly = true;
			this.ard6.Size = new System.Drawing.Size(56, 23);
			this.ard6.TabIndex = 20;
			this.ard6.Text = "";
			this.ard6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Black;
			this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Yellow;
			this.label8.Location = new System.Drawing.Point(8, 96);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(176, 16);
			this.label8.TabIndex = 24;
			this.label8.Text = "Random Days";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Black;
			this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Yellow;
			this.label9.Location = new System.Drawing.Point(8, 120);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(176, 16);
			this.label9.TabIndex = 25;
			this.label9.Text = "Random Customers";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Black;
			this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Yellow;
			this.label10.Location = new System.Drawing.Point(8, 24);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(176, 16);
			this.label10.TabIndex = 21;
			this.label10.Text = "Systematic Method";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Black;
			this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Yellow;
			this.label11.Location = new System.Drawing.Point(8, 48);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(176, 16);
			this.label11.TabIndex = 22;
			this.label11.Text = "First Day First Customer";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Black;
			this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Yellow;
			this.label12.Location = new System.Drawing.Point(8, 144);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(176, 16);
			this.label12.TabIndex = 26;
			this.label12.Text = "Complete Random";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Black;
			this.label13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Yellow;
			this.label13.Location = new System.Drawing.Point(8, 72);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(176, 16);
			this.label13.TabIndex = 23;
			this.label13.Text = "Last Day First Customer";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.mrd4,
																					this.mrd2,
																					this.mrd1,
																					this.mrd5,
																					this.mrd3,
																					this.mrd6,
																					this.label14,
																					this.label15,
																					this.label16,
																					this.label18,
																					this.label19,
																					this.label35});
			this.groupBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox3.ForeColor = System.Drawing.Color.Lime;
			this.groupBox3.Location = new System.Drawing.Point(536, 104);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(256, 176);
			this.groupBox3.TabIndex = 26;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Max Relative Deviation";
			// 
			// mrd4
			// 
			this.mrd4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mrd4.ForeColor = System.Drawing.Color.Blue;
			this.mrd4.Location = new System.Drawing.Point(184, 96);
			this.mrd4.MaxLength = 5;
			this.mrd4.Name = "mrd4";
			this.mrd4.ReadOnly = true;
			this.mrd4.Size = new System.Drawing.Size(56, 23);
			this.mrd4.TabIndex = 17;
			this.mrd4.Text = "";
			this.mrd4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// mrd2
			// 
			this.mrd2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mrd2.ForeColor = System.Drawing.Color.Blue;
			this.mrd2.Location = new System.Drawing.Point(184, 48);
			this.mrd2.MaxLength = 5;
			this.mrd2.Name = "mrd2";
			this.mrd2.ReadOnly = true;
			this.mrd2.Size = new System.Drawing.Size(56, 23);
			this.mrd2.TabIndex = 15;
			this.mrd2.Text = "";
			this.mrd2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// mrd1
			// 
			this.mrd1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mrd1.ForeColor = System.Drawing.Color.Blue;
			this.mrd1.Location = new System.Drawing.Point(184, 24);
			this.mrd1.MaxLength = 5;
			this.mrd1.Name = "mrd1";
			this.mrd1.ReadOnly = true;
			this.mrd1.Size = new System.Drawing.Size(56, 23);
			this.mrd1.TabIndex = 1;
			this.mrd1.Text = "";
			this.mrd1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// mrd5
			// 
			this.mrd5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mrd5.ForeColor = System.Drawing.Color.Blue;
			this.mrd5.Location = new System.Drawing.Point(184, 120);
			this.mrd5.MaxLength = 5;
			this.mrd5.Name = "mrd5";
			this.mrd5.ReadOnly = true;
			this.mrd5.Size = new System.Drawing.Size(56, 23);
			this.mrd5.TabIndex = 18;
			this.mrd5.Text = "";
			this.mrd5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// mrd3
			// 
			this.mrd3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mrd3.ForeColor = System.Drawing.Color.Blue;
			this.mrd3.Location = new System.Drawing.Point(184, 72);
			this.mrd3.MaxLength = 5;
			this.mrd3.Name = "mrd3";
			this.mrd3.ReadOnly = true;
			this.mrd3.Size = new System.Drawing.Size(56, 23);
			this.mrd3.TabIndex = 16;
			this.mrd3.Text = "";
			this.mrd3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// mrd6
			// 
			this.mrd6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mrd6.ForeColor = System.Drawing.Color.Blue;
			this.mrd6.Location = new System.Drawing.Point(184, 144);
			this.mrd6.MaxLength = 5;
			this.mrd6.Name = "mrd6";
			this.mrd6.ReadOnly = true;
			this.mrd6.Size = new System.Drawing.Size(56, 23);
			this.mrd6.TabIndex = 20;
			this.mrd6.Text = "";
			this.mrd6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Black;
			this.label14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Yellow;
			this.label14.Location = new System.Drawing.Point(8, 96);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(176, 16);
			this.label14.TabIndex = 24;
			this.label14.Text = "Random Days";
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Black;
			this.label15.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.Yellow;
			this.label15.Location = new System.Drawing.Point(8, 120);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(176, 16);
			this.label15.TabIndex = 25;
			this.label15.Text = "Random Customers";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Black;
			this.label16.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.Yellow;
			this.label16.Location = new System.Drawing.Point(8, 24);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(176, 16);
			this.label16.TabIndex = 21;
			this.label16.Text = "Systematic Method";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Black;
			this.label18.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label18.ForeColor = System.Drawing.Color.Yellow;
			this.label18.Location = new System.Drawing.Point(8, 48);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(176, 16);
			this.label18.TabIndex = 22;
			this.label18.Text = "First Day First Customer";
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Black;
			this.label19.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label19.ForeColor = System.Drawing.Color.Yellow;
			this.label19.Location = new System.Drawing.Point(8, 144);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(176, 16);
			this.label19.TabIndex = 26;
			this.label19.Text = "Complete Random";
			// 
			// label35
			// 
			this.label35.BackColor = System.Drawing.Color.Black;
			this.label35.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label35.ForeColor = System.Drawing.Color.Yellow;
			this.label35.Location = new System.Drawing.Point(8, 72);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(176, 16);
			this.label35.TabIndex = 23;
			this.label35.Text = "Last Day First Customer";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.ar4,
																					this.ar2,
																					this.ar1,
																					this.ar5,
																					this.ar3,
																					this.ar6,
																					this.label17,
																					this.label20,
																					this.label21,
																					this.label22,
																					this.label24,
																					this.label25});
			this.groupBox4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox4.ForeColor = System.Drawing.Color.Lime;
			this.groupBox4.Location = new System.Drawing.Point(24, 296);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(240, 176);
			this.groupBox4.TabIndex = 27;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Avg Ranking";
			// 
			// ar4
			// 
			this.ar4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ar4.ForeColor = System.Drawing.Color.Blue;
			this.ar4.Location = new System.Drawing.Point(176, 96);
			this.ar4.MaxLength = 5;
			this.ar4.Name = "ar4";
			this.ar4.ReadOnly = true;
			this.ar4.Size = new System.Drawing.Size(56, 23);
			this.ar4.TabIndex = 17;
			this.ar4.Text = "";
			this.ar4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ar2
			// 
			this.ar2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ar2.ForeColor = System.Drawing.Color.Blue;
			this.ar2.Location = new System.Drawing.Point(176, 48);
			this.ar2.MaxLength = 5;
			this.ar2.Name = "ar2";
			this.ar2.ReadOnly = true;
			this.ar2.Size = new System.Drawing.Size(56, 23);
			this.ar2.TabIndex = 15;
			this.ar2.Text = "";
			this.ar2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ar1
			// 
			this.ar1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ar1.ForeColor = System.Drawing.Color.Blue;
			this.ar1.Location = new System.Drawing.Point(176, 24);
			this.ar1.MaxLength = 5;
			this.ar1.Name = "ar1";
			this.ar1.ReadOnly = true;
			this.ar1.Size = new System.Drawing.Size(56, 23);
			this.ar1.TabIndex = 1;
			this.ar1.Text = "";
			this.ar1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ar5
			// 
			this.ar5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ar5.ForeColor = System.Drawing.Color.Blue;
			this.ar5.Location = new System.Drawing.Point(176, 120);
			this.ar5.MaxLength = 5;
			this.ar5.Name = "ar5";
			this.ar5.ReadOnly = true;
			this.ar5.Size = new System.Drawing.Size(56, 23);
			this.ar5.TabIndex = 18;
			this.ar5.Text = "";
			this.ar5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ar3
			// 
			this.ar3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ar3.ForeColor = System.Drawing.Color.Blue;
			this.ar3.Location = new System.Drawing.Point(176, 72);
			this.ar3.MaxLength = 5;
			this.ar3.Name = "ar3";
			this.ar3.ReadOnly = true;
			this.ar3.Size = new System.Drawing.Size(56, 23);
			this.ar3.TabIndex = 16;
			this.ar3.Text = "";
			this.ar3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ar6
			// 
			this.ar6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ar6.ForeColor = System.Drawing.Color.Blue;
			this.ar6.Location = new System.Drawing.Point(176, 144);
			this.ar6.MaxLength = 5;
			this.ar6.Name = "ar6";
			this.ar6.ReadOnly = true;
			this.ar6.Size = new System.Drawing.Size(56, 23);
			this.ar6.TabIndex = 20;
			this.ar6.Text = "";
			this.ar6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Black;
			this.label17.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label17.ForeColor = System.Drawing.Color.Yellow;
			this.label17.Location = new System.Drawing.Point(8, 96);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(176, 16);
			this.label17.TabIndex = 24;
			this.label17.Text = "Random Days";
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Black;
			this.label20.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label20.ForeColor = System.Drawing.Color.Yellow;
			this.label20.Location = new System.Drawing.Point(8, 120);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(176, 16);
			this.label20.TabIndex = 25;
			this.label20.Text = "Random Customers";
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Black;
			this.label21.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label21.ForeColor = System.Drawing.Color.Yellow;
			this.label21.Location = new System.Drawing.Point(8, 24);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(176, 16);
			this.label21.TabIndex = 21;
			this.label21.Text = "Systematic Method";
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.Black;
			this.label22.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label22.ForeColor = System.Drawing.Color.Yellow;
			this.label22.Location = new System.Drawing.Point(8, 48);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(176, 16);
			this.label22.TabIndex = 22;
			this.label22.Text = "First Day First Customer";
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.Black;
			this.label24.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label24.ForeColor = System.Drawing.Color.Yellow;
			this.label24.Location = new System.Drawing.Point(8, 144);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(176, 16);
			this.label24.TabIndex = 26;
			this.label24.Text = "Complete Random";
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.Color.Black;
			this.label25.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label25.ForeColor = System.Drawing.Color.Yellow;
			this.label25.Location = new System.Drawing.Point(8, 72);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(176, 16);
			this.label25.TabIndex = 23;
			this.label25.Text = "Last Day First Customer";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.wa4,
																					this.wa2,
																					this.wa1,
																					this.wa5,
																					this.wa3,
																					this.wa6,
																					this.label23,
																					this.label26,
																					this.label27,
																					this.label28,
																					this.label30,
																					this.label31});
			this.groupBox5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox5.ForeColor = System.Drawing.Color.Lime;
			this.groupBox5.Location = new System.Drawing.Point(280, 304);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(240, 168);
			this.groupBox5.TabIndex = 28;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Weighted Average";
			// 
			// wa4
			// 
			this.wa4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.wa4.ForeColor = System.Drawing.Color.Blue;
			this.wa4.Location = new System.Drawing.Point(176, 88);
			this.wa4.MaxLength = 5;
			this.wa4.Name = "wa4";
			this.wa4.ReadOnly = true;
			this.wa4.Size = new System.Drawing.Size(56, 23);
			this.wa4.TabIndex = 17;
			this.wa4.Text = "";
			this.wa4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// wa2
			// 
			this.wa2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.wa2.ForeColor = System.Drawing.Color.Blue;
			this.wa2.Location = new System.Drawing.Point(176, 40);
			this.wa2.MaxLength = 5;
			this.wa2.Name = "wa2";
			this.wa2.ReadOnly = true;
			this.wa2.Size = new System.Drawing.Size(56, 23);
			this.wa2.TabIndex = 15;
			this.wa2.Text = "";
			this.wa2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// wa1
			// 
			this.wa1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.wa1.ForeColor = System.Drawing.Color.Blue;
			this.wa1.Location = new System.Drawing.Point(176, 16);
			this.wa1.MaxLength = 5;
			this.wa1.Name = "wa1";
			this.wa1.ReadOnly = true;
			this.wa1.Size = new System.Drawing.Size(56, 23);
			this.wa1.TabIndex = 1;
			this.wa1.Text = "";
			this.wa1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// wa5
			// 
			this.wa5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.wa5.ForeColor = System.Drawing.Color.Blue;
			this.wa5.Location = new System.Drawing.Point(176, 112);
			this.wa5.MaxLength = 5;
			this.wa5.Name = "wa5";
			this.wa5.ReadOnly = true;
			this.wa5.Size = new System.Drawing.Size(56, 23);
			this.wa5.TabIndex = 18;
			this.wa5.Text = "";
			this.wa5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// wa3
			// 
			this.wa3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.wa3.ForeColor = System.Drawing.Color.Blue;
			this.wa3.Location = new System.Drawing.Point(176, 64);
			this.wa3.MaxLength = 5;
			this.wa3.Name = "wa3";
			this.wa3.ReadOnly = true;
			this.wa3.Size = new System.Drawing.Size(56, 23);
			this.wa3.TabIndex = 16;
			this.wa3.Text = "";
			this.wa3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// wa6
			// 
			this.wa6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.wa6.ForeColor = System.Drawing.Color.Blue;
			this.wa6.Location = new System.Drawing.Point(176, 136);
			this.wa6.MaxLength = 5;
			this.wa6.Name = "wa6";
			this.wa6.ReadOnly = true;
			this.wa6.Size = new System.Drawing.Size(56, 23);
			this.wa6.TabIndex = 20;
			this.wa6.Text = "";
			this.wa6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.Black;
			this.label23.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label23.ForeColor = System.Drawing.Color.Yellow;
			this.label23.Location = new System.Drawing.Point(8, 88);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(176, 16);
			this.label23.TabIndex = 24;
			this.label23.Text = "Random Days";
			// 
			// label26
			// 
			this.label26.BackColor = System.Drawing.Color.Black;
			this.label26.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label26.ForeColor = System.Drawing.Color.Yellow;
			this.label26.Location = new System.Drawing.Point(8, 112);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(176, 16);
			this.label26.TabIndex = 25;
			this.label26.Text = "Random Customers";
			// 
			// label27
			// 
			this.label27.BackColor = System.Drawing.Color.Black;
			this.label27.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label27.ForeColor = System.Drawing.Color.Yellow;
			this.label27.Location = new System.Drawing.Point(8, 16);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(176, 16);
			this.label27.TabIndex = 21;
			this.label27.Text = "Systematic Method";
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.Color.Black;
			this.label28.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label28.ForeColor = System.Drawing.Color.Yellow;
			this.label28.Location = new System.Drawing.Point(8, 40);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(176, 16);
			this.label28.TabIndex = 22;
			this.label28.Text = "First Day First Customer";
			// 
			// label30
			// 
			this.label30.BackColor = System.Drawing.Color.Black;
			this.label30.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label30.ForeColor = System.Drawing.Color.Yellow;
			this.label30.Location = new System.Drawing.Point(8, 136);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(176, 16);
			this.label30.TabIndex = 26;
			this.label30.Text = "Complete Random";
			// 
			// label31
			// 
			this.label31.BackColor = System.Drawing.Color.Black;
			this.label31.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label31.ForeColor = System.Drawing.Color.Yellow;
			this.label31.Location = new System.Drawing.Point(8, 64);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(176, 16);
			this.label31.TabIndex = 23;
			this.label31.Text = "Last Day First Customer";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.ep4,
																					this.ep2,
																					this.ep1,
																					this.ep5,
																					this.ep3,
																					this.ep6,
																					this.label29,
																					this.label32,
																					this.label33,
																					this.label34,
																					this.label36,
																					this.label37});
			this.groupBox6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox6.ForeColor = System.Drawing.Color.Lime;
			this.groupBox6.Location = new System.Drawing.Point(536, 304);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(256, 168);
			this.groupBox6.TabIndex = 29;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Evaluated Position";
			this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
			// 
			// ep4
			// 
			this.ep4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ep4.ForeColor = System.Drawing.Color.Blue;
			this.ep4.Location = new System.Drawing.Point(184, 88);
			this.ep4.MaxLength = 5;
			this.ep4.Name = "ep4";
			this.ep4.ReadOnly = true;
			this.ep4.Size = new System.Drawing.Size(64, 23);
			this.ep4.TabIndex = 36;
			this.ep4.Text = "";
			this.ep4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ep2
			// 
			this.ep2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ep2.ForeColor = System.Drawing.Color.Blue;
			this.ep2.Location = new System.Drawing.Point(184, 40);
			this.ep2.MaxLength = 5;
			this.ep2.Name = "ep2";
			this.ep2.ReadOnly = true;
			this.ep2.Size = new System.Drawing.Size(64, 23);
			this.ep2.TabIndex = 34;
			this.ep2.Text = "";
			this.ep2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ep1
			// 
			this.ep1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ep1.ForeColor = System.Drawing.Color.Blue;
			this.ep1.Location = new System.Drawing.Point(184, 16);
			this.ep1.MaxLength = 5;
			this.ep1.Name = "ep1";
			this.ep1.ReadOnly = true;
			this.ep1.Size = new System.Drawing.Size(64, 23);
			this.ep1.TabIndex = 33;
			this.ep1.Text = "";
			this.ep1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ep5
			// 
			this.ep5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ep5.ForeColor = System.Drawing.Color.Blue;
			this.ep5.Location = new System.Drawing.Point(184, 112);
			this.ep5.MaxLength = 5;
			this.ep5.Name = "ep5";
			this.ep5.ReadOnly = true;
			this.ep5.Size = new System.Drawing.Size(64, 23);
			this.ep5.TabIndex = 37;
			this.ep5.Text = "";
			this.ep5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ep3
			// 
			this.ep3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ep3.ForeColor = System.Drawing.Color.Blue;
			this.ep3.Location = new System.Drawing.Point(184, 64);
			this.ep3.MaxLength = 5;
			this.ep3.Name = "ep3";
			this.ep3.ReadOnly = true;
			this.ep3.Size = new System.Drawing.Size(64, 23);
			this.ep3.TabIndex = 35;
			this.ep3.Text = "";
			this.ep3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ep6
			// 
			this.ep6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ep6.ForeColor = System.Drawing.Color.Blue;
			this.ep6.Location = new System.Drawing.Point(184, 136);
			this.ep6.MaxLength = 5;
			this.ep6.Name = "ep6";
			this.ep6.ReadOnly = true;
			this.ep6.Size = new System.Drawing.Size(64, 23);
			this.ep6.TabIndex = 38;
			this.ep6.Text = "";
			this.ep6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label29
			// 
			this.label29.BackColor = System.Drawing.Color.Black;
			this.label29.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label29.ForeColor = System.Drawing.Color.Yellow;
			this.label29.Location = new System.Drawing.Point(8, 96);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(176, 16);
			this.label29.TabIndex = 42;
			this.label29.Text = "Random Days";
			// 
			// label32
			// 
			this.label32.BackColor = System.Drawing.Color.Black;
			this.label32.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label32.ForeColor = System.Drawing.Color.Yellow;
			this.label32.Location = new System.Drawing.Point(8, 120);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(176, 16);
			this.label32.TabIndex = 43;
			this.label32.Text = "Random Customers";
			// 
			// label33
			// 
			this.label33.BackColor = System.Drawing.Color.Black;
			this.label33.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label33.ForeColor = System.Drawing.Color.Yellow;
			this.label33.Location = new System.Drawing.Point(8, 24);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(176, 16);
			this.label33.TabIndex = 39;
			this.label33.Text = "Systematic Method";
			// 
			// label34
			// 
			this.label34.BackColor = System.Drawing.Color.Black;
			this.label34.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label34.ForeColor = System.Drawing.Color.Yellow;
			this.label34.Location = new System.Drawing.Point(8, 48);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(176, 16);
			this.label34.TabIndex = 40;
			this.label34.Text = "First Day First Customer";
			// 
			// label36
			// 
			this.label36.BackColor = System.Drawing.Color.Black;
			this.label36.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label36.ForeColor = System.Drawing.Color.Yellow;
			this.label36.Location = new System.Drawing.Point(8, 144);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(176, 16);
			this.label36.TabIndex = 44;
			this.label36.Text = "Complete Random";
			// 
			// label37
			// 
			this.label37.BackColor = System.Drawing.Color.Black;
			this.label37.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label37.ForeColor = System.Drawing.Color.Yellow;
			this.label37.Location = new System.Drawing.Point(8, 72);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(176, 16);
			this.label37.TabIndex = 41;
			this.label37.Text = "Last Day First Customer";
			// 
			// selAlgolbl
			// 
			this.selAlgolbl.BackColor = System.Drawing.Color.YellowGreen;
			this.selAlgolbl.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.selAlgolbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.selAlgolbl.Location = new System.Drawing.Point(0, 486);
			this.selAlgolbl.Name = "selAlgolbl";
			this.selAlgolbl.Size = new System.Drawing.Size(816, 24);
			this.selAlgolbl.TabIndex = 30;
			// 
			// SMEHeuCom
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(10, 22);
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(816, 510);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.selAlgolbl,
																		  this.groupBox6,
																		  this.groupBox5,
																		  this.groupBox4,
																		  this.groupBox3,
																		  this.groupBox2,
																		  this.groupBox1,
																		  this.progressBar1,
																		  this.button1,
																		  this.label1});
			this.Font = new System.Drawing.Font("Arial", 14.25F, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "SMEHeuCom";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Heuristics Comparision";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
//		[STAThread]
//		static void Main() 
//		{
//			Application.Run(new SMEHeuCom());
//		}

		

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.button1.Enabled=false;
			//			this.ResetText();
			
			int PI=0;

			FileInfo f1 = new FileInfo(@"..\..\outputs\penalty.xls");
			StreamWriter writer = f1.CreateText();

			this.c = new AlgosTest();
			this.c.open_files();
			this.sample_input_count=0;
			while(this.c.sr.ReadLine() != null)
				this.sample_input_count++;
			this.c.sr.Close();
			
			this.c.open_files();
			int penalty=0,temp=0;
			int copy = this.sample_input_count;
			this.penaltyAlgo1 = new int [this.sample_input_count];
			this.penaltyAlgo2 = new int [this.sample_input_count];
			this.penaltyAlgo3 = new int [this.sample_input_count];
			this.penaltyAlgo4 = new int [this.sample_input_count];
			this.penaltyAlgo5 = new int [this.sample_input_count];
			this.penaltyAlgo6 = new int [this.sample_input_count];

			this.best_heuristic_solution = new int [this.sample_input_count];

			this.rd_Algo1 = new double [this.sample_input_count];
			this.rd_Algo2 = new double [this.sample_input_count];
			this.rd_Algo3 = new double [this.sample_input_count];
			this.rd_Algo4 = new double [this.sample_input_count];
			this.rd_Algo5 = new double [this.sample_input_count];
			this.rd_Algo6 = new double [this.sample_input_count];

			this.progressBar1.Value = 0;
			this.progressBar1.Maximum=this.sample_input_count;
			writer.WriteLine("\n\nPenalty For Each Problem Instance\n\n");
			writer.WriteLine("Prob Inst\tAlgo1\tAlgo2\tAlgo3\tAlgo4\tAlgo5\tAlgo6");
			while(this.sample_input_count!=0)
			{
				this.progressBar1.Value++;
				this.c.file_access();
				PI++;
				writer.Write("PI {0}\t",PI);
				for(this.count=1;this.count<=6;this.count++)
				{
					this.Refresh();
					this.progressBar1.Refresh();

					Console.WriteLine("Count = {0}",count);
					penalty = this.c.process_input(this.count);
					switch(this.count)
					{
						case 1:
							this.penaltyAlgo1[temp]=penalty;
							writer.Write("{0}\t",penalty);
							break;
						case 2:
							this.penaltyAlgo2[temp]=penalty;
							writer.Write("{0}\t",penalty);
							break;
						case 3:
							this.penaltyAlgo3[temp]=penalty;
							writer.Write("{0}\t",penalty);
							break;
						case 4:
							this.penaltyAlgo4[temp]=penalty;
							writer.Write("{0}\t",penalty);
							break;
						case 5:
							this.penaltyAlgo5[temp]=penalty;
							writer.Write("{0}\t",penalty);
							break;
						case 6:
							this.penaltyAlgo6[temp]=penalty;
							writer.WriteLine("{0}",penalty);
							break;
					}
				}
				this.sample_input_count--;
				Console.WriteLine("The Counter Value now is : {0}",this.sample_input_count);
				temp++;
			}
			this.c.sr.Close();
			writer.Close();
			this.sample_input_count=copy;
			

			this.find_min_heuristic_instance();
			this.find_ARPD();
			this.find_RANK();
			this.weighted_average_rank();

			this.penalty_avg_algo1 =0;
			this.penalty_avg_algo2 =0;
			this.penalty_avg_algo3 =0;
			this.penalty_avg_algo4 =0;
			this.penalty_avg_algo5 =0;
			this.penalty_avg_algo6 =0;


			for(int i=0;i<this.sample_input_count;i++)
			{
				this.penalty_avg_algo1 += this.penaltyAlgo1[i];
				this.penalty_avg_algo2 += this.penaltyAlgo2[i];
				this.penalty_avg_algo3 += this.penaltyAlgo3[i];
				this.penalty_avg_algo4 += this.penaltyAlgo4[i];
				this.penalty_avg_algo5 += this.penaltyAlgo5[i];
				this.penalty_avg_algo6 += this.penaltyAlgo6[i];
			}

			this.penalty_avg_algo1=penalty_avg_algo1/this.sample_input_count;
			this.penalty_avg_algo2=penalty_avg_algo2/this.sample_input_count;
			this.penalty_avg_algo3=penalty_avg_algo3/this.sample_input_count;
			this.penalty_avg_algo4=penalty_avg_algo4/this.sample_input_count;
			this.penalty_avg_algo5=penalty_avg_algo5/this.sample_input_count;
			this.penalty_avg_algo6=penalty_avg_algo6/this.sample_input_count;


			this.t1.Text=this.penalty_avg_algo1.ToString();
			this.t2.Text=this.penalty_avg_algo2.ToString();
			this.t3.Text=this.penalty_avg_algo3.ToString();
			this.t4.Text=this.penalty_avg_algo4.ToString();
			this.t5.Text=this.penalty_avg_algo5.ToString();
			this.t6.Text=this.penalty_avg_algo6.ToString();

			this.button1.Enabled=true;



			this.evaluated_position();

			//backup copy
			//			this.c = new AlgosTest();
			//			this.c.open_files();
			//			this.sample_input_count=0;
			//			while(this.c.sr.ReadLine() != null)
			//				this.sample_input_count++;
			//			this.c.sr.Close();
			//
			//			this.c.open_files();

		}


		private void Form1_Load(object sender, System.EventArgs e)
		{
			//			backup copy
			this.c = new AlgosTest();
			this.c.create_instance();
			this.c.open_files();
			this.sample_input_count=0;
			while(this.c.sr.ReadLine() != null)
				this.sample_input_count++;
			this.c.sr.Close();
			
			this.c.open_files();
		}
		
		
		void weighted_average_rank()
		{
			int i,j;

			FileInfo f2 = new FileInfo(@"..\..\outputs\Weighte_Average.xls");
			StreamWriter writer = f2.CreateText();

			this.rank_count_Algo1 = new int[6];
			this.rank_count_Algo2 = new int[6];
			this.rank_count_Algo3 = new int[6];
			this.rank_count_Algo4 = new int[6];
			this.rank_count_Algo5 = new int[6];
			this.rank_count_Algo6 = new int[6];

			for(i=0;i<6;i++)
			{
				this.rank_count_Algo1[i]=0;
				this.rank_count_Algo2[i]=0;
				this.rank_count_Algo3[i]=0;
				this.rank_count_Algo4[i]=0;
				this.rank_count_Algo5[i]=0;
				this.rank_count_Algo6[i]=0;
			}

			for(i=0;i<this.sample_input_count;i++)
			{
				if(this.rank_Algo1[i]==1)
					this.rank_count_Algo1[0]++;
				else
					if(this.rank_Algo1[i]==2)
					this.rank_count_Algo1[1]++;
				else
					if(this.rank_Algo1[i]==3)
					this.rank_count_Algo1[2]++;
				else
					if(this.rank_Algo1[i]==4)
					this.rank_count_Algo1[3]++;
				else
					if(this.rank_Algo1[i]==5)
					this.rank_count_Algo1[4]++;
				else
					if(this.rank_Algo1[i]==6)
					this.rank_count_Algo1[5]++;
			}

			for(i=0;i<this.sample_input_count;i++)
			{
				if(this.rank_Algo2[i]==1)
					this.rank_count_Algo2[0]++;
				else
					if(this.rank_Algo2[i]==2)
					this.rank_count_Algo2[1]++;
				else
					if(this.rank_Algo2[i]==3)
					this.rank_count_Algo2[2]++;
				else
					if(this.rank_Algo2[i]==4)
					this.rank_count_Algo2[3]++;
				else
					if(this.rank_Algo2[i]==5)
					this.rank_count_Algo2[4]++;
				else
					if(this.rank_Algo2[i]==6)
					this.rank_count_Algo2[5]++;
			}

			for(i=0;i<this.sample_input_count;i++)
			{
				if(this.rank_Algo3[i]==1)
					this.rank_count_Algo3[0]++;
				else
					if(this.rank_Algo3[i]==2)
					this.rank_count_Algo3[1]++;
				else
					if(this.rank_Algo3[i]==3)
					this.rank_count_Algo3[2]++;
				else
					if(this.rank_Algo3[i]==4)
					this.rank_count_Algo3[3]++;
				else
					if(this.rank_Algo3[i]==5)
					this.rank_count_Algo3[4]++;
				else
					if(this.rank_Algo3[i]==6)
					this.rank_count_Algo3[5]++;
			}

			for(i=0;i<this.sample_input_count;i++)
			{
				if(this.rank_Algo4[i]==1)
					this.rank_count_Algo4[0]++;
				else
					if(this.rank_Algo4[i]==2)
					this.rank_count_Algo4[1]++;
				else
					if(this.rank_Algo4[i]==3)
					this.rank_count_Algo4[2]++;
				else
					if(this.rank_Algo4[i]==4)
					this.rank_count_Algo4[3]++;
				else
					if(this.rank_Algo4[i]==5)
					this.rank_count_Algo4[4]++;
				else
					if(this.rank_Algo4[i]==6)
					this.rank_count_Algo4[5]++;
			}

			for(i=0;i<this.sample_input_count;i++)
			{
				if(this.rank_Algo5[i]==1)
					this.rank_count_Algo5[0]++;
				else
					if(this.rank_Algo5[i]==2)
					this.rank_count_Algo5[1]++;
				else
					if(this.rank_Algo5[i]==3)
					this.rank_count_Algo5[2]++;
				else
					if(this.rank_Algo5[i]==4)
					this.rank_count_Algo5[3]++;
				else
					if(this.rank_Algo5[i]==5)
					this.rank_count_Algo5[4]++;
				else
					if(this.rank_Algo5[i]==6)
					this.rank_count_Algo5[5]++;
			}

			for(i=0;i<this.sample_input_count;i++)
			{
				if(this.rank_Algo6[i]==1)
					this.rank_count_Algo6[0]++;
				else
					if(this.rank_Algo6[i]==2)
					this.rank_count_Algo6[1]++;
				else
					if(this.rank_Algo6[i]==3)
					this.rank_count_Algo6[2]++;
				else
					if(this.rank_Algo6[i]==4)
					this.rank_count_Algo6[3]++;
				else
					if(this.rank_Algo6[i]==5)
					this.rank_count_Algo6[4]++;
				else
					if(this.rank_Algo6[i]==6)
					this.rank_count_Algo6[5]++;
			}


			this.weighted_avg_Algo1=0;
			this.weighted_avg_Algo2=0;
			this.weighted_avg_Algo3=0;
			this.weighted_avg_Algo4=0;
			this.weighted_avg_Algo5=0;
			this.weighted_avg_Algo6=0;

			int temp=0;
			writer.WriteLine("\n\n\tWeighted Average for Six Algorithms\n");
			for(i=0;i<6;i++)
			{
				switch(i+1)
				{
					case 1:
						writer.Write("Algo1\t");
						temp=6;
						for(j=0;j<6;j++)
						{
							writer.Write("{0}\t",this.rank_count_Algo1[j]);
							this.weighted_avg_Algo1+=this.rank_count_Algo1[j]*temp;
							temp--;
						}
						this.weighted_avg_Algo1/=243;
						writer.Write("{0}\n",this.weighted_avg_Algo1);
						break;

					case 2:
						writer.Write("Algo2\t");
						temp=6;
						for(j=0;j<6;j++)
						{
							writer.Write("{0}\t",this.rank_count_Algo2[j]);
							this.weighted_avg_Algo2+=this.rank_count_Algo2[j]*temp;
							temp--;
						}
						this.weighted_avg_Algo2/=243;
						writer.Write("{0}\n",this.weighted_avg_Algo2);
						break;

					case 3:
						writer.Write("Algo3\t");
						temp=6;
						for(j=0;j<6;j++)
						{
							writer.Write("{0}\t",this.rank_count_Algo3[j]);
							this.weighted_avg_Algo3+=this.rank_count_Algo3[j]*temp;
							temp--;
						}
						this.weighted_avg_Algo3/=243;
						writer.Write("{0}\n",this.weighted_avg_Algo3);
						break;

					case 4:
						writer.Write("Algo4\t");
						temp=6;
						for(j=0;j<6;j++)
						{
							writer.Write("{0}\t",this.rank_count_Algo4[j]);
							this.weighted_avg_Algo4+=this.rank_count_Algo4[j]*temp;
							temp--;
						}
						this.weighted_avg_Algo4/=243;
						writer.Write("{0}\n",this.weighted_avg_Algo4);
						break;

					case 5:
						writer.Write("Algo5\t");
						temp=6;
						for(j=0;j<6;j++)
						{
							writer.Write("{0}\t",this.rank_count_Algo5[j]);
							this.weighted_avg_Algo5+=this.rank_count_Algo5[j]*temp;
							temp--;
						}
						this.weighted_avg_Algo5/=243;
						writer.Write("{0}\n",this.weighted_avg_Algo5);
						break;

					case 6:
						writer.Write("Algo6\t");
						temp=6;
						for(j=0;j<6;j++)
						{
							writer.Write("{0}\t",this.rank_count_Algo6[j]);
							this.weighted_avg_Algo6+=this.rank_count_Algo6[j]*temp;
							temp--;
						}
						this.weighted_avg_Algo6/=243;
						writer.Write("{0}\n",this.weighted_avg_Algo6);
						break;
				}
			}
			writer.Close();

			//code for filling the weighted average textbox
			this.wa1.Text=this.weighted_avg_Algo1.ToString();
			this.wa2.Text=this.weighted_avg_Algo2.ToString();
			this.wa3.Text=this.weighted_avg_Algo3.ToString();
			this.wa4.Text=this.weighted_avg_Algo4.ToString();
			this.wa5.Text=this.weighted_avg_Algo5.ToString();
			this.wa6.Text=this.weighted_avg_Algo6.ToString();
			this.wa1.MaxLength=2;
		}



		void maxRD()
		{
			//			int i,min=0;
			//			for(i=0;i<this.sample_input_count;i++)
			//			{
			//				min=-1;
			//				if(this.rd_Algo1[i] > min)
			//					min=this.penaltyAlgo1[i];
			//			}
			//			this.maxrd_Algo1=min;
			//
			//			for(i=0;i<this.sample_input_count;i++)
			//			{
			//				min=-1;
			//				if(this.rd_Algo2[i] > min)
			//					min=this.penaltyAlgo1[i];
			//			}
			//			this.maxrd_Algo2=min;
			//
			//			for(i=0;i<this.sample_input_count;i++)
			//			{
			//				min=-1;
			//				if(this.rd_Algo3[i] > min)
			//					min=this.penaltyAlgo1[i];
			//			}
			//			this.maxrd_Algo3=min;
			//
			//			for(i=0;i<this.sample_input_count;i++)
			//			{
			//				min=-1;
			//				if(this.rd_Algo4[i] > min)
			//					min=this.penaltyAlgo1[i];
			//			}
			//			this.maxrd_Algo4=min;
			//
			//			for(i=0;i<this.sample_input_count;i++)
			//			{
			//				min=-1;
			//				if(this.rd_Algo5[i] > min)
			//					min=this.penaltyAlgo1[i];
			//			}
			//			this.maxrd_Algo5=min;
			//
			//			for(i=0;i<this.sample_input_count;i++)
			//			{
			//				min=-1;
			//				if(this.rd_Algo6[i] > min)
			//					min=this.penaltyAlgo1[i];
			//			}
			//			this.maxrd_Algo6=min;
				
		}

		void find_min_heuristic_instance()
		{
			int min;
			int i;

			for(i=0;i<this.sample_input_count;i++)
			{
				min = 99999;

				if(this.penaltyAlgo1[i] < min)
					min=this.penaltyAlgo1[i];

				if(this.penaltyAlgo2[i] < min)
					min=this.penaltyAlgo2[i];

				if(this.penaltyAlgo3[i] < min)
					min=this.penaltyAlgo3[i];

				if(this.penaltyAlgo4[i] < min)
					min=this.penaltyAlgo4[i];

				if(this.penaltyAlgo5[i] < min)
					min=this.penaltyAlgo5[i];

				if(this.penaltyAlgo6[i] < min)
					min=this.penaltyAlgo6[i];

				this.best_heuristic_solution[i]=min;
			}
			
		}	

		void find_ARPD()
		{
			int i;
			double min=0.00;

			
			FileInfo f2 = new FileInfo(@"..\..\outputs\ARPD.xls");
			StreamWriter writer = f2.CreateText();

			writer.WriteLine("\n\nAVERAGE RELATIVE PERCENTAGE DEVIATION\n");
			writer.WriteLine("Prob Inst\tAlgo1\tAlgo2\tAlgo3\tAlgo4\tAlgo5\tAlgo6");

			for(i=0;i<this.sample_input_count;i++)
			{
				this.rd_Algo1[i]=((double)(this.penaltyAlgo1[i] - this.best_heuristic_solution[i]))/this.best_heuristic_solution[i];
				this.rd_Algo2[i]=((double)(this.penaltyAlgo2[i] - this.best_heuristic_solution[i]))/this.best_heuristic_solution[i];
				this.rd_Algo3[i]=((double)(this.penaltyAlgo3[i] - this.best_heuristic_solution[i]))/this.best_heuristic_solution[i];
				this.rd_Algo4[i]=((double)(this.penaltyAlgo4[i] - this.best_heuristic_solution[i]))/this.best_heuristic_solution[i];
				this.rd_Algo5[i]=((double)(this.penaltyAlgo5[i] - this.best_heuristic_solution[i]))/this.best_heuristic_solution[i];
				this.rd_Algo6[i]=((double)(this.penaltyAlgo6[i] - this.best_heuristic_solution[i]))/this.best_heuristic_solution[i];
				writer.WriteLine("PI {0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t",i,this.rd_Algo1[i],this.rd_Algo2[i],this.rd_Algo3[i],this.rd_Algo4[i],this.rd_Algo5[i],this.rd_Algo6[i],this.best_heuristic_solution[i]);
			}

			//code to find the maximum RELATIVE DEVIATION and Avg RD
			this.avgrd_Algo1=0;
			this.avgrd_Algo2=0;
			this.avgrd_Algo3=0;
			this.avgrd_Algo4=0;
			this.avgrd_Algo5=0;
			this.avgrd_Algo6=0;

			min=-1;
			for(i=0;i<this.sample_input_count;i++)
			{
				if(this.rd_Algo1[i] > min)
					min=this.rd_Algo1[i];
				this.avgrd_Algo1 +=this.rd_Algo1[i];
			}
			this.maxrd_Algo1=min;
			this.avgrd_Algo1=(this.avgrd_Algo1)/this.sample_input_count;

			min=-1;
			for(i=0;i<this.sample_input_count;i++)
			{
				if(this.rd_Algo2[i] > min)
					min=this.rd_Algo2[i];
				this.avgrd_Algo2 +=this.rd_Algo2[i];

			}
			this.maxrd_Algo2=min;
			this.avgrd_Algo2=(this.avgrd_Algo2)/this.sample_input_count;


			min=-1;
			for(i=0;i<this.sample_input_count;i++)
			{
				if(this.rd_Algo3[i] > min)
					min=this.rd_Algo3[i];
				this.avgrd_Algo3 +=this.rd_Algo3[i];
			}
			this.maxrd_Algo3=min;
			this.avgrd_Algo3=(this.avgrd_Algo3)/this.sample_input_count;


			min=-1;
			for(i=0;i<this.sample_input_count;i++)
			{
				if(this.rd_Algo4[i] > min)
					min=this.rd_Algo4[i];
				this.avgrd_Algo4 +=this.rd_Algo4[i];
			}
			this.maxrd_Algo4=min;
			this.avgrd_Algo4=(this.avgrd_Algo4)/this.sample_input_count;


			min=-1;
			for(i=0;i<this.sample_input_count;i++)
			{
				if(this.rd_Algo5[i] > min)
					min=this.rd_Algo5[i];
				this.avgrd_Algo5 +=this.rd_Algo5[i];
			}
			this.maxrd_Algo5=min;
			this.avgrd_Algo5=(this.avgrd_Algo5)/this.sample_input_count;


			min=-1;
			for(i=0;i<this.sample_input_count;i++)
			{				
				if(this.rd_Algo6[i] > min)
					min=this.rd_Algo6[i];
				this.avgrd_Algo6 +=this.rd_Algo6[i];

			}
			this.maxrd_Algo6=min;
			this.avgrd_Algo6=(this.avgrd_Algo6)/this.sample_input_count;

			//CODE FOR FINDING THE MAX RD ENDS

			writer.WriteLine("\nAvg RD \t{0}\t{1}\t{2}\t{3}\t{4}\t{5}",this.avgrd_Algo1,this.avgrd_Algo2,
				this.avgrd_Algo3,this.avgrd_Algo4,this.avgrd_Algo5,this.avgrd_Algo6);

			//filling the average relative deviation textbox
			this.ard1.Text=this.avgrd_Algo1.ToString();
			this.ard2.Text=this.avgrd_Algo2.ToString();
			this.ard3.Text=this.avgrd_Algo3.ToString();
			this.ard4.Text=this.avgrd_Algo4.ToString();
			this.ard5.Text=this.avgrd_Algo5.ToString();
			this.ard6.Text=this.avgrd_Algo6.ToString();


			writer.WriteLine("\nMax RD \t{0}\t{1}\t{2}\t{3}\t{4}\t{5}",this.maxrd_Algo1,this.maxrd_Algo2,
				this.maxrd_Algo3,this.maxrd_Algo4,this.maxrd_Algo5,this.maxrd_Algo6);

			//filling the max relative deviation textbox
			this.mrd1.Text=this.maxrd_Algo1.ToString();
			this.mrd2.Text=this.maxrd_Algo2.ToString();
			this.mrd3.Text=this.maxrd_Algo3.ToString();
			this.mrd4.Text=this.maxrd_Algo4.ToString();
			this.mrd5.Text=this.maxrd_Algo5.ToString();
			this.mrd6.Text=this.maxrd_Algo6.ToString();

			writer.Close();
			
		}


		void find_RANK()
		{

			int i,j;
			FileInfo f2 = new FileInfo(@"..\..\outputs\sort.txt");
			StreamWriter writer = f2.CreateText();

			FileInfo f3 = new FileInfo(@"..\..\outputs\rank.xls");
			StreamWriter writer1 = f3.CreateText();

			this.temp = new double [6];

			this.rank_Algo1 = new int [this.sample_input_count];
			this.rank_Algo2 = new int [this.sample_input_count];
			this.rank_Algo3 = new int [this.sample_input_count];
			this.rank_Algo4 = new int [this.sample_input_count];
			this.rank_Algo5 = new int [this.sample_input_count];
			this.rank_Algo6 = new int [this.sample_input_count];


			writer.WriteLine("\n\nThe Sorted Array for each problem instance is as follows\n\n");
			for(i=0;i<this.sample_input_count;i++)
			{
				for(j=0;j<6;j++)
				{
					switch(j+1)
					{
						case 1:
							this.temp[j]=this.rd_Algo1[i];
							break;

						case 2:
							this.temp[j]=this.rd_Algo2[i];
							break;

						case 3:
							this.temp[j]=this.rd_Algo3[i];
							break;

						case 4:
							this.temp[j]=this.rd_Algo4[i];
							break;

						case 5:
							this.temp[j]=this.rd_Algo5[i];
							break;

						case 6:
							this.temp[j]=this.rd_Algo6[i];
							break;

					}
				}
				Array.Sort(this.temp,0,6);
				this.get_rank(i);
				for(int k=0;k<6;k++)
				{
					//					Console.WriteLine("{0}  ",this.temp[k]);
					writer.Write("{0}\t",this.temp[k]);
				}
				writer.WriteLine("");
			}
			writer.Close();
			writer1.WriteLine("\n\n\t\tRANK MATRIX FOR SIX ALGORITHMS");
			writer1.WriteLine("\nProb Instance\tAlgo1\tAlgo2\tAlgo3\tAlgo4\tAlgo5\tAlgo6");
			for(i=0;i<this.sample_input_count;i++)
			{
				writer1.WriteLine("PI{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}",i,
					this.rank_Algo1[i],this.rank_Algo2[i],this.rank_Algo3[i],
					this.rank_Algo4[i],this.rank_Algo5[i],this.rank_Algo6[i]);
			}
			writer1.Close();

			this.avg_rank_Algo1=0;
			this.avg_rank_Algo2=0;
			this.avg_rank_Algo3=0;
			this.avg_rank_Algo4=0;
			this.avg_rank_Algo5=0;
			this.avg_rank_Algo6=0;

			for(i=0;i<this.sample_input_count;i++)
			{
				this.avg_rank_Algo1+=this.rank_Algo1[i];
				this.avg_rank_Algo2+=this.rank_Algo2[i];
				this.avg_rank_Algo3+=this.rank_Algo3[i];
				this.avg_rank_Algo4+=this.rank_Algo4[i];
				this.avg_rank_Algo5+=this.rank_Algo5[i];
				this.avg_rank_Algo6+=this.rank_Algo6[i];
			}
			this.avg_rank_Algo1/=this.sample_input_count;
			this.avg_rank_Algo2/=this.sample_input_count;
			this.avg_rank_Algo3/=this.sample_input_count;
			this.avg_rank_Algo4/=this.sample_input_count;
			this.avg_rank_Algo5/=this.sample_input_count;
			this.avg_rank_Algo6/=this.sample_input_count;

			//code to fill the average rank textbox
			this.ar1.Text=this.avg_rank_Algo1.ToString();
			this.ar2.Text=this.avg_rank_Algo2.ToString();
			this.ar3.Text=this.avg_rank_Algo3.ToString();
			this.ar4.Text=this.avg_rank_Algo4.ToString();
			this.ar5.Text=this.avg_rank_Algo5.ToString();
			this.ar6.Text=this.avg_rank_Algo6.ToString();
		}


		void get_rank(int i)
		{
			int j;
			int flag1=0,flag2=0,flag3=0,flag4=0,flag5=0,flag6=0;

			for(j=0;j<6;j++)
			{
				if(this.temp[j] == this.rd_Algo1[i] && flag1==0)
				{
					this.rank_Algo1[i]=j+1;
					flag1=1;
				}
				else
					if(this.temp[j] == this.rd_Algo2[i] && flag2==0)
				{
					this.rank_Algo2[i]=j+1;
					flag2=1;
				}
				else
					if(this.temp[j] == this.rd_Algo3[i] && flag3==0)
				{
					this.rank_Algo3[i]=j+1;
					flag3=1;
				}
				else
					if(this.temp[j] == this.rd_Algo4[i] && flag4==0)
				{
					this.rank_Algo4[i]=j+1;
					flag4=1;
				}
				else
					if(this.temp[j] == this.rd_Algo5[i] && flag5==0)
				{
					this.rank_Algo5[i]=j+1;
					flag5=1;
				}
				else
					if(this.temp[j] == this.rd_Algo6[i] && flag6==0)
				{
					this.rank_Algo6[i]=j+1;
					flag6=1;
				}
			}
		}

		void evaluated_position()
		{
			int i;
			
			double min=0;
			
			double [] tarpd=new double [6];;
			double [] tmrpd=new double [6];;
			double [] trank=new double [6];;
			double [] tpenalty=new double [6];;
			double [] twavg = new double [6];
			
			double [] temp = new double [6];
			//considering weighted average
			twavg[0]=this.weighted_avg_Algo1;
			twavg[1]=this.weighted_avg_Algo2;
			twavg[2]=this.weighted_avg_Algo3;
			twavg[3]=this.weighted_avg_Algo4;
			twavg[4]=this.weighted_avg_Algo5;
			twavg[5]=this.weighted_avg_Algo6;
			//
			//			Array.Sort(temp,0,6);
			

			//considering average penalty
			temp[0]=this.penalty_avg_algo1;
			temp[1]=this.penalty_avg_algo2;
			temp[2]=this.penalty_avg_algo3;
			temp[3]=this.penalty_avg_algo4;
			temp[4]=this.penalty_avg_algo5;
			temp[5]=this.penalty_avg_algo6;

			Array.Sort(temp,0,6);
			min=temp[0];

			temp[0]=this.penalty_avg_algo1;
			temp[1]=this.penalty_avg_algo2;
			temp[2]=this.penalty_avg_algo3;
			temp[3]=this.penalty_avg_algo4;
			temp[4]=this.penalty_avg_algo5;
			temp[5]=this.penalty_avg_algo6;

		
			Console.WriteLine("penalty");
			for(i=0;i<6;i++)
			{
				tpenalty[i]=temp[i]/min;
				Console.WriteLine (tpenalty[i]);
			}

			//considering average relative deviation
			temp[0]=this.avgrd_Algo1;
			temp[1]=this.avgrd_Algo2;
			temp[2]=this.avgrd_Algo3;
			temp[3]=this.avgrd_Algo4;
			temp[4]=this.avgrd_Algo5;
			temp[5]=this.avgrd_Algo6;
			
			Array.Sort(temp,0,6);
			min=temp[0];

			temp[0]=this.avgrd_Algo1;
			temp[1]=this.avgrd_Algo2;
			temp[2]=this.avgrd_Algo3;
			temp[3]=this.avgrd_Algo4;
			temp[4]=this.avgrd_Algo5;
			temp[5]=this.avgrd_Algo6;

			Console.WriteLine ("ARpd");
			for(i=0;i<6;i++)
			{
				tarpd[i]=temp[i]/min;
				Console.WriteLine (tarpd[i]);
			}

			//considering average ranking
			temp[0]=this.avg_rank_Algo1;
			temp[1]=this.avg_rank_Algo2;
			temp[2]=this.avg_rank_Algo3;
			temp[3]=this.avg_rank_Algo4;
			temp[4]=this.avg_rank_Algo5;
			temp[5]=this.avg_rank_Algo6;

			Array.Sort(temp,0,6);
			min=temp[0];

			temp[0]=this.avg_rank_Algo1;
			temp[1]=this.avg_rank_Algo2;
			temp[2]=this.avg_rank_Algo3;
			temp[3]=this.avg_rank_Algo4;
			temp[4]=this.avg_rank_Algo5;
			temp[5]=this.avg_rank_Algo6;

			for(i=0;i<6;i++)
			{
				trank[i]=temp[i]/min;
				Console.WriteLine (trank[i]);
			}


			//considering max relative deviation
			temp[0]=this.maxrd_Algo1;
			temp[1]=this.maxrd_Algo2;
			temp[2]=this.maxrd_Algo3;
			temp[3]=this.maxrd_Algo4;
			temp[4]=this.maxrd_Algo5;
			temp[5]=this.maxrd_Algo6;

			Array.Sort(temp,0,6);
			min=temp[0];

			temp[0]=this.maxrd_Algo1;
			temp[1]=this.maxrd_Algo2;
			temp[2]=this.maxrd_Algo3;
			temp[3]=this.maxrd_Algo4;
			temp[4]=this.maxrd_Algo5;
			temp[5]=this.maxrd_Algo6;

			
			for(i=0;i<6;i++)
			{
				tmrpd[i]=temp[i]/min;
				Console.WriteLine (tmrpd[i]);
			}

			

			for(i=0;i<6;i++)
			{
				Console.WriteLine ("{0} ,{1}, {2}, {3}",tarpd[i],tmrpd[i],trank[i],tpenalty[i]);

				temp[i]=tarpd[i]+tmrpd[i]+trank[i]+tpenalty[i];
			}


			double algo1,algo2,algo3,algo4,algo5,algo6;
			algo1=temp[0];
			algo2=temp[1];
			algo3=temp[2];
			algo4=temp[3];
			algo5=temp[4];
			algo6=temp[5];

			//			Console.WriteLine ("{0} ,{1}, {2}, {3}, {4}, {5}",temp[0],temp[1],temp[2],temp[3],temp[4],temp[5]);

			Array.Sort(temp,0,6);

			int rank=0;
			int rank1,rank2,rank3,rank4,rank5,rank6;
			rank1=rank2=rank3=rank4=rank5=rank6=0;
			for(i=0;i<6;i++)
			{
				rank++;
				if(temp[i]==algo1)
					rank1=rank;
				if(temp[i]==algo2)
					rank2=rank;
				if(temp[i]==algo3)
					rank3=rank;
				if(temp[i]==algo4)
					rank4=rank;
				if(temp[i]==algo5)
					rank5=rank;
				if(temp[i]==algo6)
					rank6=rank;
			}
				

			this.ep1.Text=rank1.ToString();
			this.ep2.Text=rank2.ToString();
			this.ep3.Text=rank3.ToString();
			this.ep4.Text=rank4.ToString();
			this.ep5.Text=rank5.ToString();
			this.ep6.Text=rank6.ToString();


			int ch=0;
			if (ep1.Text == "1")
				ch = 1;
			if (ep2.Text == "1")
				ch = 2;
			if (ep3.Text == "1")
				ch = 3;
			if (ep4.Text == "1")
				ch = 4;
			if (ep5.Text == "1")
				ch = 5;
			if (ep6.Text == "1")
				ch = 6;

			switch(ch)
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

				default:
					selAlgolbl.Text = " ";
					break;
			}


		}

		private void groupBox6_Enter(object sender, System.EventArgs e)
		{
		
		}

	}
		
}
