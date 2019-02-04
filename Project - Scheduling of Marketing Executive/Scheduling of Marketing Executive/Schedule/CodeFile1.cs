using System;
using System.Data;
using System.Windows.Forms;
using System.IO;


namespace Schedule
{
	public struct Customer
	{
		public string cus_Id;
		public string cus_Hol;
		public int cus_Type;
	};

	public struct Cust
	{
		public int cus_interval;
		public int cus_visits;
	};

	public class Allocate
	{
		public DateTime sdte,edte;

		public int [,] a;
		public int totDays,totCus;
		public string head,hol;
		public int maxVisDay;
		public int NumTypes;		//No. of Priorities.
		public int [] CusInterval;
		//		public DateTime [] genHol;

		public Cust [] cm1;
		public int [] pen;
		public int [,] duplicate;
		public int [,] sample;
		public int holiday_count;
		public int [] genhol;
		public int tMax;
		public int tN;
		public int [] freedays;
		public int [] NVis;
		public int [] NCus;
		public int [] penalty_days;
		public int [] penalty_amount;
		public int [] calculated_penalty;
		public int random_customer_flag,complete_random_flag,random_flag;
		public int runfor;
		public int total_penalty;
							
		public int [] interval;
		public int minvisits;
		public int [] dayvisits;
				
		public int [] customer_order;
		public int [] customer_allocated;
		public int display_flag;
		public int [] freedays1;
		public Random r=new Random();
		public int unsuccessful=0;
		public int new_initialization;



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

		private int penalty_avg_algo1,penalty_avg_algo2,penalty_avg_algo3,penalty_avg_algo4,penalty_avg_algo5,penalty_avg_algo6;


		int [,] bcA ;
		int [,] aSys;
		int [,] aFcfsRl;
		int [,] aFcfsLr;
		int [,] aRdays;
		int [,] aRcus;
		int [,] aDC;

		public int first_rank;


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





		public Allocate()
		{
			//
			// TODO: Add constructor logic here
			//
		}
	

		
	

		public void  set_Days(int tmp)
		{
			totDays = tmp;
		}

		public void set_Cus(int tmp)
		{
			totCus = tmp;
		}

		public void set_maxVisDay(int tmp)
		{
			maxVisDay = tmp;
			tMax=tmp;
		}

		public void set_NPriorities(int tmp)
		{
			NumTypes = tmp;
		}

		///<summary>
		///To find the Type of nth Customer.
		///</summary>
		public int check_CusType(int index)
		{
			int i,j,tcnt,tmp;
			tcnt = -1;
			tmp = -1;
			for(i=0;i<Form1.alloc.NumTypes;i++)
			{
				tcnt++;
				for(j=0;j<Form1.alloc.NCus[i];j++)
				{
					tmp++;
					if(tmp == index)
						return tcnt;
				}
			}
			return tcnt;
		}

		
		public int check_CusPosInType(int index)
		{
			int i,tmp;

			for(i=0;i<Form1.alloc.NumTypes;i++)
			{
				tmp = index - Form1.alloc.NCus[i];
				if(tmp >= 0)
					index = tmp;
				else
					return index;
			}
			return index;
		}		
	
