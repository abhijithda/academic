#!D:\Perl\bin\perl

print "Content-type: text/html","\n\n";

$req_method = $ENV{'REQUEST_METHOD'};

if($req_method eq "GET")
{
	$que_str = $ENV{'QUERY_STRING'};
}
elsif($req_method eq "POST")
{
	read(STDIN,$que_str,$ENV{'CONTENT_LENGTH'});
}
else
{
	print "Error : \n";
	exit(1);
}

@key_value_pairs = split(/&/,$que_str);

foreach $key_value (@key_value_pairs)
{
	($key,$value) = split(/=/,$key_value);
	$value =~ tr/+/ /;
	$value =~ s/%([\dA-Fa-f][\dA-Fa-f])/pack ("C",hex ($1))/eg;
	if ($key eq "uname")	{$uname = $value;}
	if ($key eq "fname") 	{$fname = $value;}
	if ($key eq "lname")	{$lname = $value;}
	if  ($key eq "mname") 	{$mname = $value;}
	if  ($key eq "cid") 	{$cid  = $value;}
	if ($key eq "email")	{$email = $value;}
	if ($key eq "passq") 	{$passq = $value;}
	if ($key eq "passa")	{$passa = $value;}
	if ($key eq "elid")	{$elid  = $value;}
	if ($key eq "clid")	{$clid  = $value;}
	if ($key eq "degreeid") {$degreeid = $value;}
	if ($key eq "pass") 	{$pass	= $value;}
}

print "Hello: ";
print $uname;
use DBI();

$dbh = DBI->connect("DBI:mysql:database=hotsoft","root","");
$query_statement = "select * from login where name='$uname'";
$sth = $dbh->prepare($query_statement);
$sth->execute();

if ($ref = $sth->fetchrow_hashref())
{
	if($ref->{name} eq $uname )
	{
		print "<p><br><hr><center><font size = 4 color =blue face=tahoma><br>User name <u>\"$uname\"</u>";
		print <<'EOF';
		already exits.<br>
		<br><p>Try other User Names.</font><br><p></center><hr>
EOF
		exit(0);
	}
}
else
{
	$dbh->do("insert into login(name,pass) values ('$uname','$pass')") or die("Cannot insert to login");
}

$query_str = "insert into account(uname,fname,mname,lname,cid,email,passq,passa,elid,clid,degreeid) values ('$uname','$fname','$mname','$lname','$cid','$email','$passq','$passa','$elid','$clid','$degreeid') ";

$dbh->do($query_str);

$path_html = "../../htdocs/hot-soft/Success.html";
open(FILE,"< $path_html");

while(<FILE>)
{
	print ;
}

exit(0);
