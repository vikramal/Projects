<%@ page import="java.sql.*" %>

<%
	String cid=request.getParameter("cid_txt");
	String status=request.getParameter("status_txt");
	
	Class.forName("com.mysql.jdbc.Driver").newInstance();

	Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");

	Statement st=con.createStatement();

	String sql="update complaint set status='"+status+"' where cid='"+cid+"'";
	st.executeUpdate(sql);
	
	response.sendRedirect("admincomplaintupdate4.jsp");
%>