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
      <SPAN 
      style="FONT-SIZE: 7.5pt; FONT-FAMILY: Verdana"><B><SPAN
      style="COLOR: CYAN">
      <A 
      style="TEXT-DECORATION: underline; text-underline: single" 
      href="http://localhost/hot-soft/Adminhome.html"><font color=white>My Home</B></SPAN></font></P></TD>
    <TD 
    style="padding:0in; BACKGROUND: #000000; " 
    width=303 align="center">
      <P class=MsoNormal style="TEXT-ALIGN: center" align=center><SPAN 
      style="FONT-SIZE: 7.5pt; FONT-FAMILY: Verdana"><B><SPAN 
      style="COLOR: white">
      <A 
      style="TEXT-DECORATION: underline; text-underline: single" 
      href="http://localhost/hot-soft/home.html"><font color="#C0C0C0">Sign Out</font></A></SPAN></B></SPAN></P></TD></TR></TBODY></TABLE>
<P align="center">
<SPAN 
style="FONT-SIZE: 12pt; FONT-FAMILY: Times New Roman">&nbsp;&nbsp;&nbsp;&nbsp; </SPAN>
<img border="0" src="http://localhost/hot-soft/search.gif" width="575" height="134"></P>
<p>
<font face=verdana><br><P>
ABH

$choice = $cgi->param('choice');
$db = DBI->connect("DBI:mysql:database=hotsoft","root","");
$sth = $db->prepare("SELECT * FROM JDESC");

if ($choice == 1)
{
	$sth = $db->prepare("SELECT * FROM LOGIN");
	$sth->execute();
	if($sth->rows()>0){
		print 	"<center><font size=6 color=magenta>User in the database.</center></font>";
		$h = $sth->fetchrow_hashref();
		while($h)
		{
			print "<hr><p><p><font color=blue>User Name:	<font color=green>	$h->{'name'}<br>";
			$h = $sth->fetchrow_hashref();
		}
	}
}
elsif($choice == 2)
{
	$sth->execute();
	if($sth->rows()>0){
		print 	"<center><font size=6 color=125489>Employers in the database.</font></center><br><p><hr>";
		$h = $sth->fetchrow_hashref();
		while($h)
		{
			print "<p><p><font color=blue>Job ID : <font color=green>$h->{'id'}&nbsp&nbsp&nbsp&nbsp&nbsp ";
			print "<font color=blue>User Name:<font color=green>$h->{'name'}&nbsp&nbsp&nbsp&nbsp&nbsp &nbsp&nbsp&nbsp&nbsp&nbsp &nbsp&nbsp&nbsp&nbsp&nbsp <font color=blue>E-mail :<font color=green>$h->{'email'}<br>";
			$h = $sth->fetchrow_hashref();
		}
	}
}
elsif($choice == 3)
{
	$sth->execute();
	if($sth->rows()>0){
		print 	"<center><font size=6 color=125489>Jobs in the database.</center></font><hr>";
		$h = $sth->fetchrow_hashref();
		while($h)
		{
			print "<p><p><font color=blue>Job ID : &nbsp&nbsp&nbsp&nbsp&nbsp &nbsp&nbsp&nbsp <font color=green>$h->{'id'}<br><font color=blue>Job Title :	&nbsp&nbsp&nbsp&nbsp&nbsp<font color=green>	$h->{'jtitle'}<br>";
			print "<font color=blue>Company :	&nbsp&nbsp&nbsp&nbsp<font color=green>	$h->{'cname'}<br><hr>";
			$h = $sth->fetchrow_hashref();
		}
	}
}

print <<'EOE';
<script language="javascript">
<!--
	function validate()
	{
		if(document.choice.tname.value=="")
		{
			alert("Enter Name (ID for jobs only) ");
			return false;
		}
	}
-->
</script>
EOE

print "<form name=choice onsubmit=\"return validate()\" action=http://localhost/cgi-bin/hot-soft/admingetinfo.cgi?choice=$choice method=post>";
print <<'EOF';
<br><br><hr><br><font color=124578>Enter the Name(User)/ID(if present) you want to see details : <input type=textbox name=tname>
<input type=submit value=Go!!!>
</form><hr>
<p>Click here for <a href=http://localhost/hot-soft/adminhome.html> Admin Home </a>
<P align="center">
<img border="0" src="http://localhost/hot-soft/AdminHome_files/festive_www.gif" width="720" height="66" align="left"></P>

EOF
	
$sth->finish();
$db->disconnect();
print $cgi->end_html;

exit(0);
