#	Name : ABHIJITH D.A.	Reg.no : 1PI01IS001

# Prg3a>. Write a shell function that takes a valid directory name as an 
#	  argument and recursively descends all the sub-directories, finds
# 	  the maximum length of any file in that heirarchy and writes 
#	  this maximum value to standard output.

cd $1
ls -lR > temp1
cut -c 31-43 temp1 > temp2
sort -n temp2 > temp3
tail -1 temp3

#----------------------------Output-----------------------

#  $sh 3a.sh ../unix
#	12138


