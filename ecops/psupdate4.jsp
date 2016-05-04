<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<%@ page import="java.sql.*" %>

<%

	String x1="";

	Class.forName("com.mysql.jdbc.Driver").newInstance();

	Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");

	Statement st=con.createStatement();
	
	ResultSet rs=st.executeQuery("select * from policestation");

%>
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en">
<head>
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
          <li><a href="adminhome.html">Admin Home</a></li>
          <li><a href="addpolicestation1.jsp">Add Stations</a></li>
		  <li><a href="viewpolicestation.jsp">View Stations</a></li>
          <li id="current"><a href="psupdate1.jsp">Update Stations</a></li>
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
<form name="citizenreg" method="post" action="psupdate2.jsp"
<br>
<h1><b><img src="images\cp.png">Update Police Stations</b></h1>
<h3><font color="red">Police Station has benn Updated Successfully..!!</font></h3>
<br><br>
<table>
<tr>
<td><center><p style="font-size:20px;">Select Police Station ID</p></center></td>
<td><center></center><select name="pid" style="width:105%;">
<%
	while(rs.next())
	{
		x1=rs.getString(1);
		out.print("<option value="+x1+">"+x1);
	}
%>
</select></td>
</tr>
</table>
<br>
<input type="submit" name="s" value="Show">
<br><br><br><br><br><br>
</form>
</center>
</div>
<br><br><br><br><br>
</body>
</html>

<%
}
catch(NullPointerException ne)
{
	response.sendRedirect("index.html");
}
%>