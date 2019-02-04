#!D:\Perl\bin\perl

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
    <TD 
    style="PADDING-RIGHT: 0in; PADDING-LEFT: 0in; BACKGROUND: #663399; PADDING-BOTTOM: 0in; PADDING-TOP: 0in" 
    width=248 align="center">
      <P class=MsoNormal style="TEXT-ALIGN: center" align=center>
      <font color="grey"><SPAN 
      style="FONT-SIZE: 7.5pt; FONT-FAMILY: Verdana"><B><SPAN
      style="COLOR: CYAN">
      <A 
      style="TEXT-DECORATION: underline; text-underline: single" 
      href="http://localhost/hot-soft/Myhome.html"><font color="White">My Home</B></SPAN></font></P></TD>
    <TD 
    style="padding:0in; BACKGROUND: #000000; " 
    width=303 align="center">
      <P class=MsoNormal style="TEXT-ALIGN: center" align=center><SPAN 
      style="FONT-SIZE: 7.5pt; FONT-FAMILY: Verdana"><B><SPAN 
      style="COLOR: white">
      <A 
      style="TEXT-DECORATION: underline; text-underline: single" 
      href="javascript:window.close()"><font color="#C0C0C0">Sign Out</font></A></SPAN></B></SPAN></P></TD></TR></TBODY></TABLE>
<P align="center">
<!-- 
<img border="0" src="http://localhost/hot-soft/myaccount.gif" width="600" height="15"><SPAN 
style="FONT-SIZE: 12pt; FONT-FAMILY: Times New Roman">&nbsp;&nbsp;&nbsp;&nbsp; </SPAN>
-->
<img border="0" src="http://localhost/hot-soft/myaccount.gif" width="575" height="134"></P>
<p>
<font face=verdana><br><P>
ABH


if($uname eq "")
{
	print "<h2><font color=magenta>Invalid state, Please Relogin</h2></font>";
	print "<br><hr><p><font color=345678>Return to <a href=http://localhost/hot-soft/Login.html> Login </a>";
	exit(0);
}


$opass = $cgi->param('opass');

$db = DBI->connect("DBI:mysql:database=hotsoft","root","");
$sth = $db->prepare("SELECT * FROM LOGIN WHERE NAME='$uname' and PASS='$opass'");
$sth->execute();
$h = $sth->fetchrow_hashref();

$pass = $h->{'pass'};

if( $pass eq $opass )
{
	$fname = $cgi->param('fname');
	$mname = $cgi->param('mname');
	$lname = $cgi->param('lname');
	$cid = $cgi->param('cid');
	$email = $cgi->param('email');
	$passq = $cgi->param('passq');
	$passa = $cgi->param('passa');
	$elid = $cgi->param('elid');
	$clid = $cgi->param('clid');
	$degreeid = $cgi->param('degreeid');
	
	$db->do("DELETE FROM ACCOUNT WHERE UNAME='$uname'");

	$db1 = DBI->connect("DBI:mysql:database=hotsoft","root","");

	$query_str = "insert into account(uname,fname,mname,lname,cid,email,passq,passa,elid,clid,degreeid) values ('$uname','$fname','$mname','$lname','$cid','$email','$passq','$passa','$elid','$clid','$degreeid') ";

	$db1->do($query_str);

	print "<h2><center><font color=124578><b>Account Updated.</b></font></center></h2>	<font color=blue><P><hr><br>Hello <font color=green>$uname<font color=blue>, your account has been successfully updated.</font></P><hr><br>Click here to <a href=http://localhost/hot-soft/MyHome.html>Continue</a>";
}
else
{
	print <<'EOM';
	<h2><font color=124578>Password does not match.</font></h2>
	<p><br><br>Click here to 
	<input type = button value="Re Enter Password" onclick=window.history.back()>
EOM
}

print <<'XYZ';
<P align="center">
<img border="0" src="http://localhost/hot-soft/AdminHome_files/festive_www.gif" width="720" height="66" align="left"></P>
XYZ

$sth->finish();
$db->disconnect();
$cgi->end_html;
exit(0);



