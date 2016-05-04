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
	<a href="citizenviewps.jsp" style="color:blue">ViewStations</a>
	<td> &nbsp;
	<a href="" style="color:blue">FIRStatus</a>
	<td> &nbsp;
	<a href="filecom.jsp" style="color:blue">Complaints</a>
	<td> &nbsp;
	<a href="changepass.jsp" style="color:blue">ChangePassword</a>
	<td> &nbsp;
</div>
	<a href="citizenlogin.html" style="color:blue">Logout</a>
<hr>

<table width="20%" align="left">
<marquee direction="down" height="430" scrolldelay="100">
	
	&nbsp;<img src="p1.jpg" width="150" height="80"><br>
	<font face="italic" color="red" size="2"><strong>&nbsp;Friendly Counsellings</strong></font>
        <br><br>

        &nbsp;<img src="p2.jpg" width="150" height="80">
	<br>
        <font face="italic" color="red" size="2"><strong>&nbsp;Guards For Public</strong></font>
	<br><br>

        &nbsp;<img src="p3.jpg" width="150" height="80">
	<br>
        <font face="italic" color="red" size="2"><strong>&nbsp;e-COPS</strong></font>
	<br><br>

        &nbsp;<img src="p4.jpg" width="150" height="80">
	<br>
	<font face="italic" color="red" size="2"><strong>&nbsp;Lady Police Advancing</strong></font>
	<br><br>

        &nbsp;<img src="p5.jpg" width="150" height="80">
	<br>
        <font face="italic" color="red" size="2"><strong>&nbsp;Temple Of Security</strong></font>
</marquee>
</table> 



<table width="55%" align="centre">
	<tr>
		<td width="85%"><strong><u><font color="red">REMEMBER PLEASE:- </u></font></strong> 
			 <p align="justify"><font color="navy"> <strong>We as a team are constantly 
              working towards building a deep sense of trust in the Police Force 
              hence, instill a deep sense of security in the public. In our endeavour 
              to continuously strengthen public-police relations we are now taking 
              advantage of the interactive feature of the Internet. This medium 
              offers a two-way relationship between the information-givers and 
              receivers and this is precicely what we intend to capitalize on 
              in keeping up with our police motto-"<FONT COLOR="red">With You, For You, Always...</FONT>".</strong> </font></p><br>
	<tr>
         <td width="85%"><strong><u><font color="red">VISION:-</u></font></strong> 
            <p align="justify"><font color="navy"> <strong>To provide high quality 
              and transparent policing that satisfies the aspirations of people 
              and the society at large and helps in creating and maintaining a 
              State in which there is peace, co-existence and order so as to provide 
              a conducive environment for sustained prosperity.</strong> </font></p><br>
	<tr>
		<td width="85%"><strong><u><font color="red">MISSION:- </u></font></strong>
            <p align="justify"><font color="navy"> <strong>To transform and improve 
              on a sustained basis the Police Organization by providing an environment 
              and leadership that optimizes and sustains the development and utilization 
              of knowledge, skills and attitudes of the department by effective 
              use of all resources thus bringing about quantified professional 
              excellence and public confidence. An attempt to build a podium wherefrom 
              the Police and Public can work together in unison.</strong> </font></p><br>
</table>
</body>
</html>	