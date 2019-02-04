#!D:\Perl\bin\perl

use DBI();
use CGI;
use CGI qw/:standard/;
use CGI::Cookie;

$cg= new CGI();

$cookie1 = new CGI::Cookie(-name=>'USER',-value=>$uid,-expires=>now);
%cookies = fetch CGI::Cookie;
print header(-cookie=>$cookie1);


print <<'EOF';
<h1><font color=235689 face=tahoma><b><P>You Have Successfully loggedout of Hot-Soft Jobs.com .</font></b></P>
<font color=blue size=4><i>Please close the Browser,which you have opened for security reasons.</i></font>
<font color=125489 size=5><i><p><P>Click here for <a href=http://localhost/hot-soft/Home.html><font color=green face="Monotype Coravisa"><b> Hot-Soft Jobs.com</a></i></b><br><br>
<P><font color=125489 size=5>Click here to <a href=javascript:window.close()>Close Window</a></font>
EOF

print $cg->end_html;
$sth->finish();
$dbh->disconnect();

exit(0);