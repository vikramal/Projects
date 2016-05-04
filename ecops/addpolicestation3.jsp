<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en">
<head>
<script>
function valid(x)
{	
	if(x.area_txt.value=="")
	{
		alert("Enter Station Area");
		x.area_txt.focus();
		return false;
	}
	
	if(x.zone_txt.value=="")
	{
		alert("Select Station Zone");
		x.zone_txt.focus();
		return false;
	}
	
	if(x.head_txt.value=="")
	{
		alert("Enter Station Head");
		x.head_txt.focus();
		return false;
	}
	
	if(x.contactnum_txt.value=="")
	{
		alert("Enter Contact Number");
		x.contactnum_txt.focus();
		return false;
	}
	
	if(x.address_txt.value=="")
	{
		alert("Enter Address");
		x.address_txt.focus();
		return false;
	}
	
	if(x.contactnum_txt.value.length<10)
	{
		alert("Incorrect Contact No.")
		x.contactnum_txt.focus();
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
<%
String temp="";
Class.forName("com.mysql.jdbc.Driver").newInstance();

Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");

	Statement st=con.createStatement();
	
	ResultSet rs=st.executeQuery("select * from policestation order by pid");

	while(rs.next())
	{
		temp=rs.getString(1);
		
	}
	
	if(temp.equals(""))
	{
		temp="1000";
	}
	else
	{
		int a=Integer.parseInt(temp);
		a++;
		temp=""+a;
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
          <li><a href="adminhome.jsp">Admin Home</a></li>
          <li id="current"><a href="addpolicestation1.jsp">Stations</a></li>
		  <li><a href="viewpolicestation.jsp">View Stations</a></li>
          <li><a href="psupdate1.jsp">Update Stations</a></li>
		  <li><a href="psdelete1.jsp">Delete Stations</a></li>
	      <li><a href="index.html">Log Out</a></li>
    </ul>
  </div>
</div>
  <!-- footer ends-->
<div id="content-wrap">
  <div id="content">
    <div id="sidebar">
      <div class="sidebox">
      </div>
</div>
<br>
<br>
<div class="box">
<center>
<form name="citizenreg" method="post" action="addpolicestation2.jsp" onsubmit="return valid(this);">
<br>
<h1><img src="images\cp.png">Add Police Stations</h1>
<center><h3><font color="red">Police Station Added Successfully ..!!</font></h3></center>
<table>
<tr>
<td><center>Police Station ID</center></td><br>
<td><center><input type="text" name="id_txt" value="<%=temp%>" readonly>
</tr>
<tr>
<td><center>Police Station Area</center></td>
<td><center><input type="text" name="area_txt" onkeypress="alphabets()">
</tr>
<tr>
<td><center>Police Station Zone</center></td>
<td><center><select name="zone_txt" size="1" width="100px" height=50px>
		   <option value="North Zone">North Zone
		   <option value="south Zone">South Zone
		   <option value="East Zone">East Zone
		   <option value="West Zone">West Zone
		   </select>
</tr>
<tr>
<td><center>Head of the Station</center></td>
<td><center><input type="text" name="head_txt" onkeypress="alphabets()">
</tr>
<tr>
<td><center>Contact Number</center></td>
<td><center><input type="text" name="contactnum_txt" maxlength="10" onkeypress="numeric()">
</tr>
<tr>
<td><center>Address</center></td>
<td><center><textarea  cols="46" rows="1" name="address_txt" ></textarea>
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