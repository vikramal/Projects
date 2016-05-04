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
String a = String.valueOf(session.getAttribute("admin"));
if(a.equals("null"))
	{
		response.sendRedirect("adminlogin.html");
	}
%>
Welcome <% out.print(a); %>

	<Div Align=center>
	<font size="+1">
	<a href="adminhome.jsp" style="color:blue">Home</a>
	<td>&nbsp;
	<a href="admincomupdate.jsp" style="color:blue">Update Complaint Status</a>
	<td> &nbsp;
	</div>
	<a href="citizenlogin.html" style="color:blue">Logout</a>
<hr>

<form name="f" method="post" action="admincomreport2.jsp">
<table cellspacing="2" cellpadding="2" border="1" style="background-color:lightcyan" width="100%" align="center" >
	<h3 style="text-align:center"><u>COMPLAINT REPORT</u></h3>
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
			ResultSet rs=st.executeQuery("select * from complaint");
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
			String s=request.getParameter("psname");
			out.print(s);
			Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
			Statement st=con.createStatement();
			ResultSet rs=st.executeQuery("select * from complaint where ps='"+s+"'");
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