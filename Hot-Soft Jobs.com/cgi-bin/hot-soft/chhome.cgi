#!D:/perl/bin/perl

use DBI;
use CGI;
use CGI qw/:standard/;
use CGI::Cookie;

$cgi = new CGI();

%cookies = fetch CGI::Cookie;
print header(-cookie=>$cookie1);

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


$query_str = $ENV->{'QUERY_STRING'};
$choice = $cgi->param('choice');
#$uname = $cgi->param('uname');

$uname = $cookies{'USER'}=>value;
#print $uname;

($uname,$path)= split (/;/,$uname);
($u,$uname)= split (/=/,$uname);


if($uname eq "")
{
	print "<h2><font color=magenta>Invalid state, Please Relogin</h2></font>";
	print "<br><hr><p><font color=345678>Return to <a href=http://localhost/hot-soft/Login.html> Login </a>";
	exit(0);
}


$db = DBI->connect("DBI:mysql:database=hotsoft","root","");
$sth = $db->prepare("SELECT * FROM ACCOUNT WHERE UNAME='$uname'");

if ($choice == 1)
{
	$sth->execute();
	$h = $sth->fetchrow_hashref();
	if($h)
	{
#			print "<hr><p><p>First Name:		$h->{'fname'}<br>";
#			print "Middle Name:		$h->{'mname'}<br>";
#			print "Last Name:		$h->{'lname'}<br>";
#			print "<hr><p><p>User Name:		$h->{'uname'}<br>";
#			print "<hr><p><p>User Name:		$h->{'uname'}<br>";
		print "<center><font size=6 color=345612>My Account</font></center>	<p><p>";
		print "<br>Hello <font color=green>$uname</font> your account details is as follows:<br><p><p><hr>";
		print "<center><font  color=blue>First Name:	<font  color=green>	$h->{'fname'}";
		if($h->{'mname'})
		{
			print "<br><font color=blue>Middle Name:	<font  color=green>$h->{'mname'}";
		}
		print "<br><font  color=blue>Last Name:	<font  color=green>	$h->{'lname'} <br><br><font  color=blue>Country:	<font color=green>	$h->{'cid'}<br><font  color=blue> Email:	<font  color=green>		$h->{'email'}<br><p><font  color=blue>Total Work Experience:	<font  color=green> $h->{'elid'}<br><font  color=blue>Careel Level:	<font  color=green>	$h->{'clid'}<br><font  color=blue>Degree/Level Attained:</font>	<font  color=green> $h->{'degreeid'}</center><br><hr></font>";
	}
	else
	{
		print "$uname : Nothing is there in database.<br> You need to Update your account.<br> Click here to <a href=http://localhost/hot-soft/EditAccount.html> Edit Account</a>";
	}
}
elsif($choice == 2)
{
	$sth = $db->prepare("SELECT * FROM RESUME WHERE UNAME='$uname'");	
	$sth->execute();
		print 	"<center><font size=6 color=345612>Resume Details.</font></center>";
		print "<br>Hello <font color=green>$uname</font> your resume details is as follows:<br><p><p>";
		$h = $sth->fetchrow_hashref();
		if($h)
		{
#			print "<hr><p><p>User Name:		$h->{'uname'}<br>";
			print "<hr><p><p><font color=blue><center>Title	:<u><font color=green>  $h->{'title'}</u><br>";
			print "<p><br><u><font color=blue>Description: </u> <P><font color=green> $h->{'rdesc'}<br></P></center><hr>";			
		}
		else
		{
			print "$uname : Nothing is there in database.<br> You need to Update your Resume.<br>";
		}		
}
elsif($choice == 3)
{
	print <<'EOM';
	<script language="javascript">
	<!--
	function validate()
	{
		if( (document.login.pass.value == "") || (document.login.pass.value==""))
		{
			alert("Enter password");
			return false;
		}
		if(document.login.pass.value != document.login.conf.value)
		{
			alert("Password's doesnot match");
			return false;
		}
	}
	-->
	</script>
EOM
		
	print "<form name=login onsubmit=\"return validate()\" action= http://localhost/cgi-bin/hot-soft/passchange.cgi method=post>";
	print<<'EOF';
	<font size=6 color=cyan><center>Change Password.</center></font>
	<center><p><br><hr><br>Enter New Password: <input type=password name=pass><br>
	<br><br>Confirm Password  : <input type=password name=conf><br>
	<br><br><input type=submit value="Change Password ? " ></center><br><hr>
	</form>
EOF
}
else
{
	print "<br><h2> <center> Select Choice</h2><br></center>";
}

print "<br><p>Click here for <a href=http://localhost/hot-soft/myhome.html> My Home </a>";

print <<'XYZ';
<P align="center">
<img border="0" src="http://localhost/hot-soft/AdminHome_files/festive_www.gif" width="720" height="66" align="center"></P>
XYZ

$sth->finish();
$db->disconnect();
print $cgi->end_html;

exit(0);
