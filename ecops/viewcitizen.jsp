<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en">
<head>
<link rel="stylesheet" href="images/BluePigment.css" type="text/css" />
<title>E-cops (E-Computerized Operations for Police Services)</title>
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
<!-- header starts here -->
<div id="header">
  <div id="header-content">
    <marquee allign="middle" behaviour="slide" direction="left"><h3>Welcome to E - Cops (E-Computerized Operations for Police Services).</h3></marquee>
    <h1 id="logo-text"><a href="index.html" title=""><align=center>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp E - <span> Cops</span></align></a></h1>
    <h3 id="slogan">&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp A Computised operations of Police Services.</h3>
    <div id="header-links">
      <p> <img src="images\logo.jpg" </p>
    </div>
  </div>
</div>
<!-- navigation starts here -->


<div id="nav-wrap">
  <div id="nav">
    <ul>
          <li><a href="adminhome.jsp">Admin Home</a></li>
          <li id="current"><a href="viewcitizen.jsp">View Registration</a></li>
	      <li><a href="index.html">Log Out</a></li>
    </ul>
  </div>
</div>
  <!-- footer ends-->
<div id="content-wrap">
  <div id="content">
    <div id="sidebar">
      <div class="sidebox"><br>
      </div>
</div>
<br>
<br>
<div class="box">
<center>
<form name="viewreg" method="post" action="viewcitizen1.jsp">
<table>
	<center><h1><img src="images\cp.png">View Citizen Registration Details</h1></center>
	<tr align="center">
		<td><p>Select Username</p></td>
		<td><center><select name="user" style="width:150px;">
<%@ page import="java.sql.*" %>

<%

String temp="";
Class.forName("com.mysql.jdbc.Driver").newInstance();

Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");

	Statement st=con.createStatement();
	
	ResultSet rs=st.executeQuery("select * from citizenreg order by username");

	while(rs.next())
	{
		temp=rs.getString(1);
		out.print("<option value="+temp+">"+temp);
	}

%>
	</tr>
	<tr>
	<br>
		<td colspan="2" align="center"><input type="submit" name="s" value="Show">
	</tr>
</table>
</form>
</center>
</div><br><br></div>
</body>
</html>

<%
}
catch(NullPointerException ne)
{
	response.sendRedirect("index.html");
}
%>