<%@ page import="java.sql.*" %>

<%
	String fir=request.getParameter("fir_txt");
	
	Class.forName("com.mysql.jdbc.Driver").newInstance();

	Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");

	Statement st=con.createStatement();

	String sql="delete from fir where firno='"+fir+"'";
	st.executeUpdate(sql);
	
	response.sendRedirect("admindeletefir4.jsp");
%>