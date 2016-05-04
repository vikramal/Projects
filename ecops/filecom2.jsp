<%@ page import="java.sql.*" %>
<%
	String user = String.valueOf(session.getAttribute("usn"));
	String name = String.valueOf(session.getAttribute("fname"));
	String id = request.getParameter("id");
	String date=request.getParameter("date");
	String ps = request.getParameter("ps");
	String typ = request.getParameter("type");
	String details = request.getParameter("details");
	String status="Not Checked";
		
	Class.forName("com.mysql.jdbc.Driver").newInstance();
	
	Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
	
	Statement st=con.createStatement();
	
	String sql="insert into complaint values('"+user+"','"+name+"','"+id+"','"+date+"','"+ps+"','"+typ+"','"+details+"','"+status+"')";
	
	st.executeUpdate(sql);
	
	response.sendRedirect("filecom3.jsp");
	
%>