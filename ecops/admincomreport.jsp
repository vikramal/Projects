<html>

<head>
<img src="bplogo.jpg" width="250" height="100" align="left">
<img src="bplogo2.jpg" width="250" height="100" align="right">
<h1 align="center"><b><u>BANGALORE POLICE</u></b></h1>
<h2 align="center"><u><i>e-COPS(e-Computerized Operations for Police Services)</i></u></h2>
<hr>
<title>Bangalore Police Organization</title>
</head>
<%
String user = String.valueOf(session.getAttribute("usn"));
%>

<body background="pcb.jpg">
<%
String a = String.valueOf(session.getAttribute("admin"));
if(a.equals("null"))
	{
		response.sendRedirect("adminlogin.html");
	}
%>
Welcome <% out.print(a); %>

	<Div Align="center">
	<font size="+1">
	<a href="adminhome.jsp" style="color:blue">Home</a>
	<td>&nbsp;	
	<a href="admincomupdate.jsp" style="color:blue">Update Complaint Status</a>
	<td> &nbsp;
</div>
	<a href="citizenlogin.html" style="color:blue">Logout</a>
<hr>

<form name="f" method="post" action="admincomreport2.jsp">
<table cellspacing="2" cellpadding="2" border="1" style="background-color:lightcyan" width="45%" align="center" >
	<h3 style="text-align:center"><u>COMPLAINT REPORT</u></h3>
	<tr>
		<td><input type="radio" name="r" value="all" checked><font color="navy">All Complaints</font>
		<td>
	</tr>
	<tr>
		<td><input type="radio" name="r" value="ps" ><font color="navy">Select Police Station</font>
		<td><select name="psname">
				<%@page import="java.sql.*"%>
				<%
					String x="";
					Class.forName("com.mysql.jdbc.Driver").newInstance();
					Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
					Statement st=con.createStatement();
					ResultSet rs=st.executeQuery("select distinct(ps) from complaint");
					while(rs.next())
					{
						x=rs.getString(1);
						out.print("<option value="+x+">"+x);
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