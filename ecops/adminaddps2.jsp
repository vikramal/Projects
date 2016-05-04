<%@ page import="java.sql.*" %>
<%
	String id = request.getParameter("psid");
	String area = request.getParameter("psarea");
	String zone = request.getParameter("pszone");
	String head = request.getParameter("pshead");
	String contact = request.getParameter("psphone");
	String address = request.getParameter("psadd");
	String date = request.getParameter("psdate");
		
	Class.forName("com.mysql.jdbc.Driver").newInstance();
	
	Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
	
	Statement st=con.createStatement();
	
	String sql="insert into psdetails values('"+id+"','"+area+"','"+zone+"','"+head+"','"+contact+"','"+address+"','"+date+"')";
	
	st.executeUpdate(sql);
	
	response.sendRedirect("adminaddps3.jsp");
	
%>