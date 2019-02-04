
//Include system headers
#include <iostream.h>
#include <fstream.h>
#include <conio.h>
#include <string.h>
#include <stdlib.h>
#include <dos.h>
#include <stdio.h>
#include <ctype.h>

//Include user headers
#include "classlib.h"

//location of Student File
#define STU_FILE "C:\\Student.txt"

btree bt;
SSET s;
node *dummy,*dummy1;
block *head;
static int tot,usd;

//update record(s)
void update(char *key)
{
 student stds[100],std;
 int f=0,found=0,g;
 char upd='n';
 fstream file(STU_FILE,ios::in);
 file.seekg(0,ios::beg);
 while(!file.fail())
  if(std.Unpack(file))
	if(strcmpi(std.URN,key)==0) {
	    found=1;
	    cout<<"\n\tRecord:";
	    std.Display();
	    cout<<"\n Confirm permanent updation:[Y/N]";
	    cin>>upd;
	    if(!(upd=='Y' || upd=='y')) {
		     stds[f].Clear();
		     stds[f++].Assign(std);
	    }
	    else {
		     cout << "\n\t Enter the new record :\n";
		     std.Input(1);
		     strcpy(std.URN,key);
		     stds[f].Clear();
		     stds[f++].Assign(std);
	    }
	}
	else {
	    stds[f].Clear();
	    stds[f++].Assign(std);
	}
 file.clear();
 if(found==0)
     cout<<"\n\t Record not found.";
 else {
     file.close();
     file.open(STU_FILE,ios::out);
     file.seekp(0,ios::beg);
     for(g=0;g<f;g++)
	    if(!(stds[g].Pack(file))) continue;
		    file.clear();
 }
 file.close();
 delete head;
 delete bt.root;
 head = new block;
 bt.root = new node;
 s.create();
}

