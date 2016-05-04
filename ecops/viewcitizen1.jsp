<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en">
<head>
<%@ page import="java.sql.*" %>
<%
		String user = request.getParameter("user");
		String name = "";
		String fname = "";
		String add = "";
		String dob = "";
		String mob = "";
		String land = "";
		String email = "";
		String doc = "";
		String status = "";
		
		
		Class.forName("com.mysql.jdbc.Driver").newInstance();
		Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
		Statement st=con.createStatement();
		ResultSet rs=st.executeQuery("select * from citizenreg where username='"+user+"'");
		while(rs.next())
		{
			user=rs.getString(1);
			name=rs.getString(3);
			fname=rs.getString(5);
			add=rs.getString(6);
			dob=rs.getString(11);
			mob=rs.getString(12);
			land=rs.getString(13);
			email=rs.getString(14);
			doc=rs.getString(15);
			status=rs.getString(16);
		}
		
		session.setAttribute("un",user);
	%>
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
       <li><a href="adminhome.jsp">Admin Home</a></li>
          <li id="current"><a href="viewcitizen.jsp">View Registration</a></li>
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
<form name="adminfirreport" method="post" onsubmit="return validation(this);" action="viewcitizen2.jsp">
<br>
<h1><img src="images\cp.png">View Citizen Registeration Details</h1>
<table>
<tr>
<td><center>Username</center></td><br>
<td><center><input type="text" name="username_txt" value="<%=user%>">
</tr>
<tr>
<td><center>Name</center></td>
<td><center><input type="text" name="name_txt" value="<%=name%>">
</tr>
<tr>
<td><center>Father name</center></td>
<td><center><input type="text" name="father_txt" value="<%=fname%>">
</tr>
<tr>
<td><center>Address</center></td>
<td><center><textarea name="address_txt" rows="1" cols="46"><%=add%></textarea>
</tr>
<tr>
<td><center>Date of Birth</center></td>
<td><center><input type="text" name="dob_txt" value="<%=dob%>">
</tr>
<tr>
<td><center>Mobile Number</center></td>
<td><center><input type="text" name="mob_txt" value="<%=mob%>">
</tr>
<tr>
<td><center>Landline Nummber</center></td>
<td><center><input type="text" name="land_txt" value="<%=land%>">
</tr>
<tr>
<td><center>E-Mail</center></td>
<td><center><input type="text" name="email_txt" value="<%=email%>">
</tr>
<tr>
<td><center>Download Document</center></td>
<td><center><input type="text" name="download_txt" value="<%=doc%>"><a href="uploads/<%=doc%>" target="_blank">Download</a></center></td>
</tr>
<tr>
<td><center>Status</center></td>
<td><center><select name="status">
<option value="Approved">Approved
<option value="NotApproved">Not Approved
<option value="Cancel">Registration Cancel
</select>
</tr>
</table>
<input type="submit" value="update">
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