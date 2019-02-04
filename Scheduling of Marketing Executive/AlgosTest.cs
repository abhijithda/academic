using System;
using System.IO;

namespace Schedule
{


	public struct Customers
	{
		public int cus_interval;
		public int cus_visits;
	};

	/// <summary>
	/// Summary description for Combined.
	/// </summary>
	public class AlgosTest
	{
		
		public int [,] a;
		public int [,] duplicate;
		public int [,] sample;
		public int totDays,totCus;
		public int head,hol;
		public int holiday_count;
		public int [] genhol;
		public int NumTypes;
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
		public StreamReader sr;
		public int unsuccessful=0;
		public int new_initialization;



		//constructor
		public AlgosTest()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		/// 
		public void open_files()
		{
			this.sr = File.OpenText(@"..\..\inputs\ME.txt");
			this.new_initialization=1;
		}

			
		public void create_instance()
		{
			int i,j,k,l,m,n,o,p,q,r;
			FileInfo f2 = new FileInfo(@"..\..\inputs\ME.txt");

			StreamWriter writer = f2.CreateText();


			int scheduling_period=31;
			int total_customers=21;
			int type_of_customers=3;

			int typeA=2;
			int typeB=8;

			int visitA=7,visitB=5,visitC=3;
			
			int minvisit=4,maxvisit=8;

			int count=0;
			for(l=typeA;l<=4;l++)
				for(m=typeB;m<=10;m++)
					
					for(n=visitA;n<=9;n++)
						for(o=visitB;o<=7;o++)
							for(p=visitC;p<=5;p++)
							{
								int third= total_customers-(l+m);
								//								Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10}",scheduling_period,total_customers,
								//									type_of_customers,l,m,third,n,o,p,maxvisit,minvisit);
								writer.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10}",scheduling_period,total_customers,
									type_of_customers,l,m,third,n,o,p,maxvisit,minvisit);
								//									writer.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}",i,j,k,l,m,third,n,o,p,q,r);
								//									writer.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}",i,j,k,l,m,n,o,p,q,r);
								count++;
							}
			writer.Close();
		}

		public void file_access()
		{
			int i,j;
			//			Console.WriteLine ("***************Welcome to the SME Software***********");

			
			StreamReader sr1 = File.OpenText(@"..\..\inputs\ME HOLIDAYS.txt");
			StreamReader sr2 = File.OpenText(@"..\..\inputs\customer holidays.txt");
			StreamReader sr3 = File.OpenText(@"..\..\inputs\penalty.txt");

			string input= null;

			int count=0;
			if((input= this.sr.ReadLine())!=null)
			{
				count++;
				String[] s;
				
				switch (count)
				{
					case 1:
						s = input.Split(' ');
						//						Console.WriteLine(s[0]);
						this.totDays=int.Parse(s[0]);
						
						//						Console.WriteLine(s[1]);
						this.totCus=int.Parse(s[1]);

						//						Console.WriteLine(s[2]);
						this.NumTypes=int.Parse(s[2]);
						this.NCus = new int[this.NumTypes];
						this.NVis = new int[this.NumTypes];

					
						int day=0;
						int var=-1;
						int counter=3;
						do
						{
							var++;
							
							//							if(var==this.NumTypes-1)
							//							{
							//								this.NCus[var]=this.totCus-day;
							//							}
							//							else
						{
							day+=int.Parse(s[counter]);
							this.NCus[var]=int.Parse(s[counter]);
							//								Console.WriteLine(s[counter]);
							counter++;
						}
						
						}while(var < this.NumTypes-1);
						
						
						var=-1;
						do
						{
							var++;
							this.NVis[var]=int.Parse(s[counter]);
							//							Console.WriteLine(s[counter]);
							counter++;
						}while(var < this.NumTypes-1);
						
						
						//						Console.WriteLine(s[counter]);
						this.tMax=int.Parse(s[counter]);
						counter++;

						//						Console.WriteLine(s[counter]);
						this.minvisits=int.Parse(s[counter]);
						break;
				}
			}
			//			sr.Close();


		
			count=0;
			this.holiday_count=0;
			this.genhol= new int[20];
			while((input= sr1.ReadLine())!=null)
			{
				count++;
				String[] s;
				int counter=0;
					
				s = input.Split(' ');
				//				Console.WriteLine(s[counter]);
				int te=int.Parse(s[counter]);
				this.hol= int.Parse(s[counter]);
				counter++;
							
				//				Console.WriteLine(s[counter]);
				te=int.Parse(s[counter]);
				this.head= int.Parse(s[counter]);
				counter++;
						
				while(counter < s.Length)
				{
							
					this.genhol[this.holiday_count]=int.Parse(s[counter]);
					//					Console.WriteLine("Holiday  "+this.genhol[this.holiday_count]);
					this.holiday_count++;
					counter++;
							
				}
			}
	
			sr1.Close();


			//Total no. of Customers.		
			this.totCus = 0;
			for(i=0;i<this.NCus.Length;i++)
				this.totCus += this.NCus [i];
			int f1,f2;
			f1=this.totCus;
			f2=this.totDays;

			this.a = new int[this.totCus,this.totDays];
			this.duplicate = new int[this.totCus,this.totDays];
			this.sample=new int[this.totCus,this.totDays];

				

			for(i=0;i<this.totCus;i++)
				for(j=0;j<this.totDays;j++)
				{
					this.a[i,j] = 0;
					this.duplicate[i,j]=0;
					this.sample[i,j]=0;
				}

			
			int cntHol = 0;
			
			//initializing the general holidays by means of 8
			count=0;
			for(i=0;i<this.totCus;i++)
			{
				count=0;
				for(j=this.genhol[count];count < this.holiday_count;j=this.genhol[count])
				{
					this.a[i,j]=8;
					count++;
				}
			}
			
			if(this.head==this.hol)
			{
				for(j=this.head;j<this.totDays;j+=7)
				{
					for(i=0;i<this.totCus;i++)
					{
						this.a[i,j] = 9;
					}
					cntHol++;
				}
			}

			else
			{
				for(j=this.head;j<this.totDays;j+=7)
				{
					for(i=0;i<this.totCus;i++)
					{
						this.a[i,j] = 9;
						
					}
					cntHol++;
				}

				for(j=this.hol;j<this.totDays;j+=7)
				{
					for(i=0;i<this.totCus;i++)
					{
						this.a[i,j] = 9;
					}
					cntHol++;
				}
			}

			/*
					 * Accept the Weekly Holidays of all the Customers.
					 * 
					 * Different Customers may have different weekly holidays.
					 * */
			
			//			Console.WriteLine (" \n -------------------------------- ");
			// file operation to get the weekly holiday of customer

			count=0;
			
			while((input= sr2.ReadLine())!=null)
			{
				string [] s;
				s=input.Split(',');
				int tmp;
				i=int.Parse(s[0]);
				tmp=int.Parse(s[1]);
					
				for(j=tmp ;j<this.totDays ; j += 7)
					this.a[i,j]=7;
			}
			sr2.Close();

			this.penalty_days = new int[this.totCus];
			this.penalty_amount=new int[this.NumTypes];
			this.calculated_penalty=new int[this.totCus];
			for(i=0;i<this.NumTypes;i++)
			{
				input= sr3.ReadLine();
				//					Console.Write("Enter the Penalty amount of Type {0} customer ",i+1);
				this.penalty_amount[i]=int.Parse(input);
			}
			sr3.Close();

			//			Console.WriteLine("\n\nThe Available Days for ME to visit each customer is as follows>>>>\n\n");
			this.freedays=new int[this.totCus];
			this.freedays1= new int[this.totCus];
			for(i=0;i<this.totCus;i++)
			{
				for(j=0;j<this.totDays;j++)
				{
					if(this.a[i,j]==0)
					{
						this.freedays[i]++;
						this.freedays1[i]++;
					}
				}
				//				Console.WriteLine("Customer {0} has {1} Free Days",i+1,this.freedays[i]);
			}

			for(i=0;i<this.totCus;i++)
				for(j=0;j<this.totDays;j++)
				{
					this.duplicate[i,j] = this.a[i,j];
				}

			//making a sample copy of the allocation matrix
			for(i=0;i<this.totCus;i++)
				for(j=0;j<this.totDays;j++)
				{
					this.sample[i,j]=this.a[i,j];
				}
		}
			

		public int process_input(int choice)
		{

			
			Customers[] cm1 = new  Customers[this.totCus];
			this.interval  = new int[this.totCus];

			int tmp_cnt_int=0;
			int check=0;
			int i,j;
			for(int k=0;k<this.NCus.Length ;k++)
			{
				for(i=0;i<this.NCus[k];i++)
				{
					cm1[tmp_cnt_int].cus_visits=this.NVis[k];
					this.interval[i]=this.NVis[k];
					cm1[tmp_cnt_int].cus_interval=this.freedays[check]/this.NVis[k];
					check++;
					tmp_cnt_int++;
				}
			}


			
			

			int tt,init=0;
			int check_visits=0;
			int count=0;
			int temp1,temp2;
			int infinite=0;
				

			for(i=0;i<this.totCus;i++)
			{
				this.penalty_days[i]=0;
				this.calculated_penalty[i]=0;
			}

			//			Console.WriteLine("\n\nConstraint Posed on ME to visit each customer\n\n");
			for(i=0;i<this.totCus;i++)
			{
				tt=cm1[i].cus_interval;
				//				Console.WriteLine("ME has to visit Customer "+i+ " in " +tt+ " days");
			}


		








			do
			{
				//				Console.WriteLine("\n\n\n***************************************************");
				//				Console.WriteLine("\tEnter 1.... For Systematic Method");
				//				Console.WriteLine("\tEnter 2.... For First Come Left to Right Method");
				//				Console.WriteLine("\tEnter 3.... For First Come Right to Left Method");
				//				Console.WriteLine("\tEnter 4.... For Random Days Method");
				//				Console.WriteLine("\tEnter 5.... For Random Customers Method");
				//				Console.WriteLine("\tEnter 6.... For Complete Random Method");
				//				Console.WriteLine("\tEnter 7.... To Exit");
				//				Console.WriteLine("***************************************************\n\n");
				
				//				int tt,init=0;
				//				int check_visits=0;
				//				int count=0;
				//				int temp1,temp2;
				//				int infinite=0;
				//				int i,j;

				//array to hold the random day generated
				int []random_day = new int [this.totCus];
				int flag=0;

				this.display_flag=0;
				//			int choice=0;
				//				choice=int.Parse(Console.ReadLine());
				switch(choice)
				{
				
					case 1:
						//the main code for Systematic Method
						this.copy();
						this.display_flag=0;
						//Console.WriteLine("\n\nConstraint Posed on ME to visit each customer\n\n");
						init=0;
						for(i=0;i<this.totCus;i++)
						{
							check_visits=0;
							infinite=0;

							this.tN=cm1[i].cus_visits;
							tt=cm1[i].cus_interval;
				
							//Console.WriteLine("ME has to visit Customer "+i+ " in " +tt+ " days");
							temp1=init;
							if(init > this.totDays-1)
							{
								count=0;
								while(temp1!=this.totDays-1)
								{
									temp1--;
									count++;
								}
								init=count;
							}

				


							while((this.a[i,init])==9 || this.a[i,init]==8 || this.a[i,init]==7)
							{
								init++;

								if(init == this.totDays)
								{
									init=0;
								}
							}
	

							flag=0;
							for(j=init;check_visits < this.tN;j=this.f(i,j,this.a,tt))
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
									this.display_flag=1;
									//Console.WriteLine("Customer No.... "+i+ " Cannot Be properly Scheduled to the marketing executive");
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
							if(init == this.totDays)
								init = 0;
						}
						break;

					case 2:
						//Code for First Come Left to Right Method
						this.copy();
						this.display_flag=0;

						for(i=0;i<this.totCus;i++)
						{
							check_visits=0;
							infinite=0;

							this.tN=cm1[i].cus_visits;
							tt=cm1[i].cus_interval;
							flag=0;

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
									//						Console.WriteLine("Customer No.... "+i+ " Cannot Be properly Scheduled to the marketing executive");
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
						break;

					case 3:
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
						break;

					case 4:
							
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
						break;

					case 5:
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
		
						int day=0;
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

							flag=0;
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
						break;

					case 6:
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
						break;

						
				}

				if(choice!=7)
				{
					if(this.display_flag==0)
					{
						//Priniting the Random Days
						if(choice==4)
						{
							for(i=0;i<this.totCus;i++)
							{
								//								Console.WriteLine("Customer {0} Scheduled on day {1}",i,random_day[i]);
							}
						}

						if(choice==5)
						{
							this.rearrange_matrix();
							this.random_customer_flag=0;
						}

						this.minvisits=4;
						this.check_constraint_minvisits();

						//						Console.WriteLine("\nSuccessful\n");
						//						Console.WriteLine("\n\n");
						//						for(i=0;i<this.totCus;i++)
						//						{
						//							for(j=0;j<this.totDays;j++)
						//							{
						//								Console.Write ("{0} ",this.a[i,j]);
						//							}
						//							Console.WriteLine ();
						//						}	


		

						//code to find the penalty days of each customer
						int first,interval=0;
						for(i=0;i<this.totCus;i++)
						{
							this.penalty_days[i]=0;
							//this.penalty_amount[i]=0;
							this.calculated_penalty[i]=0;
						}
						for(i=0;i<this.totCus;i++)
						{
							first=1;
							interval=0;
							int visits=0;
							for(j=0;j<this.totDays && visits < cm1[i].cus_visits;)
							{
								if(first==1)
								{
									if(this.a[i,j]==1)
									{
										first=0;
										visits++;
									}
									j++;
								}
								else
								{
									if(this.a[i,j] == 0 )
									{
										interval++;
										j++;
										if(interval > cm1[i].cus_interval)
											this.penalty_days[i]++;
									}
									else if(this.a[i,j]==1)
									{
										interval++;
										if(interval < cm1[i].cus_interval)
										{
											interval=0;
											this.penalty_days[i]++;
											visits++;
										}
										else if(interval > cm1[i].cus_interval)
										{
											interval=0;
											this.penalty_days[i]++;
											visits++;
										}
										else if(interval == cm1[i].cus_interval)
										{
											interval=0;
											visits++;
										}
										j++;
									}

									if(j<this.totDays)
									{
										if(this.a[i,j]==9 || this.a[i,j]==8 || this.a[i,j]==7)
										{
											while(this.a[i,j]==9 || this.a[i,j]==8 || this.a[i,j]==7)
											{
												j++;
												if(j>=this.totDays)
													break;
											}
										}
									}
								}
							}
						}
			

			
						//						Console.WriteLine("\n\nThe Penalty Count for each customer is as follows...\n\n");
			
						//						for(i=0;i<this.totCus;i++)
						//						{
						////							Console.WriteLine("Penalty Count for Customer {0} is {1}", i, this.penalty_days[i]);
						//						}
		
						count=0;
						for(i=0;i<this.NumTypes;i++)
						{
							for(j=0;j<this.NCus[i];j++)
							{
								this.calculated_penalty[count]=this.penalty_amount[i]*this.penalty_days[count];
								count++;
							}
						}

						this.total_penalty=0;
						//						Console.WriteLine("\n\nThe Penalty for each customer is as follows...\n\n");
						for(i=0;i<this.totCus;i++)
						{
							//							Console.WriteLine("Penalty for Customer {0} is {1}",i+1,this.calculated_penalty[i]);
							this.total_penalty+=this.calculated_penalty[i];
						}

	
						//						Console.WriteLine("\nThe Total Penalty for this Problem Instance is = {0}\n",this.total_penalty);
						return (this.total_penalty);
					}
		   
					else
					{
						//						Console.WriteLine("\n\nThe given problem instance is not Valid");
						//						Console.WriteLine("1. Either increase the MAX VISITS in a day");
						//						Console.WriteLine("2. Either decrease the Visits of each type of customers in a day");
						//						Console.WriteLine("3. Either increase the Scheduled days");
						//						Console.WriteLine("***************Thank You for using SME Software**********");
						if(choice <4)
						{
							//							Console.WriteLine("\n\aUnsuccessful\n");
							return 5000;
						}
						//						int cc=choice;
						//						Console.WriteLine("\n\n");
						//												for(i=0;i<this.totCus;i++)
						//												{
						//													for(j=0;j<this.totDays;j++)
						//													{
						//														Console.Write ("{0} ",this.a[i,j]);
						//													}
						//													Console.WriteLine ();
						//												}	
						//return -1;
					}
				}
			}while(choice!=7);
			return (this.total_penalty);
		}		


		public void copy()
		{
			int i,j;
				
			for(i=0;i<this.totCus;i++)
			{
				for(j=0;j<this.totDays;j++)
				{
					this.a[i,j] = this.duplicate[i,j];
				}
			}
			//				Console.WriteLine("\n\n");
			//										for(i=0;i<this.totCus;i++)
			//										{
			//											for(j=0;j<this.totDays;j++)
			//											{
			//												Console.Write ("{0} ",this.duplicate[i,j]);
			//											}
			//											Console.WriteLine ();
			//										}	

				
			//				Console.WriteLine (" \n -------------------------------- ");
			// file operation to get the weekly holiday of customer

			for(i=0;i<this.totCus;i++)
				this.freedays1[i]=this.freedays[i];


			Customers[] cm1 = new  Customers[this.totCus];
			int tmp_cnt_int=0;
			int check=0;
			for(int k=0;k<this.NCus.Length ;k++)
			{
				for(i=0;i<this.NCus[k];i++)
				{
					cm1[tmp_cnt_int].cus_visits=this.NVis[k];
					cm1[tmp_cnt_int].cus_interval=this.freedays[check]/this.NVis[k];
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
				if(a[i,k]==9|| a[i,k]==8 || a[i,k]==7)
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

				if(a[i,k]==9 || a[i,k]==8 || a[i,k]==7)
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

			for(i=0;i<this.totCus;i++)
			{
				temp=this.customer_order[i];
				for(j=0;j<this.totDays;j++)
				{
					this.a[i,j]= this.sample[temp,j];
				}
			}

			for(i=0;i<this.totCus;i++)
			{
				for(j=0;j<this.totDays;j++)
				{
					this.freedays[i]=0;
				}
			}
				

			for(i=0;i<this.totCus;i++)
			{
				for(j=0;j<this.totDays;j++)
				{
					if(this.a[i,j]==0)
					{
						this.freedays[i]++;
					}
				}
			}


			int tmp_cnt_int=0;
			int check=0;
			Customers[] cm1 = new  Customers[this.totCus];

			for(int k=0;k<this.NCus.Length ;k++)
			{
				for(i=0;i<this.NCus[k];i++)
				{
					cm1[tmp_cnt_int].cus_visits=this.NVis[k];
					cm1[tmp_cnt_int].cus_interval=this.freedays[check]/this.NVis[k];
					check++;
					tmp_cnt_int++;
				}
			}

		}

		public void rearrange_matrix()
		{
			int i=0,j=0,temp=0;
		
			for(i=0;i<this.totCus;i++)
			{
				for(j=0;j<this.totDays;j++)
				{
					this.sample[i,j]=this.a[i,j];
				}
			}


			for(i=0;i<this.totCus;i++)
			{
				temp=this.customer_order[i];
				for(j=0;j<this.totDays;j++)
				{
					this.a[temp,j]= this.sample[i,j];
				}
			}

			for(i=0;i<this.totCus;i++)
			{
				for(j=0;j<this.totDays;j++)
				{
					this.sample[i,j]=this.duplicate[i,j];
				}
			}
		}
			

		public void check_constraint_minvisits()
		{
			this.dayvisits = new int[this.totDays];

			for(int i=0;i<this.totDays;i++)
				this.dayvisits[i]=0;

			//code for calculating the day visits
			for(int i=0;i<this.totDays;i++)
			{
				for(int j=0;j<this.totCus;j++)
				{
					if(this.a[j,i]==1)
						this.dayvisits[i]++;
				}
				//					Console.Write("{0} ",this.dayvisits[i]);
			}
			//				Console.Write("\n");
			int temp=0;
			int flag=0;
			for(int j=0;j<this.totDays;j++)
			{
				if(this.dayvisits[j]< this.minvisits)
				{
					for(int i=0;i<this.totCus;i++)
					{
						if(this.a[i,j]==1)
						{
							temp=0;
							flag=0;

						area1:				while(this.dayvisits[temp] < this.minvisits || (this.a[i,temp]==1)  || this.dayvisits[temp]>= this.tMax)
											{
												temp++;
												//									Console.WriteLine("");
												//									Console.Write("{0}---{1}\n",temp,this.dayvisits[temp]);
												if(temp==i)
												{
													temp++;
												}

									
									
												flag=0;
									
												if(temp >= this.totDays)
												{
													flag=1;
													break;
												}
												if(this.a[i,temp] != 0)
													temp++;
												if(temp >= this.totDays)
												{
													flag=1;
													break;
												}
												if(this.dayvisits[temp]>this.tMax)
													temp++;
											}
					
							
							if(flag==0)
							{
								this.a[i,temp]=1;
								this.a[i,j]=0;
								this.dayvisits[temp]++;
								if(this.dayvisits[temp]>8)
									//										Console.WriteLine("temp={0} dayvisit={1}",temp,this.dayvisits[temp]);

									this.dayvisits[j]--;
							}
						}
								
					}
				}

			}
			for(int i=0;i<this.totDays;i++)
			{
				this.dayvisits[i]=0;
			}
			for(int i=0;i<this.totDays;i++)
			{
				for(int j=0;j<this.totCus;j++)
				{
					if(this.a[j,i]==1)
						this.dayvisits[i]++;
				}
				//					Console.Write("{0} ",this.dayvisits[i]);
			}

		}

	}
}
