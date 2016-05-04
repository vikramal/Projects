<%@ page import="java.sql.*" %>

<%

	        String id=request.getParameter("firno");
			String psname="";
			String crime="";
			String date1="";
			String date2="";
			String reason="";
			String suspect="";
			String name="";

	Class.forName("com.mysql.jdbc.Driver").newInstance();

	Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");

	Statement st=con.createStatement();
	
	ResultSet rs=st.executeQuery("select * from fir where firno='"+id+"'");
	while(rs.next())
	{
		            id=rs.getString(1);
					psname=rs.getString(2);
					crime=rs.getString(3);
					date1=rs.getString(5);
					date2=rs.getString(6);
					reason=rs.getString(7);
					suspect=rs.getString(9);
					name=rs.getString(10);
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
     </div>
      <div class="sidebox">
      </div>
</div>
<br>
<br>
<div class="box">
<center>
<form name="complaint" method="post" action="admindeletefir3.jsp" onSubmit="return valid(this);">
<input type="hidden" name="fir">
<br>
<h1><img src="images\cp.png">Delete FIR (First Information Report)</h1>
<table>
<tr>
<td><center>FIR Number</center></td><br>
<td><center><input type="text" name="fir_txt" value="<%=id%>">
</tr>
<tr>
<td><center>Police Station</center></td>
<td><center><input type="text" name="station_txt" value="<%=psname%>">
</tr>
<tr>
<td><center>Crime/Offence</center></td>
<td><center><textarea name="crime_txt" cols="46" rows="1"><%=crime%></textarea>
</tr>
<tr>
<td><center>Date of Offence </center></td>
<td><center><input type="text" name="date1_txt" value="<%=date1%>">
</select>
</tr>
<tr>
<td><center>Date of fir</center></td>
<td><center><input type="text" name="date2_txt" value="<%=date2%>">
</tr>
<tr>
<td><center>Reason of Delay</center></td>
<td><center><input type="text" name="reason_txt" value="<%=reason%>">
</tr>
<tr>
<td><center>Suspect</center></td>
<td><center><textarea name="suspect_txt" cols="46" rows="1"><%=suspect%></textarea>
</tr>
<tr>
<td><center>Name of Complaint/Informant :</center></td>
<td><center><input type="text" name="name_txt" value="<%=name%>">
</tr>

<tr>
<td><center>Fir Status</center></td>
<td align="center"><select name="status_txt" style="width:59%;">
<option value="Verifying">Verifying the complaint
<option value="ChargesheetPrepared">Chargesheet Prepared
<option value="WarrantIssued">Warrant Issued
<option value="FIRClosed">FIR CLOSED
</select></td>
</tr>
</table>
<input type="submit" name="submit" value="Delete">
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