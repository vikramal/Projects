<html>

<head>
<img src="bplogo.jpg" width="250" height="100" align="left">
<img src="bplogo2.jpg" width="250" height="100" align="right">
<h1 align="center"><b><u>BANGALORE POLICE</u></b></h1>
<h2 align="center"><u><i>e-COPS(e-Computerized Operations for Police Services)</i></u></h2>
<hr>
<title>Bangalore Police Organization</title>
</head>

<script language="javascript">
function validate(x)
{
	if(x.details.value=="")
	{
		alert("Enter the details");
		x.details.focus();
		return false;
	}
	return true;
}

function disable()
{
	event.keyCode=0;
	document.f.ps.focus();
}
</script>

<%@ page import="java.sql.*"%>
<%@ page import="java.util.Date"%>
<%
	Date d=new Date();
	String user = String.valueOf(session.getAttribute("usn"));
	String name = String.valueOf(session.getAttribute("fname"));
	if(name.equals("null"))
	{
		response.sendRedirect("citizenlogin.html");
	}
	String id="";
	int x;
	Class.forName("com.mysql.jdbc.Driver").newInstance();
	Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
	Statement st=con.createStatement();
	ResultSet rs=st.executeQuery("select * from complaint");
	while(rs.next())
	{
		id=rs.getString(3);
	}
	if(id.equals(""))
	{
		x=100;
	}
	else
	{
		x=Integer.parseInt(id);
		x++;
	}
	id=""+x;
%>

<body background="pcb.jpg">
Welcome <%out.print(name);%>

<Div Align="center">
	<font size="+1">
	<a href="citizenhome.jsp" style="color:blue">Home</a>
	<td>&nbsp;
	<a href="citizenviewcom.jsp" style="color:blue">ViewComplaintStatus</a>
	<td> &nbsp;
</div>
	<a href="citizenlogin.html" style="color:blue">Logout</a>
<hr>

<form name="f" method="post" action="filecom2.jsp" onsubmit="return validate(this)">
	
	<table cellspacing="2" cellpadding="2" border="1" style="background-color:lightcyan" width="45%" align="center" >
	<h3 style="text-align:center"><u>COMPLAINT FORM</u></h3>		
	<h3 style="text-align:center"><b><font color="red">Complaint was Successfully Registered. Thank You for your cooperation.</u></h3>
		<td align="center"><font color="navy">Complaint ID :</font></td>
		<td align="center"><input type="text" name="id" size="4" onfocus="disable();" value="<%=id%>">
	<tr>
		<td align="center"><font color="navy">Date/Time of Complaint :</font></td>
		<td align="center"><input type="text" name="date" onfocus="disable();" value="<%=d%>" size="25">
	</tr>
	<tr>
		<td align="center"><font color="navy">Area Police Station :</font></td>
		<td align="center"><select name="ps">
			<%@page import="java.sql.*"%>
				<%
					String y="";
					Class.forName("com.mysql.jdbc.Driver").newInstance();
					Connection con1=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
					Statement st1=con1.createStatement();
					ResultSet rs1=st1.executeQuery("select * from psdetails");
					while(rs1.next())
					{
						y=rs1.getString(2);
						out.print("<option value="+y+">"+y);
					}
				%>
						</select>
	</tr>
	<tr>
		<td align="center"><font color="navy">Complaint / Information / Feedback :</font></td>
		<td align="center"><select name="type">
								<option value="faced problem at police station">Faced some problem at Police Station ?
								<option value="complaint">Complain against a Police Officer/Man
								<option value="information about minor crime">Information about Minor Crime
								<option value="feedback">Feedback
								<option value="miscellaneous">Miscellaneous
							</select>
	</tr>
	<tr>
		<td align="center"><font color="navy">Details / Description :</font></td>
		<td align="center"><textarea  cols="20" rows="6" name="details"></textarea>
	</tr>
		<tr>
		<td colspan="2" align="center">
			<input type="submit" name="s" value="Submit">
	</tr>					
	</table>
			
</form>
</body>
</html>	