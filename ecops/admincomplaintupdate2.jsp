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
      <li><a href="adminhome.jsp">Admin Home</a></li>
	  <li><a href="admincompliantreport.jsp">View Citizen Compalint</a></li>
      <li id=current><a href="admincompliantupdate.jsp">Update Complaint Status</a></li>
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
<%@ page import="java.sql.*" %>
		<%
			String cid=request.getParameter("cid");
			String user="";
			String date1="";
			String psname="";
			String complaint="";
			String details="";
			
			Class.forName("com.mysql.jdbc.Driver").newInstance();
				Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
				Statement st=con.createStatement();
				ResultSet rs=st.executeQuery("select * from complaint where cid='"+cid+"'");
				while(rs.next())
				{
					user=rs.getString(1);
					date1=rs.getString(4);
					psname=rs.getString(5);
					complaint=rs.getString(6);
					details=rs.getString(7);
				}
		%>
<form name="admincomplaintreport" method="post" onsubmit="return validation(this);" action="admincomplaintupdate3.jsp">
<br>
<table>
	<center><h3><u>UPDATE COMPLAINT STATUS </u></h3></center>
	<tr>
	<td>Complaint ID</td> 
        <td><input type="text" name="cid_txt" value="<% out.print(cid); %>"></td>  
	</tr>
        
	<tr>
	<td>User Name</td> 
        <td><input type="text" name="username_txt" value="<%=user%>"></td>  
	</tr>
        <tr>
	<td>Date/Time of Complaint</td> 
        <td><input type="text" name="datetime_txt" value="<% out.print(date1); %>"></td>  
	</tr>
        <tr>
	<td>Area Police Station</td> 
        <td><input type="text" name="area_txt" value="<% out.print(psname); %>"></td>  
	</tr>
	<tr>
	<td>Type of Complaint</td> 
        <td><input type="text" name="type_txt" value="<% out.print(complaint); %>"></td>  
	</tr>
	<tr>
	<td>Details of Complaint</td> 
        <td><textarea name="details_txt" cols="50" rows="2"><% out.print(details);%></textarea></td>  
	</tr>
	<tr>
	<td>Complaint Status</td> 
	<td><select name="status_txt" style="width:215px;">
								
<option value="Verifying">Verifying the complaint
<option value="InProgress">Action in progress
<option value="Closed">Closed
<option value="Cancelled(No Proper Details)">No Proper Details
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