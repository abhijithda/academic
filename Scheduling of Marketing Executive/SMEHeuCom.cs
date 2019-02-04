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
		public System.Windows.Forms.Label label8;
		public System.Windows.Forms.Label label9;
		public System.Windows.Forms.Label label10;
		public System.Windows.Forms.Label label11;
		public System.Windows.Forms.Label label12;
		public System.Windows.Forms.Label label13;
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
		public System.Windows.Forms.Label label14;
		public System.Windows.Forms.Label label15;
		public System.Windows.Forms.Label label16;
		public System.Windows.Forms.Label label17;
		public System.Windows.Forms.Label label18;
		public System.Windows.Forms.Label label19;
		public System.Windows.Forms.Label label20;
		public System.Windows.Forms.Label label21;
		public System.Windows.Forms.Label label22;
		public System.Windows.Forms.Label label23;
		public System.Windows.Forms.Label label24;
		public System.Windows.Forms.Label label25;
		public System.Windows.Forms.Label label26;
		public System.Windows.Forms.Label label27;
		public System.Windows.Forms.Label label28;
		public System.Windows.Forms.Label label29;
		public System.Windows.Forms.Label label30;
		public System.Windows.Forms.Label label31;
		private System.Windows.Forms.GroupBox groupBox6;
		public System.Windows.Forms.Label label32;
		public System.Windows.Forms.Label label33;
		public System.Windows.Forms.Label label34;
		public System.Windows.Forms.Label label35;
		public System.Windows.Forms.Label label36;
		public System.Windows.Forms.Label label37;
		public System.Windows.Forms.TextBox ep4;
		public System.Windows.Forms.TextBox ep2;
		public System.Windows.Forms.TextBox ep1;
		public System.Windows.Forms.TextBox ep5;
		public System.Windows.Forms.TextBox ep3;
		public System.Windows.Forms.TextBox ep6;
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
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.ard4 = new System.Windows.Forms.TextBox();
			this.ard2 = new System.Windows.Forms.TextBox();
			this.ard1 = new System.Windows.Forms.TextBox();
			this.ard5 = new System.Windows.Forms.TextBox();
			this.ard3 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.ard6 = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.mrd4 = new System.Windows.Forms.TextBox();
			this.mrd2 = new System.Windows.Forms.TextBox();
			this.mrd1 = new System.Windows.Forms.TextBox();
			this.mrd5 = new System.Windows.Forms.TextBox();
			this.mrd3 = new System.Windows.Forms.TextBox();
			this.mrd6 = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.ar4 = new System.Windows.Forms.TextBox();
			this.ar2 = new System.Windows.Forms.TextBox();
			this.ar1 = new System.Windows.Forms.TextBox();
			this.ar5 = new System.Windows.Forms.TextBox();
			this.ar3 = new System.Windows.Forms.TextBox();
			this.ar6 = new System.Windows.Forms.TextBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.wa4 = new System.Windows.Forms.TextBox();
			this.wa2 = new System.Windows.Forms.TextBox();
			this.wa1 = new System.Windows.Forms.TextBox();
			this.wa5 = new System.Windows.Forms.TextBox();
			this.wa3 = new System.Windows.Forms.TextBox();
			this.wa6 = new System.Windows.Forms.TextBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.ep4 = new System.Windows.Forms.TextBox();
			this.ep2 = new System.Windows.Forms.TextBox();
			this.ep1 = new System.Windows.Forms.TextBox();
			this.ep5 = new System.Windows.Forms.TextBox();
			this.ep3 = new System.Windows.Forms.TextBox();
			this.ep6 = new System.Windows.Forms.TextBox();
			this.label32 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.label37 = new System.Windows.Forms.Label();
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
			this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(704, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Algorithm Testing Program";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// t1
			// 
			this.t1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.t1.Location = new System.Drawing.Point(184, 24);
			this.t1.Name = "t1";
			this.t1.ReadOnly = true;
			this.t1.Size = new System.Drawing.Size(32, 20);
			this.t1.TabIndex = 1;
			this.t1.Text = "";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = " Penalty Systematic Method";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(56, 64);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 24);
			this.button1.TabIndex = 10;
			this.button1.Text = "Evaluate";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 16);
			this.label3.TabIndex = 11;
			this.label3.Text = "Penalty FCFS";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(152, 16);
			this.label4.TabIndex = 12;
			this.label4.Text = "Penalty FCFS Right to Left";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(152, 16);
			this.label5.TabIndex = 13;
			this.label5.Text = "Penalty for Random Days";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 120);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(176, 16);
			this.label6.TabIndex = 14;
			this.label6.Text = "Penalty for Random Customers";
			// 
			// t2
			// 
			this.t2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.t2.Location = new System.Drawing.Point(184, 48);
			this.t2.Name = "t2";
			this.t2.ReadOnly = true;
			this.t2.Size = new System.Drawing.Size(32, 20);
			this.t2.TabIndex = 15;
			this.t2.Text = "";
			// 
			// t3
			// 
			this.t3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.t3.Location = new System.Drawing.Point(184, 72);
			this.t3.Name = "t3";
			this.t3.ReadOnly = true;
			this.t3.Size = new System.Drawing.Size(32, 20);
			this.t3.TabIndex = 16;
			this.t3.Text = "";
			// 
			// t4
			// 
			this.t4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.t4.Location = new System.Drawing.Point(184, 96);
			this.t4.Name = "t4";
			this.t4.ReadOnly = true;
			this.t4.Size = new System.Drawing.Size(32, 20);
			this.t4.TabIndex = 17;
			this.t4.Text = "";
			// 
			// t5
			// 
			this.t5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.t5.Location = new System.Drawing.Point(184, 120);
			this.t5.Name = "t5";
			this.t5.ReadOnly = true;
			this.t5.Size = new System.Drawing.Size(32, 20);
			this.t5.TabIndex = 18;
			this.t5.Text = "";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(8, 144);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(168, 16);
			this.label7.TabIndex = 19;
			this.label7.Text = "Penalty for Complete Random";
			// 
			// t6
			// 
			this.t6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.t6.Location = new System.Drawing.Point(184, 144);
			this.t6.Name = "t6";
			this.t6.ReadOnly = true;
			this.t6.Size = new System.Drawing.Size(32, 20);
			this.t6.TabIndex = 20;
			this.t6.Text = "";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(200, 72);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(296, 16);
			this.progressBar1.TabIndex = 23;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label5,
																					this.label6,
																					this.t4,
																					this.t2,
																					this.t1,
																					this.t5,
																					this.t3,
																					this.label2,
																					this.label3,
																					this.label7,
																					this.label4,
																					this.t6});
			this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(24, 120);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(224, 176);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Avg Penalty";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label8,
																					this.label9,
																					this.ard4,
																					this.ard2,
																					this.ard1,
																					this.ard5,
																					this.ard3,
																					this.label10,
																					this.label11,
																					this.label12,
																					this.label13,
																					this.ard6});
			this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(264, 120);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(256, 176);
			this.groupBox2.TabIndex = 25;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Avg Relative Deviation";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(8, 96);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(152, 16);
			this.label8.TabIndex = 13;
			this.label8.Text = "Random Days";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(8, 120);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(176, 16);
			this.label9.TabIndex = 14;
			this.label9.Text = "Random Customers";
			// 
			// ard4
			// 
			this.ard4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ard4.Location = new System.Drawing.Point(184, 96);
			this.ard4.Name = "ard4";
			this.ard4.ReadOnly = true;
			this.ard4.Size = new System.Drawing.Size(64, 20);
			this.ard4.TabIndex = 17;
			this.ard4.Text = "";
			// 
			// ard2
			// 
			this.ard2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ard2.Location = new System.Drawing.Point(184, 48);
			this.ard2.Name = "ard2";
			this.ard2.ReadOnly = true;
			this.ard2.Size = new System.Drawing.Size(64, 20);
			this.ard2.TabIndex = 15;
			this.ard2.Text = "";
			// 
			// ard1
			// 
			this.ard1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ard1.Location = new System.Drawing.Point(184, 24);
			this.ard1.Name = "ard1";
			this.ard1.ReadOnly = true;
			this.ard1.Size = new System.Drawing.Size(64, 20);
			this.ard1.TabIndex = 1;
			this.ard1.Text = "";
			// 
			// ard5
			// 
			this.ard5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ard5.Location = new System.Drawing.Point(184, 120);
			this.ard5.Name = "ard5";
			this.ard5.ReadOnly = true;
			this.ard5.Size = new System.Drawing.Size(64, 20);
			this.ard5.TabIndex = 18;
			this.ard5.Text = "";
			// 
			// ard3
			// 
			this.ard3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ard3.Location = new System.Drawing.Point(184, 72);
			this.ard3.Name = "ard3";
			this.ard3.ReadOnly = true;
			this.ard3.Size = new System.Drawing.Size(64, 20);
			this.ard3.TabIndex = 16;
			this.ard3.Text = "";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(8, 24);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(168, 16);
			this.label10.TabIndex = 2;
			this.label10.Text = "Systematic Method";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.Location = new System.Drawing.Point(8, 48);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(120, 16);
			this.label11.TabIndex = 11;
			this.label11.Text = "FCFS Left to Right";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.Location = new System.Drawing.Point(8, 144);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(168, 16);
			this.label12.TabIndex = 19;
			this.label12.Text = "Complete Random";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label13.Location = new System.Drawing.Point(8, 72);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(152, 16);
			this.label13.TabIndex = 12;
			this.label13.Text = "FCFS Right to Left";
			// 
			// ard6
			// 
			this.ard6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ard6.Location = new System.Drawing.Point(184, 144);
			this.ard6.Name = "ard6";
			this.ard6.ReadOnly = true;
			this.ard6.Size = new System.Drawing.Size(64, 20);
			this.ard6.TabIndex = 20;
			this.ard6.Text = "";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label14,
																					this.label15,
																					this.label16,
																					this.label17,
																					this.label18,
																					this.label19,
																					this.mrd4,
																					this.mrd2,
																					this.mrd1,
																					this.mrd5,
																					this.mrd3,
																					this.mrd6});
			this.groupBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(536, 120);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(256, 176);
			this.groupBox3.TabIndex = 26;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Max Relative Deviation";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label14.Location = new System.Drawing.Point(16, 96);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(152, 16);
			this.label14.TabIndex = 24;
			this.label14.Text = "Random Days";
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label15.Location = new System.Drawing.Point(16, 120);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(144, 16);
			this.label15.TabIndex = 25;
			this.label15.Text = "Random Customers";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label16.Location = new System.Drawing.Point(16, 24);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(168, 16);
			this.label16.TabIndex = 21;
			this.label16.Text = "Systematic Method";
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label17.Location = new System.Drawing.Point(16, 48);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(120, 16);
			this.label17.TabIndex = 22;
			this.label17.Text = "FCFS Left to Right";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label18.Location = new System.Drawing.Point(16, 144);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(128, 16);
			this.label18.TabIndex = 26;
			this.label18.Text = "Complete Random";
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label19.Location = new System.Drawing.Point(16, 72);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(152, 16);
			this.label19.TabIndex = 23;
			this.label19.Text = "FCFS Right to Left";
			// 
			// mrd4
			// 
			this.mrd4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mrd4.Location = new System.Drawing.Point(184, 96);
			this.mrd4.Name = "mrd4";
			this.mrd4.ReadOnly = true;
			this.mrd4.Size = new System.Drawing.Size(64, 20);
			this.mrd4.TabIndex = 17;
			this.mrd4.Text = "";
			// 
			// mrd2
			// 
			this.mrd2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mrd2.Location = new System.Drawing.Point(184, 48);
			this.mrd2.Name = "mrd2";
			this.mrd2.ReadOnly = true;
			this.mrd2.Size = new System.Drawing.Size(64, 20);
			this.mrd2.TabIndex = 15;
			this.mrd2.Text = "";
			// 
			// mrd1
			// 
			this.mrd1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mrd1.Location = new System.Drawing.Point(184, 24);
			this.mrd1.Name = "mrd1";
			this.mrd1.ReadOnly = true;
			this.mrd1.Size = new System.Drawing.Size(64, 20);
			this.mrd1.TabIndex = 1;
			this.mrd1.Text = "";
			// 
			// mrd5
			// 
			this.mrd5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mrd5.Location = new System.Drawing.Point(184, 120);
			this.mrd5.Name = "mrd5";
			this.mrd5.ReadOnly = true;
			this.mrd5.Size = new System.Drawing.Size(64, 20);
			this.mrd5.TabIndex = 18;
			this.mrd5.Text = "";
			// 
			// mrd3
			// 
			this.mrd3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mrd3.Location = new System.Drawing.Point(184, 72);
			this.mrd3.Name = "mrd3";
			this.mrd3.ReadOnly = true;
			this.mrd3.Size = new System.Drawing.Size(64, 20);
			this.mrd3.TabIndex = 16;
			this.mrd3.Text = "";
			// 
			// mrd6
			// 
			this.mrd6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mrd6.Location = new System.Drawing.Point(184, 144);
			this.mrd6.Name = "mrd6";
			this.mrd6.ReadOnly = true;
			this.mrd6.Size = new System.Drawing.Size(64, 20);
			this.mrd6.TabIndex = 20;
			this.mrd6.Text = "";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label20,
																					this.label21,
																					this.label22,
																					this.label23,
																					this.label24,
																					this.label25,
																					this.ar4,
																					this.ar2,
																					this.ar1,
																					this.ar5,
																					this.ar3,
																					this.ar6});
			this.groupBox4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(24, 320);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(264, 176);
			this.groupBox4.TabIndex = 27;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Avg Ranking";
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label20.Location = new System.Drawing.Point(16, 96);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(152, 16);
			this.label20.TabIndex = 24;
			this.label20.Text = "Random Days";
			// 
			// label21
			// 
			this.label21.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label21.Location = new System.Drawing.Point(16, 120);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(128, 16);
			this.label21.TabIndex = 25;
			this.label21.Text = "Random Customers";
			// 
			// label22
			// 
			this.label22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label22.Location = new System.Drawing.Point(16, 24);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(168, 16);
			this.label22.TabIndex = 21;
			this.label22.Text = "Systematic Method";
			// 
			// label23
			// 
			this.label23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label23.Location = new System.Drawing.Point(16, 48);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(120, 16);
			this.label23.TabIndex = 22;
			this.label23.Text = "FCFS Left to Right";
			// 
			// label24
			// 
			this.label24.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label24.Location = new System.Drawing.Point(16, 144);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(168, 16);
			this.label24.TabIndex = 26;
			this.label24.Text = "Complete Random";
			// 
			// label25
			// 
			this.label25.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label25.Location = new System.Drawing.Point(16, 72);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(152, 16);
			this.label25.TabIndex = 23;
			this.label25.Text = "FCFS Right to Left";
			// 
			// ar4
			// 
			this.ar4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ar4.Location = new System.Drawing.Point(184, 96);
			this.ar4.Name = "ar4";
			this.ar4.ReadOnly = true;
			this.ar4.Size = new System.Drawing.Size(72, 20);
			this.ar4.TabIndex = 17;
			this.ar4.Text = "";
			// 
			// ar2
			// 
			this.ar2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ar2.Location = new System.Drawing.Point(184, 48);
			this.ar2.Name = "ar2";
			this.ar2.ReadOnly = true;
			this.ar2.Size = new System.Drawing.Size(72, 20);
			this.ar2.TabIndex = 15;
			this.ar2.Text = "";
			// 
			// ar1
			// 
			this.ar1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ar1.Location = new System.Drawing.Point(184, 24);
			this.ar1.Name = "ar1";
			this.ar1.ReadOnly = true;
			this.ar1.Size = new System.Drawing.Size(72, 20);
			this.ar1.TabIndex = 1;
			this.ar1.Text = "";
			this.ar1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ar5
			// 
			this.ar5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ar5.Location = new System.Drawing.Point(184, 120);
			this.ar5.Name = "ar5";
			this.ar5.ReadOnly = true;
			this.ar5.Size = new System.Drawing.Size(72, 20);
			this.ar5.TabIndex = 18;
			this.ar5.Text = "";
			// 
			// ar3
			// 
			this.ar3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ar3.Location = new System.Drawing.Point(184, 72);
			this.ar3.Name = "ar3";
			this.ar3.ReadOnly = true;
			this.ar3.Size = new System.Drawing.Size(72, 20);
			this.ar3.TabIndex = 16;
			this.ar3.Text = "";
			// 
			// ar6
			// 
			this.ar6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ar6.Location = new System.Drawing.Point(184, 144);
			this.ar6.Name = "ar6";
			this.ar6.ReadOnly = true;
			this.ar6.Size = new System.Drawing.Size(72, 20);
			this.ar6.TabIndex = 20;
			this.ar6.Text = "";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label26,
																					this.label27,
																					this.label28,
																					this.label29,
																					this.label30,
																					this.label31,
																					this.wa4,
																					this.wa2,
																					this.wa1,
																					this.wa5,
																					this.wa3,
																					this.wa6});
			this.groupBox5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox5.Location = new System.Drawing.Point(304, 320);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(264, 176);
			this.groupBox5.TabIndex = 28;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Weighted Average";
			// 
			// label26
			// 
			this.label26.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label26.Location = new System.Drawing.Point(8, 96);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(152, 16);
			this.label26.TabIndex = 24;
			this.label26.Text = "Random Days";
			// 
			// label27
			// 
			this.label27.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label27.Location = new System.Drawing.Point(8, 120);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(160, 16);
			this.label27.TabIndex = 25;
			this.label27.Text = "Random Customers";
			// 
			// label28
			// 
			this.label28.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label28.Location = new System.Drawing.Point(8, 24);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(168, 16);
			this.label28.TabIndex = 21;
			this.label28.Text = "Systematic Method";
			// 
			// label29
			// 
			this.label29.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label29.Location = new System.Drawing.Point(8, 48);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(120, 16);
			this.label29.TabIndex = 22;
			this.label29.Text = "FCFS Left to Right";
			// 
			// label30
			// 
			this.label30.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label30.Location = new System.Drawing.Point(8, 144);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(168, 16);
			this.label30.TabIndex = 26;
			this.label30.Text = "Complete Random";
			// 
			// label31
			// 
			this.label31.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label31.Location = new System.Drawing.Point(8, 72);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(152, 16);
			this.label31.TabIndex = 23;
			this.label31.Text = "FCFS Right to Left";
			// 
			// wa4
			// 
			this.wa4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.wa4.Location = new System.Drawing.Point(184, 96);
			this.wa4.Name = "wa4";
			this.wa4.ReadOnly = true;
			this.wa4.Size = new System.Drawing.Size(72, 20);
			this.wa4.TabIndex = 17;
			this.wa4.Text = "";
			// 
			// wa2
			// 
			this.wa2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.wa2.Location = new System.Drawing.Point(184, 48);
			this.wa2.Name = "wa2";
			this.wa2.ReadOnly = true;
			this.wa2.Size = new System.Drawing.Size(72, 20);
			this.wa2.TabIndex = 15;
			this.wa2.Text = "";
			// 
			// wa1
			// 
			this.wa1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.wa1.Location = new System.Drawing.Point(184, 24);
			this.wa1.Name = "wa1";
			this.wa1.ReadOnly = true;
			this.wa1.Size = new System.Drawing.Size(72, 20);
			this.wa1.TabIndex = 1;
			this.wa1.Text = "";
			// 
			// wa5
			// 
			this.wa5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.wa5.Location = new System.Drawing.Point(184, 120);
			this.wa5.Name = "wa5";
			this.wa5.ReadOnly = true;
			this.wa5.Size = new System.Drawing.Size(72, 20);
			this.wa5.TabIndex = 18;
			this.wa5.Text = "";
			// 
			// wa3
			// 
			this.wa3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.wa3.Location = new System.Drawing.Point(184, 72);
			this.wa3.Name = "wa3";
			this.wa3.ReadOnly = true;
			this.wa3.Size = new System.Drawing.Size(72, 20);
			this.wa3.TabIndex = 16;
			this.wa3.Text = "";
			// 
			// wa6
			// 
			this.wa6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.wa6.Location = new System.Drawing.Point(184, 144);
			this.wa6.Name = "wa6";
			this.wa6.ReadOnly = true;
			this.wa6.Size = new System.Drawing.Size(72, 20);
			this.wa6.TabIndex = 20;
			this.wa6.Text = "";
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
																					this.label32,
																					this.label33,
																					this.label34,
																					this.label35,
																					this.label36,
																					this.label37});
			this.groupBox6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox6.Location = new System.Drawing.Point(576, 312);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(224, 184);
			this.groupBox6.TabIndex = 29;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Evaluated Position";
			this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
			// 
			// ep4
			// 
			this.ep4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ep4.Location = new System.Drawing.Point(168, 96);
			this.ep4.Name = "ep4";
			this.ep4.ReadOnly = true;
			this.ep4.Size = new System.Drawing.Size(40, 26);
			this.ep4.TabIndex = 36;
			this.ep4.Text = "";
			// 
			// ep2
			// 
			this.ep2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ep2.Location = new System.Drawing.Point(168, 48);
			this.ep2.Name = "ep2";
			this.ep2.ReadOnly = true;
			this.ep2.Size = new System.Drawing.Size(40, 26);
			this.ep2.TabIndex = 34;
			this.ep2.Text = "";
			// 
			// ep1
			// 
			this.ep1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ep1.Location = new System.Drawing.Point(168, 24);
			this.ep1.Name = "ep1";
			this.ep1.ReadOnly = true;
			this.ep1.Size = new System.Drawing.Size(40, 26);
			this.ep1.TabIndex = 33;
			this.ep1.Text = "";
			// 
			// ep5
			// 
			this.ep5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ep5.Location = new System.Drawing.Point(168, 120);
			this.ep5.Name = "ep5";
			this.ep5.ReadOnly = true;
			this.ep5.Size = new System.Drawing.Size(40, 26);
			this.ep5.TabIndex = 37;
			this.ep5.Text = "";
			// 
			// ep3
			// 
			this.ep3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ep3.Location = new System.Drawing.Point(168, 72);
			this.ep3.Name = "ep3";
			this.ep3.ReadOnly = true;
			this.ep3.Size = new System.Drawing.Size(40, 26);
			this.ep3.TabIndex = 35;
			this.ep3.Text = "";
			// 
			// ep6
			// 
			this.ep6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ep6.Location = new System.Drawing.Point(168, 144);
			this.ep6.Name = "ep6";
			this.ep6.ReadOnly = true;
			this.ep6.Size = new System.Drawing.Size(40, 26);
			this.ep6.TabIndex = 38;
			this.ep6.Text = "";
			// 
			// label32
			// 
			this.label32.Font = new System.Drawing.Font("Arial", 12F, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label32.Location = new System.Drawing.Point(8, 104);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(152, 16);
			this.label32.TabIndex = 30;
			this.label32.Text = "Days";
			// 
			// label33
			// 
			this.label33.Font = new System.Drawing.Font("Arial", 12F, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label33.Location = new System.Drawing.Point(8, 128);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(144, 16);
			this.label33.TabIndex = 31;
			this.label33.Text = "Customers";
			// 
			// label34
			// 
			this.label34.Font = new System.Drawing.Font("Arial", 12F, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label34.Location = new System.Drawing.Point(8, 32);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(128, 16);
			this.label34.TabIndex = 27;
			this.label34.Text = "Systematic";
			// 
			// label35
			// 
			this.label35.Font = new System.Drawing.Font("Arial", 12F, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label35.Location = new System.Drawing.Point(8, 56);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(120, 16);
			this.label35.TabIndex = 28;
			this.label35.Text = "FCFS L to R";
			// 
			// label36
			// 
			this.label36.Font = new System.Drawing.Font("Arial", 12F, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label36.Location = new System.Drawing.Point(8, 152);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(136, 16);
			this.label36.TabIndex = 32;
			this.label36.Text = "Complete";
			// 
			// label37
			// 
			this.label37.Font = new System.Drawing.Font("Arial", 12F, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label37.Location = new System.Drawing.Point(8, 80);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(152, 16);
			this.label37.TabIndex = 29;
			this.label37.Text = "FCFS R to L";
			// 
			// SMEHeuCom
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(10, 22);
			this.ClientSize = new System.Drawing.Size(804, 578);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
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
				
			Console.WriteLine("{0} {1}",rank1,rank2);


			this.ep1.Text=rank1.ToString();
			this.ep2.Text=rank2.ToString();
			this.ep3.Text=rank3.ToString();
			this.ep4.Text=rank4.ToString();
			this.ep5.Text=rank5.ToString();
			this.ep6.Text=rank6.ToString();

		}

		private void groupBox6_Enter(object sender, System.EventArgs e)
		{
		
		}

	}
		
}
