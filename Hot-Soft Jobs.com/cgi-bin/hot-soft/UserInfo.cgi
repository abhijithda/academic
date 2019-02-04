#!/usr/bin/perl

use DBI;
use CGI;

$cgi = new CGI();

print $cgi->header();
print $cgi->start_html;

$uname = $cgi->param('uname');

if($uname eq "")
{
	print "<h2><font color=magenta>Invalid state, Please Relogin</h2></font>";
	print "<br><hr><p><font color=345678>Return to <a href=http://localhost/hot-soft/Login.html> Login </a>";
	exit(0);
}


$db = DBI->connect("DBI:mysql:database=hotsoft","root","");
$sth = $db->prepare("SELECT * FROM LOGIN");
$sth->execute();
if($sth->rows()>0){
	print 	"<align=right><font size=6>User in the database.</font>";
	$h = $sth->fetchrow_hashref();
	while($h)
	{
		print "<p><p><center>User Name:		$h->{'name'}<br>";
		$h = $sth->fetchrow_hashref();
	}
}

$sth->finish();
$db->disconnect();
print $cgi->end_html;

exit(0);
