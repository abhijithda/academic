#!D:\Perl\bin\perl

use DBI();
use CGI;
use CGI qw/:standard/;
use CGI::Cookie;

$cg= new CGI();


#print $cg->header();
#print $cg->start_html;


$uname = $cg->param('USER');
$pass = $cg->param('PASS');

$uid=$uname;
$cookie1 = new CGI::Cookie(-name=>'USER',-value=>$uid,-path=>'/cgi-bin');
%cookies = fetch CGI::Cookie;
print header(-cookie=>$cookie1);

$dbh=DBI->connect("DBI:mysql:database=hotsoft;host=localhost","root","");
$sth=$dbh->prepare("SELECT * FROM login WHERE NAME='$uname' and PASS='$pass'");
$sth->execute();
if($href=$sth->fetchrow_hashref())
{
#	$q = new CGI;
#	$username = $q->param('username'); 
#	$password = $q->param('password'); 
	
	$uid = $cookies{'USER'}=>value;
	($uid,$u) = split(/;/,$uid);
	($u,$uid) = split(/=/,$uid);
	print "<font color=blue><b>Welcome: <font color=green>$uid</b></font>";


#	$log_file = "log_mem.txt";
#	if(open(LOGMEM,">> $log_file"))
#	{
#		print LOGMEM "$uname\n";
#		close(LOGMEM);
#	}
#	else
#	{
#		print "sorry cannot access";
#		exit(0);
#	}

	$path_html = "../../htdocs/hot-soft/myhome.html";
	open(FILE,"< $path_html");
	while(<FILE>)
	{
		print $_;
	}
	close(FILE);
}
else
{
	print "<font color=236590><br><h1><center>Invalid User-ID/Password.</h1></center><p><br><br><br><a href=http://localhost/hot-soft/login.html> Click here to login agian</a>";
}

print $cg->end_html;
$sth->finish();
$dbh->disconnect();

exit(0);