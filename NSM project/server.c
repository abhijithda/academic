#include<sys/types.h>
#include<sys/socket.h>
#include<stdio.h>
#include<netinet/in.h>
#include<netinet/tcp.h>
#include<arpa/inet.h>
#include<fcntl.h>
#include<unistd.h>
#include<signal.h>
#include<sys/errno.h>

#define NET_ADDR "127.0.0.1"
//#define NET_ADDR "169.254.119.233"
#define PORT 9900

#define BUFLEN 1000

int cli_sockfd;


void quit_pipe()
{
	printf("Broken Pipe: client machine code of Network System Monitoring is stopped.");
	exit(2);
}

void quit()
{
	signal(SIGPIPE,quit_pipe);
	char *buf = "Client Machine Code of Network System Monitoring: Stopped.";
	send(cli_sockfd,buf,sizeof(buf),0);
	printf("%s",buf);
	exit(1);
}


int main( int argc, char *argv[] )
{
	signal(SIGINT,quit);
	signal(SIGQUIT,quit);
	signal(SIGTSTP,quit);
	signal(SIGPIPE,quit_pipe);

	int ser_sockfd,cli_sockfd;
	int ser_len,cli_len;
	int result=0;
	int count,fd,x; 
    	char choice;
	struct sockaddr_in ser_addr;
	struct sockaddr_in cli_addr;

	char num[5],nread=0;
	char *desc;
	int rbytes,conflag=1;
	char buf[800];
	ser_sockfd = socket(AF_INET,SOCK_STREAM,0);

	ser_addr.sin_family = AF_INET;
	ser_addr.sin_addr.s_addr = inet_addr(NET_ADDR);
	ser_addr.sin_port = htons(PORT);
	ser_len = sizeof(ser_addr);

	bind(ser_sockfd,(struct sockaddr *)&ser_addr,ser_len);
	listen(ser_sockfd,5);


	cli_len = sizeof(cli_addr);
	cli_sockfd = accept(ser_sockfd,(struct sockaddr *)&cli_addr,&cli_len);

//Mention the choice to the client

	while(1)
	{
		recv(cli_sockfd,num,sizeof(num),0);
		choice = num[0];
//		printf("\n%c\n",choice);

 		switch(choice)
    		{
        	case 'b':
                  system("ps -l >actpsf");
                  desc="Process status";
                  break;

	        case 'c':
                  system("tty| cut  -c 6- >actpsf");
                  desc="terminal info";
                  break;
		case 'd':
                  system("uptime >actpsf");
                  desc="Uptime status";
                  break;

	        case 'e':
                  system("cat /proc/cpuinfo >actpsf");   
                  desc="Cpuinfo";  
                  break;
        	case 'f': 
                  system("cat /proc/ioports >actpsf");   
                  desc="ioports status";  
                  break;
	        case 'g': 
                  system(" cat /proc/interrupts >actpsf");   
                  desc="interrupts status";  
                  break;
        	case 'h': 
                  system("cat  /proc/filesystems >actpsf");   
                  desc="filesystem";  
                  break;
	        case 'i': 
                  system("cat  /etc/sysconfig/hwconf >actpsf");   
                  desc="Hardware Config";  
                  break;
        	case 'j': 
                  system("cat  /proc/partitions >actpsf");   
                  desc="Partitions info";  
                  break;
	        case 'k': 
                  system("cat  /proc/slabinfo >actpsf");   
                  desc="slabinfo";  
                  break;
        	case 'l': 
                  system("cat  /proc/iomem >actpsf");   
                  desc="iomem status";  
                  break;
		case 'm': 
                  system("cat  /proc/devices >actpsf");   
                  desc="devices status";  
                  break;
        	case 'n': 
                  system("cat  /proc/stat >actpsf");   
                  desc="stat status";  
                  break;
		case 'o':   
                  system("cat /proc/meminfo >actpsf");   
                  desc="Meminfo ";  
                  break;

		case 'p':
		  system("mount >actpsf");
		  desc="Mounted Files";
		  break;
		case 'q':
		  system("cat /proc/ide/hda/model >actpsf");
		  desc="Hard Disk Model";
		  break;
		case 'r':
		  system("cat /proc/ide/drivers >actpsf");
		  desc="Hardware Drivers";
		  break;		
		case 's':
		  system("who -u >actpsf");
		  desc="Users of the System";
		  break;
		case 't':
		  system("finger > actpsf");
		  desc="System Users information";
		  break;
		case 'u':
		  system("ps -e >actpsf");
		  desc="Report Process status information of client";
		  break;
		case 'v':
		  system("df >actpsf");
		  desc="Disk usage Information of client";
		  break;
       		case 'z':
		  close(cli_sockfd);
		  cli_len = sizeof(cli_addr);
		  cli_sockfd = accept(ser_sockfd,(struct sockaddr *)&cli_addr,&cli_len);
		  conflag=0;
		  break;
		//  exit(0);
		}
		if(conflag!=0)
		{
      			fd=open("actpsf",O_RDONLY);
		        rbytes=read(fd,&buf,800);
        		buf[rbytes]='\0';
			send(cli_sockfd,buf,sizeof(buf),0);
		        close(fd);
			buf[0]='\0';
		}
		conflag=1;
       		system("rm -f act*");
//      	printf("Sent %s to the server\n",desc);
	}

	close(cli_sockfd);
	return 0;
}

