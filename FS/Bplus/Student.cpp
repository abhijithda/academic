
//system include headers
#include <iostream.h>
#include <fstream.h>
#include <conio.h>
#include <string.h>
#include <stdlib.h>
#include <dos.h>
#include <stdio.h>
#include <ctype.h>

//location of Student File
#define STU_FILE "C:\\Student.txt"
//prototype
int search(char *);
int srch;

/************************************************/
class student		// class for student record
{
       public:
	      char URN[25];
	      char Name[30];
	      char Addr[40];
	      char Sem[10];
	      char Bran[20];

	      ~student(){}

	      void Clear();
	      int Read();
	      int Unpack(fstream&);
	      int Pack(fstream&);
	      void Input(int,char *);
	      void Display();
	      void Assign(student&);

		char* geturn()  {return URN; }
		char* getname()	{return Name;}
		char* getadd() 	{return Addr;}
		char* getsem() 	{return Sem; }
		char* getbrn()	{return Bran; }
};

/************************************************/
//class IOBUF: clearing the buffer,
//parent class for varlen and delmfld buffer classes

class iobuf
{
      protected:
		 char Buffer[100];
		 int BufSiz;
      public:
		 void Clear();
		 virtual int Read(fstream&)=0;
		 virtual int Write(fstream&)=0;
		 virtual int Pack(student&,fstream&)=0;
		 virtual int Unpack(student&,fstream&)=0;
};

//varlen: defines read & write operation on files
class varlen : public iobuf
{
       public:
	      int Read(fstream&);
	      int Write(fstream&);
};

//delmfld: defines pack & unpack operations for the buffer
class delmfld : public varlen
{
       public:
	      int Pack(student&,fstream&);
	      int Unpack(student&,fstream&);
};
//////////////////////////////////////////////////////////////////////////


//update record(s)
void update(char *key)
{
 student stds[100],std;
 int f=0,found=0,g;
 char upd='n';
 fstream file(STU_FILE,ios::in);
 srch=0;
 file.seekg(0,ios::beg);
 while(!file.fail())
    if(std.Unpack(file))
	if(strcmpi(std.URN,key)==0)
	{
	    found=1;
	    cout<<"\n\tRecord:";
	    std.Display();
	    cout<<"\n Confirm permanent updation:[Y/N]";
	    cin>>upd;
	    if(!(upd=='Y' || upd=='y'))
	    {
		     stds[f].Clear();
		     stds[f++].Assign(std);
	    }
	    else
	    {
			char *urn;
		     cout << "\n\t Enter the new record :\n";
		     std.Input(1,urn);
		     strcpy(std.URN,key);
		     stds[f].Clear();
		     stds[f++].Assign(std);
	    }
	}
	else
	{
	    stds[f].Clear();
	    stds[f++].Assign(std);
	}
	file.clear();
	 if(found==0)
	     cout<<"\n\t Record not found.";
	 else
	 {
	     file.close();
	     file.open(STU_FILE,ios::out);
	     file.seekp(0,ios::beg);
	     for(g=0;g<f;g++)
		    if(!(stds[g].Pack(file))) continue;
			    file.clear();
	 }
	 file.close();
}

//assign record(s)
void assign(char *key)
{
 student stds[100],std;
 int f=0,found=0,g;
 char upd='n';
 student temp;
 srch=0;
// fstream file(STU_FILE,ios::app);
 fstream file(STU_FILE,ios::in);
 file.seekg(0,ios::beg);
 while(!file.fail())
  if(std.Unpack(file))
	if(strcmpi(std.URN,key)==0) {
	    found=1;
	    cout<<"\n\tRecord:";
	    std.Display();
	    cout<<"\n Confirm Assignment:[Y/N]";
	    cin>>upd;
	    if(!(upd=='Y' || upd=='y')) {
		     stds[f].Clear();
		     stds[f++].Assign(std);
	    }
	    else {
		     cout << "\n\t Enter the new URN : ";
		     cin>>temp.URN;
		     cout << "\n";
		     if(search(temp.URN)==0)
		     {
		     strcpy(temp.Name,std.Name);
		     strcpy(temp.Addr,std.Addr);
		     strcpy(temp.Sem,std.Sem);
		     strcpy(temp.Bran,std.Bran);

		     file.clear();
		     file.close();
		     fstream file(STU_FILE,ios::app);
		     file.seekp(0,ios::end);
			srch=0;
		     if(temp.Pack(file))	cout << "\n\t Student Record Assigned.";
		     else
			cout << "\n\t Failure.";
		     }
		     else
		     {
		     cout<<"\n\nThe record "<<temp.URN<<" already exists"<<endl;
		     return;
		     }
	    }
	}
	else {
	    stds[f].Clear();
	    stds[f++].Assign(std);
	}
 file.clear();
 file.close();
 if(found==0)
     cout<<"\n\t Record not found.";
}

