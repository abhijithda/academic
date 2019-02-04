#!D:\Perl\bin\perl

use DBI;
use CGI;

use CGI qw/:standard/;
use CGI::Cookie;

$cgi = new CGI();

%cookies = fetch CGI::Cookie;
print header(-cookie=>$cookie1);

$uname = $cookies{'USER'}=>value;
($uname,$path)= split (/;/,$uname);
($u,$uname)= split (/=/,$uname);

$db1 = DBI->connect("DBI:mysql:database=hotsoft","root","");
$sth = $db1->prepare("SELECT * FROM ACCOUNT WHERE UNAME = '$uname'");
$sth->execute();
$h = $sth->fetchrow_hashref();
if($h)
{
	$path_html = "../../htdocs/hot-soft/EditAccount.html";
	open(FILE,$path_html);
	while(<FILE>)
	{
		print $_;
	}
	print "fname=$h->{'fname'} mname=$h->{'mname'} lname=$h->{'lname'}";
	
	
	fname varchar(30) not null,
	mname varchar(30),
	lname varchar(30) not null,
	cid   varchar(30),
	email varchar(60) not null,
	passq varchar(60),
	passa varchar(20),
	elid  varchar(30),
	clid  varchar(50),
	degreeid varchar(50)

	
}else{
	print <<'EOF';
	The Session has expired.<p>
	Please <a href=http://localhost/hot-soft/Login.html>Login</a> agian.
EOF
}


my $dbh = DBI->connect("DBI:mysql:database=hotsoft","root","");
$query_statement = "select * from login where name='$uname'";
my $sth = $dbh->prepare($query_statement);
$sth->execute();

$dbh->do("delete from account where uname='$uname'");
$dbh->do("update login set pass='$pass' where name='$uname'");

$query_str = "insert into account(uname,fname,mname,lname,cid,email,passq,passa,elid,clid,degreeid) values ('$uname','$fname','$mname','$lname','$cid','$email','$passq','$passa','$elid','$clid','$degreeid') ";

$dbh->do($query_str) or die("Cannot insert to account table");

print "<font size=6 color=blue family=tahoma><u> The Account has been updated.</font> <h1><b><font size=10 color=green></font></b></h1></u>";

exit(0);



