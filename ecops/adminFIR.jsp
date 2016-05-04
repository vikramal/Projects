<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en">
<head>
<script>
function valid(x)
{
	if(x.station_txt.value=="")
	{
		alert("Enter Station");
		x.station_txt.focus();
		return false;
	}
	
	if(x.crime_txt.value=="")
	{
		alert("Enter Crime/Offence");
		x.crime_txt.focus();
		return false;
	}
	
	if(x.act_txt.value=="")
	{
		alert("Enter Act/Section");
		x.act_txt.focus();
		return false;
	}
	
	if(x.details_txt.value=="")
	{
		alert("Enter DATE(Occurence Of Offence)");
		x.details_txt.focus();
		return false;
	}
	
	if(x.date_txt.value=="")
	{
		alert("Enter DATE(Occurence Of Offence)");
		x.date_txt.focus();
		return false;
	}
	
	if(x.date1_txt.value=="")
	{
		alert("Enter DATE(Information Recieved at Police Station) ");
		x.date1_txt.focus();
		return false;
	}
	
	if(x.reason_txt.value=="")
	{
		alert("Enter Reason for the delay in Reporting");
		x.reason_txt.focus();
		return false;
	}
	
	if(x.address_txt.value=="")
	{
		alert("Enter ADDRESS (Place Of Occurence Of Crime/Offence)");
		x.address_txt.focus();
		return false;
	}
	
	if(x.suspect_txt.value=="")
	{
		alert("Enter Known / Unknown / Suspected");
		x.suspect_txt.focus();
		return false;
	}
	
	if(x.name_txt.value=="")
	{
		alert("Enter Name");
		x.name_txt.focus();
		return false;
	}
	
	if(x.fname_txt.value=="")
	{
		alert("Enter Father's / Husband's Name");
		x.fname_txt.focus();
		return false;
	}
	
	if(x.dob_txt.value=="")
	{
		alert("Enter Date-Of-Birth");
		x.dob_txt.focus();
		return false;
	}
	
	if(x.national_txt.value=="")
	{
		alert("Enter Nationality");
		x.national_txt.focus();
		return false;
	}
	
	if(x.id_txt.value=="")
	{
		alert("Enter Identity Proof");
		x.id_txt.focus();
		return false;
	}
	
	if(x.proof_txt.value=="")
	{
		alert("Enter Produced Proof's ID");
		x.proof_txt.focus();
		return false;
	}
	
	if(x.dob_txt.value=="")
	{
		alert("Enter Occupation");
		x.dob_txt.focus();
		return false;
	}
	
	if(x.con_txt.value=="")
	{
		alert("Enter Contact Number");
		x.con_txt.focus();
		return false;
	}
	
	if(x.add_txt.value=="")
	{
		alert("Enter Address");
		x.add_txt.focus();
		return false;
	}
	
	
	return true;
}
function numeric()
{
	if(!((event.keyCode>=48)&&(event.keyCode<=57)))
	{
		alert("Enter only numbers");
		event.keyCode=0;
	}
}
function alphabets()
{
	if(!(((event.keyCode>65)&&(event.keyCode<=91))||((event.keyCode>=97)&&(event.keyCode<=122))||(event.keyCode==32)))
	{
		alert("Numbers & Special characters not allowed");
		event.keyCode=0;
	}
	
}
</script>
<link rel="stylesheet" href="images/BluePigment.css" type="text/css" />
<title>Welcome to E - Cops (E-Computerized Operations for Police Services).</title> 
</head>
<body>
<%

