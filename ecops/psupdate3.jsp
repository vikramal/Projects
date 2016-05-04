<%@ page import="java.sql.*" %>

<%
	String pid=request.getParameter("id_txt");
	String area=request.getParameter("area_txt");
	String zone=request.getParameter("zone_txt");
	String head=request.getParameter("head_txt");
	String contactnum=request.getParameter("contactnum_txt");
	String address=request.getParameter("address_txt");
	
	Class.forName("com.mysql.jdbc.Driver").newInstance();

	Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");

	Statement st=con.createStatement();

	String sql="update policestation set area='"+area+"', zone='"+zone+"', head='"+head+"', contactnum='"+contactnum+"', address='"+address+"' where pid='"+pid+"'";
	st.executeUpdate(sql);
	
	response.sendRedirect("psupdate4.jsp");
%>