#!/usr/bin/perl

use DBI;
use CGI;

$cgi = new CGI();

print $cgi->header();
print $cgi->start_html;

$uname = $cgi->param{'uname'};

my $db1 = DBI->connect("DBI:mysql:database=hotsoft","root","");
my $sth = $db1->prepare("SELECT * FROM ACCOUNT WHERE UNAME = '$uname'");
$sth->execute();
my $h = $sth->fetchrow_hashref();
if($h->rows()>0){
	fname = $h->{'fname'};
	mname = $h->{'mname');
	lname = $h->{'lname'};
	cid   = $h->{'cid'};
	email = $h->{'email'};
	passq = $h->{'passq'};
	passa = $h->{'passq'};
	elid  = $h->{'elid'};
	clid  = $h->{'clid'};
	degreeid = $h->{'degreeid'};
	
	print <<'EOF';

<FORM ACTION=http://localhost/cgi-bin/hot-soft/editaccinfo.cgi?uname=$uname METHOD=POST>
<CENTER>
<TABLE height=20 cellSpacing=0 cellPadding=0 width=600 border=0>
  <TBODY>
  <TR>
    <TD bgColor=#000000 colSpan=3><IMG height=1 
      src="EditAccount_files/pixel.gif" width=600 border=0><BR clear=all></TD></TR>
  <TR>
    <TD width=1 bgColor=#000000><IMG height=20 
      src="EditAccount_files/pixel.gif" width=1 border=0><BR clear=all></TD>
    <TD width=598 bgColor=#000000>
      <TABLE height=20 cellSpacing=0 cellPadding=0 width=600 border=0>
        <TBODY>
        <TR>
          <TD align=middle bgColor=#000000><FONT 
            face="verdana,MS Sans Serif, Geneva, Helvetica" color=#ffffff 
            size=1><B><a href="http://127.0.0.1/hot-soft/Home.html">Home</a></B></FONT></TD>
          <TD align=middle bgColor=#000000><FONT 
            face="verdana,MS Sans Serif, Geneva, Helvetica" color=#ffffff 
            size=1><B>Search Jobs</B></FONT></TD>
          <TD align=middle bgColor=#663399><FONT 
            face="verdana,MS Sans Serif, Geneva, Helvetica" color=white 
            size=1><B>My Home</B></FONT></TD>
          <TD align=middle bgColor=#000000><FONT 
            face="verdana,MS Sans Serif, Geneva, Helvetica" color=#ffffff 
            size=1><B>Career Centre</B></FONT></TD>
          <TD align=middle bgColor=#000000><B><FONT 
            face="verdana,MS Sans Serif, Geneva, Helvetica" color=#ffffff 
            size=1>Help</FONT></B></TD>
          <TD align=middle bgColor=#000000><FONT 
            face="verdana,MS Sans Serif, Geneva, Helvetica" color=#ffffff 
            size=1><B>For Employers</B></FONT></TD></TR></TBODY></TABLE></TD>
    <TD width=1 bgColor=#000000><IMG height=20 
      src="EditAccount_files/pixel.gif" width=1 border=0><BR clear=all></TD></TR>
  <TR>
    <TD bgColor=#000000 colSpan=3><IMG height=1 
      src="EditAccount_files/pixel.gif" width=600 border=0><BR 
  clear=all></TD></TR></TBODY></TABLE>
<CENTER><IMG height=1 src="EditAccount_files/pixel.gif" width=600 
border=0><BR><IMG height=15 alt="My Monster" 
src="EditAccount_files/festive_js_head.gif" width=600><BR></CENTER>
<TABLE cellSpacing=0 cellPadding=0 width=600 border=0>
  <TBODY>
  <TR>
    <TD height=86><IMG height=173 src="EditAccount_files/hotjobsicon.bmp" 
      width=599 border=0></TD></TR></TBODY></TABLE>
<TABLE cellSpacing=0 cellPadding=0 width=600 align=center border=0>
  <TBODY>
  <TR>
    <TD align=middle>&nbsp;</TD></TR></TBODY></TABLE></CENTER>
<CENTER>
<TABLE cellSpacing=0 cellPadding=0 width=597 border=0>
  <TBODY>
  <TR>
    <TD vAlign=top width=460>
      <SCRIPT language=JavaScript src="" type=text/javascript>
<!-- -->
      </SCRIPT>

      <SCRIPT language=JavaScript>

<!-- // begin hide

var cancelClicked = false;





// Called when new country selected from country dropdown
function DisplayAsterisk(doco) {
	with (doco.mons_form1) {
		if (( typeof CountryID != "undefined" ) && ( typeof PostalCode != "undefined" )) {
			// This will show red asterisk on Postal Code field when Country is selected as Canada or Zip Code is required field (except HK, NZ)
			var strCountryID = CountryID.options[CountryID.selectedIndex].value;
			document.getElementById("RedAsterisk").innerHTML = (strCountryID == "30"  ) ? '<font color="#CC0000">*</font>' : '<font color="#CC0000"><br></font>';
		}
	}
}



// Validate that the passwords are the same, and that
// the email address looks OK
function submitHandler(doco)
{
	// var form = doco.mons_form1;
	var retVal = true;

    // If the cancel button was clicked, get out of here
    if (  cancelClicked == true )
    {
		return retVal;
	}





    if( retVal == true )
    {
        retVal = checkString( doco.mons_form1.FirstName, "First Name", false);
    }
    if( retVal == true )
    {
        retVal = checkString( doco.mons_form1.LastName, "Last Name", false);
    }



	//vaclav 18-MAR-2004 DEV00078463
    if( (retVal == true) && (doco.mons_form1.experiencelevelid.selectedIndex == 0) )
	{
		warnEmpty (doco.mons_form1.experiencelevelid, "Total Work Experience");
		retVal = false;
    }


		if( retVal == true )
		{
		    retVal = checkEmail( doco.mons_form1.EMail );
		}
		if( retVal == true )
		{
		    retVal = checkString( doco.mons_form1.UserName, "Create a Username", false);
		}
		if( retVal == true )
		{
		    retVal = checkString( doco.mons_form1.myPassword, "Create a Password", false);
		}
		if( retVal == true )
		{
		    retVal = checkString( doco.mons_form1.PasswordConfirm, "Confirm Password", false);
		}


	
		
			
	if( (retVal == true) && (doco.mons_form1.careerlevelid.selectedIndex == 0) ) {
		warnEmpty (doco.mons_form1.careerlevelid, "Career Level");
		retVal = false;
	}

		
	





	
		
	




	if( (retVal == true) && (doco.mons_form1.levelid.selectedIndex == 0) )
	{
		warnEmpty (doco.mons_form1.levelid, "Degree Level:");
		retVal = false;
    }





if( retVal == true )
    {
		if ( (doco.mons_form1.PasswordHintQuestion.selectedIndex != 0)
			&& (( isEmpty(doco.mons_form1.PasswordHintAnswer.value) == true ) || ( isWhitespace(doco.mons_form1.PasswordHintAnswer.value) == true ) ))
		{
			doco.mons_form1.PasswordHintAnswer.focus();
			alert("You did not enter an Answer for the Password Question.  Please enter an Answer.");
			retVal = false;
		}
	}
    if( retVal == true )
    {
		if (( ( isEmpty(doco.mons_form1.PasswordHintAnswer.value) == false ) || ( isWhitespace(doco.mons_form1.PasswordHintAnswer.value) == false ) )
			&& (doco.mons_form1.PasswordHintQuestion.selectedIndex == 0))
		{
			doco.mons_form1.PasswordHintQuestion.focus();
			alert("You did not select a Password Question.  Please select a Password Question.");
			retVal = false;
		}
	}








	if( retVal == true )
	{
		var password1 = doco.mons_form1.myPassword.value;
		var password2 = doco.mons_form1.PasswordConfirm.value;
		if( password1 != password2 )
		{
			var msg = "";
			msg += "_________________________________\n";
			msg += "Passwords do not match. Please re-enter them.\n";
			msg += "_________________________________\n";
			doco.mons_form1.myPassword.focus();
			doco.mons_form1.myPassword.select();
			alert( msg );
			retVal = false;
		}
    }

	// Check Postal/ZIP code when CountryID and PostalCode fields exists and Country is selected as Canada
	if (( retVal == true ) && ( typeof doco.mons_form1.CountryID != "undefined" ) && ( typeof doco.mons_form1.PostalCode != "undefined" ))
	{
		if (doco.mons_form1.CountryID.options[doco.mons_form1.CountryID.selectedIndex].value == "30")
		{
			var postalcodeCanada = /^([A-Z][0-9]){3}$/;

			doco.mons_form1.PostalCode.value = doco.mons_form1.PostalCode.value.replace(/\s/g, "").toUpperCase();
			if (postalcodeCanada.test(doco.mons_form1.PostalCode.value) == false)
			{
				retVal = warnInvalid(doco.mons_form1.PostalCode, "Postal/ZIP code is a required field if you are from Canada.\nCanadian postal codes have the form LNLNLN where L=letter and N=number.");
			}
		}
	}










//Return the code to make sure the user answers the optin questions
//Begin User Optins Validation Code - Require User to pick yes or no

	
	if ( ( retVal == true ) && ( document.mons_form1.optin_yn_70_210[0].checked == false )
			&& ( document.mons_form1.optin_yn_70_210[1].checked == false ) )
			{
				document.mons_form1.optin_yn_70_210[0].focus();
				alert('Please answer all of the required questions by selecting either yes or no.');
				retVal = false;
			}

	//End User Optins Validation Code



	var strLoggedIn;
	strLoggedIn = "False";




	if ( ( retVal == true )  && ( strLoggedIn.indexOf( "True" ) > -1 ) && (isWhitespace(doco.mons_form1.OldPassword.value)) )
	{
		retVal = false;
		doco.mons_form1.OldPassword.focus();
		alert("Enter your old password to confirm changes");
	}



    return retVal;
}

function IsNumeric (s)
{   var i;
    if (IsEmpty(s))
       if (IsNumeric.arguments.length == 1) return false
       else return (IsNumeric.arguments[1] == true);
    // Search through string's characters one by one
    // until we find a non-numeric character.
    // When we do, return false; if we don't, return true.
    for (i = 0; i < s.length; i++)
    {
        // Check that current character is number.
        var c = s.charAt(i);
        if (!IsDigit(c)) return false;
    }
    // All characters are numbers.
    return true;
}

function IsEmpty(s)
{   return ((s == null) || (s.length == 0))
}

function IsDigit (c)
{   return ((c >= "0") && (c <= "9"))
}

// -->

      </SCRIPT>

      <CENTER><SPAN class=txtNormal><FONT color=#cc0000><B></B></FONT></SPAN>
      <FORM id=mons_form1 name=mons_form1 
      onsubmit="return submitHandler(document);" 
      action=/new.asp?ID=enableRedirect&amp;redirect=%2Findex%2Easp 
      method=post><INPUT type=hidden value=1 name=opt_c70_> <INPUT type=hidden 
      value=114460 name=optin_nmid_70_210> <INPUT type=hidden value=114947 
      name=optin_dmid_70_210> <INPUT type=hidden value=1 
      name=optin_typeid_70_210> <INPUT type=hidden value=-1 
      name=optin_dbval_70_210> 
      <TABLE cellSpacing=0 cellPadding=0 width=600 border=0>
        <TBODY>
        <TR>
          <TD width=600 colSpan=3 height=0>
            <P><BR><!--<center>--><STRONG><SPAN class=txtpgTitle>Edit My 
            Hot-Soft Jobs Account</SPAN></STRONG><BR><BR></P></TD></TR>
        <TR>
          <TD align=left width=600 colSpan=3><FONT color=#cc0000>* <SPAN 
            class=txtSmallNormal>Required fields. </SPAN></FONT></TD></TR></X:MTMT>
        <TR><!--FirstName-->
          <TD vAlign=bottom width=8><FONT color=#cc0000>*</FONT></TD>
          <TD vAlign=bottom width=162>
            <DIV class=txtXsmall align=left>First Name</DIV></TD>
          <TD vAlign=bottom width=430>
          <INPUT id=FirstName maxLength=50 size=30 
            name=fname value=$fname> </TD></TR>
        <TR><!--MiddleName-->
          <TD vAlign=center width=8></TD>
          <TD width=162>
            <DIV class=txtXsmall align=left>Middle Name</DIV></TD><!--<td  valign="center"><font color="#CC0000"><br></font></td>-->
          <TD width=430>
          <INPUT id=MiddleName maxLength=50 size=30 
            name=mname value=$mname> </TD></TR>
        <TR><!--LastName-->
          <TD vAlign=top width=8 height=50><FONT color=#cc0000>*</FONT></TD>
          <TD vAlign=top width=162>
            <DIV class=txtXsmall align=left>Last Name</DIV></TD>
          <TD vAlign=top width=430>
          <INPUT id=LastName maxLength=50 size=30 
            name=lname value=$lname> </TD></TR>
        <TR><!--Country-->
          <TD vAlign=top width=8><FONT color=#cc0000>*</FONT></TD>
          <TD vAlign=top width=162>
            <DIV class=txtXsmall align=left>Country</DIV></TD>
          <TD vAlign=top width=430>
          <SELECT id=CountryID 
            onchange=DisplayAsterisk(document); name=cid > <OPTION 
              value=70 NAME="CountryID">India</OPTION> <OPTION 
              value=1>Afghanistan</OPTION> <OPTION value=2>Albania</OPTION> 
              <OPTION value=3>Algeria</OPTION> <OPTION value=178>American 
              Samoa</OPTION> <OPTION value=4>Andorra</OPTION> <OPTION 
              value=5>Angola</OPTION> <OPTION value=176>Anguilla</OPTION> 
              <OPTION value=177>Antartica</OPTION> <OPTION value=175>Antigua and 
              Barbuda</OPTION> <OPTION value=6>Argentina</OPTION> <OPTION 
              value=7>Armenia</OPTION> <OPTION value=179>Aruba</OPTION> <OPTION 
              value=8>Australia</OPTION> <OPTION value=9>Austria</OPTION> 
              <OPTION value=10>Azerbaidjan</OPTION> <OPTION 
              value=11>Bahamas</OPTION> <OPTION value=12>Bahrain</OPTION> 
              <OPTION value=13>Bangladesh</OPTION> <OPTION 
              value=14>Barbados</OPTION> <OPTION value=15>Belarus</OPTION> 
              <OPTION value=16>Belgium</OPTION> <OPTION value=17>Belize</OPTION> 
              <OPTION value=18>Benin</OPTION> <OPTION value=19>Bermuda</OPTION> 
              <OPTION value=20>Bhutan</OPTION> <OPTION value=21>Bolivia</OPTION> 
              <OPTION value=22>Bosnia-Herzegovina</OPTION> <OPTION 
              value=23>Botswana</OPTION> <OPTION value=181>Bouvet 
              Island</OPTION> <OPTION value=24>Brazil</OPTION> <OPTION 
              value=201>British Indian Ocean Territory</OPTION> <OPTION 
              value=180>Brunei Darussalam</OPTION> <OPTION 
              value=25>Bulgaria</OPTION> <OPTION value=26>Burkina Faso</OPTION> 
              <OPTION value=27>Burundi</OPTION> <OPTION 
              value=28>Cambodia</OPTION> <OPTION value=29>Cameroon</OPTION> 
              <OPTION value=30>Canada</OPTION> <OPTION value=31>Cape 
              Verde</OPTION> <OPTION value=32>Cayman Islands</OPTION> <OPTION 
              value=33>Central African Republic</OPTION> <OPTION 
              value=34>Chad</OPTION> <OPTION value=35>Chile</OPTION> <OPTION 
              value=36>China</OPTION> <OPTION value=185>Christmas 
              Island</OPTION> <OPTION value=182>Cocos (Keeling) Islands</OPTION> 
              <OPTION value=37>Colombia</OPTION> <OPTION 
              value=204>Comoros</OPTION> <OPTION value=38>Congo</OPTION> <OPTION 
              value=183>Cook Islands</OPTION> <OPTION value=39>Costa 
              Rica</OPTION> <OPTION value=40>Croatia</OPTION> <OPTION 
              value=41>Cyprus</OPTION> <OPTION value=42>Czech Republic</OPTION> 
              <OPTION value=43>Denmark</OPTION> <OPTION 
              value=44>Djibouti</OPTION> <OPTION value=186>Dominica</OPTION> 
              <OPTION value=187>Dominican Republic</OPTION> <OPTION 
              value=233>East Timor</OPTION> <OPTION value=45>Ecuador</OPTION> 
              <OPTION value=46>Egypt</OPTION> <OPTION value=47>El 
              Salvador</OPTION> <OPTION value=48>Equatorial Guinea</OPTION> 
              <OPTION value=49>Eritrea</OPTION> <OPTION 
              value=50>Estonia</OPTION> <OPTION value=51>Ethiopia</OPTION> 
              <OPTION value=189>Falkland Islands</OPTION> <OPTION 
              value=191>Faroe Islands</OPTION> <OPTION value=52>Fiji</OPTION> 
              <OPTION value=53>Finland</OPTION> <OPTION value=228>Former 
              USSR</OPTION> <OPTION value=54>France</OPTION> <OPTION 
              value=55>France (European Territory)</OPTION> <OPTION 
              value=193>French Guyana</OPTION> <OPTION value=230>French Southern 
              Territories</OPTION> <OPTION value=56>Gabon</OPTION> <OPTION 
              value=57>Gambia</OPTION> <OPTION value=58>Georgia</OPTION> <OPTION 
              value=59>Germany</OPTION> <OPTION value=60>Ghana</OPTION> <OPTION 
              value=194>Gibraltar</OPTION> <OPTION value=61>Greece</OPTION> 
              <OPTION value=195>Greenland</OPTION> <OPTION 
              value=192>Grenada</OPTION> <OPTION value=196>Guadeloupe 
              (French)</OPTION> <OPTION value=62>Guam</OPTION> <OPTION 
              value=198>Guatemala</OPTION> <OPTION value=63>Guinea</OPTION> 
              <OPTION value=64>Guinea Bissau</OPTION> <OPTION 
              value=65>Guyana</OPTION> <OPTION value=200>Haiti</OPTION> <OPTION 
              value=199>Heard and McDonald Islands</OPTION> <OPTION 
              value=66>Honduras</OPTION> <OPTION value=67>Hong Kong</OPTION> 
              <OPTION value=68>Hungary</OPTION> <OPTION 
              value=69>Iceland</OPTION> <OPTION value=70>India</OPTION> <OPTION 
              value=71>Indonesia</OPTION> <OPTION value=73>Iraq</OPTION> <OPTION 
              value=74>Ireland</OPTION> <OPTION value=75>Israel</OPTION> <OPTION 
              value=76>Italy</OPTION> <OPTION value=77>Ivory Coast</OPTION> 
              <OPTION value=202>Jamaica</OPTION> <OPTION value=78>Japan</OPTION> 
              <OPTION value=79>Jordan</OPTION> <OPTION 
              value=80>Kazakhstan</OPTION> <OPTION value=81>Kenya</OPTION> 
              <OPTION value=203>Kiribati</OPTION> <OPTION 
              value=82>Kuwait</OPTION> <OPTION value=83>Kyrgyzstan</OPTION> 
              <OPTION value=84>Laos</OPTION> <OPTION value=85>Latvia</OPTION> 
              <OPTION value=86>Lebanon</OPTION> <OPTION 
              value=87>Lesotho</OPTION> <OPTION value=88>Liberia</OPTION> 
              <OPTION value=90>Liechtenstein</OPTION> <OPTION 
              value=91>Lithuania</OPTION> <OPTION value=92>Luxembourg</OPTION> 
              <OPTION value=208>Macau</OPTION> <OPTION 
              value=93>Macedonia</OPTION> <OPTION value=94>Madagascar</OPTION> 
              <OPTION value=95>Malawi</OPTION> <OPTION 
              value=96>Malaysia</OPTION> <OPTION value=97>Maldives</OPTION> 
              <OPTION value=98>Mali</OPTION> <OPTION value=99>Malta</OPTION> 
              <OPTION value=207>Marshall Islands</OPTION> <OPTION 
              value=210>Martinique (French)</OPTION> <OPTION 
              value=100>Mauritania</OPTION> <OPTION value=212>Mauritius</OPTION> 
              <OPTION value=241>Mayotte</OPTION> <OPTION 
              value=101>Mexico</OPTION> <OPTION value=190>Micronesia</OPTION> 
              <OPTION value=102>Moldavia</OPTION> <OPTION 
              value=103>Monaco</OPTION> <OPTION value=104>Mongolia</OPTION> 
              <OPTION value=211>Montserrat</OPTION> <OPTION 
              value=105>Morocco</OPTION> <OPTION value=106>Mozambique</OPTION> 
              <OPTION value=107>Namibia</OPTION> <OPTION 
              value=215>Nauru</OPTION> <OPTION value=108>Nepal</OPTION> <OPTION 
              value=109>Netherlands</OPTION> <OPTION value=110>Netherlands 
              Antilles</OPTION> <OPTION value=216>Neutral Zone</OPTION> <OPTION 
              value=213>New Caledonia (French)</OPTION> <OPTION value=111>New 
              Zealand</OPTION> <OPTION value=112>Nicaragua</OPTION> <OPTION 
              value=113>Niger</OPTION> <OPTION value=114>Nigeria</OPTION> 
              <OPTION value=217>Niue</OPTION> <OPTION value=214>Norfolk 
              Island</OPTION> <OPTION value=209>Northern Mariana 
              Islands</OPTION> <OPTION value=116>Norway</OPTION> <OPTION 
              value=117>Oman</OPTION> <OPTION value=118>Pakistan</OPTION> 
              <OPTION value=222>Palau</OPTION> <OPTION value=119>Panama</OPTION> 
              <OPTION value=219>Papua New Guinea</OPTION> <OPTION 
              value=120>Paraguay</OPTION> <OPTION value=121>Peru</OPTION> 
              <OPTION value=122>Philippines</OPTION> <OPTION value=221>Pitcairn 
              Island</OPTION> <OPTION value=123>Poland</OPTION> <OPTION 
              value=218>Polynesia (French)</OPTION> <OPTION 
              value=124>Portugal</OPTION> <OPTION value=126>Qatar</OPTION> 
              <OPTION value=127>Reunion (French)</OPTION> <OPTION 
              value=128>Romania</OPTION> <OPTION value=129>Russian 
              Federation</OPTION> <OPTION value=130>Rwanda</OPTION> <OPTION 
              value=197>S. Georgia &amp; S. Sandwich Islands</OPTION> <OPTION 
              value=224>Saint Helena</OPTION> <OPTION value=205>Saint Kitts 
              &amp; Nevis Anguilla</OPTION> <OPTION value=206>Saint 
              Lucia</OPTION> <OPTION value=220>Saint Pierre and 
              Miquelon</OPTION> <OPTION value=131>Saint Tome and 
              Principe</OPTION> <OPTION value=237>Saint Vincent &amp; 
              Grenadines</OPTION> <OPTION value=132>Samoa</OPTION> <OPTION 
              value=227>San Marino</OPTION> <OPTION value=133>Saudi 
              Arabia</OPTION> <OPTION value=134>Senegal</OPTION> <OPTION 
              value=135>Seychelles</OPTION> <OPTION value=136>Sierra 
              Leone</OPTION> <OPTION value=137>Singapore</OPTION> <OPTION 
              value=138>Slovakia</OPTION> <OPTION value=139>Slovenia</OPTION> 
              <OPTION value=223>Solomon Islands</OPTION> <OPTION 
              value=140>Somalia</OPTION> <OPTION value=141>South Africa</OPTION> 
              <OPTION value=142>South Korea</OPTION> <OPTION 
              value=143>Spain</OPTION> <OPTION value=144>Sri Lanka</OPTION> 
              <OPTION value=146>Suriname</OPTION> <OPTION value=225>Svalbard and 
              Jan Mayen Islands</OPTION> <OPTION value=147>Swaziland</OPTION> 
              <OPTION value=148>Sweden</OPTION> <OPTION 
              value=149>Switzerland</OPTION> <OPTION 
              value=151>Tadjikistan</OPTION> <OPTION value=152>Taiwan</OPTION> 
              <OPTION value=153>Tanzania</OPTION> <OPTION 
              value=154>Thailand</OPTION> <OPTION value=155>Togo</OPTION> 
              <OPTION value=231>Tokelau</OPTION> <OPTION 
              value=232>Tonga</OPTION> <OPTION value=234>Trinidad and 
              Tobago</OPTION> <OPTION value=156>Tunisia</OPTION> <OPTION 
              value=157>Turkey</OPTION> <OPTION value=158>Turkmenistan</OPTION> 
              <OPTION value=229>Turks and Caicos Islands</OPTION> <OPTION 
              value=235>Tuvalu</OPTION> <OPTION value=159>Uganda</OPTION> 
              <OPTION value=160>UK</OPTION> <OPTION value=161>Ukraine</OPTION> 
              <OPTION value=162>United Arab Emirates</OPTION> <OPTION 
              value=163>Uruguay</OPTION> <OPTION value=164>US</OPTION> <OPTION 
              value=236>US Minor Outlying Islands</OPTION> <OPTION 
              value=165>Uzbekistan</OPTION> <OPTION value=239>Vanuatu</OPTION> 
              <OPTION value=166>Vatican City</OPTION> <OPTION 
              value=167>Venezuela</OPTION> <OPTION value=168>Vietnam</OPTION> 
              <OPTION value=169>Virgin Islands (British)</OPTION> <OPTION 
              value=238>Virgin Islands (US)</OPTION> <OPTION value=240>Wallis 
              and Futuna Islands</OPTION> <OPTION value=188>Western 
              Sahara</OPTION> <OPTION value=170>Yemen</OPTION> <OPTION 
              value=171>Yugoslavia</OPTION> <OPTION value=172>Zaire</OPTION> 
              <OPTION value=173>Zambia</OPTION> <OPTION 
              value=174>Zimbabwe</OPTION></SELECT> </TD></TR>
        <TR>
          <TD width=589 colSpan=3>&nbsp; 
            <P>&nbsp;</P></TD></TR>
        <TR><!--Email-->
          <TD vAlign=bottom width=8><FONT color=#cc0000>*</FONT></TD>
          <TD vAlign=bottom width=162>
            <DIV class=txtXsmall align=left>Email Address</DIV></TD>
          <TD vAlign=bottom width=430>
          <INPUT id=EMail maxLength=100 size=60 
            name=email value=$email> </TD></TR>
        <TR>
          <TD width=8></TD>
          <TD width=162></TD>
          <TD class=txtSmallNormal vAlign=bottom width=430></TD></TR><!--email preferences-->
        <TR>
          <TD vAlign=top width=600 colSpan=3 height=40>&nbsp;</TD></TR>
        <TR>
          <TD width=600 colSpan=3 height=15>
            <HR>
          </TD></TR>
        <TR>
          <TD vAlign=center width=8><FONT color=#cc0000>*</FONT></TD>
          <TD width=162>
            <DIV align=left><SPAN class=txtXsmall>Create a Username</SPAN> 
          </DIV></TD>
          <TD width=430>
            <TABLE cellSpacing=0 cellPadding=0>
              <TBODY>
              <TR><!--Password-->
          <TD vAlign=bottom width=8><FONT color=#cc0000>*</FONT></TD>
          <TD vAlign=bottom width=162>
            <DIV class=txtXsmall align=left>Create a Password</DIV></TD>
          <TD vAlign=bottom width=430>
            <TABLE cellSpacing=0 cellPadding=0>
              <TBODY>
              <TR>
                <TD vAlign=bottom>
                <INPUT id=myPassword type=password 
                  maxLength=20 name=pass size="20"> </TD>
                <TD vAlign=bottom width=2>&nbsp;<BR>&nbsp;</TD>
                <TD class=txtSmallNormal vAlign=bottom><FONT 
                  maxlength="20">Use between 1 and 20 characters</FONT> 
              </TD></TR></TBODY></TABLE></TD></TR>
        <TR><!--ConfirmPassword-->
          <TD vAlign=top width=8><FONT color=#cc0000>*</FONT></TD>
          <TD vAlign=top width=162>
            <DIV class=txtXsmall align=left>Confirm Password</DIV></TD>
          <TD vAlign=top width=430>
            <TABLE cellSpacing=0 cellPadding=0>
              <TBODY>
              <TR>
                <TD vAlign=top>
                <INPUT id=PasswordConfirm type=password 
                  maxLength=20 name=cpass size="20"> </TD>
                <TD vAlign=top width=2>&nbsp;<BR>&nbsp;</TD>
                <TD>&nbsp;<BR>&nbsp; </TD></TR></TBODY></TABLE></TD></TR><X:SL02>
        <TR><!--PasswordQuestion-->
          <TD vAlign=center width=8><FONT color=#cc0000><BR></FONT></TD>
          <TD width=162>
            <DIV class=txtXsmall align=left>Password Question</DIV></TD>
          <TD width=419>
          <SELECT id=PasswordHintQuestion 
            name=passq><OPTION value=0 selected>--- Select 
              ---</OPTION><OPTION value=1>What is the name of your favourite 
              pet?</OPTION><OPTION value=2>What is the name of the city/town 
              where you were born?</OPTION><OPTION value=3>What is your mother's 
              maiden name?</OPTION></SELECT> </TD></TR>
        <TR><!--PasswordQuestionAnswer-->
          <TD vAlign=center width=8><FONT color=#cc0000><BR></FONT></TD>
          <TD width=162>
            <DIV class=txtXsmall align=left>Your Answer</DIV></TD>
          <TD width=430>
          <INPUT id=PasswordHintAnswer maxLength=100 
            name=passa value=$passa size="20"> </TD></TR>
        <TR><!--PasswordQuestion Help Text-->
          <TD width=170 colSpan=2>&nbsp; </TD>
          <TD class=txtSmallNormal width=430>To help remember and protect your 
            password, supply a personal ""hint"" by selecting a Password 
            Question and answering it below. </TD></TR>
        <TR>
          <TD width=600 colSpan=3 height=15>
            <HR>
          </TD></TR><!--NickName/ScreenName-->
        <TR><!--PostalCode--><!--- add for spacing issues--->
        <TR>
          <TD width=589 colSpan=3>&nbsp;</TD></TR>
        <TR><!--TotalYearsWorkExperience-->
          <TD vAlign=center width=8><FONT color=#cc0000>* </FONT></TD>
          <TD width=162>
            <DIV class=txtXsmall align=left>Total Work Experience </DIV></TD>
          <TD width=430><FONT face="Verdana, Arial, Geneva, sans-serif" 
            size=-1><SELECT name=elid value=$elid> <OPTION value="" 
              selected>--Select--</OPTION><OPTION value=1>Less than 1 
              Year</OPTION><OPTION value=2>1 to 2 Years</OPTION><OPTION 
              value=3>2 to 5 Years</OPTION><OPTION value=4>5 to 7 
              Years</OPTION><OPTION value=5>7 to 10 Years</OPTION><OPTION 
              value=6>10 to 15 Years</OPTION><OPTION value=7>More than 15 
              Years</OPTION></SELECT> </FONT></TD></TR>
        <TR><!-- CareerLevel-->
          <TD vAlign=center width=8><FONT color=#cc0000>*</FONT> </TD>
          <TD width=162>
            <DIV class=txtXsmall align=left>Career Level </DIV></TD>
          <TD width=430><SELECT id=careerlevelid name=clid><OPTION 
              value="" selected>--- Select ---</OPTION> <OPTION value=16>Student 
              (High School)</OPTION><OPTION value=10>Student</OPTION><OPTION 
              value=11>Entry Level (less than 2 years of 
              experience)</OPTION><OPTION value=12>Mid Career (2+ years of 
              experience)</OPTION><OPTION value=13>Manager</OPTION><OPTION 
              value=14>Senior Management (VP and equivalent)</OPTION><OPTION 
              value=15>Top Management (CEO and equivalent)</OPTION></SELECT> 
</TD></TR>
        <TR>
          <TD vAlign=center width=8><FONT color=#cc0000>*</FONT></TD>
          <TD width=162>
            <DIV class=txtXsmall align=left>Degree/Level Attained</DIV></TD>
          <TD class=txtXsmall width=430>
          <SELECT id=educationlevelid 
            name=degreeid><OPTION value="" selected>--- Select ---</OPTION> 
              <OPTION value=1>High School or Equivalent (12th, Intermediate, Jr 
              College)</OPTION><OPTION value=2>Certification 
              (Diploma)</OPTION><OPTION value=3>Vocational 
              (Diploma)</OPTION><OPTION value=9>Some Tertiary Coursework 
              Completed</OPTION><OPTION value=4>Associates 
              Degree</OPTION><OPTION value=5>Bachelor's Degree-Graduate Degree 
              (BA, BSc, BCom)</OPTION><OPTION value=6>Master's Degree-Post 
              Graduate (MA, MSc, MComm, LLB)</OPTION><OPTION 
              value=7>Doctorate</OPTION><OPTION 
              value=8>Professional-Engineering(BE or BTech)</OPTION></SELECT> 
        </TD></TR><!-- SIZZLE: Moved EmailPreference from here --><!--Message currently only used in MONS -->
        <TR>
          <TD align=middle width=600 colSpan=3>
            <TABLE cellSpacing=0 cellPadding=0 align=center>
              <TBODY>
              <TR>
                <TD vAlign=center align=right></TD></TR></TBODY></TABLE></TD>
        <TR>
          <TD width=600 colSpan=3>&nbsp;<X:SL02> 
            <P><X:SL02><A name=toldpass><SPAN 
            style="FONT-SIZE: 10pt; COLOR: #cc0000; FONT-FAMILY: Verdana">*</SPAN></A><SPAN 
            style="FONT-SIZE: 10pt; FONT-FAMILY: Verdana">Enter your old 
            password to confirm changes&nbsp;&nbsp; 
            <INPUT type=password 
            maxLength=20 name=opass size="20"></SPAN> </P>
            <P>&nbsp;</P></TD></TR>
        <TR>
          <TD width=600 colSpan=3>
            <TABLE align=center>
              <TBODY>
              <TR>
                <TD align=right><A href="http://localhost/cgi-bin/hot-soft/"><INPUT class=btnNormal type=submit align=right value=Submit name=Continue></A> 
                </TD>
                <TD width=100>&nbsp;</TD>
                <TD align=left><INPUT class=btnNormal onclick="cancelClicked=true; return true;" type=submit align=left value=Cancel name=Cancel> 
                </TD></TR></TBODY></TABLE></TD>
        <TR>
          <TD width=600 colSpan=3><BR>&nbsp;<BR></TD></TR></TBODY></TABLE><INPUT 
      type=hidden value=/index.asp name=REFERRER> <INPUT type=hidden 
      name=CANCELREDIRECT> <INPUT type=hidden name=NULLEMAIL> </FORM></CENTER><!-- Set a variable to determine what version of JavaScript we support.  --><!-- This technique can be extended to any number of language versions.  --><!-- The browser won't execute a script block that it can't support.  -->
      <SCRIPT language=JavaScript> var _version = 1.0; </SCRIPT>

      <SCRIPT language=JavaScript1.1> var _version = 1.1; </SCRIPT>

      <SCRIPT language=JavaScript1.2> var _version = 1.2; </SCRIPT>

      <SCRIPT language=JavaScript1.3> var _version = 1.3; </SCRIPT>

      <SCRIPT language=JavaScript1.4> var _version = 1.4; </SCRIPT>

      <SCRIPT language=JavaScript1.5> var _version = 1.5; </SCRIPT>

      <SCRIPT language=JavaScript>
// Make duplicate screen name and username errors stand out
// so users don't get confused and think a dup username is the
// problem when it is really the screen name
// Also scroll old password field into view when old password doesn't
// match.

	//alert(_version);

	var errorCode = 0;
	var errMsg = "";

	var strLoggedIn;
	strLoggedIn = "False";




	if ( errorCode == -2147219601 )
	{
		if ( navigator.appName == "Microsoft Internet Explorer" )
		{
			location.hash = "tun";
			document.mons_form1.UserName.select();
		}
		else if ( _version <= 1.3 )  //Netscape (version 4.x) and other non-ie browsers
		{
			alert(errMsg);
			document.mons_form1.UserName.focus();
			document.mons_form1.UserName.select();
		}
		else  //Netscape (version 6.x) and other non-ie browsers
		{
			//bring the user name field into view
			//need to go to the field below user name,
			//because part of help text not visible when scroll to
			//to user name
			document.mons_form1.myPassword.focus();

			//put the focus back onto user name field and hilite it
			document.mons_form1.UserName.select();
		}
	}
	else if ( errorCode == -2147219600 )
	{
		if ( navigator.appName == "Microsoft Internet Explorer" )
		{
			location.hash = "tsn";
			document.mons_form1.NickName.select();
		}
		else if ( _version <= 1.3 )  //Netscape (version 4.x) and other non-ie browsers
		{
			alert(errMsg);
			document.mons_form1.NickName.focus();
			document.mons_form1.NickName.select();
		}
		else  //Netscape (version 6.x) and other non-ie browsers
		{
			//bring the screen name field into view
			//need to go to the field below screen name,
			//because part of help text not visible when scroll to
			//to screen name


			document.mons_form1.careerlevelid.focus();



			//put the focus back onto screen name field and hilite it
			document.mons_form1.NickName.select();
		}
	}
	else if ( ( strLoggedIn == "True" ) && ( "True" == "False" ) )
	{
		if ( navigator.appName == "Microsoft Internet Explorer" )
		{
			location.hash = "toldpass";
			document.mons_form1.OldPassword.select();
		}
		else if ( _version <= 1.3 )  //Netscape (version 4.x) and other non-ie browsers
		{
			document.mons_form1.OldPassword.focus();
			document.mons_form1.OldPassword.select();
		}
		else  //Netscape (version 6.x) and other non-ie browsers
		{
			document.mons_form1.Continue.focus();
			document.mons_form1.OldPassword.select();
		}
	}
      </SCRIPT>
    </TD></TR></TBODY></TABLE>
<TABLE cellSpacing=0 cellPadding=0 width=140 border=0>
  <TBODY>
  <TR>
    <TD></TD></TR></TBODY></TABLE></CENTER><!-- Start Footer --></TABLE><FONT 
face="verdana, arial, geneva, sans-serif" color=#000000 size=1>
<CENTER><BR><BR>&nbsp; 
<P align=center><IMG height=71 alt="" src="EditAccount_files/festive_js.gif" 
width=600 border=0></P></CENTER></FONT>

</FORM>
<P></P></BODY></HTML>
	
		
EOF
}else{
	print <<'EOF';
	The Session has expired.<p>
	Please <a href=http://localhost/hot-soft/Login.html>Login</a> agian.
EOF
}

exit(0);



