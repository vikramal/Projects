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
	
<script language="javascript">

function disable()
{
	event.keyCode=0;
	document.f.pshead.focus();
}

function validate(x)
{
	if(x.pshead.value=="")
	{
		alert("Enter the name of the Head of Police Station");
		x.pshead.focus();
		return false;
	}
	if(x.psadd.value=="")
	{
		alert("Address cannot be left blank");
		x.psadd.focus();
		return false;
	}
	if(x.psphone.value=="")
	{
		alert("Contact No. cannot be left blank");
		x.psphone.focus();
		return false;
	}
	if(x.psphone.value.length<10)
	{
		alert("Incorrect Contact No.")
		x.psphone.focus();
		return false;
	}
	return true;
}

function numeric()
{
	if(!((event.keyCode>=48)&&(event.keyCode<=57)))
	{
		alert("Enter only numbers");
		event.keyCode=0;
	}
}

function alphabets()
{
	if(!(((event.keyCode>65)&&(event.keyCode<=91))||((event.keyCode>=97)&&(event.keyCode<=122))||(event.keyCode==32)))
	{
		alert("Numbers & Special characters not allowed");
		event.keyCode=0;
	}
	
}
</script>

<%@ page import="java.sql.*" %>
<%@ page import="java.util.Date"%>
		<%
			String id="";
			String area=request.getParameter("psname");
			String zone="";
			String head="";
			String contact="";
			String address="";
			Date d=new Date();
			
			Class.forName("com.mysql.jdbc.Driver").newInstance();
				Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
				Statement st=con.createStatement();
				ResultSet rs=st.executeQuery("select * from psdetails where area='"+area+"'");
				while(rs.next())
				{
					id=rs.getString(1);
					zone=rs.getString(3);
					head=rs.getString(4);
					contact=rs.getString(5);
					address=rs.getString(6);
					
				}
		%>
		
<form name="f" method="post" action="adminupdateps3.jsp" onsubmit="return validate(this)">
		<table cellspacing="2" cellpadding="2" border="1" style="background-color:lightcyan" align="center" >		
		<tr>
			<td align="center"><font color="navy">Police Station ID :</font></td>
			<td align="center"><input type="text" name="psid" onfocus="disable();" value="<% out.print(id); %>">
		</tr>
		<tr>
			<td align="center"><font color="navy">Area :</font></td>
			<td align="center"><input type="text" name="psarea" onfocus="disable();" value="<% out.print(area); %>">
		</tr>
		<tr>
			<td align="center"><font color="navy">Zone :</font></td>
			<td align="center"><input type="text" name="pszone"  size="25" onfocus="disable();" value="<% out.print(zone); %>">
		</tr>
		<tr>
			<td align="center"><font color="navy">Head :</font></td>
			<td align="center"><input type="text" name="pshead" onkeypress="alphabets()" value="<% out.print(head); %>">
		</tr>
		<tr>
			<td align="center"><font color="navy">Contact :</font></td>
			<td align="center"><input type="text" name="psphone" maxlength="10" onkeypress="numeric()" value="<% out.print(contact); %>">
		</tr>
		<tr>
			<td align="center"><font color="navy">Address :</font></td>
			<td align="center"><input type="text" name="psadd" size="50" value="<% out.print(address); %>">
		</tr>
		<tr>
			<td align="center"><font color="navy">Date :</font></td>
			<td align="center"><input type="text" name="psdate" size="25" onfocus="disable();" value="<%=d%>">
		<tr>
			<td colspan="2" align="center">
			<input type="submit" name="s" value="UPDATE">
		</tr>
		
		</table>
	</form>
</body>
</html>