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
	<a href="filecom.jsp" style="color:blue">File Complaints</a>
	<td>&nbsp;
</div>
<a href="citizenlogin.html" style="color:blue">Logout</a>
<hr>

<form name="f" method="post" action="citizenviewcom2.jsp">
<table cellspacing="2" cellpadding="2" border="1" style="background-color:lightcyan" align="center" >
	<h3 style="text-align:center"><u>VIEW COMPLAINT STATUS</u></h3>
	<tr>
		<td><input type="radio" name="r" value="all" checked><font color="navy">All</font>
		<td>
	</tr>
	<tr>
		<td><input type="radio" name="r" value="id" ><font color="navy">Select Complaint Number</font>
		<td><select name="id">
		<%@ page import="java.sql.*"%>

	<%
		
		String user = String.valueOf(session.getAttribute("usn"));
		String id="";
		
		Class.forName("com.mysql.jdbc.Driver").newInstance();
		Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
		Statement st=con.createStatement();
		ResultSet rs=st.executeQuery("select * from complaint where username='"+user+"'");
		while(rs.next())
		{
			id=rs.getString(3);
			out.print("<option value="+id+">"+id);
		}
	%>
			</select>
	</tr>
	<tr>
		<td colspan="2" align="center"><input type="submit" name="s" value="Show">
	</tr>
	</table>
	
</form>
</body>
</html>	