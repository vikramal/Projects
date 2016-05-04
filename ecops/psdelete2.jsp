<%@ page import="java.sql.*" %>

<%

	String x1=request.getParameter("pid");
	String area="";	
	String zone="";
	String head="";
	String contactnum="";
	String address="";

	Class.forName("com.mysql.jdbc.Driver").newInstance();

	Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");

	Statement st=con.createStatement();
	
	ResultSet rs=st.executeQuery("select * from policestation where pid='"+x1+"'");
	while(rs.next())
	{
		area=rs.getString(2);
		zone=rs.getString(3);
		head=rs.getString(4);
		contactnum=rs.getString(5);
		address=rs.getString(6);
	}
%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
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
          <li><a href="psupdate1.jsp">Update Stations</a></li>
		  <li id="current"><a href="psdelete1.jsp">Delete Stations</a></li>
	      <li><a href="index.html">Log Out</a></li>
    </ul>
  </div>
</div>
  <!-- footer ends-->
<div id="content-wrap">
  <div id="content">
    <div id="sidebar" >
      <div class="sidebox">
      </div>
</div>
<br>
<br>
<div class="box">
<center>
<form name="psdelete2" method="post" action="psdelete3.jsp"
<br>
<h1><img src="images\cp.png">Delete Police Stations</h1>
<table>
<tr>
<td><center>Police Station ID</center></td><br>
<td><center><input type="text" name="id_txt" value="<%=x1%>">
</tr>
<tr>
<td><center>Police Station Area</center></td>
<td><center><input type="text" name="area_txt" value="<%=area%>">
</tr>
<tr>
<td><center>Police Station Zone</center></td>
<td><center><input type="text" name="zone_txt" value="<%=zone%>">
</tr>
<tr>
<td><center>Head of the Station</center></td>
<td><center><input type="text" name="head_txt" value="<%=head%>">
</tr>
<tr>
<td><center>Contact Number</center></td>
<td><center><input type="text" name="contactnum_txt" value="<%=contactnum%>">
</tr>
<tr>
<td><center>Address</center></td>
<td><center><textarea  cols="46" rows="1" name="address_txt"><%=address%></textarea>
</tr>
</table>

<input type="submit" name="submit" value="Delete">
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