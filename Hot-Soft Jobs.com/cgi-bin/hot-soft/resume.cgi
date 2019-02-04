#!D:\Perl\bin\perl

use CGI;
use DBI;
use CGI qw/:standard/;
use CGI::Cookie;


$cg = new CGI();

%cookies = fetch CGI::Cookie;
print header(-cookie=>$cookie1);
$uname = cookies->{'USER'}=>value;

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

($uname,$path)= split (/;/,$uname);
($u,$uname)= split (/=/,$uname);

if($uname eq "")
{
	print "<h2><font color=magenta>Invalid state, Please Relogin</h2></font>";
	print "<br><hr><p><font color=345678>Return to <a href=http://localhost/hot-soft/Login.html> Login </a>";
	exit(0);
}

$db = DBI->connect("DBI:mysql:database=hotsoft","root","");
$sth = $db->prepare("select * from resume where uname='$uname'");
$sth->execute();

$h = $sth->fetchrow_hashref();

print "Hello : <font color=green>$uname </font><br>";

if ($sth->rows())
{
	print "<FORM ACTION=http://localhost/cgi-bin/hot-soft/delresume.cgi?uname=$uname METHOD=POST>";
	print<<'EOF';
	<font size=5 color=red family=verdana><p><h2><hr><center> Your resume already exits </h2></font></center>
	<p><hr><br>Delete old Resume: 
	<INPUT TYPE = SUBMIT value="Yes ?" name=delete></hr>
EOF
}
else
{
	$des = $cg->param('des');
	$des =~ s/"'"/"\'"/g ;
	$title = $cg->param('title');
	$title =~ s/"'"/"\'"/g ;
	
	$des =~ s/\n/<br>/g ;

	$que_str = "INSERT INTO RESUME(UNAME,TITLE,RDESC) VALUES ('$uname','$title','$des')";
	$db->do($que_str);
	print "<p><br><hr><center><u><font color=blue>Resume Title: <font color=green>$title </u><br><br><P> Your Resume has been successfully Uploaded<P></center><p><br><hr>";
	print "Return to <a href=http://localhost/hot-soft/myhome.html> My Home </a>";
}

print <<'XYZ';
<P align="center">
<img border="0" src="http://localhost/hot-soft/AdminHome_files/festive_www.gif" width="720" height="66" align="left"></P>
XYZ


print $cg->end_html;

$sth->finish();
$db->disconnect();

exit(0);
