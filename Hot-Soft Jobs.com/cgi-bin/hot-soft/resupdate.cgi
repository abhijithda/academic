#!/usr/bin/perl

use CGI;
use DBI;


$cg = new CGI();
print $cg->header();
print $cg->start_html;

$uname = $cg->param('uname');

if($uname eq "")
{
	print "<h2><font color=magenta>Invalid state, Please Relogin</h2></font>";
	print "<br><hr><p><font color=345678>Return to <a href=http://localhost/hot-soft/Login.html> Login </a>";
	exit(0);
}



my $db = DBI->connect("DBI:mysql:database=hotsoft","root","");
my $sth = $db->prepare("select * from resume where uname='$uname'");
$sth->execute();
my $h = $sth->fetchrow_hashref();
if ($sth->rows() > 0)
{
	print<<'EOF';
	<font size=5 color=red family=verdana>***** Your resume already exits *****</font>
	<FORM ACTION=http://localhost/cgi-bin/hot-soft/delresume.cgi?uname=$uname METHOD=POST>
Delete old Resume: <INPUT TYPE = SUBMIT value="Yes ?" name=delete>
EOF
}
else
{
	$des = $cg->param('des');
	$title = $cg->param('title');
	$db->do("insert into resume(uname,title,rdesc) values ('$uname','$title','$des')");
}
print $cg->end_html;

$sth->finish();
$db->disconnect();

exit(0);
