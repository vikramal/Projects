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
	if(x.cpass.value=="")
		{
			alert("Current Password cannot be left blank");
			x.cpass.focus();
			return false;
		}
	if(x.npass.value=="")
		{
			alert("New Password cannot be left blank");
			x.npass.focus();
			return false;
		}
		if(x.npass.value.length<6)
		{
			alert("Password should be atleast 6 characters long");
			x.npass.focus();
			return false;
		}
	return true;
}
</script>
	
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

<center>
	<h3 style="text-align:center">CHANGE PASSWORD</h3>
		<form name="changepass" method="POST" action="changepass2.jsp" onsubmit="return validate(this)">
			<table cellspacing="2" cellpadding="2" border="1" style="background-color:lightcyan" width="30%">
		<tr>
			<td align="center"><font color="navy">Current Password:-</font></td>
            <td align="center"><INPUT type="text" name="cpass" value='' maxlength="15"></td>
		</tr>
		<tr>
			<td align="center"><font color="navy">New Password:-</font></td>
			<td align="center"><input type="text" name="npass" value='' maxlength="15"/></td>
		</tr>
		 <tr>
			<td colspan="2" align="center">
			<input type="submit" name="s" value="Submit">
		</tr>	
			</table>
		</form>
</center>
</body>
</html>