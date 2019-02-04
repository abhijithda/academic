#	Name : ABHIJITH D.A.	Reg.No : 1PI01IS001

# 2a>.	Write a shell script that accepts two filenames as arguments, check 
#	if the permissions are identical and if the files are identical,
#	output common permissions and otherwise outputs each filename 
#	followed by its permissions.

if [ $# -ne 2 ]
then 
 echo "Wrong arguments"
 exit
fi
str1=`ls -l $1 | cut -c 2-10`
str2=`ls -l $2 | cut -c 2-10`
if [ $str1 = $str2 ]
then
 echo "Permissions are identical."
 echo $1 $str1
 echo $2 $str2
else
 echo "Permissions are not identical."
 echo $1 $str1
 echo $2 $str2
fi

