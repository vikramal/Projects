<%@ page import="java.sql.*" %>

<%
	String user=request.getParameter("username_txt");
	String status=request.getParameter("status");
	
	Class.forName("com.mysql.jdbc.Driver").newInstance();
	
	if(status.equals("Cancel"))
	{
		Connection con1=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");

		Statement st1=con1.createStatement();

		String sql1="delete from citizenreg where username='"+user+"'";
		st1.executeUpdate(sql1);
		response.sendRedirect("adminhome.jsp");
	}
	else
	{
		Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");

		Statement st=con.createStatement();

		String sql="update citizenreg set status='"+status+"' where username='"+user+"'";
		st.executeUpdate(sql);
	
		response.sendRedirect("adminhome.jsp");
	}
%>