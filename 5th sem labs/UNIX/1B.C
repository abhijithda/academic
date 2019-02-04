/*	Name : ABHIJITH D.A.	Reg.no : 1PI01IS001

  Prg.1b : Write a C program that creates a child process to read commands
	   from the standard input and execute them (a minimal implementation
	   of a shell-like program). You assume no arguments will be passed
	   to the commands to be executed.
*/

#include<stdio.h>
#include<fcntl.h>

pid_t pid;

int main()
{
 char arr[50];
 pid=fork();
 if(pid==0)
 {
  printf("\n\t Enter the command to execute : ");
  scanf("%s",arr);
  system(arr);
  printf("\n\t Child terminating. ");
 }
 else
 {
  wait(0);
  printf("\n\t Parent terminating.\n");
 }
 return 0;
}

/*------------------------Outputs-------------------------

$./a.out

	Enter the command to execute : ls
1a.sh  1b.c  2a.sh  3a.sh 3b.c a.out temp

	Child terminating.
	Parent terminating.
$_

*/

