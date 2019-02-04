#!D:/perl/bin/perl

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

$pass = $cgi->param('pass');

$db = DBI->connect("DBI:mysql:database=hotsoft","root","");
$db->do("UPDATE LOGIN SET PASS='$pass' WHERE NAME='$uname'");

	print "<br>Hello <font color=green>$uname</font><br><p><p><hr>";
print <<'EOF';
<p><br><font color=blue face=verdana><center>Your Password has been changed successfully.</font></center><br><hr>
<p><br>Click here for <a href=http://localhost/hot-soft/myhome.html>MyHome</a>
EOF

exit(0);
