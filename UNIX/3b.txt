/*	Name : ABHIJITH D.A.	Reg.no : 1PIO1IS001

  Prg3b>. Write a C program which accepts valid file names as command 
	  line arguments and for each of the arguments, prints the type
	  of the file (regular file, directory file, character special
	  file, block file, symbolic link etc.).
*/

#include<stdio.h>
#include<stdlib.h>
#include<sys/stat.h>

int main(int argc,char *argv[])
{
 struct stat filestat;
 if(argc>2)
  exit(1);
 stat(argv[1],&filestat);
 {
  if(S_ISREG(filestat.st_mode))
   printf("\n\t Regular file.");
  else if(S_ISDIR(filestat.st_mode))
   printf("\n\t Directory file.");
  else if(S_ISBLK(filestat.st_mode))
   printf("\n\t Block file.");
  else if(S_ISCHR(filestat.st_mode))
   printf("\n\t Character special file.");
  else if(S_ISLNK(filestat.st_mode)) 
   printf("\n\t Symbolic link file.");
 }
 getchar();
} 

/*-----------------------Output-----------------------

1>. $./a.out /home

	Directory file.
    $_

2>. $./a.out 3b.c

	Regular file.
    $_

3>. $./a.out /dev/fd0

	Block file.
    $_
*/
