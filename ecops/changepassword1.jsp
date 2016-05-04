<%@page import="java.sql.*"%>
<%
	String cp=request.getParameter("oldpassword_txt");
	String np=request.getParameter("newpassword_txt");
	String user = String.valueOf(session.getAttribute("user"));
	String temp="";
	
	Class.forName("com.mysql.jdbc.Driver").newInstance();
	
	Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
	
	Statement st= con.createStatement();
	
	ResultSet rs=st.executeQuery("select * from citizenreg where username='"+user+"' and password='"+cp+"'");
	
	while(rs.next())
		{
			temp=rs.getString(2);
		}
	if(temp.equals(""))
		{
			response.sendRedirect("changepassworderror.html");
		}
	else
		{
			Connection con1=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
	
			Statement st1= con1.createStatement();
			
			String sql="update citizenreg set password='"+np+"' where username='"+user+"'";
			
			st1.executeUpdate(sql);
			response.sendRedirect("changepassword2.html");
		}
%>
