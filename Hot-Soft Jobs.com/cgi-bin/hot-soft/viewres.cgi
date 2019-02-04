#!D:/Perl/bin/perl

use DBI;
use CGI;

$cgi = new CGI();

print $cgi->header();
print $cgi->start_html;

$db = DBI->connect("DBI:mysql:database=hotsoft","root","");
$db1 = DBI->connect("DBI:mysql:database=hotsoft","root","");
$sth = $db->prepare("SELECT * FROM RESUME");
$sth->execute();

print 	"<center><font size=6 color=blue>Resumes in the database.</center></font>";
$h = $sth->fetchrow_hashref();

if($h)
{
	print "<br><hr><br>";
	while($h)
	{
		if($h->{'uname'})
		{
			$uname = $h->{'uname'};
			$st = $db1->prepare("SELECT * FROM ACCOUNT WHERE UNAME='$uname'");
			$st->execute();
			$acc = $st->fetchrow_hashref();

			print "<p><font color=blue>First Name: <font color=green>$acc->{'fname'} &nbsp&nbsp&nbsp&nbsp <font color=blue>Last Name: <font color=green>$acc->{'lname'} &nbsp&nbsp&nbsp&nbsp <font color=blue>Email-ID: <font color=green>$acc->{'email'} <br>";
			print "<P><font color=blue>Title: <font color=green>$h->{'title'} <p> <font color=blue>Description: <font color=green>$h->{'rdesc'}</P><hr>";
		}
		$h = $sth->fetchrow_hashref();
}
}
else
{
	print "<font size=4 color=125478><b>No Resumes are uploaded to database.</b></font><br>";
}

$sth->finish();
$st->finish();
$db->disconnect();
$db1->disconnect();

print <<'EOF';
<font size=3 color=051454 face=verdana>Click here to return to <a href=http://localhost/hot-soft/EmployersHome.html><font color=green size=4>Employers Home Page</a>
EOF

print $cgi->end_html;

exit(0);
