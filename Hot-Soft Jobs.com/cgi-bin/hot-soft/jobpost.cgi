#!d:\Perl\bin\perl

use DBI;
use CGI;

$cgi = new CGI();

print $cgi->header();
print $cgi->start_html;

print <<'ABH';
<TABLE class=MsoNormalTable 
style="WIDTH: 642; mso-padding-alt: 0in 0in 0in 0in; mso-cellspacing: 0in" 
height=20 cellSpacing=0 cellPadding=0 border=0>
  <TBODY>
  <TR style="mso-yfti-irow: 0; mso-yfti-firstrow: yes; mso-yfti-lastrow: yes">
    <TD 
    style="padding:0in; BACKGROUND: #FFFFFF; " 
    width=79 align="center">
      <P class=MsoNormal style="TEXT-ALIGN: center" align=center><SPAN 
      style="FONT-SIZE: 7.5pt; FONT-FAMILY: Verdana"><B><SPAN 
      style="COLOR: white">
      <font color="#833083">&nbsp;</font></SPAN></B></SPAN></P></TD>
<P align="center">
<img border="0" src="http://localhost/hot-soft/myaccount.gif" width="575" height="134" align="center"></P>
<p>
<font face=verdana><br><P>
ABH


$jcat = $cgi->param('jcat');
$city = $cgi->param('city');
$jtitle = $cgi->param('jtitle');
$jdesc = $cgi->param('jdesc');
$jlevel = $cgi->param('jlevel');
$jtype = $cgi->param('jtype');
$jstatus = $cgi->param('jstatus');
$minpay = $cgi->param('minpay');
$maxpay = $cgi->param('maxpay');

$name = $cgi->param('name');
$cname = $cgi->param('cname');
$email = $cgi->param('email');
$caddr = $cgi->param('caddr');
$country = $cgi->param('country');
$pincode = $cgi->param('pincode');
$phone = $cgi->param('phone');

$desc =~ s/\n/<br>/g ;

my $dbh = DBI->connect("DBI:mysql:database=hotsoft","root","");
$dbh->do("insert into jdesc(jcat,city,jtitle,jdesc,jlevel,jtype,jstatus,minpay,maxpay,name,cname,email,caddr,country,pincode,phone) values ('$jcat','$city','$jtitle','$jdesc','$jlevel','$jtype','$jstatus','$minpay','$maxpay','$name','$cname','$email','$caddr','$country','$pincode','$phone')");


print <<'EOF';
<hr><font face=verdana color=cyan size=5>Your Job has been posted to <b><u>"Hot-Soft Jobs.com" </b></u></font><p>
<br><br>Click here to return to <a href=http://localhost/hot-soft/employersHome.html> Employer's Home page </a>
<br><br>Click here to return to <a href=http://localhost/hot-soft/Home.html> Home page </a>
<font color=blue><br><hr>
EOF

print <<'XYZ';
<P align="center">
<img border="0" src="http://localhost/hot-soft/AdminHome_files/festive_www.gif" width="720" height="66" align="center"></P>
XYZ

$dbh->disconnect();
print $cgi->end_html;

exit(0);



