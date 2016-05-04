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
      <p> <img src="images\logo.jpg" </p>
    </div>
  </div>
</div>
<!-- navigation starts here -->
<div id="nav-wrap">
  <div id="nav">
    <ul>
          <li><a href="citizenhome.jsp">Citizen Home</a></li>
		  <li id="current"><a href="citizenviewstation.jsp">View Stations</a></li>
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
<form name="admincomplaintreport" method="post" onsubmit="return validation(this);">
<br>
<table style="border:2px solid black;">
	<center><h1><img src="images\cp.png">View Police Station Details</h1></center>
	<tr style="border:2px solid black;color:darkblue;">
		<td style="border:2px solid black;color:darkblue;">Station ID </td>
		<td style="border:2px solid black;color:darkblue;">Station Area </td>
		<td style="border:2px solid black;color:darkblue;">Station Zone </td>
		<td style="border:2px solid black;color:darkblue;">Station Head </td>
		<td style="border:2px solid black;color:darkblue;">Contact No </td>
		<td style="border:2px solid black;color:darkblue;">Station Address </td>
	</tr>
	<%@ page import="java.sql.*" %>
	<%
		String id = "";
		String area = "";
		String zone = "";
		String head = "";
		String contact = "";
		String address = "";
		
		Class.forName("com.mysql.jdbc.Driver").newInstance();
		Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
		Statement st=con.createStatement();
		ResultSet rs=st.executeQuery("select * from policestation");
		while(rs.next())
		{
			id=rs.getString(1);
			area=rs.getString(2);
			zone=rs.getString(3);
			head=rs.getString(4);
			contact=rs.getString(5);
			address=rs.getString(6);
			
			out.print("<tr style='border:2px solid black;'>");
			out.print("<td style='border:2px solid black;'>"+id);
			out.print("<td style='border:2px solid black;'>"+area);
			out.print("<td style='border:2px solid black;'>"+zone);
			out.print("<td style='border:2px solid black;'>"+head);
			out.print("<td style='border:2px solid black;'>"+contact);
			out.print("<td style='border:2px solid black;'>"+address);
		}
	%>
</table>
</form>
</center>
</div>
<br>
<br>
</body>
</html>

<%
}
catch(NullPointerException ne)
{
	response.sendRedirect("index.html");
}
%>