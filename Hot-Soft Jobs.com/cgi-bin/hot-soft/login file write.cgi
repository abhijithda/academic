#!D:\Perl\bin\perl

use DBI();
use CGI;
$cg= new CGI();


print $cg->header();
print $cg->start_html;

$uname = $cg->param('USER');
$pass = $cg->param('PASS');

$dbh=DBI->connect("DBI:mysql:database=hotsoft;host=localhost","root","");
$sth=$dbh->prepare("SELECT * FROM login WHERE NAME='$uname' and PASS='$pass'");
$sth->execute();
if($href=$sth->fetchrow_hashref())
{
	$log_file = "log_mem.txt";
	if(open(LOGMEM,">> $log_file"))
	{
		print LOGMEM "$uname\n";
		close(LOGMEM);
	}
	else
	{
		print "sorry cannot access";
		exit(0);
	}
	$path_html = "../../htdocs/hot-soft/myhome.html";
	open(FILE,"< $path_html");
	print "Hi : $uname";
	while(<FILE>)
	{
		print $_;
	}
	close(FILE);
}
else
{
	print "Invalid User-id/Password.";
}

print $cg->end_html;
$sth->finish();
$dbh->disconnect();

exit(0);