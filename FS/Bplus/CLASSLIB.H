
//B+ Plus tree class libary
///////////////////////////////////////////////////////////////////////
class block		// class for block
      {
       public:
	      char keys[4][11];
	      block *link;
	      int disp[4];
	      int cnt;

	      block();
	      ~block(){}

	      void split();
	      void merge();
      };
/*************************************************/
class SSET		// class for sequence set
      {
       public:
	      typedef block *BK;

	      SSET();
	      ~SSET(){}

	      void create();
	      int Insert(char*,int);
	      void del(char*);
	      block *FindNode(char*);
	      void display();
      };
/**************************************************/
class node	// class for btree node
      {
       public:
	      char keys[4][11];		//Stores Keys. i,e URN
	      node *dptrs[4];		//Stores Address (i,e in memory) to sequence set
	      node *uptr;			//Points to parent node
	      block *ptr[4];		//Points to child node
	      int cnt;

	      node();
	      ~node(){}

	      int isLeaf();
	      void split(node *,node *,node *);
      };
/**************************************************/
class btree     // class for btree
      {
       public:
	      node *root;

	      btree();
	      ~btree(){}

	      int insert(char*,block *);
	      node* findLeaf(char*,int&);
	      block *search(char*,int&);
	      void create();
	      void dis(node*);
      };
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
	      int Unpack(fstream&);
	      int Pack(fstream&);
	      void Input(int);
	      void Display();
	      void Assign(student&);
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
