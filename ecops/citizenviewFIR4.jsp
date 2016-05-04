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
</div>
	<a href="citizenlogin.html" style="color:blue">Logout</a>
<hr>

<form name="f" method="post" action="">
	<table cellspacing="2" cellpadding="2" border="1" style="background-color:lightcyan"  align="center" >
	<h3 style="text-align:center"><u>COMPLAINT STATUS :</u></h3>
	<tr>
		<td><font color="navy">FIR No. :</font>
		<td><font color="navy">Police station :</font>
		<td><font color="navy">Crime / Offence :</font>
		<td><font color="navy">Date of Crime :</font>
		<td><font color="navy">Date/Time of Complaint :</font>
		<td><font color="navy">Reason for Dealy in Complaint :</font>
		<td><font color="navy">Suspect :</font>
		<td><font color="navy">Name Of Complainant :</font>
		<td><font color="navy">Status:</font>
	</tr>
	<tr>
		<%@page import="java.sql.*"%>
	<%
		String f = String.valueOf(session.getAttribute("firnumber"));
		String ps="";
		String crime="";
		String date1="";
		String date2="";
		String reason="";
		String suspect="";
		String name="";
		String status="";
		
		Class.forName("com.mysql.jdbc.Driver").newInstance();
		Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
		Statement st=con.createStatement();
		ResultSet rs=st.executeQuery("select * from fir where firno='"+f+"'");
			while(rs.next())
			{
				ps=rs.getString(2);
				crime=rs.getString(3);
				date1=rs.getString(5);
				date2=rs.getString(6);
				reason=rs.getString(7);
				suspect=rs.getString(9);
				name=rs.getString(10);
				status=rs.getString(19);
				
				out.print("<tr>");
				out.print("<td>"+f);
				out.print("<td>"+ps);
				out.print("<td>"+crime);
				out.print("<td>"+date1);
				out.print("<td>"+date2);
				out.print("<td>"+reason);
				out.print("<td>"+suspect);
				out.print("<td>"+name);
				out.print("<td>"+status);
				out.print("</tr>");
			}
	%>
</table>
</form>
</body>
</html>
		