#!D:\Perl\bin\perl

use DBI;
use CGI;

$cgi = new CGI();

print $cgi->header();
print $cgi->start_html;

print <<'ABH';
<CENTER>
      <TABLE height=20 cellSpacing=0 cellPadding=0 width=600 border=0>
        <TR>
          <TD align=middle bgColor=#000000>
          <FONT 
            face="Verdana" color=#ffffff 
            size=1><B><A href="http://localhost/hot-soft/Home.html">
          <font color="#808080">Hot-Soft 
            Jobs Home Page</font></A></B></FONT></TD></TR></TABLE>
<P>
<img border="0" src="http://localhost/hot-soft/pass.GIF" width="534" height="132"></P>
</CENTER>
<P> &nbsp </P>
ABH
	
$uname = $cgi->param('uname');
$passa = $cgi->param('passa');
$passq = $cgi->param('passq');

$db = DBI->connect("DBI:mysql:database=hotsoft","root","");
$sth = $db->prepare("SELECT * FROM ACCOUNT WHERE UNAME='$uname' and PASSA='$passa' and PASSQ='$passq'");
$sth->execute();
$hr = $sth->fetchrow_hashref();

if($hr)
{
	$db1 = DBI->connect("DBI:mysql:database=hotsoft","root","");
    $sth1 = $db1->prepare("SELECT * FROM LOGIN WHERE NAME='$uname'");
	$sth1->execute();
	$h = $sth1->fetchrow_hashref();
	$pass = $h->{'pass'};
	$sth1->finish();
	$db1->disconnect();

	print "<h2><center><font color=124578><b>Your Password is $pass. </b></font></center> </h2><p><br><font face=forte>Click here to </font> <a href=http://localhost/hot-soft/Login.html>Continue</a>";
}
else
{
	print "<h2><center><font color=124578><b>There is no match for these entries to get Password.</b></font></center> </h2><p><br>Click here to <a href=http://localhost/hot-soft/Login.html>Continue</a>";
}

$sth->finish();
$db->disconnect();
print $cgi->end_html;
exit(0);

