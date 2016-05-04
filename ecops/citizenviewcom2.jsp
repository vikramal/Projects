<html>

<head>
<img src="bplogo.jpg" width="250" height="100" align="left">
<img src="bplogo2.jpg" width="250" height="100" align="right">
<h1 align="center"><b><u>BANGALORE POLICE</u></b></h1>
<h2 align="center"><u><i>e-COPS(e-Computerized Operations for Police Services)</i></u></h2>
<hr>
<title>Bangalore Police Organization</title>
</head>

<body background="pcb.jpg">
<%
String z = String.valueOf(session.getAttribute("fname"));
if(z.equals("null"))
	{
		response.sendRedirect("citizenlogin.html");
	}
%>
Welcome <% out.print(z); %>
	<Div Align="center">
	<font size="+1">
	<a href="citizenhome.jsp" style="color:blue">Home</a>
	<td>&nbsp;
	<a href="filecom.jsp" style="color:blue">File Complaints</a>
	<td>&nbsp;
</div>
	<a href="citizenlogin.html" style="color:blue">Logout</a>
<hr>

<form name="f" method="post" action="">
<table cellspacing="2" cellpadding="2" border="1" style="background-color:lightcyan"  align="center" >
	<h3 style="text-align:center"><u>COMPLAINT STATUS :</u></h3>
	<tr>
		<td><font color="navy">Username :</font>
		<td><font color="navy">Name Of Complainant :</font>
		<td><font color="navy">Complaint ID :</font>
		<td><font color="navy">Date/Time of Complaint :</font>
		<td><font color="navy">Area Police Station :</font>
		<td><font color="navy">Type Of Complaint :</font>
		<td><font color="navy">Details :</font>
		<td><font color="navy">Status:</font>
	<tr>
	<%@page import="java.sql.*"%>
	<%
		String a=String.valueOf(session.getAttribute("usn"));
		String user="";
		String name="";
		String comid="";
		String date="";
		String ps="";
		String typ="";
		String details="";
		String status="";
		String r=request.getParameter("r");
		
		Class.forName("com.mysql.jdbc.Driver").newInstance();
		if(r.equals("all"))
		{
			Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
			Statement st=con.createStatement();
			ResultSet rs=st.executeQuery("select * from complaint where username='"+a+"'");
			while(rs.next())
			{
				user=rs.getString(1);
				name=rs.getString(2);
				comid=rs.getString(3);
				date=rs.getString(4);
				ps=rs.getString(5);
				typ=rs.getString(6);
				details=rs.getString(7);
				status=rs.getString(8);
				
				out.print("<tr>");
				out.print("<td>"+user);
				out.print("<td>"+name);
				out.print("<td>"+comid);
				out.print("<td>"+date);
				out.print("<td>"+ps);
				out.print("<td>"+typ);
				out.print("<td>"+details);
				out.print("<td>"+status);
				out.print("</tr>");
			}
		}
		
		else
		{
			String s=request.getParameter("id");
			Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
			Statement st=con.createStatement();
			ResultSet rs=st.executeQuery("select * from complaint where comid='"+s+"'");
			while(rs.next())
			{
				user=rs.getString(1);
				name=rs.getString(2);
				comid=rs.getString(3);
				date=rs.getString(4);
				ps=rs.getString(5);
				typ=rs.getString(6);
				details=rs.getString(7);
				status=rs.getString(8);
				
				out.print("<tr>");
				out.print("<td>"+user);
				out.print("<td>"+name);
				out.print("<td>"+comid);
				out.print("<td>"+date);
				out.print("<td>"+ps);
				out.print("<td>"+typ);
				out.print("<td>"+details);
				out.print("<td>"+status);
				out.print("</tr>");
			}
		}
	%>
</table>
</form>
</body>
</html>