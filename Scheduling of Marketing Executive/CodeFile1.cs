using System;
using System.Data;
using System.Windows.Forms;


namespace Schedule
{
	public struct Customer
	{
		public string cus_Id;
		public string cus_Hol;
		public int cus_Type;
	};

	public class Allocate
	{
		public DateTime sdte,edte;

		public int [,] a;
		public int totDays,totCus;
		public string head,hol;
		public int maxVisDay;
		public int[] NVis,NCus;		//No. of Customers and Visits for each type of Priority..
		public int NumTypes;		//No. of Priorities.
		public int [] CusInterval;
		public DateTime [] genHol;
	

		public Allocate()
		{
			//
			// TODO: Add constructor logic here
			//
		}
	

		bool check_CusVis(int[,] a,int krow,int tN)
		{
			int j,cnt=0;
			for(j=0;j<totDays;j++)
				if(a[krow,j] == 1)
				{
					cnt++;
					if(cnt >= tN)
						return false;
				}

			return true;
		}

		bool check_constraint(int[,] a,int krow,int kcol,int tN)
		{
			int i,j,cnt=0;

			for(i=0;i<totCus;i++)
				if( a[i,kcol] == 1)
				{
					cnt++;
					if(cnt >= maxVisDay)
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

		int Initial_Ptr(int init,int i)
		{
			do
			{
				init++;
				if(init >= totDays)
					init = 0;
			}while(a[i,init] != 0);
			return init;
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
			int check_feasible=-1,check_feasible_cnt = -1;

			Form1.alloc.CusInterval = new int[Form1.alloc.totCus];

			Form1.alloc.a = new int[Form1.alloc.totCus,Form1.alloc.totDays];
			
			///<summary>
			///Intialise the Matrix "a" to "0".
			///</summary>
			for(i=0;i<Form1.alloc.totCus;i++)
				for(j=0;j<Form1.alloc.totDays;j++)
					Form1.alloc.a[i,j] = 0;
		
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
							
					int tmpInit = Form1.alloc.find_Day(Form1.customer[i].cus_Hol);
					if(tmpInit != -1)
					{
						tmpInit -= Form1.alloc.find_Day(Form1.alloc.sdte.DayOfWeek.ToString());
						tmpInit += 7;
						tmpInit %= 7;
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
						///</summary>
						if(Form1.alloc.a[i,j] != 9 || Form1.alloc.a[i,j] != 5)
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

			
			int interval,init=-1;
			for(i=0;i<Form1.alloc.totCus;i++)
			{
				interval = Form1.alloc.CusInterval [i];
			
				//	Function to find the starting position of the pointer in a row.
//				init = Form1.alloc.Initial_Ptr(init,i);

//Initialise the init = 0, to start always with the first working day of the feasible day
//				in the period.
				init = 0;

				for(j=init;j<Form1.alloc.totDays;j++)
				{
					///<summary>
					///we need to increment the interval for the working days of the customer.
					///The Company Weekly Off and Head Office Visit days may be working days for the customers.
					///</summary>
					if(Form1.alloc.a[i,j] == 0 || Form1.alloc.a[i,j] == 2 || Form1.alloc.a[i,j] == 4)
					{
						interval++;

						if(Form1.alloc.a[i,j] == 0 && interval >= Form1.alloc.CusInterval [i] && Form1.alloc.check_constraint(Form1.alloc.a,i,j,Form1.alloc.NVis[Form1.customer[i].cus_Type - 1] ))
						{
							Form1.alloc.a[i,j] = 1;
							interval = 0;	//-1;
						}
					}
				}
			
				for(j=0;j<init;j++)
				{
					if(Form1.alloc.a[i,j] == 0 || Form1.alloc.a[i,j] == 2 || Form1.alloc.a[i,j] == 4)
					{
						interval++;
						if(interval >= Form1.alloc.CusInterval[i] && Form1.alloc.check_constraint(Form1.alloc.a,i,j,Form1.alloc.NVis[Form1.customer[i].cus_Type - 1] ))
						{
							Form1.alloc.a[i,j] = 1;
							interval = 0;	//-1;
						}
					}
				}
			
				interval = 0;	//-1;
				//	Check If the Row is satisfying the Required no. of visits for the Particular type of customer.
				if(Form1.alloc.check_CusVis(Form1.alloc.a,i,Form1.alloc.NVis [Form1.customer[i].cus_Type - 1]))
				{
					i--;
					if(check_feasible == i)
						check_feasible_cnt++;
					else
					{
						check_feasible = i;
						check_feasible_cnt = -1;
					}

					if(check_feasible_cnt == 5)
					{
						MessageBox.Show(Form1.CusTypes  , "The Scheduling is not possible.\n Either increase no. of Maximum visits per day, or decrease no. of customers or visits");
						return false;
					}
				}
			}
			return true;
		}		

		public void display_result()
		{
			int i,j;

			for(i=0;i<Form1.alloc.totCus;i++)
			{
				object [] ch = new object[Form1.alloc.totDays];
				for(j=0;j<Form1.alloc.totDays;j++)
				{
					if(a[i,j] == 0)
						ch[j] = ' ';		//Feasible cell or not allocated.
					else if(a[i,j] == 1)
						ch[j] = 'A';		//Scheduled.
					else if(a[i,j] == 9)
						ch[j] = 'W';		//Weekly Off of Customer.
					else if(a[i,j] == 5)
						ch[j] = 'G';		//General Holiday.
					else if(a[i,j] == 2)
						ch[j] = 'H';		//Head office visit.
					else if(a[i,j] == 4)
						ch[j] = 'C';		//Company Closure day or weekly off.
				}

				DataRow r = Form1.result.tabRes.NewRow();
				r.ItemArray = ch;
				Form1.result.dgRes.RowHeadersVisible = true;
				Form1.result.tabRes.Rows.Add(r);
			}
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


	}
}