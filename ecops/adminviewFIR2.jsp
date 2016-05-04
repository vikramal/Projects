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
      <li><a href="adminhome.jsp">Admin home</a></li>
      <li><a href="fir.jsp">FIR</a></li>
	  <li id="current"><a href="adminviewfir.jsp">View FIR's</a></li>
	  <li><a href="adminupdatefir.jsp">UPDATE FIR</a></li>
	  <li><a href="admindeletefir.jsp">DELETE FIR</a></li>
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
<form name="adminfirreport" method="post" onsubmit="return validation(this);" action="admincomreport2.jsp">
<br>
<table width="100%">
	<center><h3><img src="images\cp.png">View FIR Report</h3></center>
	<tr>
		<td style="border:2px solid black;color:darkblue;">FIR NO.</td>
		<td style="border:2px solid black;color:darkblue;">Police Station</td>
		<td style="border:2px solid black;color:darkblue;">CRIME \ OFFENCE</td>
		<td style="border:2px solid black;color:darkblue;">ACT / SECTION</td>
		<td style="border:2px solid black;color:darkblue;">DATE (Occurance of offence)</td>
		<td style="border:2px solid black;color:darkblue;">DATE (Information Recieved at Police Station)</td>
		<td style="border:2px solid black;color:darkblue;">ADDRESS (Place of occrence of crime/offence)</td>
		<td style="border:2px solid black;color:darkblue;">SUSPECT</td>
		<td style="border:2px solid black;color:darkblue;">NAME</td>
		<td style="border:2px solid black;color:darkblue;">DATE-OF-BIRTH</td>
		<td style="border:2px solid black;color:darkblue;">PRODUCED PROOF'S ID</td>
		<td style="border:2px solid black;color:darkblue;">CONTACT NO.</td>
		<td style="border:2px solid black;color:darkblue;">ADDRESS</td>
		<td style="border:2px solid black;color:darkblue;">STATUS</td>
	</tr>
	<%@ page import="java.sql.*" %>
	<%
		String fir = "";
		String psname = "";
		String crime = "";
		String act1 = "";
		String cdate1 = "";
		String date2 = "";
		
		String add1 = "";
		String suspect = "";
		String name = "";
		
		String dob = "";
		String proofid = "";
		String contact = "";
		String add2 = "";
		String status = "";
		
		Class.forName("com.mysql.jdbc.Driver").newInstance();
		Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
		Statement st=con.createStatement();
		ResultSet rs=st.executeQuery("select * from fir");
		while(rs.next())
		{
			fir=rs.getString(1);
			psname=rs.getString(2);
			crime=rs.getString(3);
			act1=rs.getString(4);
			cdate1=rs.getString(5);
			date2=rs.getString(6);
			add1=rs.getString(8);
			suspect=rs.getString(9);
			name=rs.getString(10);
			dob=rs.getString(12);
			proofid=rs.getString(15);
			contact=rs.getString(16);
			add2=rs.getString(17);
			status=rs.getString(18);
			
			out.print("<tr style='border:2px solid black;'>");
			out.print("<td style='border:2px solid black;'>"+fir);
			out.print("<td style='border:2px solid black;'>"+psname);
			out.print("<td style='border:2px solid black;'>"+crime);
			out.print("<td style='border:2px solid black;'>"+act1);
			out.print("<td style='border:2px solid black;'>"+cdate1);
			out.print("<td style='border:2px solid black;'>"+date2);
			out.print("<td style='border:2px solid black;'>"+add1);
			out.print("<td style='border:2px solid black;'>"+suspect);
			out.print("<td style='border:2px solid black;'>"+name);
			out.print("<td style='border:2px solid black;'>"+dob);
			out.print("<td style='border:2px solid black;'>"+proofid);
			out.print("<td style='border:2px solid black;'>"+contact);
			out.print("<td style='border:2px solid black;'>"+add2);
			out.print("<td style='border:2px solid black;'>"+status);
		}
	%>
</table>
</form>
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