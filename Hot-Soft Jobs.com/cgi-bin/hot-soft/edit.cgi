#!D:\Perl\bin\perl

use DBI();
use CGI;

use CGI qw/:standard/;
use CGI::Cookie;

$cgi = new CGI();

%cookies = fetch CGI::Cookie;
print header(-cookie=>$cookie1);

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


$dbh=DBI->connect("DBI:mysql:database=hotsoft;host=localhost","root","");
$sth=$dbh->prepare("SELECT * FROM ACCOUNT WHERE UNAME='$uname'");
$sth->execute();
if($href=$sth->fetchrow_hashref())
{

	$fname 	= 	$href->{'fname'};
	$mname 	= 	$href->{'mname'};
	$lname 	= 	$href->{'lname'};
	$cid 	=	$href->{'cid'};
	$email 	= 	$href->{'email'};
	$passq 	= 	$href->{'passq'};
	$passa 	= 	$href->{'passa'};
	$elid 	= 	$href->{'elid'};
	$clid 	= 	$href->{'clid'};
	$degreeid = $href->{'degreeid'};
	
	$path_html = "../../htdocs/hot-soft/EditAccount.html";
	
	open(FILE,"< $path_html");
	$content=<FILE>;
    while($content)
    {
		$content=~ s/"_fname_"/$fname/g ;
		$content=~ s/"_mname_"/$mname/g;
		$content=~ s/"_lname_"/$lname/g;
		$content=~ s/"_cid_"/$cid/g;
		$content=~ s/"_email_"/$email/g;
		$content=~ s/"_passa_"/$passa/g;
		$content=~ s/"_passq_"/$passq/g;
		$content=~ s/"_elid_"/$elid/g;
		$content=~ s/"_clid_"/$clid/g;
		$content=~ s/"_degreeid_"/$degreeid/g;
		print $content;
		$content=<FILE>;
 	}
	close(FILE);
}		
$sth->finish();
$dbh->disconnect();
exit(0);