//search for given record with urn as key
int search(char *key)
{
  student std;
  int i;
  char reg[20];

  fstream file(STU_FILE,ios::in);
  file.seekg(ios::beg);
  student st;
  srch=0;
  char *URN;
  delmfld temp;

/*	while( temp.Read(file) !=0 )
	 {
		temp.Unpack(st,file);

		URN=st.geturn();

		if ( strcmp(URN,key) == 0 )
		 {
			cout<<"Record Found.\n";
			st.Display();
			getch();
			file.clear();
			file.close();
			return 1;
		 }
	 }*/

	while( !file.fail())
	 {
		temp.Unpack(st,file);

		URN=st.geturn();

		if ( strcmp(URN,key) == 0 )
		 {
			cout<<"Record Found.\n";
			st.Display();
			getch();
			file.clear();
			file.close();
			return 1;
		 }
	 }
	cout << "Record not found!!!\n";
	file.clear();
	file.close();
	return 0;
}



//append a record to the file
void append()
{
	srch=1;
  student std;
  char *urn;
  clrscr();
  cout<<"\n\n\nEnter the URN : ";
  cin>>urn;
  if(search(urn)==0)
  {
  fstream file(STU_FILE,ios::app);
  std.Input(1,urn);
  file.seekp(0,ios::end);
  if(std.Pack(file))	cout << "\n\t Done.";
  else	cout << "\n\t Failure.";
  getch();
  file.clear();
  file.close();
  }
  else
  {
	cout<<"\n\n\nSince The Record above already exists enter a new record\n";
  }
  srch=0;
}

//delete record(s) from file
void delrec(char *key)
{
  int r=0,found=0,s;
  char del='N';
  srch=0;
  student stds[100],std;
  fstream file(STU_FILE,ios::in);
  file.seekg(0,ios::beg);
  while(!file.fail())
    if(std.Unpack(file))
      if(strcmpi(std.URN,key)==0)
      {
	found=1;
	cout<<"Record :";
	std.Display();
	cout<<"\n Confirm permanent deletion:[Y/N]";
	cin>>del;
	if(!(del=='Y' || del=='y'))
	{
	  stds[r].Clear();
	  stds[r++].Assign(std);
	}
	else
	cout<<"\n\t Deleted : ";
      }
      else
      {
	stds[r].Clear();
	stds[r++].Assign(std);
      }
  file.clear();
  if(found==0) cout<<"\n\t Record not found.";
  else
  {
    file.close();
    file.open(STU_FILE,ios::out);
    file.seekp(0,ios::beg);
    for(s=0;s<r;s++)
      if(!(stds[s].Pack(file))) continue;
    file.clear();
  }
  file.close();
}




/*************************************************************/
//display all record(s) in the file
void display()
{
     delmfld temp;
     fstream file(STU_FILE,ios::in);
     student st;
     char *urn;
     int i=0;
     srch=1;

	while( temp.Read(file)!=0 )
	 {
		temp.Unpack(st,file);

		urn=st.geturn();
		if( strcmp(urn,"") != 0 )
		 {
			cout<<"\n\n************\n";
			cout<<"Record # : "<<++i;
			cout<<"\n************\n";
			st.Display();
			getch();
		 }
	 }
	 srch=0;
}


///////////////////////////////////////////////////////////////////////////
void iobuf::Clear()
{
  strcpy(Buffer,"");
  BufSiz=0;
}

