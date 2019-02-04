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
	public class HiddenResults : System.Windows.Forms.Form 
	{
		private System.Windows.Forms.Label label1;
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
		public System.Windows.Forms.TextBox t1;
		public System.Windows.Forms.TextBox t2;
		public System.Windows.Forms.TextBox t3;
		public System.Windows.Forms.TextBox t4;
		public System.Windows.Forms.TextBox t5;
		public System.Windows.Forms.TextBox t6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		public System.Windows.Forms.TextBox ard4;
		public System.Windows.Forms.TextBox ard2;
		public System.Windows.Forms.TextBox ard1;
		public System.Windows.Forms.TextBox ard5;
		public System.Windows.Forms.TextBox ard3;
		public System.Windows.Forms.TextBox ard6;
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
		public System.Windows.Forms.Label label5;
		public System.Windows.Forms.Label label6;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.Label label7;
		public System.Windows.Forms.Label label4;
		public System.Windows.Forms.Label label8;
		public System.Windows.Forms.Label label9;
		public System.Windows.Forms.Label label10;
		public System.Windows.Forms.Label label11;
		public System.Windows.Forms.Label label12;
		public System.Windows.Forms.Label label13;
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
		public System.Windows.Forms.TextBox wa6;


		public HiddenResults()
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
			this.t2 = new System.Windows.Forms.TextBox();
			this.t3 = new System.Windows.Forms.TextBox();
			this.t4 = new System.Windows.Forms.TextBox();
			this.t5 = new System.Windows.Forms.TextBox();
			this.t6 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.ard4 = new System.Windows.Forms.TextBox();
			this.ard2 = new System.Windows.Forms.TextBox();
			this.ard1 = new System.Windows.Forms.TextBox();
			this.ard5 = new System.Windows.Forms.TextBox();
			this.ard3 = new System.Windows.Forms.TextBox();
			this.ard6 = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.ar4 = new System.Windows.Forms.TextBox();
			this.ar2 = new System.Windows.Forms.TextBox();
			this.ar1 = new System.Windows.Forms.TextBox();
			this.ar5 = new System.Windows.Forms.TextBox();
			this.ar3 = new System.Windows.Forms.TextBox();
			this.ar6 = new System.Windows.Forms.TextBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.wa4 = new System.Windows.Forms.TextBox();
			this.wa2 = new System.Windows.Forms.TextBox();
			this.wa1 = new System.Windows.Forms.TextBox();
			this.wa5 = new System.Windows.Forms.TextBox();
			this.wa3 = new System.Windows.Forms.TextBox();
			this.wa6 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(728, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Inputs  Compared using various Performance Measures";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// t1
			// 
			this.t1.AutoSize = false;
			this.t1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.t1.ForeColor = System.Drawing.Color.Blue;
			this.t1.Location = new System.Drawing.Point(200, 24);
			this.t1.MaxLength = 5;
			this.t1.Name = "t1";
			this.t1.ReadOnly = true;
			this.t1.Size = new System.Drawing.Size(64, 20);
			this.t1.TabIndex = 1;
			this.t1.Text = "";
			this.t1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// t2
			// 
			this.t2.AutoSize = false;
			this.t2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.t2.ForeColor = System.Drawing.Color.Blue;
			this.t2.Location = new System.Drawing.Point(200, 48);
			this.t2.MaxLength = 5;
			this.t2.Name = "t2";
			this.t2.ReadOnly = true;
			this.t2.Size = new System.Drawing.Size(64, 20);
			this.t2.TabIndex = 15;
			this.t2.Text = "";
			this.t2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// t3
			// 
			this.t3.AutoSize = false;
			this.t3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.t3.ForeColor = System.Drawing.Color.Blue;
			this.t3.Location = new System.Drawing.Point(200, 72);
			this.t3.MaxLength = 5;
			this.t3.Name = "t3";
			this.t3.ReadOnly = true;
			this.t3.Size = new System.Drawing.Size(64, 20);
			this.t3.TabIndex = 16;
			this.t3.Text = "";
			this.t3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// t4
			// 
			this.t4.AutoSize = false;
			this.t4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.t4.ForeColor = System.Drawing.Color.Blue;
			this.t4.Location = new System.Drawing.Point(200, 96);
			this.t4.MaxLength = 5;
			this.t4.Name = "t4";
			this.t4.ReadOnly = true;
			this.t4.Size = new System.Drawing.Size(64, 20);
			this.t4.TabIndex = 17;
			this.t4.Text = "";
			this.t4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// t5
			// 
			this.t5.AutoSize = false;
			this.t5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.t5.ForeColor = System.Drawing.Color.Blue;
			this.t5.Location = new System.Drawing.Point(200, 120);
			this.t5.MaxLength = 5;
			this.t5.Name = "t5";
			this.t5.ReadOnly = true;
			this.t5.Size = new System.Drawing.Size(64, 20);
			this.t5.TabIndex = 18;
			this.t5.Text = "";
			this.t5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// t6
			// 
			this.t6.AutoSize = false;
			this.t6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.t6.ForeColor = System.Drawing.Color.Blue;
			this.t6.Location = new System.Drawing.Point(200, 144);
			this.t6.MaxLength = 5;
			this.t6.Name = "t6";
			this.t6.ReadOnly = true;
			this.t6.Size = new System.Drawing.Size(64, 20);
			this.t6.TabIndex = 20;
			this.t6.Text = "";
			this.t6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label5,
																					this.label6,
																					this.label2,
																					this.label3,
																					this.label7,
																					this.label4,
																					this.t4,
																					this.t2,
																					this.t1,
																					this.t5,
																					this.t3,
																					this.t6});
			this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.Lime;
			this.groupBox1.Location = new System.Drawing.Point(40, 80);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(296, 176);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Avg Penalty";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label8,
																					this.label9,
																					this.label10,
																					this.label11,
																					this.label12,
																					this.label13,
																					this.ard4,
																					this.ard2,
																					this.ard1,
																					this.ard5,
																					this.ard3,
																					this.ard6});
			this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.Lime;
			this.groupBox2.Location = new System.Drawing.Point(368, 80);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(320, 176);
			this.groupBox2.TabIndex = 25;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = " Relative  Percentage  Deviation";
			// 
			// ard4
			// 
			this.ard4.AutoSize = false;
			this.ard4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ard4.ForeColor = System.Drawing.Color.Blue;
			this.ard4.Location = new System.Drawing.Point(224, 96);
			this.ard4.MaxLength = 5;
			this.ard4.Name = "ard4";
			this.ard4.ReadOnly = true;
			this.ard4.Size = new System.Drawing.Size(64, 20);
			this.ard4.TabIndex = 17;
			this.ard4.Text = "";
			this.ard4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ard2
			// 
			this.ard2.AutoSize = false;
			this.ard2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ard2.ForeColor = System.Drawing.Color.Blue;
			this.ard2.Location = new System.Drawing.Point(224, 48);
			this.ard2.MaxLength = 5;
			this.ard2.Name = "ard2";
			this.ard2.ReadOnly = true;
			this.ard2.Size = new System.Drawing.Size(64, 20);
			this.ard2.TabIndex = 15;
			this.ard2.Text = "";
			this.ard2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ard1
			// 
			this.ard1.AutoSize = false;
			this.ard1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ard1.ForeColor = System.Drawing.Color.Blue;
			this.ard1.Location = new System.Drawing.Point(224, 24);
			this.ard1.MaxLength = 5;
			this.ard1.Name = "ard1";
			this.ard1.ReadOnly = true;
			this.ard1.Size = new System.Drawing.Size(64, 20);
			this.ard1.TabIndex = 1;
			this.ard1.Text = "";
			this.ard1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ard5
			// 
			this.ard5.AutoSize = false;
			this.ard5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ard5.ForeColor = System.Drawing.Color.Blue;
			this.ard5.Location = new System.Drawing.Point(224, 120);
			this.ard5.MaxLength = 5;
			this.ard5.Name = "ard5";
			this.ard5.ReadOnly = true;
			this.ard5.Size = new System.Drawing.Size(64, 20);
			this.ard5.TabIndex = 18;
			this.ard5.Text = "";
			this.ard5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ard3
			// 
			this.ard3.AutoSize = false;
			this.ard3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ard3.ForeColor = System.Drawing.Color.Blue;
			this.ard3.Location = new System.Drawing.Point(224, 72);
			this.ard3.MaxLength = 5;
			this.ard3.Name = "ard3";
			this.ard3.ReadOnly = true;
			this.ard3.Size = new System.Drawing.Size(64, 20);
			this.ard3.TabIndex = 16;
			this.ard3.Text = "";
			this.ard3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ard6
			// 
			this.ard6.AutoSize = false;
			this.ard6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ard6.ForeColor = System.Drawing.Color.Blue;
			this.ard6.Location = new System.Drawing.Point(224, 144);
			this.ard6.MaxLength = 5;
			this.ard6.Name = "ard6";
			this.ard6.ReadOnly = true;
			this.ard6.Size = new System.Drawing.Size(64, 20);
			this.ard6.TabIndex = 20;
			this.ard6.Text = "";
			this.ard6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
			this.groupBox4.ForeColor = System.Drawing.Color.Lime;
			this.groupBox4.Location = new System.Drawing.Point(40, 280);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(296, 184);
			this.groupBox4.TabIndex = 27;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Avg Ranking";
			// 
			// ar4
			// 
			this.ar4.AutoSize = false;
			this.ar4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ar4.ForeColor = System.Drawing.Color.Blue;
			this.ar4.Location = new System.Drawing.Point(200, 96);
			this.ar4.MaxLength = 5;
			this.ar4.Name = "ar4";
			this.ar4.ReadOnly = true;
			this.ar4.Size = new System.Drawing.Size(72, 20);
			this.ar4.TabIndex = 17;
			this.ar4.Text = "";
			this.ar4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ar2
			// 
			this.ar2.AutoSize = false;
			this.ar2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ar2.ForeColor = System.Drawing.Color.Blue;
			this.ar2.Location = new System.Drawing.Point(200, 48);
			this.ar2.MaxLength = 5;
			this.ar2.Name = "ar2";
			this.ar2.ReadOnly = true;
			this.ar2.Size = new System.Drawing.Size(72, 20);
			this.ar2.TabIndex = 15;
			this.ar2.Text = "";
			this.ar2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ar1
			// 
			this.ar1.AutoSize = false;
			this.ar1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ar1.ForeColor = System.Drawing.Color.Blue;
			this.ar1.Location = new System.Drawing.Point(200, 24);
			this.ar1.MaxLength = 5;
			this.ar1.Name = "ar1";
			this.ar1.ReadOnly = true;
			this.ar1.Size = new System.Drawing.Size(72, 20);
			this.ar1.TabIndex = 1;
			this.ar1.Text = "";
			this.ar1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ar5
			// 
			this.ar5.AutoSize = false;
			this.ar5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ar5.ForeColor = System.Drawing.Color.Blue;
			this.ar5.Location = new System.Drawing.Point(200, 120);
			this.ar5.MaxLength = 5;
			this.ar5.Name = "ar5";
			this.ar5.ReadOnly = true;
			this.ar5.Size = new System.Drawing.Size(72, 20);
			this.ar5.TabIndex = 18;
			this.ar5.Text = "";
			this.ar5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ar3
			// 
			this.ar3.AutoSize = false;
			this.ar3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ar3.ForeColor = System.Drawing.Color.Blue;
			this.ar3.Location = new System.Drawing.Point(200, 72);
			this.ar3.MaxLength = 5;
			this.ar3.Name = "ar3";
			this.ar3.ReadOnly = true;
			this.ar3.Size = new System.Drawing.Size(72, 20);
			this.ar3.TabIndex = 16;
			this.ar3.Text = "";
			this.ar3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ar6
			// 
			this.ar6.AutoSize = false;
			this.ar6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ar6.ForeColor = System.Drawing.Color.Blue;
			this.ar6.Location = new System.Drawing.Point(200, 144);
			this.ar6.MaxLength = 5;
			this.ar6.Name = "ar6";
			this.ar6.ReadOnly = true;
			this.ar6.Size = new System.Drawing.Size(72, 20);
			this.ar6.TabIndex = 20;
			this.ar6.Text = "";
			this.ar6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label14,
																					this.label15,
																					this.label16,
																					this.label17,
																					this.label18,
																					this.label19,
																					this.wa4,
																					this.wa2,
																					this.wa1,
																					this.wa5,
																					this.wa3,
																					this.wa6});
			this.groupBox5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox5.ForeColor = System.Drawing.Color.Lime;
			this.groupBox5.Location = new System.Drawing.Point(368, 288);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(320, 176);
			this.groupBox5.TabIndex = 28;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Weighted Average";
			// 
			// wa4
			// 
			this.wa4.AutoSize = false;
			this.wa4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.wa4.ForeColor = System.Drawing.Color.Blue;
			this.wa4.Location = new System.Drawing.Point(224, 88);
			this.wa4.MaxLength = 5;
			this.wa4.Name = "wa4";
			this.wa4.ReadOnly = true;
			this.wa4.Size = new System.Drawing.Size(72, 20);
			this.wa4.TabIndex = 17;
			this.wa4.Text = "";
			this.wa4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// wa2
			// 
			this.wa2.AutoSize = false;
			this.wa2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.wa2.ForeColor = System.Drawing.Color.Blue;
			this.wa2.Location = new System.Drawing.Point(224, 40);
			this.wa2.MaxLength = 5;
			this.wa2.Name = "wa2";
			this.wa2.ReadOnly = true;
			this.wa2.Size = new System.Drawing.Size(72, 20);
			this.wa2.TabIndex = 15;
			this.wa2.Text = "";
			this.wa2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// wa1
			// 
			this.wa1.AutoSize = false;
			this.wa1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.wa1.ForeColor = System.Drawing.Color.Blue;
			this.wa1.Location = new System.Drawing.Point(224, 16);
			this.wa1.MaxLength = 5;
			this.wa1.Name = "wa1";
			this.wa1.ReadOnly = true;
			this.wa1.Size = new System.Drawing.Size(72, 20);
			this.wa1.TabIndex = 1;
			this.wa1.Text = "";
			this.wa1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// wa5
			// 
			this.wa5.AutoSize = false;
			this.wa5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.wa5.ForeColor = System.Drawing.Color.Blue;
			this.wa5.Location = new System.Drawing.Point(224, 112);
			this.wa5.MaxLength = 5;
			this.wa5.Name = "wa5";
			this.wa5.ReadOnly = true;
			this.wa5.Size = new System.Drawing.Size(72, 20);
			this.wa5.TabIndex = 18;
			this.wa5.Text = "";
			this.wa5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// wa3
			// 
			this.wa3.AutoSize = false;
			this.wa3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.wa3.ForeColor = System.Drawing.Color.Blue;
			this.wa3.Location = new System.Drawing.Point(224, 64);
			this.wa3.MaxLength = 5;
			this.wa3.Name = "wa3";
			this.wa3.ReadOnly = true;
			this.wa3.Size = new System.Drawing.Size(72, 20);
			this.wa3.TabIndex = 16;
			this.wa3.Text = "";
			this.wa3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// wa6
			// 
			this.wa6.AutoSize = false;
			this.wa6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.wa6.ForeColor = System.Drawing.Color.Blue;
			this.wa6.Location = new System.Drawing.Point(224, 136);
			this.wa6.MaxLength = 5;
			this.wa6.Name = "wa6";
			this.wa6.ReadOnly = true;
			this.wa6.Size = new System.Drawing.Size(72, 20);
			this.wa6.TabIndex = 20;
			this.wa6.Text = "";
			this.wa6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Black;
			this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Yellow;
			this.label5.Location = new System.Drawing.Point(8, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(176, 16);
			this.label5.TabIndex = 24;
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
			this.label6.TabIndex = 25;
			this.label6.Text = "Random Customers";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Black;
			this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Yellow;
			this.label2.Location = new System.Drawing.Point(8, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(176, 16);
			this.label2.TabIndex = 21;
			this.label2.Text = "Systematic Method";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Black;
			this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Yellow;
			this.label3.Location = new System.Drawing.Point(8, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(176, 16);
			this.label3.TabIndex = 22;
			this.label3.Text = "First Day First Customer";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Black;
			this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Yellow;
			this.label7.Location = new System.Drawing.Point(8, 144);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(176, 16);
			this.label7.TabIndex = 26;
			this.label7.Text = "Complete Random";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Black;
			this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Yellow;
			this.label4.Location = new System.Drawing.Point(8, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(176, 16);
			this.label4.TabIndex = 23;
			this.label4.Text = "Last Day First Customer";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Black;
			this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Yellow;
			this.label8.Location = new System.Drawing.Point(16, 96);
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
			this.label9.Location = new System.Drawing.Point(16, 120);
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
			this.label10.Location = new System.Drawing.Point(16, 24);
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
			this.label11.Location = new System.Drawing.Point(16, 48);
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
			this.label12.Location = new System.Drawing.Point(16, 144);
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
			this.label13.Location = new System.Drawing.Point(16, 72);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(176, 16);
			this.label13.TabIndex = 23;
			this.label13.Text = "Last Day First Customer";
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Black;
			this.label14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Yellow;
			this.label14.Location = new System.Drawing.Point(16, 96);
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
			this.label15.Location = new System.Drawing.Point(16, 120);
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
			this.label16.Location = new System.Drawing.Point(16, 24);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(176, 16);
			this.label16.TabIndex = 21;
			this.label16.Text = "Systematic Method";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Black;
			this.label17.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label17.ForeColor = System.Drawing.Color.Yellow;
			this.label17.Location = new System.Drawing.Point(16, 48);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(176, 16);
			this.label17.TabIndex = 22;
			this.label17.Text = "First Day First Customer";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Black;
			this.label18.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label18.ForeColor = System.Drawing.Color.Yellow;
			this.label18.Location = new System.Drawing.Point(16, 144);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(176, 16);
			this.label18.TabIndex = 26;
			this.label18.Text = "Complete Random";
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Black;
			this.label19.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label19.ForeColor = System.Drawing.Color.Yellow;
			this.label19.Location = new System.Drawing.Point(16, 72);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(176, 16);
			this.label19.TabIndex = 23;
			this.label19.Text = "Last Day First Customer";
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Black;
			this.label20.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label20.ForeColor = System.Drawing.Color.Yellow;
			this.label20.Location = new System.Drawing.Point(16, 96);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(176, 16);
			this.label20.TabIndex = 24;
			this.label20.Text = "Random Days";
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Black;
			this.label21.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label21.ForeColor = System.Drawing.Color.Yellow;
			this.label21.Location = new System.Drawing.Point(16, 120);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(176, 16);
			this.label21.TabIndex = 25;
			this.label21.Text = "Random Customers";
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.Black;
			this.label22.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label22.ForeColor = System.Drawing.Color.Yellow;
			this.label22.Location = new System.Drawing.Point(16, 24);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(176, 16);
			this.label22.TabIndex = 21;
			this.label22.Text = "Systematic Method";
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.Black;
			this.label23.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label23.ForeColor = System.Drawing.Color.Yellow;
			this.label23.Location = new System.Drawing.Point(16, 48);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(176, 16);
			this.label23.TabIndex = 22;
			this.label23.Text = "First Day First Customer";
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.Black;
			this.label24.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label24.ForeColor = System.Drawing.Color.Yellow;
			this.label24.Location = new System.Drawing.Point(16, 144);
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
			this.label25.Location = new System.Drawing.Point(16, 72);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(176, 16);
			this.label25.TabIndex = 23;
			this.label25.Text = "Last Day First Customer";
			// 
			// HiddenResults
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(10, 22);
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(728, 502);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox5,
																		  this.groupBox4,
																		  this.groupBox2,
																		  this.groupBox1,
																		  this.label1});
			this.Font = new System.Drawing.Font("Arial", 14.25F, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "HiddenResults";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Heuristics Comparision";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		private void Form1_Load(object sender, System.EventArgs e)
		{
			sample_input_count=1;
			

			penaltyAlgo1 = new int [sample_input_count];
			penaltyAlgo2 = new int [sample_input_count];
			penaltyAlgo3 = new int [sample_input_count];
			penaltyAlgo4 = new int [sample_input_count];
			penaltyAlgo5 = new int [sample_input_count];
			penaltyAlgo6 = new int [sample_input_count];

			best_heuristic_solution = new int [sample_input_count];

			rd_Algo1 = new double [sample_input_count];
			rd_Algo2 = new double [sample_input_count];
			rd_Algo3 = new double [sample_input_count];
			rd_Algo4 = new double [sample_input_count];
			rd_Algo5 = new double [sample_input_count];
			rd_Algo6 = new double [sample_input_count];
				
			penaltyAlgo1[0]=Form1.alloc.pen[0];
			penaltyAlgo2[0]=Form1.alloc.pen[1];
			penaltyAlgo3[0]=Form1.alloc.pen[2];
			penaltyAlgo4[0]=Form1.alloc.pen[3];
			penaltyAlgo5[0]=Form1.alloc.pen[4];
			penaltyAlgo6[0]=Form1.alloc.pen[5];


			find_min_heuristic_instance();
			find_ARPD();
			find_RANK();
			weighted_average_rank();

			penalty_avg_algo1 =0;
			penalty_avg_algo2 =0;
			penalty_avg_algo3 =0;
			penalty_avg_algo4 =0;
			penalty_avg_algo5 =0;
			penalty_avg_algo6 =0;


			for(int i=0;i<sample_input_count;i++)
			{
				penalty_avg_algo1 += penaltyAlgo1[i];
				penalty_avg_algo2 += penaltyAlgo2[i];
				penalty_avg_algo3 += penaltyAlgo3[i];
				penalty_avg_algo4 += penaltyAlgo4[i];
				penalty_avg_algo5 += penaltyAlgo5[i];
				penalty_avg_algo6 += penaltyAlgo6[i];
			}

			penalty_avg_algo1=penalty_avg_algo1/sample_input_count;
			penalty_avg_algo2=penalty_avg_algo2/sample_input_count;
			penalty_avg_algo3=penalty_avg_algo3/sample_input_count;
			penalty_avg_algo4=penalty_avg_algo4/sample_input_count;
			penalty_avg_algo5=penalty_avg_algo5/sample_input_count;
			penalty_avg_algo6=penalty_avg_algo6/sample_input_count;


			t1.Text=penalty_avg_algo1.ToString();
			t2.Text=penalty_avg_algo2.ToString();
			t3.Text=penalty_avg_algo3.ToString();
			t4.Text=penalty_avg_algo4.ToString();
			t5.Text=penalty_avg_algo5.ToString();
			t6.Text=penalty_avg_algo6.ToString();

			evaluated_position();
		}
		
		
		void weighted_average_rank()
		{
			int i,j;

			FileInfo f2 = new FileInfo(@"..\..\outputs\Weighte_Average.xls");
			StreamWriter writer = f2.CreateText();

			rank_count_Algo1 = new int[6];
			rank_count_Algo2 = new int[6];
			rank_count_Algo3 = new int[6];
			rank_count_Algo4 = new int[6];
			rank_count_Algo5 = new int[6];
			rank_count_Algo6 = new int[6];

			for(i=0;i<6;i++)
			{
				rank_count_Algo1[i]=0;
				rank_count_Algo2[i]=0;
				rank_count_Algo3[i]=0;
				rank_count_Algo4[i]=0;
				rank_count_Algo5[i]=0;
				rank_count_Algo6[i]=0;
			}

			for(i=0;i<sample_input_count;i++)
			{
				if(rank_Algo1[i]==1)
					rank_count_Algo1[0]++;
				else
					if(rank_Algo1[i]==2)
					rank_count_Algo1[1]++;
				else
					if(rank_Algo1[i]==3)
					rank_count_Algo1[2]++;
				else
					if(rank_Algo1[i]==4)
					rank_count_Algo1[3]++;
				else
					if(rank_Algo1[i]==5)
					rank_count_Algo1[4]++;
				else
					if(rank_Algo1[i]==6)
					rank_count_Algo1[5]++;
			}

			for(i=0;i<sample_input_count;i++)
			{
				if(rank_Algo2[i]==1)
					rank_count_Algo2[0]++;
				else
					if(rank_Algo2[i]==2)
					rank_count_Algo2[1]++;
				else
					if(rank_Algo2[i]==3)
					rank_count_Algo2[2]++;
				else
					if(rank_Algo2[i]==4)
					rank_count_Algo2[3]++;
				else
					if(rank_Algo2[i]==5)
					rank_count_Algo2[4]++;
				else
					if(rank_Algo2[i]==6)
					rank_count_Algo2[5]++;
			}

			for(i=0;i<sample_input_count;i++)
			{
				if(rank_Algo3[i]==1)
					rank_count_Algo3[0]++;
				else
					if(rank_Algo3[i]==2)
					rank_count_Algo3[1]++;
				else
					if(rank_Algo3[i]==3)
					rank_count_Algo3[2]++;
				else
					if(rank_Algo3[i]==4)
					rank_count_Algo3[3]++;
				else
					if(rank_Algo3[i]==5)
					rank_count_Algo3[4]++;
				else
					if(rank_Algo3[i]==6)
					rank_count_Algo3[5]++;
			}

			for(i=0;i<sample_input_count;i++)
			{
				if(rank_Algo4[i]==1)
					rank_count_Algo4[0]++;
				else
					if(rank_Algo4[i]==2)
					rank_count_Algo4[1]++;
				else
					if(rank_Algo4[i]==3)
					rank_count_Algo4[2]++;
				else
					if(rank_Algo4[i]==4)
					rank_count_Algo4[3]++;
				else
					if(rank_Algo4[i]==5)
					rank_count_Algo4[4]++;
				else
					if(rank_Algo4[i]==6)
					rank_count_Algo4[5]++;
			}

			for(i=0;i<sample_input_count;i++)
			{
				if(rank_Algo5[i]==1)
					rank_count_Algo5[0]++;
				else
					if(rank_Algo5[i]==2)
					rank_count_Algo5[1]++;
				else
					if(rank_Algo5[i]==3)
					rank_count_Algo5[2]++;
				else
					if(rank_Algo5[i]==4)
					rank_count_Algo5[3]++;
				else
					if(rank_Algo5[i]==5)
					rank_count_Algo5[4]++;
				else
					if(rank_Algo5[i]==6)
					rank_count_Algo5[5]++;
			}

			for(i=0;i<sample_input_count;i++)
			{
				if(rank_Algo6[i]==1)
					rank_count_Algo6[0]++;
				else
					if(rank_Algo6[i]==2)
					rank_count_Algo6[1]++;
				else
					if(rank_Algo6[i]==3)
					rank_count_Algo6[2]++;
				else
					if(rank_Algo6[i]==4)
					rank_count_Algo6[3]++;
				else
					if(rank_Algo6[i]==5)
					rank_count_Algo6[4]++;
				else
					if(rank_Algo6[i]==6)
					rank_count_Algo6[5]++;
			}


			weighted_avg_Algo1=0;
			weighted_avg_Algo2=0;
			weighted_avg_Algo3=0;
			weighted_avg_Algo4=0;
			weighted_avg_Algo5=0;
			weighted_avg_Algo6=0;

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
							writer.Write("{0}\t",rank_count_Algo1[j]);
							weighted_avg_Algo1+=rank_count_Algo1[j]*temp;
							temp--;
						}
						weighted_avg_Algo1/=243;
						writer.Write("{0}\n",weighted_avg_Algo1);
						break;

					case 2:
						writer.Write("Algo2\t");
						temp=6;
						for(j=0;j<6;j++)
						{
							writer.Write("{0}\t",rank_count_Algo2[j]);
							weighted_avg_Algo2+=rank_count_Algo2[j]*temp;
							temp--;
						}
						weighted_avg_Algo2/=243;
						writer.Write("{0}\n",weighted_avg_Algo2);
						break;

					case 3:
						writer.Write("Algo3\t");
						temp=6;
						for(j=0;j<6;j++)
						{
							writer.Write("{0}\t",rank_count_Algo3[j]);
							weighted_avg_Algo3+=rank_count_Algo3[j]*temp;
							temp--;
						}
						weighted_avg_Algo3/=243;
						writer.Write("{0}\n",weighted_avg_Algo3);
						break;

					case 4:
						writer.Write("Algo4\t");
						temp=6;
						for(j=0;j<6;j++)
						{
							writer.Write("{0}\t",rank_count_Algo4[j]);
							weighted_avg_Algo4+=rank_count_Algo4[j]*temp;
							temp--;
						}
						weighted_avg_Algo4/=243;
						writer.Write("{0}\n",weighted_avg_Algo4);
						break;

					case 5:
						writer.Write("Algo5\t");
						temp=6;
						for(j=0;j<6;j++)
						{
							writer.Write("{0}\t",rank_count_Algo5[j]);
							weighted_avg_Algo5+=rank_count_Algo5[j]*temp;
							temp--;
						}
						weighted_avg_Algo5/=243;
						writer.Write("{0}\n",weighted_avg_Algo5);
						break;

					case 6:
						writer.Write("Algo6\t");
						temp=6;
						for(j=0;j<6;j++)
						{
							writer.Write("{0}\t",rank_count_Algo6[j]);
							weighted_avg_Algo6+=rank_count_Algo6[j]*temp;
							temp--;
						}
						weighted_avg_Algo6/=243;
						writer.Write("{0}\n",weighted_avg_Algo6);
						break;
				}
			}
			writer.Close();

			//code for filling the weighted average textbox
			wa1.Text=weighted_avg_Algo1.ToString();
			wa2.Text=weighted_avg_Algo2.ToString();
			wa3.Text=weighted_avg_Algo3.ToString();
			wa4.Text=weighted_avg_Algo4.ToString();
			wa5.Text=weighted_avg_Algo5.ToString();
			wa6.Text=weighted_avg_Algo6.ToString();
			wa1.MaxLength=2;
		}



		void maxRD()
		{
		}


		void find_min_heuristic_instance()
		{
			int min;
			int i;

			for(i=0;i<sample_input_count;i++)
			{
				min = 99999;

				if(penaltyAlgo1[i] < min)
					min=penaltyAlgo1[i];

				if(penaltyAlgo2[i] < min)
					min=penaltyAlgo2[i];

				if(penaltyAlgo3[i] < min)
					min=penaltyAlgo3[i];

				if(penaltyAlgo4[i] < min)
					min=penaltyAlgo4[i];

				if(penaltyAlgo5[i] < min)
					min=penaltyAlgo5[i];

				if(penaltyAlgo6[i] < min)
					min=penaltyAlgo6[i];

				best_heuristic_solution[i]=min;
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
				if(this.best_heuristic_solution[i]!=0)
				{
					this.rd_Algo1[i]=((double)(this.penaltyAlgo1[i] - this.best_heuristic_solution[i]))/this.best_heuristic_solution[i];
					this.rd_Algo2[i]=((double)(this.penaltyAlgo2[i] - this.best_heuristic_solution[i]))/this.best_heuristic_solution[i];
					this.rd_Algo3[i]=((double)(this.penaltyAlgo3[i] - this.best_heuristic_solution[i]))/this.best_heuristic_solution[i];
					this.rd_Algo4[i]=((double)(this.penaltyAlgo4[i] - this.best_heuristic_solution[i]))/this.best_heuristic_solution[i];
					this.rd_Algo5[i]=((double)(this.penaltyAlgo5[i] - this.best_heuristic_solution[i]))/this.best_heuristic_solution[i];
					this.rd_Algo6[i]=((double)(this.penaltyAlgo6[i] - this.best_heuristic_solution[i]))/this.best_heuristic_solution[i];
				}
				else
				{
					this.rd_Algo1[i]=(double)this.penaltyAlgo1[i];
					this.rd_Algo2[i]=(double)this.penaltyAlgo2[i];
					this.rd_Algo3[i]=(double)this.penaltyAlgo3[i];
					this.rd_Algo4[i]=(double)this.penaltyAlgo4[i];
					this.rd_Algo5[i]=(double)this.penaltyAlgo5[i];
					this.rd_Algo6[i]=(double)this.penaltyAlgo6[i];
				}
				writer.WriteLine("PI {0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t",i,this.rd_Algo1[i],this.rd_Algo2[i],this.rd_Algo3[i],this.rd_Algo4[i],this.rd_Algo5[i],this.rd_Algo6[i],this.best_heuristic_solution[i]);
			}

			//code to find the maximum RELATIVE DEVIATION and Avg RD
			avgrd_Algo1=0;
			avgrd_Algo2=0;
			avgrd_Algo3=0;
			avgrd_Algo4=0;
			avgrd_Algo5=0;
			avgrd_Algo6=0;

			min=-1;
			for(i=0;i<sample_input_count;i++)
			{
				if(rd_Algo1[i] > min)
					min=rd_Algo1[i];
				avgrd_Algo1 +=rd_Algo1[i];
			}
			maxrd_Algo1=min;
			avgrd_Algo1=(avgrd_Algo1)/sample_input_count;

			min=-1;
			for(i=0;i<sample_input_count;i++)
			{
				if(rd_Algo2[i] > min)
					min=rd_Algo2[i];
				avgrd_Algo2 +=rd_Algo2[i];

			}
			maxrd_Algo2=min;
			avgrd_Algo2=(avgrd_Algo2)/sample_input_count;


			min=-1;
			for(i=0;i<sample_input_count;i++)
			{
				if(rd_Algo3[i] > min)
					min=rd_Algo3[i];
				avgrd_Algo3 +=rd_Algo3[i];
			}
			maxrd_Algo3=min;
			avgrd_Algo3=(avgrd_Algo3)/sample_input_count;


			min=-1;
			for(i=0;i<sample_input_count;i++)
			{
				if(rd_Algo4[i] > min)
					min=rd_Algo4[i];
				avgrd_Algo4 +=rd_Algo4[i];
			}
			maxrd_Algo4=min;
			avgrd_Algo4=(avgrd_Algo4)/sample_input_count;


			min=-1;
			for(i=0;i<sample_input_count;i++)
			{
				if(rd_Algo5[i] > min)
					min=rd_Algo5[i];
				avgrd_Algo5 +=rd_Algo5[i];
			}
			maxrd_Algo5=min;
			avgrd_Algo5=(avgrd_Algo5)/sample_input_count;


			min=-1;
			for(i=0;i<sample_input_count;i++)
			{				
				if(rd_Algo6[i] > min)
					min=rd_Algo6[i];
				avgrd_Algo6 +=rd_Algo6[i];

			}
			maxrd_Algo6=min;
			avgrd_Algo6=(avgrd_Algo6)/sample_input_count;

			//CODE FOR FINDING THE MAX RD ENDS

			writer.WriteLine("\nAvg RD \t{0}\t{1}\t{2}\t{3}\t{4}\t{5}",avgrd_Algo1,avgrd_Algo2,
				avgrd_Algo3,avgrd_Algo4,avgrd_Algo5,avgrd_Algo6);

			//filling the average relative percentage deviation textbox
			avgrd_Algo1 *= 100;
			avgrd_Algo2 *= 100;
			avgrd_Algo3 *= 100;
			avgrd_Algo4 *= 100;
			avgrd_Algo5 *= 100;
			avgrd_Algo6 *= 100;

			ard1.Text=avgrd_Algo1.ToString();
			ard2.Text=avgrd_Algo2.ToString();
			ard3.Text=avgrd_Algo3.ToString();
			ard4.Text=avgrd_Algo4.ToString();
			ard5.Text=avgrd_Algo5.ToString();
			ard6.Text=avgrd_Algo6.ToString();


			writer.WriteLine("\nMax RD \t{0}\t{1}\t{2}\t{3}\t{4}\t{5}",maxrd_Algo1,maxrd_Algo2,
				maxrd_Algo3,maxrd_Algo4,maxrd_Algo5,maxrd_Algo6);

			//filling the max relative deviation textbox
			writer.Close();
		}


		void find_RANK()
		{

			int i,j;
			FileInfo f2 = new FileInfo(@"..\..\outputs\sort.txt");
			StreamWriter writer = f2.CreateText();

			FileInfo f3 = new FileInfo(@"..\..\outputs\rank.xls");
			StreamWriter writer1 = f3.CreateText();

			temp = new double [6];

			rank_Algo1 = new int [sample_input_count];
			rank_Algo2 = new int [sample_input_count];
			rank_Algo3 = new int [sample_input_count];
			rank_Algo4 = new int [sample_input_count];
			rank_Algo5 = new int [sample_input_count];
			rank_Algo6 = new int [sample_input_count];


			writer.WriteLine("\n\nThe Sorted Array for each problem instance is as follows\n\n");
			for(i=0;i<sample_input_count;i++)
			{
				for(j=0;j<6;j++)
				{
					switch(j+1)
					{
						case 1:
							temp[j]=rd_Algo1[i];
							break;

						case 2:
							temp[j]=rd_Algo2[i];
							break;

						case 3:
							temp[j]=rd_Algo3[i];
							break;

						case 4:
							temp[j]=rd_Algo4[i];
							break;

						case 5:
							temp[j]=rd_Algo5[i];
							break;

						case 6:
							temp[j]=rd_Algo6[i];
							break;

					}
				}
				Array.Sort(temp,0,6);
				get_rank(i);
				for(int k=0;k<6;k++)
				{
					//					Console.WriteLine("{0}  ",temp[k]);
					writer.Write("{0}\t",temp[k]);
				}
				writer.WriteLine("");
			}
			writer.Close();
			writer1.WriteLine("\n\n\t\tRANK MATRIX FOR SIX ALGORITHMS");
			writer1.WriteLine("\nProb Instance\tAlgo1\tAlgo2\tAlgo3\tAlgo4\tAlgo5\tAlgo6");
			for(i=0;i<sample_input_count;i++)
			{
				writer1.WriteLine("PI{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}",i,
					rank_Algo1[i],rank_Algo2[i],rank_Algo3[i],
					rank_Algo4[i],rank_Algo5[i],rank_Algo6[i]);
			}
			writer1.Close();

			avg_rank_Algo1=0;
			avg_rank_Algo2=0;
			avg_rank_Algo3=0;
			avg_rank_Algo4=0;
			avg_rank_Algo5=0;
			avg_rank_Algo6=0;

			for(i=0;i<sample_input_count;i++)
			{
				avg_rank_Algo1+=rank_Algo1[i];
				avg_rank_Algo2+=rank_Algo2[i];
				avg_rank_Algo3+=rank_Algo3[i];
				avg_rank_Algo4+=rank_Algo4[i];
				avg_rank_Algo5+=rank_Algo5[i];
				avg_rank_Algo6+=rank_Algo6[i];
			}
			avg_rank_Algo1/=sample_input_count;
			avg_rank_Algo2/=sample_input_count;
			avg_rank_Algo3/=sample_input_count;
			avg_rank_Algo4/=sample_input_count;
			avg_rank_Algo5/=sample_input_count;
			avg_rank_Algo6/=sample_input_count;

			//code to fill the average rank textbox
			ar1.Text=avg_rank_Algo1.ToString();
			ar2.Text=avg_rank_Algo2.ToString();
			ar3.Text=avg_rank_Algo3.ToString();
			ar4.Text=avg_rank_Algo4.ToString();
			ar5.Text=avg_rank_Algo5.ToString();
			ar6.Text=avg_rank_Algo6.ToString();
		}


		void get_rank(int i)
		{
			int j;
			int flag1=0,flag2=0,flag3=0,flag4=0,flag5=0,flag6=0;

			for(j=0;j<6;j++)
			{
				if(temp[j] == rd_Algo1[i] && flag1==0)
				{
					rank_Algo1[i]=j+1;
					flag1=1;
				}
				else
					if(temp[j] == rd_Algo2[i] && flag2==0)
				{
					rank_Algo2[i]=j+1;
					flag2=1;
				}
				else
					if(temp[j] == rd_Algo3[i] && flag3==0)
				{
					rank_Algo3[i]=j+1;
					flag3=1;
				}
				else
					if(temp[j] == rd_Algo4[i] && flag4==0)
				{
					rank_Algo4[i]=j+1;
					flag4=1;
				}
				else
					if(temp[j] == rd_Algo5[i] && flag5==0)
				{
					rank_Algo5[i]=j+1;
					flag5=1;
				}
				else
					if(temp[j] == rd_Algo6[i] && flag6==0)
				{
					rank_Algo6[i]=j+1;
					flag6=1;
				}
			}
		}


		void evaluated_position()
		{
			int i;
			double [] temp;
			temp=new double [6];
			
			//considering weighted average
			temp[0]=this.weighted_avg_Algo1;
			temp[1]=this.weighted_avg_Algo2;
			temp[2]=this.weighted_avg_Algo3;
			temp[3]=this.weighted_avg_Algo4;
			temp[4]=this.weighted_avg_Algo5;
			temp[5]=this.weighted_avg_Algo6;

			Array.Sort(temp,0,6);
			double algo1,algo2,algo3,algo5,algo6,algo4;
			int flag1=0,flag2=0,flag3=0,flag4=0,flag5=0,flag6=0;
			algo1=0;
			algo2=0;
			algo3=0;
			algo4=0;
			algo5=0;
			algo6=0;

			int ranky=7;
			for(i=0;i<6;i++)
			{
				ranky--;
				if(temp[i]==this.weighted_avg_Algo1)
					algo1=ranky;
				if(temp[i]==this.weighted_avg_Algo2)
					algo2=ranky;
				if(temp[i]==this.weighted_avg_Algo3)
					algo3=ranky;
				if(temp[i]==this.weighted_avg_Algo4)
					algo4=ranky;
				if(temp[i]==this.weighted_avg_Algo5)
					algo5=ranky;
				if(temp[i]==this.weighted_avg_Algo6)
					algo6=ranky;
			}

			//considering average penalty
			temp[0]=this.penalty_avg_algo1;
			temp[1]=this.penalty_avg_algo2;
			temp[2]=this.penalty_avg_algo3;
			temp[3]=this.penalty_avg_algo4;
			temp[4]=this.penalty_avg_algo5;
			temp[5]=this.penalty_avg_algo6;

			Array.Sort(temp,0,6);
			ranky=0;
			for(i=0;i<6;i++)
			{
				ranky++;
				if(temp[i]==this.penalty_avg_algo1)
					algo1+=ranky;
				if(temp[i]==this.penalty_avg_algo2)
					algo2+=ranky;
				if(temp[i]==this.penalty_avg_algo3)
					algo3+=ranky;
				if(temp[i]==this.penalty_avg_algo4)
					algo4+=ranky;
				if(temp[i]==this.penalty_avg_algo5)
					algo5+=ranky;
				if(temp[i]==this.penalty_avg_algo6)
					algo6+=ranky;
			}

			//considering average relative deviation
			temp[0]=this.avgrd_Algo1;
			temp[1]=this.avgrd_Algo2;
			temp[2]=this.avgrd_Algo3;
			temp[3]=this.avgrd_Algo4;
			temp[4]=this.avgrd_Algo5;
			temp[5]=this.avgrd_Algo6;
			
			Array.Sort(temp,0,6);
			
			ranky=0;
			for(i=0;i<6;i++)
			{
				ranky++;
				if(temp[i]==this.avgrd_Algo1)
					algo1+=ranky;
				if(temp[i]==this.avgrd_Algo2)
					algo2+=ranky;
				if(temp[i]==this.avgrd_Algo3)
					algo3+=ranky;
				if(temp[i]==this.avgrd_Algo4)
					algo4+=ranky;
				if(temp[i]==this.avgrd_Algo5)
					algo5+=ranky;
				if(temp[i]==this.avgrd_Algo6)
					algo6+=ranky;
			}


			//considering average ranking
			temp[0]=this.avg_rank_Algo1;
			temp[1]=this.avg_rank_Algo2;
			temp[2]=this.avg_rank_Algo3;
			temp[3]=this.avg_rank_Algo4;
			temp[4]=this.avg_rank_Algo5;
			temp[5]=this.avg_rank_Algo6;

			Array.Sort(temp,0,6);
			ranky=0;
			for(i=0;i<6;i++)
			{
				ranky++;
				if(temp[i]==this.avg_rank_Algo1)
					algo1+=ranky;
				if(temp[i]==this.avg_rank_Algo2)
					algo2+=ranky;
				if(temp[i]==this.avg_rank_Algo3)
					algo3+=ranky;
				if(temp[i]==this.avg_rank_Algo4)
					algo4+=ranky;
				if(temp[i]==this.avg_rank_Algo5)
					algo5+=ranky;
				if(temp[i]==this.avg_rank_Algo6)
					algo6+=ranky;
			}


			//considering max relative deviation
			temp[0]=this.maxrd_Algo1;
			temp[1]=this.maxrd_Algo2;
			temp[2]=this.maxrd_Algo3;
			temp[3]=this.maxrd_Algo4;
			temp[4]=this.maxrd_Algo5;
			temp[5]=this.maxrd_Algo6;

			Array.Sort(temp,0,6);
			ranky=0;
			for(i=0;i<6;i++)
			{
				ranky++;
				if(temp[i]==this.maxrd_Algo1)
					algo1+=ranky;
				if(temp[i]==this.maxrd_Algo2)
					algo2+=ranky;
				if(temp[i]==this.maxrd_Algo3)
					algo3+=ranky;
				if(temp[i]==this.maxrd_Algo4)
					algo4+=ranky;
				if(temp[i]==this.maxrd_Algo5)
					algo5+=ranky;
				if(temp[i]==this.maxrd_Algo6)
					algo6+=ranky;
			}

			temp[0]=algo1=algo1/5;
			temp[1]=algo2=algo2/5;
			temp[2]=algo3=algo3/5;
			temp[3]=algo4=algo4/5;
			temp[4]=algo5=algo5/5;
			temp[5]=algo6=algo6/5;
			Array.Sort(temp,0,6);

			ranky=0;
			for(i=0;i<6;i++)
			{
				ranky++;
				if(temp[i]==algo1 && flag1==0)
				{
					algo1=ranky;
					flag1=1;
				}
				else
					if(temp[i]==algo2 && flag2==0)
				{
					algo2=ranky;
					flag2=1;
				}
				else
					if(temp[i]==algo3 && flag3==0)
				{
					algo3=ranky;
					flag3=1;
				}
				else
					if(temp[i]==algo4 && flag4==0)
				{
					algo4=ranky;
					flag4=1;
				}
				else
					if(temp[i]==algo5 && flag5==0)
				{
					algo5=ranky;
					flag5=1;
				}
				else
					if(temp[i]==algo6 && flag6==0)
				{
					algo6=ranky;
					flag6=1;
				}
			}


		}


	}
}