//assign record(s)
void assign(char *key)
{
 student stds[100],std;
 int f=0,found=0,g;
 char upd='n';
 student temp;

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
		     cout << "\n\t Enter the new URN :";
		     cin>>temp.URN;
		     for(int a1=0;temp.URN[a1]!='\0';a1++)
			temp.URN[a1]=toupper(temp.URN[a1]);
		     strcpy(temp.Name,std.Name);
		     strcpy(temp.Addr,std.Addr);
		     strcpy(temp.Sem,std.Sem);
		     strcpy(temp.Bran,std.Bran);
		     int flag1=1, pos;
		     file.clear();
		     file.close();
		     fstream file(STU_FILE,ios::app);
		     file.seekp(0,ios::end);
		     pos=file.tellp();
		     flag1=s.Insert(temp.URN,pos);
		     if(flag1 && temp.Pack(file))	cout << "\n\t Student Record Assigned.";
		     else	cout << "\n\t Failure.";
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
void search(char *key)
{
  student std;
  int found=0,i;
  block *dp;
  fstream file(STU_FILE,ios::in);
  file.seekg(ios::beg);
  dp=bt.search(key,found);
  if(found==0)
	cout<<"\n\t Record not found.";
  else
  {
	 found=0;
	 for(i=0;i<dp->cnt;i++)
	  if(strcmpi(key,dp->keys[i])==0) {
		found = 1;
		file.seekg(dp->disp[i],ios::beg);
		std.Unpack(file);
		cout<<"\n\t Record found : ";
		std.Display();
	 }
	 if(found==0) cout<<"\n\t Record not found ";
  }
  file.clear();
  file.close();
}

//append a record to the file
void append()
{
  student std;
  int flag=1, pos;
  fstream file(STU_FILE,ios::app);
  std.Input(0);
  file.seekp(0,ios::end);
  pos=file.tellp();
  flag=s.Insert(std.URN,pos);
  if(flag && std.Pack(file))	cout << "\n\t Done.";
  else	cout << "\n\t Failure.";
  file.clear();
  file.close();
}

//delete record(s) from file
void delrec(char *key)
{
  int r=0,found=0,s;
  char del='N';
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

//display all record(s) in the file
void display(node * p)
{
  int i,j;
  student std;
  if(p->isLeaf())
  {
	//if file does not exist
	fstream file(STU_FILE,ios::in);
	if(file.fail())	{
		printf("\n The File Is Empty\n");
		getch();
		return;
	}
	for(i=0;i<p->cnt;i++) {
	     block * t=p->ptr[i];
	     for(j=0;j<t->cnt;j++) {
		file.seekg(t->disp[j],ios::beg);
		if(std.Unpack(file)) {
			std.Display();
			cout << "\n\t\t Press any key ...";
			getch();
		}
		else break;
	     }
	}
	file.clear();
	file.close();
  }
  for(i=0;i<p->cnt;i++)
    if(p->dptrs[i]!=0) display(p->dptrs[i]);
}

//////////////////////////////////////////////////////////////////////////
node::node()	// constructor for btree node
{
  for(int i=0;i<4;i++)
  {
    strcpy(keys[i],'\0');
    dptrs[i]=0;
    ptr[i]=0;
  }
  uptr=0;
  cnt=0;
}

int node::isLeaf()
{
  int flag=1;
  for(int i=0;i<4;i++)
	 if((dptrs[i]) != 0)
	 {
	      flag=0;
	      break;
	  }
  return flag;
}

//nd : node to split;         cr : curr. level new node;
//up : upper level new node   rt : root of btree
//rt is for updating the root if it gets split
void node::split(node *nd,node *cr,node *up)
{
  int i;
  node *z=nd->uptr;//parent of nd
  cr=new node;
  for(i=2;i<4;i++)//move half of 'nd' to 'cr'
  {
    strcpy(cr->keys[cr->cnt],nd->keys[i]);
    strcpy(nd->keys[i],'\0');
    cr->ptr[cr->cnt]=nd->ptr[i];
    nd->ptr[i]=0;
    cr->dptrs[cr->cnt]=nd->dptrs[i];
    nd->ptr[i]=0;
    cr->cnt++;
    nd->cnt--;
  }
  if(z!=0)//nd is not root of b-tree
  {
    node *x2;
    if(z->cnt==4)//if upper level splits
    {
      dummy=0; dummy1=0;
      z->split(z,up,x2);//in upper level, up becomes cr. (recursive)
      if(dummy!=0) up=dummy;
      if(dummy1!=0) z=dummy1;

      for(i=2;i>=0;i--)//update z
      {
	if(strcmp((up->keys[i]),'\0')!=0)
	  if(strcmp((nd->keys[(nd->cnt)-1]),(up->keys[i]))<0)
	  {// shift the entries
	    strcpy(up->keys[i+1],up->keys[i]);
	    up->ptr[i+1]=up->ptr[i];
	    up->dptrs[i+1]=up->dptrs[i];
	  }
	  else
	  {//insert nd's highest value to z
	    strcpy(up->keys[i+1],(nd->keys[(nd->cnt)-1]));
	    up->ptr[i+1]=(nd->ptr[(nd->cnt)-1]);
	    up->cnt++;
	    break;
	  }
      }
      if(i<0)
      {
	strcpy(up->keys[0],(nd->keys[(nd->cnt)-1]));
	up->ptr[0]=(nd->ptr[(nd->cnt)-1]);
	up->cnt++;
      }
      for(i=3;i>0 && strcmp((cr->keys[(cr->cnt)-1]),up->keys[i])!=0;i--);
      up->dptrs[i]=cr;
      cr->uptr=up;
    }
    else
    {
      for(i=2;i>=0;i--)//update z
      {
	if(strcmp((z->keys[i]),'\0')!=0)
	  if(strcmp((nd->keys[(nd->cnt)-1]),(z->keys[i]))<0)
	  {// shift the entries
	    strcpy(z->keys[i+1],z->keys[i]);
	    z->ptr[i+1]=z->ptr[i];
	    z->dptrs[i+1]=z->dptrs[i];
	  }
	  else
	  {//insert nd's highest value to z
	    strcpy(z->keys[i+1],(nd->keys[(nd->cnt)-1]));
	    z->ptr[i+1]=(nd->ptr[(nd->cnt)-1]);
	    z->cnt++;
	    break;
	  }
      }
      if(i<0)
      {
	strcpy(z->keys[0],(nd->keys[(nd->cnt)-1]));
	z->ptr[0]=(nd->ptr[(nd->cnt)-1]);
	z->cnt++;
      }//z is updated
      //change the ptr of z towards cr at required position
      for(i=3;i>0 && strcmp((cr->keys[(cr->cnt)-1]),z->keys[i])!=0;i--);
      z->dptrs[i]=cr;
      cr->uptr=nd->uptr;
    }
  }
  else//handle root
  {
    up=new node;
    strcpy(up->keys[0],nd->keys[(nd->cnt)-1]);
    up->ptr[0]=nd->ptr[(nd->cnt)-1];
    up->dptrs[0]=nd;
    strcpy(up->keys[1],cr->keys[(cr->cnt)-1]);
    up->ptr[1]=cr->ptr[(cr->cnt)-1];
    up->dptrs[1]=cr;
    up->cnt=2;
    nd->uptr=cr->uptr=up;
    bt.root=up;//reset root
  }
  dummy=cr;
  dummy1=nd;
}

//////////////////////////////////////////////////////////////////////////
btree::btree()		// construtor for btree
{
  root=new node;
}

/***************************************************/
//flg = 1 => already exists
node* btree::findLeaf(char* value,int &flg)
{
  node *x=root;
  int i;
  flg=0;
  while(!(x->isLeaf()))
  {
   for(i=3;i>=0;i--)
    {
     if((strcmp((x->keys[i]),'\0'))!=0)
      if(strcmp(value,(x->keys[i]))>0)
      {
       if(i<(x->cnt)-1)
	x=x->dptrs[i+1];
       else
	x=x->dptrs[(x->cnt)-1];
       break;
      }
      else if(strcmp(value,(x->keys[i]))==0) flg=1;
    }
    if(i<0) x=x->dptrs[0];
  }
  for(i=0;i<x->cnt;i++)
    if(strcmp(value,(x->keys[i]))==0)
    {
      flg=1;
      return x;
    }
  return x;
}

void btree::dis(node *p)
{
  int i;
  static int j=0;
  cout<< "Level-" << j++ <<":";
  for(i=0;i<p->cnt;i++)
    cout << "    " << p->keys[i];
  cout << endl;
  for(i=0;i<p->cnt;i++)
    if(p->dptrs[i]!=0) 
    	dis(p->dptrs[i]);
  j--;
}

void btree::create()
{
 block *temp=head;
 bt.root = new node;
 while(temp!=0)
 {
  bt.insert(temp->keys[temp->cnt-1],temp);
  temp = temp->link;
 }
}

int btree::insert(char* val, block *d)
{
  int i,flag;
  node *x=findLeaf(val,flag),*a1,*a2;
  if(flag==1)
  {
    cout << "\n\t Repeated! " << val << endl;
    return 0;
  }
  if((x->cnt)==4)//there is no space in the record so insert
  {
    x->split(x,a1,a2);//split the leaf and upper nodes if needed
    x=findLeaf(val,flag);
  }
  for(i=2;i>=0;i--)
    if(strcmp((x->keys[i]),'\0')!=0)
      if(strcmp(val,(x->keys[i]))<0)
      {
	strcpy(x->keys[i+1],x->keys[i]);
	x->ptr[i+1]=x->ptr[i];
      }
      else
      {
	strcpy(x->keys[i+1],val);
	x->ptr[i+1]=d;
	x->cnt++;
	break;
      }
  if(i<0)
  {
    strcpy(x->keys[0],val);
    x->ptr[0]=d;
    x->cnt++;
  }
  else if(i==(x->cnt)-2)
    while((x->uptr)!=0)
    {
      x=x->uptr;
      strcpy(x->keys[(x->cnt)-1],val);
      x->ptr[(x->cnt)-1]=d;
    }
    return 1;
}

//displacement is retruned, flag 'found' is set
block *btree::search(char *key,int &fnd)
{
  int i,flg=0;
  fnd=0;
  node *x=findLeaf(key,flg),*a1,*a2;
  for(i=0;i<x->cnt;i++)
   if(strcmp(key,x->keys[i])<=0)
   {
    fnd=1;
    return(x->ptr[i]);
   }
  return head;
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
  if(!Read(file)) return 0;
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
void student::Input(int flUpd)
{
   int i;
   Clear();
   if(!flUpd) {cout<<"\t URN      : "; cin>>URN;}
	for (i=0; i<strlen(URN); i++)
	{
	   URN[i] = toupper(URN[i]);
	}

//   convert_2_upper(URN);
   cout<<"\t Name     : "; gets(Name);
   cout<<"\t Address  : "; gets(Addr);
   cout<<"\t Semester : "; cin>>Sem;
   cout<<"\t Branch   : "; gets(Bran);
}

//display 1 student record
void student::Display()
{
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

///////////////////////////////////////////////////////////////////////////
block :: block()	// constructor for block
	  {
	   for(int i=0;i<4;i++)
	   {
	strcpy(keys[i],'\0');
	disp[i]=0;
	   }
	   cnt=0;
	   link=0;
		}
/***********************************************************************/
void block :: split()		// function to split the block
	  {
	   block *newnode;
	   newnode=new block;
	   int j=0;
	   for(int i=2;i<this->cnt;i++)
	   {
			strcpy(newnode->keys[j],this->keys[i]);
			strcpy(this->keys[i],'\0');
			newnode->disp[j]=this->disp[i];
			this->disp[i]=-1;
			newnode->cnt++;
			j++;
	   }
	   newnode->link = this->link;
	   this->link=newnode;
	   this->cnt-=2;
	   bt.create();
}

/***********************************************************************/
void block :: merge()		// function to merge two blocks
	  {
	   block *t1,*t2;
	   t1=head;
	   if(t1 == this)        // merge first block
	   {
	if(t1->link->cnt < 4 )  // check wether next block can be merged
	{
	 for(int p=t1->link->cnt;p>=0;p--)
	 {
	  strcpy(t1->link->keys[p],t1->link->keys[p-1]);
	  t1->link->disp[p] = t1->link->disp[p-1];
	 }
	 strcpy(t1->link->keys[0],t1->keys[0]);
	 t1->link->disp[0]=t1->disp[0];
	 t1->link->cnt++;
	 head=t1->link;
	 t1->link=0;
	 delete t1;
	}
	else if(t1->link->cnt==4)     	// redistribution of keys
	{
	 strcpy(t1->keys[1],t1->link->keys[0]);
	 t1->disp[1]=t1->link->disp[0];
	 t1->cnt++;
	 for(int c=0;c<t1->link->cnt;c++)
	 {
	  strcpy(t1->link->keys[c],t1->link->keys[c+1]);
	  t1->link->disp[c]=t1->link->disp[c+1];
	 }
	 t1->link->cnt--;
	}
	   }
	   else		// find which block to be merged
	   {
	while(t1->link != this)
	 t1=t1->link;
	if(t1->cnt < 4)		// merge with left node
	{
	 strcpy(t1->keys[t1->cnt],this->keys[0]);
	 t1->disp[t1->cnt] = this->disp[0];
	 t1->link = this->link;
	 t1->cnt++;
	 this->link=0;
	 delete this;
	}
	else
	{
	 if(this->link !=0)  	// check wether node to be merged is last
	 {                      // if not
	  t2=this->link;
	  if(t2->cnt < 4)      // merge with right node
	  {
	   for(int i=t2->cnt;i>=0;i--)
	   {
		strcpy(t2->keys[i],t2->keys[i-1]);
		t2->disp[i]=t2->disp[i-1];
	   }
		strcpy(t2->keys[0],this->keys[0]);
	   t2->disp[0]=this->disp[0];
	   t2->cnt++;
	   t1->link = this->link;
	   this->link=0;
	   delete this;
	  }
	  else	  {  	//Redistribution
	   t2=this->link;
	   strcpy(this->keys[this->cnt],t2->keys[0]);
	   this->disp[this->cnt]=t2->disp[0];
	   this->cnt++;
	   for(int i=0;i<t2->cnt;i++)
	   {
	    strcpy(t2->keys[i],t2->keys[i+1]);
	    t2->disp[i]=t2->disp[i+1];
	   }
	   t2->cnt--;
	  }
	 }
	 else			// if it is last block
	 {
	  strcpy(this->keys[1],this->keys[0]);
	  this->disp[1]=this->disp[0];
	  strcpy(this->keys[0],t1->keys[t1->cnt-1]);
	  this->disp[0]=t1->disp[t1->cnt-1];
	  this->cnt++;
	  t1->cnt--;
	 }
	}
  }
}

//////////////////////////////////////////////////////////////////////////
SSET :: SSET()		// constructor for sequence set
      {
		 head = new block;
      }

/***********************************************************************/
void SSET::create()	// function to create blocks from file
{
  int pos;
  char *buf;
  fstream file;
  file.open(STU_FILE,ios::in);
  if(file.fail())  {
	clrscr();
	return;
  }
  while(!file.fail())  {

	 pos=file.tellg();
	 file.getline(buf,100,'|');
	 if(strcmp(buf,"")!=0) {
	    s.Insert(buf,pos);
	    file.getline(buf,100,'\n');
	}
  }
  file.close();
  bt.create();
}

/*****************************************************************/
block *SSET :: FindNode(char *val)	// function to find the block
      {
       BK t=head;
       int flag=0;

       node *temp=bt.root;
       int flg;
       temp = bt.findLeaf(val,flg);
       for(int i=0;i<temp->cnt;i++)
		if((strcmpi(temp->keys[i],val)>=0))
		{
		 t=temp->ptr[i];
		 flag=1;
		 break;
		}
		else if((temp->cnt!=0)&& (flag!=1) &&(!(strcmpi(temp->keys[i],val)==0)))
		 t=temp->ptr[temp->cnt-1];

    return t;
  }

/************************************************************************/
int SSET :: Insert(char *val,int disp) // function to insert key in block
{
    int i=0;
    BK x=FindNode(val);
    for(i=0;i<x->cnt;i++)
      if(strcmpi(x->keys[i],val)==0)
	  { cout<< " key "<<val<<" is repeated "<<endl;
	   return 0;
	   }
    if(x->cnt < 4)
    {
		for(i=0;i<x->cnt;i++)
		 if(strcmpi(x->keys[i],val)>0)
		  break;
	    if(strcmpi(x->keys[i],val)==0)
		  { cout<< " key "<<val<<" is repeated "<<endl;
		   return 0;
		   }
		else
		{
		 int d=i;
		 i=x->cnt-1;
		 while(i>=d)
		 {
		  strcpy(x->keys[i+1],x->keys[i]);
		  x->disp[i+1]=x->disp[i];
		  i--;
		 }
		 strcpy(x->keys[d],val);		// Store Key value
		 x->disp[d]=disp;				// Store Key Address
		 x->cnt++;
		 if(d==x->cnt-1)
		 {
		  bt.create();
		 }
	}
    }
    else	//If node is full. i,e. x->cnt=4
    {
	x->split();
	x=FindNode(val);
	if(x->cnt < 4)
	{
	 for(i=0;i<x->cnt;i++)
	  if(strcmpi(x->keys[i],val)>=0) break;
	 if(strcmpi(x->keys[i],val)==0)
	  //cout<< " key "<<val<<" is repeated "<<endl;
	  cout<<"";
	 else
	 {
	  int d=i;
	  i=x->cnt-1;
	  while(i>=d)
	  {
	   strcpy(x->keys[i+1],x->keys[i]);
	   x->disp[i+1]=x->disp[i];
	   i--;
	  }
	  strcpy(x->keys[d],val);
	  x->disp[d]=disp;
	  x->cnt++;
	 }
	}
	bt.create();
       }
       return 1;
      }
/**************************************************************************/
void SSET :: del(char *val)	// function to delete key from block
      {
	   int z,flg=0,i;
       BK x=FindNode(val);
       for(i=0;i<x->cnt;i++)
	if(strcmpi(x->keys[i],val)==0)
	{
	 flg=1;
	 z=i;
	 break;
	}
       if(flg==1)
       {
	if(x->cnt-1 < 2)
	{
	 for(int j=i;i<x->cnt;i++)
	 {
	  strcpy(x->keys[j],x->keys[i+1]);
	  strcpy(x->keys[i+1],"");
	  x->disp[j]=x->disp[i+1];
	  x->disp[i+1]=-1;
	  j++;
	 }
	 x->cnt--;
	 x->merge();
	 delete bt.root;
	 //bt.create();
	}
	else
	{
	 for(int j=i;i<x->cnt;i++)
	 {
	  strcpy(x->keys[j],x->keys[i+1]);
	  strcpy(x->keys[i+1],"");
	  x->disp[j]=x->disp[i+1];
	  x->disp[i+1]=-1;
	  j++;
	 }
	 x->cnt--;
	 if(z==x->cnt)
	 {
	 delete bt.root;
	  bt.root = new node;
	  //bt.create();
	 }
	}
       }
       else
	cout<<"\n Key "<<val<<" not found";
      }
/**********************************************************************/
void SSET :: display()		// function to display nodes
      {
       int j=0;
       BK t;
       t=head;
       getch();
       cout<<"\n Block Structure ";
       while(t != 0)
       {
	cout<<"\n Node :"<<j;
	for(int i=0;i<t->cnt;i++)
	{
	 cout<<"\n keys["<<i<<"] : " <<t->keys[i]
	     <<"\t\t disp["<<i<<"] : "<<t->disp[i];
	}
	t=t->link;
	j++;
	getch();
       }
      }
/*************************************************/

///////////////////////////////////////////////////////////////////////////
int main()
{
    int pos;
    char key[100];
    student stud;

    // For conversion of Key (URN) to upper
    void convert_2_upper(char *key);

    // Initial SCREEN Display
    clrscr();
    int ab;

    textcolor(YELLOW);
    gotoxy(10,5);cprintf("Implementation of STUDENT's FILE STRUCTURE using B+ Tree");
    textcolor(GREEN);// + BLINK);
    gotoxy(18,8);cprintf("***********************************************");
    textcolor(MAGENTA);
    gotoxy(20,10);cprintf("Project Developed By:");
    gotoxy(32,12);cprintf(" - ABHIJITH D.A. (1PI01IS001)");
    gotoxy(32,14);cprintf(" - MAHESH M.P.  (1PI01IS042)");
    textcolor(GREEN);// + BLINK);
    gotoxy(18,16);cprintf("***********************************************");
    textcolor(YELLOW);
    gotoxy(38,20);cprintf("Under Guidance of :");
    textcolor(MAGENTA);
    gotoxy(48,22);cprintf(" Mr. SRIKANTH S.P. ");
    gotoxy(48,23);cprintf(" Lecturer, ISE-DEPT, PESIT.\n\n");

    int abh=15,abhi=1;
    for(ab=74;!kbhit();)
    {
	textcolor(abh + BLINK);
	if(ab==74){
	ab=0;//gotoxy(24,ab);
	cout<<"\r";
	}
	if(abh==15) abh=0;

	if(abhi==1){
		gotoxy(ab,1); abhi=0;}
	else{
		gotoxy(ab,25);abhi=1;}

//	cout<<"\b";
	delay(50);
	cprintf("  ");
	delay(50);
	ab+=2;abh++;
    }
    getch();

    s.create();

    textcolor(12);
    cprintf("\r");
    char ch;
    do {
      clrscr();
      textcolor(LIGHTRED);
      gotoxy(32,4);cprintf("MAIN MENU");
      textcolor(GREEN);
      gotoxy(18,6);cprintf("******************************************");
      textcolor(LIGHTCYAN);
      gotoxy(18,7);cprintf(" 1: Add Student record into the file");
      gotoxy(18,8);cprintf(" 2: Search for record using BPlusTree");
      gotoxy(18,9);cprintf(" 3: Delete record of a particular student");
      gotoxy(18,10);cprintf(" 4: Update record of a particular student");
      gotoxy(18,11);cprintf(" 5: Assign record of one student to anther");
      gotoxy(18,12);cprintf(" 6: Display records in Sequential manner ");
      gotoxy(18,13);cprintf(" 7: BPlusTree structure display");
      gotoxy(18,14);cprintf(" 8: Quit program");
      textcolor(GREEN);
      gotoxy(18,15);cprintf("******************************************");

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

      gotoxy(18,16);cout<<"\r\t\t Enter choice [1-8]: ";
      gotoxy(38,16);cin>>ch;

      switch(ch)
       {
	 case '1':
	   clrscr();
	   textcolor(LIGHTBLUE);
	   gotoxy(15,2);cprintf(" ----- A D D   S T U D E N T   R E C O R D -----");
	   gotoxy(10,5);cprintf("\r");
	   append();
	   break;

	 case '2':
	   clrscr();
	   textcolor(LIGHTCYAN);
	   gotoxy(15,2);cprintf(" ----- S E A R C H   S T U D E N T   R E C O R D -----");
	   gotoxy(10,5);cprintf("\r");
	   cout<<"\n\t Enter the URN to search : ";
	   cin>>key;
	   convert_2_upper(key);
	   search(key);
	   break;

	 case '3':
	   clrscr();
	   textcolor(BROWN);
	   gotoxy(15,2);cprintf(" -----  D E L E T E   S T U D E N T   R E C O R D -----");
	   gotoxy(10,5);cprintf("\r");
	   cout<<"\n\t Enter the URN to delete : ";
	   cin>>key;
	   convert_2_upper(key);
	   delrec(key);
	   s.del(key);
	   delete head;
	   head = new block;
	   bt.root = new node;
	   s.create();
	   break;

	 case '4':
	   clrscr();
	   textcolor(GREEN);
	   gotoxy(15,2);cprintf(" ----- U P D A T E   S T U D E N T   R E C O R D -----");
	   cout<<"\n\n\t Enter the URN to update : ";
	   cin>>key;
	   convert_2_upper(key);
	   update(key);
	   break;

	 case '5':
	   clrscr();
	   textcolor(YELLOW);
	   gotoxy(15,2);cprintf(" ----- A S S I G N   S T U D E N T   R E C O R D -----");
	   cout<<"\n\n\t Enter the URN which you want to assign : ";
	   cin>>key;
	   convert_2_upper(key);
	   assign(key);
	   break;

	 case '6':
	   clrscr();
	   textcolor(MAGENTA);
	   gotoxy(15,2);cprintf(" -----  S T U D E N T   R E C O R D S  -----");
	   display(bt.root);
	   break;

	 case '7':
	   clrscr();
	   textcolor(DARKGRAY);
	   gotoxy(3,2);cprintf(" ----- B P L U S  T R E E  D I S P L A Y O F  S T U D E N T   R E C O R D -----");
	   fstream file(STU_FILE,ios::in);
	   if(file.fail())	{
		printf("\n The File Is Empty\n");
		getch();
		file.close();
		continue;
	   }
	   bt.dis(bt.root);
	   s.display();
	   break;

	 case '8':
	   highvideo();
	   textcolor(RED + BLINK);
	   gotoxy(24,20);cprintf(" -----   THANK YOU   -----  ");
	   textcolor(LIGHTRED);
	   gotoxy(22,24);cprintf( " !!!  Press any key to exit... !!!");
	   getch();
	   exit(1);

	 default:
	   cout<<"\n\t\t !!! Invalid Choice. ";
	   break;
       }
       cout << "\n\t Press any key ... 	to continue !!!";
       getch();
       }
       while(ch!='8');

	   return 0;
}
///////////////////////////////////////////////////////////////////////////

void convert_2_upper(char *key)
{
	int i;
	for(i=0;key[i]!='\0';i++)
		key[i]=toupper(key[i]);
}
///////////////////////////////////////////////////////////////////////////