////////////////////////////////////////////////////////////////////////////
//reads record into buffer & finds buffer length
int varlen::Read(fstream &file)
{
  if(file.fail()) return 0;
  Clear();
  file.getline(Buffer,100,'\n');
  BufSiz=strlen(Buffer);
  return 1;
}
//writes record into file & appends
int varlen::Write(fstream &file)
{
  if(file.write(Buffer,BufSiz))
  {
    file.write("\n",1);
    return 1;
  }
  return 0;
}

////////////////////////////////////////////////////////////////////////////
//pack the student into Buffer with delimter and write into file
int delmfld::Pack(student &std,fstream  &file)
{
  Clear();
  strcpy(Buffer,std.URN);
  strcat(Buffer,"|");
  strcat(Buffer,std.Name);
  strcat(Buffer,"|");
  strcat(Buffer,std.Addr);
  strcat(Buffer,"|");
  strcat(Buffer,std.Sem);
  strcat(Buffer,"|");
  strcat(Buffer,std.Bran);
  strcat(Buffer,'\0');
  BufSiz=strlen(Buffer);
  return(Write(file));
}

//read record from file into Buffer and unpack into student
int delmfld::Unpack(student &std,fstream &file)
{
  if((srch==0))
  {
  if(!Read(file)) return 0;
  }
  std.Clear();
  if(BufSiz>0)
  {
    int p=0,q;
    for(q=0;Buffer[q]!='|';q++) std.URN[p++]=Buffer[q];
    std.URN[p]='\0'; p=0; q++;
	for(;Buffer[q]!='|';q++) std.Name[p++]=Buffer[q];
    std.Name[p]='\0'; p=0; q++;
    for(;Buffer[q]!='|';q++) std.Addr[p++]=Buffer[q];
    std.Addr[p]='\0'; p=0; q++;
    for(;Buffer[q]!='|';q++) std.Sem[p++]=Buffer[q];
    std.Sem[p]='\0'; p=0; q++;
    for(;q<BufSiz;q++) std.Bran[p++]=Buffer[q];
    std.Bran[p]='\0';
    return 1;
  }
  return 0;
}

////////////////////////////////////////////////////////////////////////////
//clears student object
void student::Clear()
{
  strcpy(URN,"");
  strcpy(Name,"");
  strcpy(Addr,"");
  strcpy(Sem,"");
  strcpy(Bran,"");
}
//read data
void student::Input(int flUpd,char *urn)
{
   Clear();
   if(!flUpd) {cout<<"\t URN      : "; cin>>URN;}
   else
	strcpy(URN,urn);
   cout<<"\t Name     : "; gets(Name);
//   getline(Name,'\n');
   cout<<"\t Address  : "; gets(Addr);
   cout<<"\t Semester : "; cin>>Sem;
   cout<<"\t Branch   : "; gets(Bran);
}

//display 1 student record
void student::Display()
{
  if (strcmp(URN,"")==0)
	return;

  cout << "\n\t URN       : " << URN
       << "\n\t Name      : " << Name
       << "\n\t Address   : " << Addr
	   << "\n\t Semester  : " << Sem
       << "\n\t Branch    : " << Bran;
}

//assign given student to this student
void student::Assign(student &std)
{
  strcpy(URN,std.URN);
  strcpy(Name,std.Name);
  strcpy(Addr,std.Addr);
  strcpy(Sem,std.Sem);
  strcpy(Bran,std.Bran);
}

//packs student into new buffer
int student::Pack(fstream &file)
{
  delmfld buffer;
  return (buffer.Pack(*this,file));
}

//unpacks buffer into student
int student::Unpack(fstream &file)
{
  delmfld buffer;
  return (buffer.Unpack(*this,file));
}

/*************************************************/

