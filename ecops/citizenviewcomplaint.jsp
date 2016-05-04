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
      <li><a href="citizenhome.jsp">Citizen home</a></li>
      <li><a href="complaint.jsp">Complaint</a></li>
	  <li id="current"><a href="citizenviewcomplaint.jsp">View Complaint Status</a></li>
      <li><a href="index.html">Logout</a></li>
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
<table>
	<center><h1><img src="images\cp.png">View Citizen Complaints</h1></center>
	<tr>
		<td style="border:2px solid black;color:darkblue;">Username
		<td style="border:2px solid black;color:darkblue;">Complaint ID
		<td style="border:2px solid black;color:darkblue;">Date/Time of Complaint
		<td style="border:2px solid black;color:darkblue;">Area Police Station
		<td style="border:2px solid black;color:darkblue;">Type Of Complaint
		<td style="border:2px solid black;color:darkblue;">Details
		<td style="border:2px solid black;color:darkblue;">Place Of Occurence Of Crime/Offence
		<td style="border:2px solid black;color:darkblue;">Status
		
	</tr>
	<%@ page import="java.sql.*" %>
	<%
		String user = "";
		String cid = "";
		String date1 = "";
		String psname = "";
		String complaint = "";
		String details = "";
		String add="";
		String status = "";
		String r=request.getParameter("r");
		
			Class.forName("com.mysql.jdbc.Driver").newInstance();
		
			Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
			Statement st=con.createStatement();
			ResultSet rs=st.executeQuery("select * from complaint where username='"+x+"'");
			while(rs.next())
			{
				user=rs.getString(1);
				cid=rs.getString(3);
				date1=rs.getString(4);
				psname=rs.getString(5);
				complaint=rs.getString(6);
				details=rs.getString(7);
				add=rs.getString(8);
				status=rs.getString(9);
			
				out.print("<tr style='border:2px solid black;'>");
				out.print("<td style='border:2px solid black;'>"+user);
				out.print("<td style='border:2px solid black;'>"+cid);
				out.print("<td style='border:2px solid black;'>"+date1);
				out.print("<td style='border:2px solid black;'>"+psname);
				out.print("<td style='border:2px solid black;'>"+complaint);
				out.print("<td style='border:2px solid black;'>"+details);
				out.print("<td style='border:2px solid black;'>"+add);
				out.print("<td style='border:2px solid black;'>"+status);
				
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