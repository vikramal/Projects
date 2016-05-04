<%@ page import="java.sql.*" %>

<%
	String pid=request.getParameter("id_txt");
		
	Class.forName("com.mysql.jdbc.Driver").newInstance();

	Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");

	Statement st=con.createStatement();

	String sql="delete from policestation where pid='"+pid+"'";
	st.executeUpdate(sql);
	
	response.sendRedirect("psdelete4.jsp");
%>