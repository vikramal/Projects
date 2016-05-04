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
	if(x.psarea.value=="")
	{
		alert("Enter the police station area");
		x.psarea.focus();
		return false;
	}
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

function disable()
{
	event.keyCode=0;
	document.f.psarea.focus();
}
</script>

<%@ page import="java.sql.*"%>
<%@ page import="java.util.Date"%>
<%
	Date d=new Date();
	String id="";
	int x;
	Class.forName("com.mysql.jdbc.Driver").newInstance();
	Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
	Statement st=con.createStatement();
	ResultSet rs=st.executeQuery("select * from psdetails");
	while(rs.next())
	{
		id=rs.getString(1);
	}
	if(id.equals(""))
	{
		x=01;
	}
	else
	{
		x=Integer.parseInt(id);
		x++;
	}
	id=""+x;
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
	<a href="adminviewps.jsp" style="color:blue">View Stations</a>
	<td>&nbsp;
	<a href="adminupdateps.jsp" style="color:blue">Update Station Details</a>
	<td>&nbsp;	
</div>
	<a href="citizenlogin.html" style="color:blue">Logout</a>
<hr>

<form name="f" method="post" action="adminaddps2.jsp" onsubmit="return validate(this)">
	<table cellspacing="2" cellpadding="2" border="1" style="background-color:lightcyan" align="center" width="40%" >
	<h3 style="text-align:center"><u>ADD POLICE STATION</u></h3>
	<tr>
		<td align="center"><font color="navy">Police Station ID :-</font></td>
        <td align="center"><INPUT type="text" name="psid" size="4" onfocus="disable();" value="<%=id%>"></td>
	</tr>
	<tr>
		<td align="center"><font color="navy">Police Station Area :-</font></td>
        <td align="center"><INPUT type="text" name="psarea" value='' maxlength="25" onkeypress="alphabets()"></td>
	</tr>
	<tr>
		<td align="center"><font color="navy">Police Station Zone :-</font></td>
        <td align="center"><select name="pszone">
								<option value="centralzone">Central Zone
								<option value="eastzone">East Zone
								<option value="northzone">North Zone
								<option value="southzone">South Zone
								<option value="westzone">West Zone
							</select>
	</tr>
	<tr>
		<td align="center"><font color="navy">Head Of the Station :-</font></td>
        <td align="center"><INPUT type="text" name="pshead" value='' maxlength="25" onkeypress="alphabets()"></td>
	</tr>
	<tr>
		<td align="center"><font color="navy">Contact Number :-</font></td>
        <td align="center"><INPUT type="text" name="psphone" value='' maxlength="10" onkeypress="numeric()"></td>
	</tr>
	<tr>
		<td align="center"><font color="navy">Address:-</font></td>
        <td align="center"><textarea  cols="20" rows="6" name="psadd"></textarea>
	</tr>
	<tr>
		<td align="center"><font color="navy">Date :</font></td>
		<td align="center"><input type="text" name="psdate" size="25" onfocus="disable();" value="<%=d%>">
	</tr>
	<tr>
		<td colspan="2" align="center">
		<input type="submit" name="s" value="ADD">
		<input type="reset" name="r" value="CLEAR">  
	</tr>
	</table>
</form>
</body>
</html>
