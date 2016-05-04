<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en">
<head>
<!-- validation here -->

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
	  <li id=current><a href="admincompliantreport.jsp">View Citizen Compalint</a></li>
      <li><a href="admincomplaintupdate.jsp">Update Complaint Status</a></li>
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
<form name="admincomplaintreport" method="post" onsubmit="return validation(this);" action="admincompliantreport2.jsp">
<br>
<table>
	<h1><img src="images\cp.png">View Citizen Complaints</h1>
	<tr>
		<td><input type="radio" name="r" value="all" checked>All Complaints
		<td>
	</tr>
	<tr>
		<td><input type="radio" name="r" value="ps" >Select Police Station
		<td><select name="psname" style="width:74%;">
			<%@page import="java.sql.*"%>
				<%
					String x1="";
					Class.forName("com.mysql.jdbc.Driver").newInstance();
					Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
					Statement st=con.createStatement();
					ResultSet rs=st.executeQuery("select distinct(ps) from complaint");
					while(rs.next())
					{
						x1=rs.getString(1);
						out.print("<option value="+x1+">"+x1);
					}
				%>
			</select>
	</tr>
	<tr>
		<td colspan="2" align="center"><input type="submit" name="s" value="Show">
	</tr>
</table>
</form>
</center>
</div><br><br><br><br></div>
</body>
</html>

<%
}
catch(NullPointerException ne)
{
	response.sendRedirect("index.html");
}
%>