try
{

	String x=(String) session.getAttribute("user");
	if(x.equals("null"))
	{
		response.sendRedirect("index.html");
	}

%>
<%@ page import="java.sql.*" %> 
<!--- For Auto Generate --->
<%

String temp1="";
Class.forName("com.mysql.jdbc.Driver").newInstance();

Connection con1=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");

	Statement st1=con1.createStatement();
	
	ResultSet rs1=st1.executeQuery("select * from fir order by firno");
	while(rs1.next())
	{
		temp1=rs1.getString(1);
		
	}
	
	if(temp1.equals(""))
	{
		temp1="1000";
	}
	else
	{
		int a=Integer.parseInt(temp1);
		a++;
		temp1=""+a;
	}
%>
<!--- Auto Generate Code Ends Here --->
<%@ page import="java.sql.*" %>

<%
	String cid=request.getParameter("cid");
	String uname="";
	String cd="";
	String ps="";
	String cdet="";
	String add1="";
	
	String fname="";
	String add="";
	String nat="";
	String dob="";
	String mob="";
	String up="";
	

	Class.forName("com.mysql.jdbc.Driver").newInstance();

	Connection con2=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");

	Statement st2=con2.createStatement();
	
	ResultSet rs2=st2.executeQuery("select * from complaint where cid='"+cid+"'");
	while(rs2.next())
	{
		uname=rs2.getString(1);
		cd=rs2.getString(4);
		ps=rs2.getString(5);
		cdet=rs2.getString(7);
		add1=rs2.getString(8);
	}
	Connection con3=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");

	Statement st3=con3.createStatement();
	
	ResultSet rs3=st3.executeQuery("select * from citizenreg where username='"+uname+"'");
	
	while(rs3.next())
	{
		fname=rs3.getString(5);
		add=rs3.getString(6);
		nat=rs3.getString(10);
		dob=rs3.getString(11);
		mob=rs3.getString(12);
		up=rs3.getString(15);
	}
%>

<!-- header starts here -->
<div id="header">
  <div id="header-content">
    <marquee allign="middle" behaviour="slide" direction="left"><b><h3>Welcome to E - Cops (E-Computerized Operations for Police Services).</b></h3></marquee>
    <h1 id="logo-text"><a href="index.html" title=""><align=center>&nbsp&nbsp&nbsp E - <span> Cops</span></align></a></h1>
    <h2 id="slogan">&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp A Computised operations of Police Services.</h2>
    <div id="header-links">
      <p> <img src="C:\apache-tomcat-4.1.36\apache-tomcat-4.1.36\webapps\ROOT\Ecops\images\logo.jpg" </p>
    </div>
  </div>
</div>
<!-- navigation starts here -->


<div id="nav-wrap">
  <div id="nav">
    <ul>
      <li><a href="adminhome.jsp">Admin home</a></li>
      <li id="current"><a href="fir.jsp">FIR</a></li>
	  <li><a href="adminviewfir.jsp">View FIR's</a></li>
	  <li><a href="adminupdatefir.jsp">Update FIR</a></li>
	  <li><a href="admindeletefir">Delete FIR</a></li>
      <li><a href="index.html">Contact</a></li>
    </ul>
  </div>
</div>
  <!-- footer ends-->
<div id="content-wrap">
  <div id="content">
    <div id="sidebar" >
     </div>
      <div class="sidebox">
      </div>
</div>
<br>
<br>
<div class="box">
<center>
<form name="complaint"  method="post" action="adminfir2.jsp" onSubmit="return valid(this);">
<br>
<h1><img src="images\cp.png">Lodge FIR (First Information Report)</h1>
<table>
<tr>
<td><center>FIR Number</center></td><br>
<td><center><input type="text" name="fir" value="<%=temp1%>">
</tr>
<tr>
<td><center>Police Station</center></td>
<td><center><input type="text" name="area_txt" value="<%=ps%>">
</tr>
<tr>
<td><center>Crime/Offence</center></td>
<td><center><textarea name="crime_txt" cols="46" rows="1"><%=cdet%></textarea>
</tr>
<tr>
<td><center>Act/Section</center></td>
<td><center><input type="text" name="act_txt">
</select>
</tr>
<tr>
<td><center>Date(Occurence of Offence)</center></td>
<td><center><input type="text" name="date_txt">
</tr>
<tr>
<td><center>Date(Information Recived at Police Station)</center></td>
<td><center><input type="text" name="date1_txt" value="<%=cd%>">
</tr>
<tr>
<td><center>Reason of Delay in Reporting</center></td>
<td><center><input type="text" name="reason_txt" value="Unknown">
</tr>
<tr>
<td><center>ADDRESS (Place Of Occurence Of Crime/Offence)</center></td>
<td><center><textarea name="address_txt" cols="46" rows="1"><%=add1%></textarea>
</tr>
<tr>
<td><center>Known / Unknown / Suspected </center></td>
<td><center><input type="text" name="suspect_txt" value="Unknown">
</tr>
<tr cols="2">
<td><center>COMPLAINANT / INFORMANT DETAILS</center></td>
</tr>
<tr>
<td><center>Name</center></td>
<td><center><input type="text" name="name_txt" value="<%=uname%>">
</tr>
<tr>
<td><center>Father's / Husband's Name</center></td>
<td><center><input type="text" name="fname_txt" value="<%=fname%>">
</tr>
<tr>
<td><center>Date-Of-Birth</center></td>
<td><center><input type="text" name="dob_txt" value="<%=dob%>">
</tr>
<tr>
<td><center>Nationality</center></td>
<td><center><input type="text" name="national_txt" value="<%=nat%>">
</tr>
<tr>
<td><center>Identity Proof</center></td>
<td><center><select name="id_txt">
						<option value="Passport">Passport
						<option value="DrivingLicense">Driving License
						<option value="VoterCard">Voter Card
						<option value="AadharCard">Aadhar Card
						<option value="RationCard">Ration Card
			</select></td>
</tr>
<tr>
<td><center>Produced Proof's ID</center></td>
<td><center><input type="text" name="proof_txt" value="<%=up%>">
</tr>
<tr>
<td><center>Contact Number</center></td>
<td><center><input type="text" name="cno_txt" value="<%=mob%>">
</tr>
<tr>
<td><center>Address</center></td>
<td><center><textarea name="add_txt" cols="46" rows="1"><%=add%></textarea>
</tr>

</table>
<input type="submit" name="submit" value="submit">
<input type="reset" name="reset" value="clear">
</form>
</center>
</div></div>
</body>
</html>

<%
}
catch(NullPointerException ne)
{
	response.sendRedirect("index.html");
}
%>