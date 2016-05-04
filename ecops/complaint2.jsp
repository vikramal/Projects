<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en">
<head>
<script>
function valid(x)
{
	if(x.complaint_txt.value=="")
	{
		alert("Select Complaint Type");
		x.complaint_txt.focus();
		return false;
	}
	
	if(x.details_txt.value=="")
	{
		alert("Enter Details/Description ");
		x.details_txt.focus();
		return false;
	}
	
	x.date_txt.value=x.dt.value;
	x.id_txt.value=x.id.value;
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
<%@ page import="java.util.Date" %>

<%

	Date d=new Date();
	String x1=""+d;
%>

<%@ page import="java.sql.*" %>

<%

String temp1="";
Class.forName("com.mysql.jdbc.Driver").newInstance();

Connection con1=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");

	Statement st1=con1.createStatement();
	
	ResultSet rs1=st1.executeQuery("select * from complaint order by cid");

	while(rs1.next())
	{
		temp1=rs1.getString(3);
		
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
<!-- header starts here -->
<div id="header">
  <div id="header-content">
    <marquee allign="middle" behaviour="slide" direction="left"><b><h3>Welcome to E - Cops (E-Computerized Operations for Police Services).</b></h3></marquee>
    <h1 id="logo-text"><a href="index.html" title=""><align=center>&nbsp&nbsp&nbsp E - <span> Cops</span></align></a></h1>
    <h2 id="slogan">&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp A Computised operations of Police Services.</h2>
    <div id="header-links">
      <p> <img src="images\logo.jpg" </p>
    </div>
  </div>
</div>
<!-- navigation starts here -->


<div id="nav-wrap">
  <div id="nav">
    <ul>
      <li><a href="citizenhome.jsp">Citizen home</a></li>
      <li id="current"><a href="complaint.jsp">Complaint</a></li>
	  <li><a href="citizenviewcomplaint.jsp">View Complaint Status</a></li>
      <li><a href="index.html">Logout</a></li>
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
<form name="complaint" method="post" action="complaint1.jsp" onSubmit="return valid(this);">
<input type="hidden" name="date_txt">
<input type="hidden" name="id_txt">
<br>
<h1><u>Lodge Complaint.</u></h1>
<h3><font color="red">Complaint was Successfully Registered. Thank You for your cooperation.</font></h3>
<table>
<tr>
<td><center>Complaint ID</center></td><br>
<td><center><input type="text" name="id" value="<%=temp1%>" disabled>
</tr>
<tr>
<td><center>Date/Time of Complaint</center></td>
<td><center><input type="text" name="dt" value="<%=x1%>" disabled size=35>
</tr>
<tr>
<td><center>Area Police Station </center></td>
<td><center><select name="area_txt" style="width:34%;">

<%@ page import="java.sql.*" %>

<%

String temp="";
Class.forName("com.mysql.jdbc.Driver").newInstance();

Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");

	Statement st=con.createStatement();
	
	ResultSet rs=st.executeQuery("select * from policestation order by area");

	while(rs.next())
	{
		temp=rs.getString(2);
		out.print("<option value="+temp+">"+temp);
	}

%>
</tr>
<tr>
<td><center>Complaint/Information/Feedback</center></td>
<td><center><select name="complaint_txt" style="width:60%;">
<option>Some problems faced in police sation?
<option>Theft
<option>dowry
<option>Eve teasing
<option>Murder
<option>Half murder
<option>Cheating
<option>Chain snatching
<option>Vehicle missing
<option>Others....
</select>
</tr>
<tr>
<td><center>Details/Description</center></td>
<td><center><textarea name="details_txt" cols="80" rows="6"></textarea>
</tr>
<tr>
<br>
<td><center>ADDRESS (Place Of Occurence Of Crime/Offence)</center></td>
<br>
<td><center><textarea name="address_txt" cols="80" rows="6"></textarea>
</tr>
</table>
<input type="submit" name="submit" value="submit">
</form>
</center>
</div>
</body>
</html>

<%
}
catch(NullPointerException ne)
{
	response.sendRedirect("index.html");
}
%>