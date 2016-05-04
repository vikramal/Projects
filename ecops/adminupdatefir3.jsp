<%@ page import="java.sql.*" %>

<%
	String fir=request.getParameter("fir_txt");
	String status=request.getParameter("status_txt");
	
	Class.forName("com.mysql.jdbc.Driver").newInstance();

	Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");

	Statement st=con.createStatement();

	String sql="update fir set status='"+status+"' where firno='"+fir+"'";
	st.executeUpdate(sql);
	
	response.sendRedirect("adminupdatefir4.jsp");
%>