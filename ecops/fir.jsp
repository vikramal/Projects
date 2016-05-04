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
      <li><a href="adminhome.jsp">Admin home</a></li>
      <li id="current"><a href="fir.jsp">FIR</a></li>
	  <li><a href="adminviewfir.jsp">View FIR's</a></li>
	  <li><a href="adminupdatefir.jsp">Update FIR</a></li>
	  <li><a href="admindeletefir">Delete FIR</a></li>
      <li><a href="index.html">Contact</a></li>
    </ul>
  </div>
</div>
  <!-- footer ends-->
<div id="content-wrap">
  <div id="content">
    <div id="sidebar" >
     </div>
      <div class="sidebox">
      </div>
</div>
<br>
<br>
<div class="box">
<center>
<form name="fir" method="post" action="adminfir.jsp">
<br>
<table>
	<center><h1><img src="images\cp.png">Lodge FIR (First Information Report)</h1></center>
	<tr>
	<td>Select Complaint ID</td> 
        <td><select name="cid" style="width:104%;">
			<%@ page import="java.sql.*" %>
			<%
				String r="";
				Class.forName("com.mysql.jdbc.Driver").newInstance();
				Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
				Statement st=con.createStatement();
				ResultSet rs=st.executeQuery("select * from complaint");
				while(rs.next())
				{
					r=rs.getString(3);
					out.print("<option value="+r+">"+r);
				}
			%>
			</select>
		</td>   
	</tr>
</table>
<td><input type="submit" value="show"></td>
</form>
</center>
</div></div>
</body>
</html>

<%
}
catch(NullPointerException ne)
{
	response.sendRedirect("index.html");
}
%>