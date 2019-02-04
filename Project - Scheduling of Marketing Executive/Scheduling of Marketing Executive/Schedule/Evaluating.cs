using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Schedule
{
	/// <summary>
	/// Summary description for Evaluating.
	/// </summary>
	public class Evaluating : System.Windows.Forms.Form
	{
		public System.Windows.Forms.Label lblEval;
		private System.Windows.Forms.ProgressBar pbEval;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Evaluating()
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
			this.pbEval = new System.Windows.Forms.ProgressBar();
			this.lblEval = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pbEval
			// 
			this.pbEval.Location = new System.Drawing.Point(16, 8);
			this.pbEval.Maximum = 1000;
			this.pbEval.Name = "pbEval";
			this.pbEval.Size = new System.Drawing.Size(264, 23);
			this.pbEval.TabIndex = 0;
			// 
			// lblEval
			// 
			this.lblEval.Location = new System.Drawing.Point(24, 48);
			this.lblEval.Name = "lblEval";
			this.lblEval.Size = new System.Drawing.Size(232, 23);
			this.lblEval.TabIndex = 1;
			this.lblEval.Text = "Evaluating ";
			// 
			// Evaluating
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.ClientSize = new System.Drawing.Size(292, 96);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.lblEval,
																		  this.pbEval});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Evaluating";
			this.Text = "Evaluating";
			this.Load += new System.EventHandler(this.Evaluating_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void Evaluating_Load(object sender, System.EventArgs e)
		{
			int i,flag=0;
			pbEval.Enabled = true;
			pbEval.Maximum = 10000;
			pbEval.Value = 0;


			while(pbEval.Value != pbEval.Maximum )
			{
				if(flag == 100000)
				{
					pbEval.Value += 10;
					pbEval.Refresh();
					flag = 1;
				}
				flag++;
			}
			Form1.result.Show();
		}


	}
}
