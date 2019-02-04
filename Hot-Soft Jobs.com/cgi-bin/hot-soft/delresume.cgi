#!D:\Perl\bin\perl

use CGI;
use DBI;


$cg = new CGI();
print $cg->header();
print $cg->start_html;

$query_str = $ENV{'QUERY_STRING'};
($name,$uname) = split(/=/,$query_str);

$db = DBI->connect("DBI:mysql:database=hotsoft","root","");
$db->do("delete from resume where uname='$uname'");

print "USER: <font color=green>$uname</font><font color=blue>: <center><hr>Your old Resume has been deleted.</center></font><hr>";
print <<'EOF';
	<p>If you want create a new resume click <a href=http://localhost/hot-soft/resume.html> Here </a>
	<p> Click here<a href=http://localhost/hot-soft/MyHome.html> My Home </a>
EOF

print $cg->end_html;

$db->disconnect();

exit(0);
