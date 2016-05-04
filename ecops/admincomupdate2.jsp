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
	<a href="admincomreport.jsp" style="color:blue">View Complaints</a>
	<td>&nbsp;
</div>
	<a href="citizenlogin.html" style="color:blue">Logout</a>
<hr>
	
<script language="javascript">
function disable()
{
	event.keyCode=0;
	document.f.status.focus();
}
</script>
	
	<%@ page import="java.sql.*" %>
		<%
			String id=request.getParameter("id");
			String user="";
			String date="";
			String ps="";
			String typ="";
			String details="";
			
			Class.forName("com.mysql.jdbc.Driver").newInstance();
				Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
				Statement st=con.createStatement();
				ResultSet rs=st.executeQuery("select * from complaint where comid='"+id+"'");
				while(rs.next())
				{
					user=rs.getString(1);
					date=rs.getString(4);
					ps=rs.getString(5);
					typ=rs.getString(6);
					details=rs.getString(7);
				}
		%>
			
	<form name="f" method="post" action="admincomupdate3.jsp">
		<table cellspacing="2" cellpadding="2" border="1" style="background-color:lightcyan" align="center" >		
		<tr>
			<td align="center"><font color="navy">Complaint ID :</font></td>
			<td align="center"><input type="text" name="comid" onfocus="disable();" value="<% out.print(id); %>">
		</tr>
		<tr>
			<td align="center"><font color="navy">Username :</font></td>
			<td align="center"><input type="text" name="user" onfocus="disable();" value="<% out.print(user); %>">
		</tr>
		<tr>
			<td align="center"><font color="navy">Date/Time of Complaint :</font></td>
			<td align="center"><input type="text" name="date"  size="25" onfocus="disable();" value="<% out.print(date); %>">
		</tr>
		<tr>
			<td align="center"><font color="navy">Area Police Station :</font></td>
			<td align="center"><input type="text" name="ps" onfocus="disable();" value="<% out.print(ps); %>">
		</tr>
		<tr>
			<td align="center"><font color="navy">Type Of Complaint :</font></td>
			<td align="center"><input type="text" name="type" size="40" onfocus="disable();" value="<% out.print(typ); %>">
		</tr>
		<tr>
			<td align="center"><font color="navy">Details Of Complaint :</font></td>
			<td align="center"><input type="text" name="details" size="50" onfocus="disable();" value="<% out.print(details); %>">
		</tr>
		<tr>
			<td align="center"><font color="navy">Complaint Status :</font></td>
			<td align="center"><select name="status">
								<option value="Verifying">Verifying the complaint
								<option value="InProgress">Action in progress
								<option value="Closed">Closed
							</select>
		<tr>
			<td colspan="2" align="center">
			<input type="submit" name="s" value="UPDATE">
		</tr>
		
		</table>
	</form>
</body>
</html>