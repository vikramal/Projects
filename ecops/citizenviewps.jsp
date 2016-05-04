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
String a = String.valueOf(session.getAttribute("fname"));
if(a.equals("null"))
	{
		response.sendRedirect("citizenlogin.html");
	}
%>
Welcome <% out.print(a); %>
	<Div Align="center">
	<font size="+1">
	<a href="citizenhome.jsp" style="color:blue">Home</a>
	<td>&nbsp;
</div>
	<a href="citizenlogin.html" style="color:blue">Logout</a>
<hr>

<form name="f" method="post" action="">
	<table cellspacing="2" cellpadding="2" border="1" style="background-color:lightcyan" align="center" width="100%" >
	<h3 style="text-align:center"><u>VIEW POLICE STATION DETAILS</u></h3>
	<tr>
		<td align="center"><font color="navy">Station ID :-</font></td>
		<td align="center"><font color="navy">Station Area :-</font></td>
		<td align="center"><font color="navy">Station Zone :-</font></td>
		<td align="center"><font color="navy">Station Head :-</font></td>
		<td align="center"><font color="navy">Contact No. :-</font></td>
		<td align="center"><font color="navy">Station Address :-</font></td>
		<td align="center"><font color="navy">Date :-</font></td>
	</tr>
	<%@ page import="java.sql.*" %>
	<%
		String id = "";
		String area = "";
		String zone = "";
		String head = "";
		String contact = "";
		String address = "";
		String date = "";
		
		Class.forName("com.mysql.jdbc.Driver").newInstance();
		Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
		Statement st=con.createStatement();
		ResultSet rs=st.executeQuery("select * from psdetails");
		while(rs.next())
		{
			id=rs.getString(1);
			area=rs.getString(2);
			zone=rs.getString(3);
			head=rs.getString(4);
			contact=rs.getString(5);
			address=rs.getString(6);
			date=rs.getString(7);
			
			out.print("<tr>");
			out.print("<td>"+id);
			out.print("<td>"+area);
			out.print("<td>"+zone);
			out.print("<td>"+head);
			out.print("<td>"+contact);
			out.print("<td>"+address);
			out.print("<td>"+date);
		}
	%>
</table>
</form>
</body>
</html>
