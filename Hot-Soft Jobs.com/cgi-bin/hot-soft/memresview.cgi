#!D:/perl/bin/perl

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


$tname = $cgi->param('tname');

$db = DBI->connect("DBI:mysql:database=hotsoft","root","");

	$sth = $db->prepare("SELECT * FROM JDESC WHERE ID='$tname'");
	$sth->execute();
	if($h = $sth->fetchrow_hashref())
	{
		print "<h2><font size=6 color=875421>Jobs in the database.</font><br><p><p></h2><br><br><hr><br>";
		print "<font color=blue><center>Job Title : <font color=green>	$h->{'jtitle'}<br>";
		print "<font color=blue>Job Category :	<font color=green>	 		$h->{'jcat'}<br>";
		print "<font color=blue><br>Job Description <br> <P><font color=green>		 	$h->{'jdesc'}</P><br>";
		print "<font color=blue>City :	<font color=green>			 		$h->{'city'}<br><br>";
		print "<font color=blue>Career Level :	<font color=green>		 		$h->{'jlevel'}<br>";
#		print "<font color=blue>Job Status :<font color=green>					$h->{'jstatus'}<br>";
		print "<font color=blue>Job Type : 	<font color=green>				$h->{'jtype'}<br>";
		print "<font color=blue>Maximum Pay : <font color=green>				$h->{'maxpay'}<br>";
		print "<font color=blue>Minimum Pay : <font color=green>				$h->{'minpay'}<br></align><br><hr></center>";


		print "<h2><font size=6 color=875421>Contact Employer.</font></h2>";
		print "<p><hr><center><br><font color=blue>Name: <font color=green> $h->{'name'}";
		print "<br><font color=blue>Company Name: <font color=green>$h->{'cname'}";
		print "<br><font color=blue><br>Email-ID:<font color=green>  $h->{'email'}";
		print "<br><font color=blue><br>Company Address:<font color=green>  $h->{'caddr'}";		
		print "<br><font color=blue>Country:<font color=green>  $h->{'country'}";
		print "<br><font color=blue>Pin code:<font color=green>  $h->{'pincode'}";		
		print "<br><font color=blue><br>Phone Number:<font color=green>  $h->{'phone'}<br></center><br><hr>";
	}
	else
	{
		print "<center><P>&nbsp</P><h2><font size=6 color=236589>Nothing to display for \"$tname\".</font></h2></center><P>&nbsp</P>";
	}
	
print <<'XYZ';
<P align="center">
<img border="0" src="http://localhost/hot-soft/AdminHome_files/festive_www.gif" width="720" height="66" align="left"></P>
XYZ


$sth->finish();
$db->disconnect();
print $cgi->end_html;

exit(0);
