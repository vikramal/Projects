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
	if(x.firno.value=="")
	{
		x.firno.focus();
		return false;
	}
	if(x.firno.value.length<6)
	{
		alert("Incorrect FIR NO. , Try Again...");
		x.firno.focus();
		return false;
	}
	if(x.name.value=="")
	{
		alert("Enter your name");
		x.name.focus();
		return false;
	}
return true;
}
</script>

<%@ page import="java.sql.*"%>
	<%
	String user = String.valueOf(session.getAttribute("usn"));
	String name = String.valueOf(session.getAttribute("fname"));
	if(name.equals("null"))
	{
		response.sendRedirect("citizenlogin.html");
	}
%>

<body background="pcb.jpg">
Welcome <%out.print(name);%>

<Div Align="center">
	<font size="+1">
	<a href="citizenhome.jsp" style="color:blue">Home</a>
	<td>&nbsp;
</div>
	<a href="citizenlogin.html" style="color:blue">Logout</a>
<hr>

<form name="f" method="post" action="citizenviewFIR2.jsp" onsubmit="return validate(this)">
	
	<table cellspacing="2" cellpadding="2" border="1" style="background-color:lightcyan" width="45%" align="center" >
	<h3 style="text-align:center"><u>VIEW FIR STATUS</u></h3>
	<h3 style="text-align:center"><b><font color="red">FIR number and Name do not match. TRY AGAIN !!</u></h3>
		<td align="center"><font color="navy"> Enter your FIR No. :-</font></td>
		<td align="center"><input type="text" name="firno" size="8" maxlength="8">
	<tr>
		<td align="center"><font color="navy"> Enter your NAME :-</font></td>
		<td align="center"><input type="text" name="name" size="30">
	</tr>
	<tr>
		<td colspan="2" align="center">
		<input type="submit" name="s" value="Submit">
		<input type="reset" name="r" value="Clear">
	</tr>					
	</table>
			
</form>
</body>
</html>		