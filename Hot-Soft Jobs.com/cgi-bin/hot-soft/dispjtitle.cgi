#!d:\Perl\bin\perl
	
use CGI;
use DBI;

$cgi+$id = new CGI();

print $cgi+$id->header();
print $cgi+$id->start_html;

$uname = $cgi+$id->param('uname');
$id = $cgi+$id->param('id');

my $db = DBI->connect("DBI:mysql:database=hotsoft","root","");

$query_str = "select id,jtitle from jdesc ";
if($id ne "")
{
	$query_str = "select * from jdesc where id=$id";
}
my $sth = $db->prepare($query_str);
$sth->execute();
my $hr;

if($id eq "")
{
	while($hr = $sth->fetchrow_hashref())
	{
		$id = $hr->{'id'};
		print "<p><br><font size=4 color=blue face=verdana> :	$id";
#		print "<a href=http://localhost/hot-soft/dispjdesc.html?uname=$uname&id=$id><b> $href->{'jtitle'} </b></a>	<hr><p>";
		print "<a href=http://localhost/hot-soft/dispjtitle.cgi?uname=$uname&id=$id><b> $hr->{'jtitle'} </b></a>	<hr><p>";
	}
}
else
{
	$hr = $sth->fetchrow_hashref();
	if($hr)
	{
#		$id = $hr->{'id'};
		print "<p><br><font size=4 color=blue face=verdana> :	$id<p>";
		print "<br>Title:<b> $hr->{'jtitle'} </b><br><br><br><hr><p>";
		print "<p>Description: <br><br><br><i> $hr->{'jdesc'}";
		print "Click here to return to <a href=http://localhost/hot-soft/dispjtitle.html?uname=$uname>Titles Page</a>";
	}
}
	
$sth->finish();
$db->disconnect();

print $cgi+$id->end_html;

exit(0);
