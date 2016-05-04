<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en">
<head>
<link rel="stylesheet" href="images/BluePigment.css" type="text/css" />
<title>E-cops (E-Computerized Operations for Police Services)</title>
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
    <marquee allign="middle" behaviour="slide" direction="left"><h3>Welcome to E - Cops (E-Computerized Operations for Police Services).</h3></marquee>
    <p><align=left><img src="images\2.gif"></align></p>
    <h1 id="logo-text"><a href="index.html" title=""><align=center>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp E - <span> Cops</span></align></a></h1>
    <h3 id="slogan">&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp A Computised operations of Police Services.</h3>
    <div id="header-links">
      <p> <img src="images\logo.jpg" </p>
    </div>
  </div>
</div>
<!-- navigation starts here -->


<div id="nav-wrap">
  <div id="nav">
    <ul>
      <li id="current"><a href="citizenhome.html">Citizen Home</a></li>
      <li><a href="citizenviewstation.jsp">View Stations</a></li>
      <li><a href="citizenviewfir.jsp">FIR status</a></li>
      <li><a href="complaint.jsp">Complaint</a></li>
      <li><a href="changepassword.html">Change Password</a></li>
	  <li><a href="contact.html">Contact</a></li>
	  <li><a href="index.html">Log Out</a></li>    </ul>
  </div>
</div>
  <!-- footer ends-->
<div id="content-wrap">
<h1 align="left">Welcome <font color="darkblue"><%=x%></font>....!!</align></h1>
  <div id="content">
    <div id="sidebar">
      <div class="sidebox">
      </div>
</div>
<br>
<br>
<div class="box">
<h1><b>NATIONAL RECOGNITION FOR E - COPS</h1>
<p>E -Cops has achieved another milestone by bagging the National Award for exemlary E- Governance initiative of Government of Andra Pradesh.
The Award was presenter by the Honourable Deputy Prime Minister of India on 13th November 2003 at the inagural session of 7th National Conference of E- Goverence at Chennai.
Andra Pradesh state has bagged 8 of 36 awards announced. Sri S.V. Ramana Murthy, I.P.S , Inspector General of Police, Police Computer services was awarded this Prestigious Award for Conceptualizing,
developing and implementing E- Cops, an E- Goverence Initiative on behalf of Andra Pradesh Police. Sri. S.V Ramana Murthy, I.P.S, Inspector General of Police, Police Computer Services received this
award on 13th November from the hands of Honourable Deputy Prime Minister of India in the presence of Honourable Cheif Minister of Tamil Nadu. These awards were institued by the Government of India
by the department of Administrative Reforms and Public Grievances. This is annual award was instituted for the first time for exemplary E -Goverence Initiative(Project).</p>
<br>
<br>
<h1>Application Description</h1>
<p><b>E - Cops is intended to provide total computerised information system support for the work of police.
Its primary activities are not Transparency-related, but help provide police officers with information on criminal cases and on criminals.
E - Cops would also help provide heads and senior officers with management information about crime control, and about administration and support services such as accounting and personal management.</b></p>
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