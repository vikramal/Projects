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
	  <li><a href="adminviewfir.jsp">View FIR's</a></li>
	  <li><a href="adminupdatefir.jsp">UPDATE FIR</a></li>
	  <li id="current"><a href="admindeletefir.jsp">DELETE FIR</a></li>
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
<form name="admincomplaintreport" method="post" onsubmit="return validation(this);" action="adminupdatefir2.jsp">
<br>
<table>
	<h3><img src="images\cp.png">Update FIR Status</h3>
	 <h2><font color="red">FIR Deleted Successfully ...!!!</font></h2>
	<tr>
		<td>Select FIR Number</td>
		<td><select name="firno" style="width:109%;">
			<%@page import="java.sql.*"%>
				<%
				String r="";
				Class.forName("com.mysql.jdbc.Driver").newInstance();
				Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
				Statement st=con.createStatement();
				ResultSet rs=st.executeQuery("select * from fir");
				while(rs.next())
				{
					r=rs.getString(1);
					out.print("<option value="+r+">"+r);
				}
			%>
			<option>
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