		public bool schedule_customers()
		{
			int i,j,k;

			Form1.alloc.CusInterval = new int[Form1.alloc.totCus];

			Form1.alloc.a = new int[Form1.alloc.totCus,Form1.alloc.totDays];
			Form1.alloc.sample = new int[Form1.alloc.totCus,Form1.alloc.totDays];
			Form1.alloc.duplicate = new int[Form1.alloc.totCus,Form1.alloc.totDays];
			
			///<summary>
			///Intialise the Matrix "a" to "0".
			///</summary>
			for(i=0;i<Form1.alloc.totCus;i++)
				for(j=0;j<Form1.alloc.totDays;j++)
					Form1.alloc.a[i,j] = 0;
		
			block_genHol();

			///<summary>
			/// Block the Weekly Holidays = 9, of all the Customers.
			///	Differnent Customers may have different weekly holidays.
			///</summary>			 
			int tmp_cnt_int=0;
			for(k=0;k<Form1.alloc.NCus.Length ;k++)
			{
				for(i=0;i<Form1.alloc.NCus[k];i++)
				{
					///<summary>
					/// Block the Weekly holidays of the Customers.
					///</summary>
					int tmpInit;
					tmpInit = Form1.alloc.find_Day(Form1.customer[tmp_cnt_int].cus_Hol);
					if(tmpInit != -1)
					{
						tmpInit -= Form1.alloc.find_Day(Form1.alloc.sdte.DayOfWeek.ToString ());
						if(tmpInit < 0)
							tmpInit += 7;

						for(j=tmpInit ;j<Form1.alloc.totDays ; j += 7)
							Form1.alloc.a[tmp_cnt_int,j]=9;
					}
					/*
					 * Calculate the Time Interval of each Customer.
					 * This is needed to find the no. of working days for a Customer.
					 * */
					int cnt = 0;
					for(j=0;j<Form1.alloc.totDays ;j++)
						///<summary>
						///Consider days excluding Weekly off of customer (9) and General holidays(5)
						///as working days for the customer.
						///</summary>
						if(Form1.alloc.a[tmp_cnt_int,j] != 9 && Form1.alloc.a[tmp_cnt_int,j] != 5)
							cnt++;

					Form1.alloc.CusInterval[tmp_cnt_int] = cnt/Form1.alloc.NVis[k];
			
					tmp_cnt_int++;

				}
			}


			///<summary>
			///	Block All the Head Office Visits = 2 and Weekly Off = 4 of the Company.
			///</summary>
			for(i=0;i<Form1.alloc.totCus ;i++)
			{
				///<summary>
				///Compare Whether first Start Day comes, or Company Weekly Off comes.
				///and then block depending on that.
				///</summary>
				j = find_Day(Form1.alloc.head) - find_Day(Form1.alloc.sdte.DayOfWeek.ToString ());
				if(j<0)
					j += 7;
				if(find_Day(Form1.alloc.head.ToString()) != -1)
				{
					for( ;j<Form1.alloc.totDays ;j += 7)
						Form1.alloc.a[i,j] = 2;
				}

				k = find_Day(Form1.alloc.hol) - find_Day(Form1.alloc.sdte.DayOfWeek.ToString());
				if(k<0)
					k += 7;
				if(find_Day(Form1.alloc.hol) != -1)
				{
					for( ;k<Form1.alloc.totDays ;k += 7)
						Form1.alloc.a[i,k] = 4;
				}
			}

			///<summary>
			/// Block All the General Holidays = 5.
			///</summary>
			block_genHol();


			freedays=new int[totCus];
			freedays1= new int[totCus];
			for(i=0;i<totCus;i++)
			{
				for(j=0;j<totDays;j++)
				{
					if(a[i,j]==0 || a[i,j]==2 ||a[i,j]==4 )
					{
						freedays[i]++;
						freedays1[i]++;
					}
				}
			}


			for(i=0;i<totCus;i++)
			{
				for(j=0;j<totDays;j++)
				{
					Console.Write("{0} \t",a[i,j]);
				}
				Console.WriteLine("");
			}
			
			
			for(i=0;i<totCus;i++)
				for(j=0;j<totDays;j++)
				{
					duplicate[i,j] = a[i,j];
				}
			
			//making a sample copy of the allocation matrix
			for(i=0;i<totCus;i++)
				for(j=0;j<totDays;j++)
				{
					sample[i,j]=a[i,j];
				}

			bcA = new int[Form1.alloc.totCus,Form1.alloc.totDays ];
			aSys = new int[Form1.alloc.totCus,Form1.alloc.totDays ];
			aFcfsRl = new int[Form1.alloc.totCus,Form1.alloc.totDays ];
			aFcfsLr = new int[Form1.alloc.totCus,Form1.alloc.totDays ];
			aRdays = new int[Form1.alloc.totCus,Form1.alloc.totDays ];
			aRcus = new int[Form1.alloc.totCus,Form1.alloc.totDays ];
			aDC = new int[Form1.alloc.totCus,Form1.alloc.totDays ];

			pen = new int [6];

			//	For Systamatic Method.
			for(i=0;i<Form1.alloc.totCus ;i++)
				for(j=0;j<Form1.alloc.totDays ;j++)
					bcA[i,j] = Form1.alloc.a[i,j];

			Systamatic_Heuristic();
			if(display_flag==0)
				pen[0] = calculate_penalty(1);
			else
				pen[0] = 99999;
			for(i=0;i<Form1.alloc.totCus ;i++)
				for(j=0;j<Form1.alloc.totDays ;j++)
					aSys[i,j] = Form1.alloc.a[i,j];

			//  For FCFS LR
			for(i=0;i<Form1.alloc.totCus ;i++)
				for(j=0;j<Form1.alloc.totDays ;j++)
					bcA[i,j] = Form1.alloc.a[i,j];

			FCFS_LR_Heuristic();
			if(display_flag==0)
				pen[1] = calculate_penalty(2);
			else
				pen[0] = 99999;
			for(i=0;i<Form1.alloc.totCus ;i++)
				for(j=0;j<Form1.alloc.totDays ;j++)
					aFcfsLr[i,j] = Form1.alloc.a[i,j];

			//  For FCFS RL
			for(i=0;i<Form1.alloc.totCus ;i++)
				for(j=0;j<Form1.alloc.totDays ;j++)
					bcA[i,j] = Form1.alloc.a[i,j];

			FCFS_RL_Heuristic();
			if(display_flag==0)
				pen[2] = calculate_penalty(3);
			else
				pen[0] = 99999;
			for(i=0;i<Form1.alloc.totCus ;i++)
				for(j=0;j<Form1.alloc.totDays ;j++)
					aFcfsRl[i,j] = Form1.alloc.a[i,j];


			//  For Random Days
			int count=0;
	l1 :	for(i=0;i<Form1.alloc.totCus ;i++)
				for(j=0;j<Form1.alloc.totDays ;j++)
					bcA[i,j] = Form1.alloc.a[i,j];
			count++;
			Random_Days_Heuristic();
			if(display_flag==0)
				pen[3] = calculate_penalty(4);
			else
			{
				if(count<1000)
					goto l1;
				else
					pen[3]=99999;
			}
			for(i=0;i<Form1.alloc.totCus ;i++)
				for(j=0;j<Form1.alloc.totDays ;j++)
					aRdays[i,j] = Form1.alloc.a[i,j];

			count=0;
			//  For Random Customers
	l2: 	for(i=0;i<Form1.alloc.totCus ;i++)
				for(j=0;j<Form1.alloc.totDays ;j++)
					bcA[i,j] = Form1.alloc.a[i,j];
			count++;
			Random_Customers_Heuristic();
			if(display_flag==0)
				pen[4] = calculate_penalty(5);
			else
			{
				if(count<1000)
					goto l2;
				else
					pen[4]=99999;
			}
			for(i=0;i<Form1.alloc.totCus ;i++)
				for(j=0;j<Form1.alloc.totDays ;j++)
					aRcus[i,j] = Form1.alloc.a[i,j];


			//  For Complete Random
			count=0;
	l3 :		for(i=0;i<Form1.alloc.totCus ;i++)
				for(j=0;j<Form1.alloc.totDays ;j++)
					bcA[i,j] = Form1.alloc.a[i,j];
			count++;
			Complete_Random_Heuristic();
			if(display_flag==0)
				pen[5] = calculate_penalty(6);
			else
			{
				if(count<1000)
					goto l3;
				else
					pen[5]=99999;
			}
			for(i=0;i<Form1.alloc.totCus ;i++)
				for(j=0;j<Form1.alloc.totDays ;j++)
					aDC[i,j] = Form1.alloc.a[i,j];


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


			for(i=0;i<sample_input_count;i++)
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


			evaluated_position();

			return true;
		
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

			for(i=0;i<sample_input_count;i++)
			{
				rd_Algo1[i]=((double)(penaltyAlgo1[i] - best_heuristic_solution[i]))/best_heuristic_solution[i];
				rd_Algo2[i]=((double)(penaltyAlgo2[i] - best_heuristic_solution[i]))/best_heuristic_solution[i];
				rd_Algo3[i]=((double)(penaltyAlgo3[i] - best_heuristic_solution[i]))/best_heuristic_solution[i];
				rd_Algo4[i]=((double)(penaltyAlgo4[i] - best_heuristic_solution[i]))/best_heuristic_solution[i];
				rd_Algo5[i]=((double)(penaltyAlgo5[i] - best_heuristic_solution[i]))/best_heuristic_solution[i];
				rd_Algo6[i]=((double)(penaltyAlgo6[i] - best_heuristic_solution[i]))/best_heuristic_solution[i];
				writer.WriteLine("PI {0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t",i,rd_Algo1[i],rd_Algo2[i],rd_Algo3[i],rd_Algo4[i],rd_Algo5[i],rd_Algo6[i],best_heuristic_solution[i]);
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
			writer.WriteLine("\nMax RD \t{0}\t{1}\t{2}\t{3}\t{4}\t{5}",maxrd_Algo1,maxrd_Algo2,
				maxrd_Algo3,maxrd_Algo4,maxrd_Algo5,maxrd_Algo6);
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
			first_rank=0;

			for(i=0;i<6;i++)
			{
				ranky++;
				if(temp[i]==algo1 && flag1==0)
				{
					algo1=ranky;
					flag1=1;
					if(ranky==1)
						first_rank=1;
				}
				else
					if(temp[i]==algo2 && flag2==0)
				{
					algo2=ranky;
					flag2=1;
					if(ranky==1)
						first_rank=2;
				}
				else
					if(temp[i]==algo3 && flag3==0)
				{
					algo3=ranky;
					flag3=1;
					if(ranky==1)
						first_rank=3;
				}
				else
					if(temp[i]==algo4 && flag4==0)
				{
					algo4=ranky;
					flag4=1;
					if(ranky==1)
						first_rank=4;
				}
				else
					if(temp[i]==algo5 && flag5==0)
				{
					algo5=ranky;
					flag5=1;
					if(ranky==1)
						first_rank=5;
				}
				else
					if(temp[i]==algo6 && flag6==0)
				{
					algo6=ranky;
					flag6=1;
					if(ranky==1)
						first_rank=6;
				}
			}

			int j;
			FileInfo f5 = new FileInfo(@"..\..\outputs\resultant_allocation_matrix.xls");
			StreamWriter writer = f5.CreateText();
			
			switch(first_rank)
			{
				case 1:
					//	For Systamatic Method.
					writer.WriteLine("\n\nUsing the Systematic Scheduling Algoritm\n\n");
					for(i=0;i<Form1.alloc.totCus ;i++)
						for(j=0;j<Form1.alloc.totDays ;j++)
							Form1.alloc.a[i,j] = aSys[i,j] ;
					
					break;

				case 2:
					//  For FCFS LR
					writer.WriteLine("\n\nUsing the FCFS LR Scheduling Algoritm\n\n");
					for(i=0;i<Form1.alloc.totCus ;i++)
						for(j=0;j<Form1.alloc.totDays ;j++)
							Form1.alloc.a[i,j] = aFcfsLr[i,j] ;
					break;

				case 3:
					//  For FCFS RL
					writer.WriteLine("\n\nUsing the FCFS RL Scheduling Algoritm\n\n");
					for(i=0;i<Form1.alloc.totCus ;i++)
						for(j=0;j<Form1.alloc.totDays ;j++)
							Form1.alloc.a[i,j] = aFcfsRl[i,j];
					break;


				case 4:
					//  For Random Days
					writer.WriteLine("\n\nUsing the Random Days Scheduling Algoritm\n\n");
					for(i=0;i<Form1.alloc.totCus ;i++)
						for(j=0;j<Form1.alloc.totDays ;j++)
							Form1.alloc.a[i,j] = aRdays[i,j];
					break;

				case 5:
					//  For Random Customers
					writer.WriteLine("\n\nUsing the Random Customers Scheduling Algoritm\n\n");
					for(i=0;i<Form1.alloc.totCus ;i++)
						for(j=0;j<Form1.alloc.totDays ;j++)
							Form1.alloc.a[i,j] = aRcus[i,j];
					break;


				case 6:
					//  For Complete Random
					writer.WriteLine("\n\nUsing the Complete Random Scheduling Algoritm\n\n");
					for(i=0;i<Form1.alloc.totCus ;i++)
						for(j=0;j<Form1.alloc.totDays ;j++)
							Form1.alloc.a[i,j] = aDC[i,j];
					break;
			}
			for(i=0;i<Form1.alloc.totCus ;i++)
			{
				for(j=0;j<Form1.alloc.totDays ;j++)
				{
					writer.Write("{0}\t",Form1.alloc.a[i,j]);
				}
				writer.WriteLine ("");
			}
			writer.Close();


		}

	
		public void display_result()
		{
			int i,j;

			for(i=0;i<Form1.alloc.totCus;i++)
			{
				int visPerCus = 0;
				object [] ch = new object[Form1.alloc.totDays + 1];
				for(j=0;j<Form1.alloc.totDays;j++)
				{
					if(a[i,j] == 0)
						ch[j] = ' ';		//Feasible cell or not allocated.
					else if(a[i,j] == 1)
					{
						ch[j] = 'A';		//Scheduled.
						visPerCus++;
					}
					else if(a[i,j] == 9)
						ch[j] = 'W';		//Weekly Off of Customer.
					else if(a[i,j] == 5)
						ch[j] = 'G';		//General Holiday.
					else if(a[i,j] == 2)
						ch[j] = 'H';		//Head office visit.
					else if(a[i,j] == 4)
						ch[j] = 'C';		//Company Closure day or weekly off.
				}

				ch[j] = visPerCus;
				DataRow r = Form1.result.tabRes.NewRow();
				r.ItemArray = ch;
				Form1.result.dgRes.RowHeadersVisible = true;
				Form1.result.tabRes.Rows.Add(r);
			}


			object [] totVisPerDay = new object[Form1.alloc.totDays + 1];
			for(j=0;j<Form1.alloc.totDays;j++)
			{
				int visPerDay = 0;
				for(i=0;i<Form1.alloc.totCus;i++)
				{
					if(a[i,j] == 1)
					{
						visPerDay++;
					}
				}
				totVisPerDay[j] = visPerDay;
			}

			totVisPerDay[j] = ' ';
			
			DataRow dr = Form1.result.tabRes.NewRow();
			dr.ItemArray = totVisPerDay;
			Form1.result.dgRes.RowHeadersVisible = true;
			Form1.result.dgRes.ColumnHeadersVisible = true;
			Form1.result.tabRes.Rows.Add(dr);

			Form1.result.dgRes.Refresh();
		}


		public void block_genHol()
		{
			int i,j;
			for(i=0;i<Form1.alloc.totDays;i++)
			{
				string str = Form1.alloc.sdte.AddDays(i).ToString("d");
				if(Form1.company.hol.Contains(str))
					for(j=0;j<Form1.alloc.totCus;j++)
						a[j,i] = 5;
			}
		}


		public int find_Day(string text1)
		{
			int tmp;
			switch (text1 )
			{
				case "Sunday" : tmp = 0;
					break;

				case "Monday" : tmp = 1;
					break;

				case "Tuesday" : tmp = 2;
					break;

				case "Wednesday" : tmp = 3;
					break;

				case "Thursday" : tmp = 4;
					break;

				case "Friday" : tmp = 5;
					break;

				case "Saturday" : tmp = 6;
					break;

				default : tmp = -1;
					break;
			}
			return tmp;
		}



		public void Systamatic_Heuristic()
		{
			
			int i,j,k;
			cm1 = new  Cust[totCus];
			interval  = new int[totCus];
			
			int tmp_cnt_int=0;
			int check=0;
						
			for(k=0;k<NCus.Length ;k++)
			{
				for(i=0;i<NCus[k];i++)
				{
					cm1[tmp_cnt_int].cus_visits=NVis[k];
					interval[i]=NVis[k];
					cm1[tmp_cnt_int].cus_interval=freedays[check]/NVis[k];
					check++;
					tmp_cnt_int++;
				}
			}
			
			//initialising the penalty
			penalty_days = new int [totCus];
			calculated_penalty = new int [totCus];
			for(i=0;i<totCus;i++)
			{
				penalty_days[i]=0;
				calculated_penalty[i]=0;
			}
			
			int tt,init=0;
			int check_visits=0;
			int count=0;
			int temp1,temp2;
			int infinite=0,flag;
			
			
			//the main code for Systematic Method
			copy();
			display_flag=0;
			//Console.WriteLine("\n\nConstraint Posed on ME to visit each customer\n\n");
			init=0;
			for(i=0;i<totCus;i++)
			{
				check_visits=0;
				infinite=0;
			
				tN=cm1[i].cus_visits;
				tt=cm1[i].cus_interval;
							
				//Console.WriteLine("ME has to visit Customer "+i+ " in " +tt+ " days");
				temp1=init;
				if(init > totDays-1)
				{
					count=0;
					while(temp1!=totDays-1)
					{
						temp1--;
						count++;
					}
					init=count;
				}
			
							
			
			
				while((a[i,init])==9 || a[i,init]==5 || a[i,init]==4 ||  a[i,init]==2)
				{
					init++;
			
					if(init == totDays)
					{
						init=0;
					}
				}
				
			
				flag=0;
				for(j=init;check_visits < tN;j=f(i,j,a,tt))
				{
					//checking for the presence of holidays
					//in the interval
								
				area1:	temp1=j;
					temp2=j-tt;
					if(flag==0)
						init=j;
			
					//checking for infinite loop
					infinite++;
					if(infinite > 200)
					{
						display_flag=1;
						//Console.WriteLine("Customer No.... "+i+ " Cannot Be properly Scheduled to the marketing executive");
						break;
					}
			
					if(j > totDays-1)
					{
						count=0;
						while(temp1!=totDays-1)
						{
							temp1--;
							count++;
						}
						j=count;
					}
			
								
					if(a[i,j] == 0)
					{
						if(check_constraint(a,i,j,tN))
						{
							check_visits=check_visits+1;
							a[i,j] = 1;
							if(flag==0)
								flag=1;
						}
						else
						{
							j++;
							goto area1;
						}
					}
					else
					{
						j++;
						goto area1;
					}
								
				}
			
				init++;
				if(init == totDays)
					init = 0;
			}
			
		}


		void FCFS_LR_Heuristic()
		{

			int i,j,k;
			cm1 = new  Cust[totCus];
			interval  = new int[totCus];
			
			int tmp_cnt_int=0;
			int check=0;
						
			for(k=0;k<NCus.Length ;k++)
			{
				for(i=0;i<NCus[k];i++)
				{
					cm1[tmp_cnt_int].cus_visits=NVis[k];
					interval[i]=NVis[k];
					cm1[tmp_cnt_int].cus_interval=freedays[check]/NVis[k];
					check++;
					tmp_cnt_int++;
				}
			}
			
			//initialising the penalty
			penalty_days = new int [totCus];
			calculated_penalty = new int [totCus];
			for(i=0;i<totCus;i++)
			{
				penalty_days[i]=0;
				calculated_penalty[i]=0;
			}
			
			int tt=0;
			int check_visits=0;
			int count=0;
			int temp1,temp2;
			int infinite=0,flag;


			//code for lr fcfs
			copy();
			display_flag=0;

			for(i=0;i<totCus;i++)
			{
				check_visits=0;
				infinite=0;

				tN=cm1[i].cus_visits;
				tt=cm1[i].cus_interval;
				flag=0;

				for(j=0;check_visits < tN;j=f(i,j,a,tt))
				{
					//checking for the presence of holidays
					//in the interval
					
				area1:	temp1=j;
					temp2=j-tt;
					//checking for infinite loop
					infinite++;
					if(infinite > 200)
					{
						display_flag=1;
						//						Console.WriteLine("Customer No.... "+i+ " Cannot Be properly Scheduled to the marketing executive");
						break;
					}

					if(j > totDays-1)
					{
						count=0;
						while(temp1!=totDays-1)
						{
							temp1--;
							count++;
						}
						j=count;
					}

					
					if(a[i,j] == 0)
					{
						if(check_constraint(a,i,j,tN))
						{
							check_visits=check_visits+1;
							a[i,j] = 1;
							flag=1;
						}
						else
						{
							j++;
							goto area1;
						}
					}
					else
					{
						j++;
						goto area1;
					}
					
				}
			}

		}


		void Random_Days_Heuristic()
		{

			int i,j,k;
			int []random_day = new int [this.totCus];
			
			cm1 = new  Cust[totCus];
			interval  = new int[totCus];
			
			int tmp_cnt_int=0;
			int check=0;
						
			for(k=0;k<NCus.Length ;k++)
			{
				for(i=0;i<NCus[k];i++)
				{
					cm1[tmp_cnt_int].cus_visits=NVis[k];
					interval[i]=NVis[k];
					cm1[tmp_cnt_int].cus_interval=freedays[check]/NVis[k];
					check++;
					tmp_cnt_int++;
				}
			}
			
			//initialising the penalty
			penalty_days = new int [totCus];
			calculated_penalty = new int [totCus];
			for(i=0;i<totCus;i++)
			{
				penalty_days[i]=0;
				calculated_penalty[i]=0;
			}
			
			int tt,init=0;
			int check_visits=0;
			int count=0;
			int temp1,temp2;
			int infinite=0,flag;

			//Code for Random method
			this.copy();

			//the main code 
			this.display_flag=0;
			for(i=0;i<this.totCus;i++)
			{
				check_visits=0;
				infinite=0;

				this.tN=cm1[i].cus_visits;
				tt=cm1[i].cus_interval;
				

				init = this.r.Next(this.totDays-1);
				while((this.a[i,init])==9 || (this.a[i,init])==8 || (this.a[i,init])==7)
				{
					init = this.r.Next(this.totDays-1);
				}
	
				random_day[i]=init;
				
				for(j=init;check_visits < this.tN;j=this.f(i,j,this.a,tt))
				{
					//checking for the presence of holidays
					//in the interval
					
				area1:	temp1=j;
					temp2=j-tt;
					//checking for infinite loop
					infinite++;
					if(infinite > 200)
					{
						this.display_flag=1;
						//									Console.WriteLine("{0}",this.display_flag);
						break;
					}

					if(j > this.totDays-1)
					{
						count=0;
						while(temp1!=this.totDays-1)
						{
							temp1--;
							count++;
						}
						j=count;
					}

					
					if(this.a[i,j] == 0)
					{
						if(this.check_constraint(this.a,i,j,this.tN))
						{
							check_visits=check_visits+1;
							this.a[i,j] = 1;
						}
						else
						{
							j++;
							goto area1;
						}
					}
					else
					{
						j++;
						goto area1;
					}
					
				}
				
			}

		}

		void FCFS_RL_Heuristic()
		{

			int i,j,k;
			cm1 = new  Cust[totCus];
			interval  = new int[totCus];
			
			int tmp_cnt_int=0;
			int check=0;
						
			for(k=0;k<NCus.Length ;k++)
			{
				for(i=0;i<NCus[k];i++)
				{
					cm1[tmp_cnt_int].cus_visits=NVis[k];
					interval[i]=NVis[k];
					cm1[tmp_cnt_int].cus_interval=freedays[check]/NVis[k];
					check++;
					tmp_cnt_int++;
				}
			}
			
			//initialising the penalty
			penalty_days = new int [totCus];
			calculated_penalty = new int [totCus];
			for(i=0;i<totCus;i++)
			{
				penalty_days[i]=0;
				calculated_penalty[i]=0;
			}
			
			int tt,init=0;
			int check_visits=0;
			int count=0;
			int temp1,temp2;
			int infinite=0,flag;

			//Code for First Come Right to left method
			this.copy();
			this.display_flag=0;
			for(i=0;i<this.totCus;i++)
			{
				check_visits=0;
				infinite=0;

				this.tN=cm1[i].cus_visits;
				tt=cm1[i].cus_interval;
				flag=0;

				for(j=this.totDays-1;check_visits < this.tN;j=this.f1(i,j,this.a,tt))
				{
					//checking for the presence of holidays
					//in the interval
					
				area1:	temp1=j;
					temp2=j-tt;
					//checking for infinite loop
					infinite++;
					if(infinite > 200)
					{
						this.display_flag=1;
						break;
					}


					if(j < 0)
					{
						count= this.totDays-1;
						while(temp1!= 0)
						{
							temp1++;
							count--;
						}
						j=count;
					}

					
					if(this.a[i,j] == 0)
					{
						if(this.check_constraint(this.a,i,j,this.tN))
						{
							check_visits=check_visits+1;
							this.a[i,j] = 1;
							flag=1;
						}
						else
						{
							j--;
							goto area1;
						}
					}
					else
					{
						j--;
						goto area1;
					}
				}
			}

		}


		void Complete_Random_Heuristic()
		{

			int i,j,k,day;
			int []random_day = new int [this.totCus];
			
			cm1 = new  Cust[totCus];
			interval  = new int[totCus];
			
			int tmp_cnt_int=0;
			int check=0;
						
			for(k=0;k<NCus.Length ;k++)
			{
				for(i=0;i<NCus[k];i++)
				{
					cm1[tmp_cnt_int].cus_visits=NVis[k];
					interval[i]=NVis[k];
					cm1[tmp_cnt_int].cus_interval=freedays[check]/NVis[k];
					check++;
					tmp_cnt_int++;
				}
			}
			
			//initialising the penalty
			penalty_days = new int [totCus];
			calculated_penalty = new int [totCus];
			for(i=0;i<totCus;i++)
			{
				penalty_days[i]=0;
				calculated_penalty[i]=0;
			}
			
			int tt,init=0;
			int check_visits=0;
			int count=0;
			int temp1,temp2;
			int infinite=0,flag;

			this.copy();
			this.random_customer_flag=1;
			/*code for generating random customers*/
			this.customer_order = new int[this.totCus];
			this.customer_allocated= new int[this.totCus];
			for(i=0;i<this.totCus;i++)
			{
				this.customer_order[i]=0;
				this.customer_allocated[i]=0;
			}
		
			day=0;
			for(i=0;i<this.totCus;i++)
			{
			label1:
				day=this.r.Next(this.totCus);
				if(this.customer_allocated[day]==1)
					goto label1;
				else
				{
					this.customer_allocated[day]=1;
					this.customer_order[i]=day;
				}
				//							Console.WriteLine("Customer {1} is Scheduled on day {0}",day,i);
			}
			//code ended

			//Call Function Randomize the Customers allocation matrix
			this.random_customers();
							
							
			//the main code 
			this.display_flag=0;
			for(i=0;i<this.totCus;i++)
			{
				check_visits=0;
				infinite=0;
				//								Console.WriteLine("The value of i is = {0}",i);
				this.tN=cm1[this.customer_order[i]].cus_visits;
				tt=cm1[this.customer_order[i]].cus_interval;

				init = this.r.Next(this.totDays-1);
				while((this.a[i,init])==9)
				{
					init = this.r.Next(this.totDays-1);
				}
	
				random_day[i]=init;
				flag=0;
				for(j=init;check_visits < this.tN;j=this.f(i,j,this.a,tt))
				{
					//checking for the presence of holidays
					//in the interval
				area1:	temp1=j;
					temp2=j-tt;
									

					//checking for infinite loop
					infinite++;
					if(infinite > 200)
					{
						this.display_flag=1;
						//									Console.WriteLine("Customer No.... "+i+ " Cannot Be properly Scheduled to the marketing executive");
						break;
					}

					if(j > this.totDays-1)
					{
						count=0;
						while(temp1!=this.totDays-1)
						{
							temp1--;
							count++;
						}
						j=count;
					}

					
					if(this.a[i,j] == 0)
					{
						if(this.check_constraint(this.a,i,j,this.tN))
						{
							check_visits=check_visits+1;
							this.a[i,j] = 1;
											
						}
						else
						{
							j++;
							goto area1;
						}
					}
					else
					{
						j++;
						goto area1;
					}
					
				}
								
			}


		}


		void Random_Customers_Heuristic()
		{

			int i,j,k,day;
			int []random_day = new int [this.totCus];
			
			cm1 = new  Cust[totCus];
			interval  = new int[totCus];
			
			int tmp_cnt_int=0;
			int check=0;
						
			for(k=0;k<NCus.Length ;k++)
			{
				for(i=0;i<NCus[k];i++)
				{
					cm1[tmp_cnt_int].cus_visits=NVis[k];
					interval[i]=NVis[k];
					cm1[tmp_cnt_int].cus_interval=freedays[check]/NVis[k];
					check++;
					tmp_cnt_int++;
				}
			}
			
			//initialising the penalty
			penalty_days = new int [totCus];
			calculated_penalty = new int [totCus];
			for(i=0;i<totCus;i++)
			{
				penalty_days[i]=0;
				calculated_penalty[i]=0;
			}
			
			int tt,init=0;
			int check_visits=0;
			int count=0;
			int temp1,temp2;
			int infinite=0;


			this.copy();
			this.random_customer_flag=1;
			/*code for generating random customers*/
			this.customer_order = new int[this.totCus];
			this.customer_allocated= new int[this.totCus];
			for(i=0;i<this.totCus;i++)
			{
				this.customer_order[i]=0;
				this.customer_allocated[i]=0;
			}
		
			
			for(i=0;i<this.totCus;i++)
			{
			label1:
				day=this.r.Next(this.totCus);
				if(this.customer_allocated[day]==1)
					goto label1;
				else
				{
					this.customer_allocated[day]=1;
					this.customer_order[i]=day;
				}
				//							Console.WriteLine("Customer {1} is Scheduled on day {0}",day,i);
			}
			//code ended

			//Call Function Randomize the Customers allocation matrix
			this.random_customers();
							
							
			//the main code 
			this.display_flag=0;
			for(i=0;i<this.totCus;i++)
			{
				check_visits=0;
				infinite=0;
				//								Console.WriteLine("The value of i is = {0}",i);
				this.tN=cm1[this.customer_order[i]].cus_visits;
				tt=cm1[this.customer_order[i]].cus_interval;

				for(j=0;check_visits < this.tN;j=this.f(i,j,this.a,tt))
				{
					//checking for the presence of holidays
					//in the interval
				area1:	temp1=j;
					temp2=j-tt;
									

					//checking for infinite loop
					infinite++;
					if(infinite > 200)
					{
						this.display_flag=1;
						//									Console.WriteLine("Customer No.... "+i+ " Cannot Be properly Scheduled to the marketing executive");
						break;
					}

					if(j > this.totDays-1)
					{
						count=0;
						while(temp1!=this.totDays-1)
						{
							temp1--;
							count++;
						}
						j=count;
					}

					
					if(this.a[i,j] == 0)
					{
						if(this.check_constraint(this.a,i,j,this.tN))
						{
							check_visits=check_visits+1;
							this.a[i,j] = 1;
											
						}
						else
						{
							j++;
							goto area1;
						}
					}
					else
					{
						j++;
						goto area1;
					}
					
				}
								
			}


		}
		int  calculate_penalty(int choice)
		{

			int count,i,j;

			if(display_flag==0)
			{
				//Priniting the Random Days
				if(choice==4)
				{
					for(i=0;i<totCus;i++)
					{
						//								Console.WriteLine("Customer {0} Scheduled on day {1}",i,random_day[i]);
					}
				}

				if(choice==5)
				{
					rearrange_matrix();
					random_customer_flag=0;
				}

				minvisits=4;
				check_constraint_minvisits();

				Console.WriteLine("\nSuccessful\n");
				Console.WriteLine("\n\n");
				for(i=0;i<totCus;i++)
				{
					for(j=0;j<totDays;j++)
					{
						Console.Write ("{0} ",a[i,j]);
					}
					Console.WriteLine ();
				}	


		

				//code to find the penalty days of each customer
				int first,interval=0;
				for(i=0;i<totCus;i++)
				{
					penalty_days[i]=0;
					//penalty_amount[i]=0;
					calculated_penalty[i]=0;
				}
				for(i=0;i<totCus;i++)
				{
					first=1;
					interval=0;
					int visits=0;
					for(j=0;j<totDays && visits < cm1[i].cus_visits;)
					{
						if(first==1)
						{
							if(a[i,j]==1)
							{
								first=0;
								visits++;
							}
							j++;
						}
						else
						{
							if(a[i,j]==0)
							{
								interval++;
								j++;
								if(interval > cm1[i].cus_interval)
									penalty_days[i]++;
							}
							else
								if(a[i,j]==1)
							{
								interval++;
								if(interval < cm1[i].cus_interval)
								{
									interval=0;
									penalty_days[i]++;
									visits++;
								}
								else if(interval > cm1[i].cus_interval)
								{
									interval=0;
									penalty_days[i]++;
									visits++;
								}
								else if(interval == cm1[i].cus_interval)
								{
									interval=0;
									visits++;
								}
								j++;
							}

							if(j<totDays)
							{
								if(a[i,j]==9 || a[i,j]==5 || a[i,j]==4 || a[i,j]==2)
								{
									while(a[i,j]==9 || a[i,j]==5 || a[i,j]==4 || a[i,j]==2)
									{
										j++;
										if(j>=totDays)
											break;
									}
								}
							}
						}
					}
				}
			
				
				Console.WriteLine("\n\n");
				for(i=0;i<totCus;i++)
				{
					for(j=0;j<totDays;j++)
					{
						Console.Write ("{0} ",a[i,j]);
					}
					Console.WriteLine ();
				}	

			
				//						Console.WriteLine("\n\nThe Penalty Count for each customer is as follows...\n\n");
			
				//						for(i=0;i<totCus;i++)
				//						{
				////							Console.WriteLine("Penalty Count for Customer {0} is {1}", i, penalty_days[i]);
				//						}
		
				count=0;
				penalty_amount = new int[NumTypes];
				penalty_amount[0]=25;
				penalty_amount[0]=10;
				penalty_amount[0]=1;
				

				for(i=0;i<NumTypes;i++)
				{
					for(j=0;j<NCus[i];j++)
					{
						calculated_penalty[count]=penalty_amount[i]*penalty_days[count];
						count++;
					}
				}

				total_penalty=0;
				Console.WriteLine("\n\nThe Penalty for each customer is as follows...\n\n");
				for(i=0;i<totCus;i++)
				{
					Console.WriteLine("Penalty for Customer {0} is {1}",i+1,calculated_penalty[i]);
					total_penalty+=calculated_penalty[i];
				}

	
				Console.WriteLine("\nThe Total Penalty for this Problem Instance is = {0}\n",total_penalty);
				return (total_penalty);
			}
			return (total_penalty);
		}


		public void copy()
		{
			int i,j;
				
			for(i=0;i<totCus;i++)
			{
				for(j=0;j<totDays;j++)
				{
					a[i,j] = duplicate[i,j];
				}
			}
			//				Console.WriteLine("\n\n");
			//										for(i=0;i<totCus;i++)
			//										{
			//											for(j=0;j<totDays;j++)
			//											{
			//												Console.Write ("{0} ",duplicate[i,j]);
			//											}
			//											Console.WriteLine ();
			//										}	

				
			//				Console.WriteLine (" \n -------------------------------- ");
			// file operation to get the weekly holiday of customer

			for(i=0;i<totCus;i++)
				freedays1[i]=freedays[i];


			//			Cust[] cm1 = new  Cust[totCus];
			int tmp_cnt_int=0;
			int check=0;
			for(int k=0;k<NCus.Length ;k++)
			{
				for(i=0;i<NCus[k];i++)
				{
					cm1[tmp_cnt_int].cus_visits=NVis[k];
					cm1[tmp_cnt_int].cus_interval=freedays[check]/NVis[k];
					check++;
					tmp_cnt_int++;
				}
			}
		}

		public int f(int i,int j,int [,] a,int tt)
		{
			int count,temp1;
			int interval=0;
			int k=0;
			for(k=j;interval<=tt;)
			{
				temp1=k;
				if(k > totDays-1)
				{
					count=0;
					while(temp1!=totDays-1)
					{
						temp1--;
						count++;
					}
					k=count-1;
				}
				if(a[i,k]==9|| a[i,k]==5 || a[i,k]==2 || a[i,k]==4)
					k++;
				else
				{
					interval++;
					k++;
				}
			}
			return k-1;
		}


		public int f1(int i,int j,int [,] a,int tt)
		{
			int count,temp1;
			int interval=0;
			int k=0;
			for(k=j;interval<=tt;)
			{
				temp1=k;
			
				if(k < 0)
				{
					count=totDays-1;
					while(temp1!= 0)
					{
						temp1++;
						count--;
					}
					k=count+1;
				}

				if(a[i,k]==9 || a[i,k]==5 || a[i,k]==2 || a[i,k]==4)
					k--;
				else
				{
					interval++;
					k--;
				}
			}
			return k+1;
		}

		public bool check_constraint(int[,] a,int krow,int kcol,int tN)
		{
			int i,j,cnt=0;

			for(i=0;i<totCus;i++)
				if( a[i,kcol] == 1)
				{
					cnt++;
					if(cnt >= tMax)
						return false;
				}

			cnt=0;
			for(j=0;j<totDays;j++)
				if(a[krow,j] == 1)
				{
					cnt++;
					if(cnt >= tN)
						return false;
				}
			return true;
		}


		public void random_customers()
		{
			
			int i=0,j=0,temp=0;

			for(i=0;i<totCus;i++)
			{
				temp=customer_order[i];
				for(j=0;j<totDays;j++)
				{
					a[i,j]= sample[temp,j];
				}
			}

			for(i=0;i<totCus;i++)
			{
				for(j=0;j<totDays;j++)
				{
					freedays[i]=0;
				}
			}
				

			for(i=0;i<totCus;i++)
			{
				for(j=0;j<totDays;j++)
				{
					if(a[i,j]==0)
					{
						freedays[i]++;
					}
				}
			}


			int tmp_cnt_int=0;
			int check=0;
			Cust[] cm1 = new  Cust[totCus];

			for(int k=0;k<NCus.Length ;k++)
			{
				for(i=0;i<NCus[k];i++)
				{
					cm1[tmp_cnt_int].cus_visits=NVis[k];
					cm1[tmp_cnt_int].cus_interval=freedays[check]/NVis[k];
					check++;
					tmp_cnt_int++;
				}
			}

		}

		public void rearrange_matrix()
		{
			int i=0,j=0,temp=0;
		
			for(i=0;i<totCus;i++)
			{
				for(j=0;j<totDays;j++)
				{
					sample[i,j]=a[i,j];
				}
			}


			for(i=0;i<totCus;i++)
			{
				temp=customer_order[i];
				for(j=0;j<totDays;j++)
				{
					a[temp,j]= sample[i,j];
				}
			}

			for(i=0;i<totCus;i++)
			{
				for(j=0;j<totDays;j++)
				{
					sample[i,j]=duplicate[i,j];
				}
			}
		}
			

		public void check_constraint_minvisits()
		{
			dayvisits = new int[totDays];

			for(int i=0;i<totDays;i++)
				dayvisits[i]=0;

			//code for calculating the day visits
			for(int i=0;i<totDays;i++)
			{
				for(int j=0;j<totCus;j++)
				{
					if(a[j,i]==1)
						dayvisits[i]++;
				}
				//					Console.Write("{0} ",dayvisits[i]);
			}
			//				Console.Write("\n");
			int temp=0;
			int flag=0;
			for(int j=0;j<totDays;j++)
			{
				if(dayvisits[j]< minvisits)
				{
					for(int i=0;i<totCus;i++)
					{
						if(a[i,j]==1)
						{
							temp=0;
							flag=0;

						area1:				while(dayvisits[temp] < minvisits || (a[i,temp]==1)  || dayvisits[temp]>= tMax)
											{
												temp++;
												//									Console.WriteLine("");
												//									Console.Write("{0}---{1}\n",temp,dayvisits[temp]);
												if(temp==i)
												{
													temp++;
												}

									
									
												flag=0;
									
												if(temp >= totDays)
												{
													flag=1;
													break;
												}
												if(a[i,temp] != 0)
													temp++;
												if(temp >= totDays)
												{
													flag=1;
													break;
												}
												if(dayvisits[temp]>tMax)
													temp++;
											}
											
					
							
							if(flag==0)
							{
								a[i,temp]=1;
								a[i,j]=0;
								dayvisits[temp]++;
//								if(dayvisits[temp]>this.tMax)
//										Console.WriteLine("temp={0} dayvisit={1}",temp,dayvisits[temp]);
                                dayvisits[j]--;
							}
						}
								
					}
				}

			}
			for(int i=0;i<totDays;i++)
			{
				dayvisits[i]=0;
			}
			for(int i=0;i<totDays;i++)
			{
				for(int j=0;j<totCus;j++)
				{
					if(a[j,i]==1)
						dayvisits[i]++;
				}
			}
		}

	}
}