<%@page import="java.sql.*"%>
<%
	String cp=request.getParameter("cpass");
	String np=request.getParameter("npass");
	String user = String.valueOf(session.getAttribute("usn"));
	String temp="";
	
	Class.forName("com.mysql.jdbc.Driver").newInstance();
	
	Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
	
	Statement st= con.createStatement();
	
	ResultSet rs=st.executeQuery("select * from citizendet where username='"+user+"' and password='"+cp+"'");
	
	while(rs.next())
		{
			temp=rs.getString(2);
		}
	if(temp.equals(""))
		{
			response.sendRedirect("changepasserror.jsp");
		}
	else
		{
			Connection con1=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
	
			Statement st1= con1.createStatement();
			
			String sql="update citizendet set password='"+np+"' where username='"+user+"'";
			
			st1.executeUpdate(sql);
			response.sendRedirect("citizenhome.jsp");
					}
%>
