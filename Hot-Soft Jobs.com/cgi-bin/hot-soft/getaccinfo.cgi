#!D:\perl/bin/perl

use DBI;
use CGI;

$cgi = new CGI();

print $cgi->header();
print $cgi->start_html;

$uname = $cgi->param{'uname'};

if($uname eq "")
{
	print "<h2><font color=magenta>Invalid state, Please Relogin</h2></font>";
	print "<br><hr><p><font color=345678>Return to <a href=http://localhost/hot-soft/Login.html> Login </a>";
	exit(0);
}


my $db = DBI->connect("DBI:mysql:database=hotsoft","root","");
my $sth = db->prepare("SELECT * FROM ACCOUNT WHERE UNAME='$uname');
$sth->execute();
my h = $sth->fetchrow_hashref();
if($h->rows()>0)
{
	print "<align=right><font size=6>My Account</font>	<p><p>	<center>First Name:		$h->{'fname'}<br>Middle Name:	$h->{'mname'}<br>Last Name:		$h->{'lname'}<br>		Country:		$h-{'cid'}<br>Email:			$h->{'email'}<br><p>Total Work Experience:	$h->{'elid'}<br>Careel Level:			$h->{'clid'}<br>Degree/Level Attained:	$h->{'degreeid'}<br>";
}
else
{
	print <<'EOF';
	The Session has expired.<p>
	Please <a href=http://localhost/hot-soft/Login.html>Login</a> agian.
EOF
}

$sth->finish();
$db->disconnect();
print $cgi->end_html;

exit(0);
