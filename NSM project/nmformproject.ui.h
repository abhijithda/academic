/****************************************************************************
** ui.h extension file, included from the uic-generated form implementation.
**
** If you wish to add, delete or rename functions or slots use
** Qt Designer which will update this file, preserving your code. Create an
** init() function in place of a constructor, and a destroy() function in
** place of a destructor.
*****************************************************************************/

#include<qmessagebox.h>
#include<qstring.h>
#include<qaccessible.h>

#include<sys/types.h>
#include<sys/socket.h>
#include<stdio.h>
#include<netinet/in.h>
#include<arpa/inet.h>
#include<unistd.h>
#include<string.h>
#include<netinet/in.h>
#include<fcntl.h>
#include<unistd.h>
#include<sys/errno.h>
#include<signal.h>

#define PORT1 9900
#define BUFLEN 1000

extern 	int 	errno;

int sockfd;
int count=0;
struct sockaddr_in address;
int choice;
char chnum[2];
char ch[800];
int saveflag=0;
bool newcon=false;


void nmFormproject::newConnection()
{
    if(!newcon)
    {
	newcon=true;
	strcpy(chnum,"z");
	send(sockfd,chnum,sizeof(chnum),0);
	::close(sockfd);
	requestpushButton->setEnabled(FALSE);
	startpushButton->setEnabled(FALSE);
	comboBox2->setEnabled(FALSE);
	lineEdit4->setEnabled(FALSE);
    }
    lineEdit4->clear();
    lineEdit4->setEnabled(TRUE);
    startpushButton->setEnabled(TRUE);
    lineEdit4->setEnabled(TRUE);
//    QAccessibleInterface::lineEdit4->setFocus(TRUE);
    textEdit2->clear();
}

void nmFormproject::connectfun()
{
    if ( lineEdit4->text()  == "")
    {
	QMessageBox::message("Warning","IP Address of the Client : INVALID","Ok",this,0);
	return ;
    }
    
    const char *NET_ADDR=  lineEdit4->text() ;
    sockfd = socket(AF_INET,SOCK_STREAM,0);
    address.sin_family = AF_INET;
    address.sin_addr.s_addr = inet_addr(NET_ADDR);
    address.sin_port =htons(PORT1);
	
    if(::connect(sockfd,(struct sockaddr *)&address,sizeof(address))==-1)
    {
	QMessageBox::message("Warning"," Specified Client not available.","Ok",this,0); 
	requestpushButton->setEnabled(FALSE);
	return;
//	textEdit2->setText("Client:cannot connect to the server");
    }
    
    textEdit2->setText("System Ready");
    lineEdit4->setEnabled(FALSE);
    startpushButton->setEnabled(FALSE);
    requestpushButton->setEnabled(TRUE);
    comboBox2->setEnabled(TRUE);
}

void nmFormproject::requestfun()
{
    newcon = false;
    requestpushButton->setEnabled(FALSE);
    choice = comboBox2->currentItem();
    switch(choice+1)
    {
	case 1:
		strcpy(chnum,"b");
		break;
	case 2:
		strcpy(chnum,"c");
		break;
	case 3:
		strcpy(chnum,"d");
		break;
	case 4:
		strcpy(chnum,"e");
		break;
	case 5:
		strcpy(chnum,"f");
		break;
	case 6:
		strcpy(chnum,"g");
		break;
	case 7:
		strcpy(chnum,"h");
		break;
	case 8:
		strcpy(chnum,"i");
		break;
	case 9:
		strcpy(chnum,"j");
		break;
	case 10:
		strcpy(chnum,"k");
		break;
	case 11:
		strcpy(chnum,"l");
		break;
	case 12:
		strcpy(chnum,"m");
		break;
	case 13:
		strcpy(chnum,"n");
		break;
	case 14:
		strcpy(chnum,"o");		
		break;
	 case 15:
		strcpy(chnum,"p");
		break;
	case 16:
		strcpy(chnum,"q");
		break;
	case 17:
		strcpy(chnum,"r");
		break;
	    case 18:
		strcpy(chnum,"s");
		break;
	   case 19:
		strcpy(chnum,"t");
		break;
	case 20:
		strcpy(chnum,"u");
		break;
	case 21:
		strcpy(chnum,"v");
		break;
		
    }
    
    send(sockfd,chnum,sizeof(chnum),MSG_NOSIGNAL);
   if(errno == EPIPE)
    {
	QMessageBox::message("Invalid State - Broken PIPE","Warning: Client Machine code not runnig,\n or\n Machine shut down","Ok",this,0);
	requestpushButton->setEnabled(FALSE);
	comboBox2->setEnabled(FALSE);
	::close(sockfd);
	newcon = TRUE;
	errno =0;
	return;
    }
    
    if(recv(sockfd,ch,sizeof(ch),O_NONBLOCK) ==-1  or errno == SIGPIPE or errno == EAGAIN)
    {
	QMessageBox::message("Invalid State","Warning: Client Machine code not runnig,\n or\n Machine break down","Ok",this,0);
	requestpushButton->setEnabled(FALSE);
	comboBox2->setEnabled(FALSE);
	::close(sockfd);
	newcon = TRUE;
	errno =0;
	return;
    }
    
    textEdit2->setText(ch);
    saveflag=1;
    requestpushButton->setEnabled(TRUE); 
}



void nmFormproject::mainsaveaction()
{
    if(saveflag==1)
    {
	enterpathtext->setEnabled(TRUE);
	savepushbutton->setEnabled(TRUE);
	cancelpushbutton->setEnabled(TRUE);
    }
    else
    {
	enterpathtext->setEnabled(FALSE);
	savepushbutton->setEnabled(FALSE);
	cancelpushbutton->setEnabled(FALSE);
    }
	
}


void nmFormproject::actualsaveaction()
{
    if(enterpathtext->text() == "")
    {
	QMessageBox::information( this, "Information",
                                          "Enter a valid Path/File name", "", "", "",0, 1 );
    }
    
  
    else
    {
	
	
	char filename[30];
	int filedes=0;
	
	strcpy(filename,enterpathtext->text());
                if((filedes=open(filename,O_RDWR|O_CREAT|O_EXCL,777)) == -1)
	  {
	      QMessageBox::information( this, "Error Creating File",						" Enter a valid Path Name\n or \n\t File already exists.", "", "", "",0, 1 );
	  }
	else
	{
	      write(filedes,textEdit2->text(),800);
	      fflush(stdin);
	      QMessageBox::information( this, "Information","File Successfully Created and Saved", "", "", "",0, 1 );
	}
    }
}


void nmFormproject::actualsavecancelaction()
{
 	enterpathtext->setEnabled(FALSE);
	savepushbutton->setEnabled(FALSE);
	cancelpushbutton->setEnabled(FALSE);
}

    
void nmFormproject::aboutfun()
{
    QMessageBox::information( this, "About", "NETWORK SYSTEM MONITORING \n \n\t - By \n\n\tABHIJITH D.A. (1PI01IS001) \n\t MAHESH M.P. (1PI01IS042)\n\t 7th SEM,\n\t ISE,\n\t PESIT. ", "", "", "",0, 1 );
}

void nmFormproject::clearfun()
{
    saveflag=0;
    actualsavecancelaction();
    textEdit2->clear();
}

void nmFormproject::exitfun()
{  
    strcpy(chnum,"z");
    send(sockfd,chnum,sizeof(chnum),0);
    ::close(sockfd);
    close();
}

    
