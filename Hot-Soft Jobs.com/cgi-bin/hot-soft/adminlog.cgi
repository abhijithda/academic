#!D:/perl/bin/perl
	
use CGI;
use DBI;
use CGI qw/:standard/;
use CGI::Cookie;

$cg = new CGI();

$uname = $cg->param('adminname');
$pass = $cg->param('adminpass');

print $cg->header();
print $cg->start_html;

$db = DBI->connect("DBI:mysql:database=hotsoft","root","");
$st = $db->prepare("SELECT * FROM ADMIN WHERE NAME='$uname'");
$st->execute();

if($st->rows() <= 0)
{
	print "Invalid Administrator.\n";
	print "Please try Again.";
}
else
{
	$hr = $st->fetchrow_hashref();
	if ($hr->{'pass'} eq $pass)
	{
		$cookie_admin = new CGI::Cookie(-name=>'USER',-value=>$uid,-path=>'/cgi-bin');
		%cookies = fetch CGI::Cookie;
#		print header(-cookie=>$cookie_admin);
#		$uname = $cookies{'USER'}=>value;
#		print $uname;

#		print "<h1><font color=blue>Welcome Administrator: <font color=green>$uname.</font></h1>";
		$path_html = "../../htdocs/hot-soft/AdminHome.html";
		open(FILE,"< $path_html");#or die("Cannot open file AdminHome.html");
		while(<FILE>)
		{
			print $_;
		}
	}
	else
	{
		print "Invalid password.";
	}
}

print $cg->end_html;

$st->finish();
$db->disconnect();

exit(0);