///////////////////////////////////////////////////////////////////////////
int main()
{
    int pos;
    char key[100];
    char ch;
    student stud;

    // Initial SCREEN Display
    clrscr();
    int ab;

    textcolor(YELLOW);
    gotoxy(10,5);cprintf("Implementation of Part-I of File Structures Lab");
    textcolor(GREEN);
    gotoxy(18,8);cprintf("***********************************************");
    textcolor(MAGENTA);
    gotoxy(20,10);cprintf("Project Developed By:");
    gotoxy(32,12);cprintf(" - ABHIJITH D.A. (1PI01IS001)");
    gotoxy(32,14);cprintf(" - MAHESH M.P.  (1PI01IS042)");
    textcolor(GREEN);
    gotoxy(18,16);cprintf("***********************************************");
    textcolor(YELLOW);
    gotoxy(38,20);cprintf("Under Guidance of :");
    textcolor(MAGENTA);
    gotoxy(48,22);cprintf(" Mr. SRIKANTH S.P. ");
    gotoxy(48,23);cprintf(" Lecturer, ISE-DEPT, PESIT.\n\n");

    int abh=15,abhi=1;
    for(ab=74;!kbhit();)
    {
	textcolor(abh);
	if(ab==74){
	ab=0;
	cout<<"\r";
	}
	if(abh==15) abh=0;

	if(abhi==1)
	{
		gotoxy(ab,1); abhi=0;
	}
	else
	{
		gotoxy(ab,25);abhi=1;
	}

	cout<<"\b";
	fflush(stdin);
	delay(50);
	cprintf("  ");
	delay(50);
	ab+=2;abh++;
    }
    getch();
    fflush(stdin);

    do
    {
      clrscr();
      textcolor(LIGHTRED);
      gotoxy(32,4);cprintf("MAIN MENU");
      textcolor(GREEN);
      gotoxy(18,6);cprintf("******************************************");
      textcolor(LIGHTCYAN);
      gotoxy(18,7);cprintf(" 1: Add Student record into the file");
      gotoxy(18,8);cprintf(" 2: Search for record by URN");
      gotoxy(18,9);cprintf(" 3: Delete record of a particular student");
      gotoxy(18,10);cprintf(" 4: Update record of a particular student");
      gotoxy(18,11);cprintf(" 5: Assign record of one student to another");
      gotoxy(18,12);cprintf(" 6: Display all records");
      gotoxy(18,13);cprintf(" 7: Quit program");
      textcolor(GREEN);
      gotoxy(18,14);cprintf("******************************************");

      abh=15,abhi=0;
      gotoxy(ab,25);
      for(ab=0;;){
	textcolor(abh);
	if(ab==74) break;
	if(ab==0){cout<<"\r";}
	if(abh==15) abh=0;
	if(abhi==1){gotoxy(ab,1); abhi=0;}
	else{gotoxy(ab,25);abhi=1;}
	cprintf("  ");
	ab+=2;abh++;
    }

      gotoxy(18,16);cout<<"\r\t\t Enter choice [1-7]: ";
      gotoxy(38,16);cin>>ch;

	switch(ch)
	{
		case '1':
			   append();
			   break;

		case '2':
			   clrscr();
			   cout<<"\n\t Enter the URN to search : ";
			   cin>>key;
			   cout<<"\n\n";
			   search(key);
			   break;


		 case '3':
			   clrscr();
			   cout<<"\n\t Enter the URN to delete : ";
			   cin>>key;
			   delrec(key);
			   break;

		 case '4':
			   clrscr();
			   textcolor(GREEN);
			   cprintf(" ----- U P D A T E   S T U D E N T   R E C O R D -----");
			   cout<<"\n\n\t Enter the URN to update : ";
			   cin>>key;
			   update(key);
			   break;

		 case '5':
			   clrscr();
			   textcolor(YELLOW);
			   cprintf(" ----- A S S I G N   S T U D E N T   R E C O R D -----");
			   cout<<"\n\n\t Enter the URN which you want to assign : ";
			   cin>>key;
			   assign(key);
			   break;

		 case '6':
			   clrscr();
			   display();
			   break;

		 case '7':
			   highvideo();
			   textcolor(RED);
			   gotoxy(24,20);cprintf(" -----   THANK YOU   -----  ");
			   textcolor(LIGHTRED);
			   gotoxy(22,24);cprintf( " !!!  Press any key to exit... !!!");
			   getch();
			   exit(1);

		 default:
			   cout<<"\n\t\t !!! Invalid Choice. Press any key ... !!!";
			   break;
	}
	if(ch>='1' && ch<='7')
		cout << "\n\t Press any key to return to menu ...";
	getch();
     }
     while(ch!='7');

     return 0;
}
///////////////////////////////////////////////////////////////////////////