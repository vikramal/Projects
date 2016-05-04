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

	<Div Align="center">
	<font size="+1">
	<a href="adminhome.jsp" style="color:blue">Home</a>
	<td>&nbsp;
	<a href="adminaddps.jsp" style="color:blue">Add Station</a>
	<td>&nbsp;
	<a href="adminviewps.jsp" style="color:blue">View Stations</a>
	<td>&nbsp;
</div>
	<a href="citizenlogin.html" style="color:blue">Logout</a>
<hr>

<form name="f" method="post" action="adminupdateps2.jsp">
<table cellspacing="2" cellpadding="2" border="1" style="background-color:lightcyan" width="50%" align="center" >
	<h3 style="text-align:center"><u>UPDATE POLICE STATION INFO. :</u></h3>
	<h3 style="text-align:center"><b><font color="red">Police Station Info. Successfully Updated...!!!</font></b></h3>
	<td align="center"><font color="navy">Select Police Station :</font></td>
	<td align="center"><select name="psname">
	<%@ page import="java.sql.*" %>
			<%
				String r="";
				Class.forName("com.mysql.jdbc.Driver").newInstance();
				Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
				Statement st=con.createStatement();
				ResultSet rs=st.executeQuery("select * from psdetails");
				while(rs.next())
				{
					r=rs.getString(2);
					out.print("<option value="+r+">"+r);
				}
			%>
			</select>
		<tr>
		<td colspan="2" align="center">
			<input type="submit" name="s" value="SHOW">
	</tr>
</table>
</form>
</body>
</html>	