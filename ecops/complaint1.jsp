<%@ page import="java.sql.*" %>
<%
String x=(String) session.getAttribute("user");

String y=(String) session.getAttribute("name");
%>
<%

	
	String id=request.getParameter("id_txt");
	String date=request.getParameter("date_txt");
	String area=request.getParameter("area_txt");
	String com=request.getParameter("complaint_txt");
	String det=request.getParameter("details_txt");
	String add=request.getParameter("address_txt");
	String status="Not Checked";

	Class.forName("com.mysql.jdbc.Driver").newInstance();
		
	Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");

	Statement st=con.createStatement();

	String sql="insert into complaint values('"+x+"','"+y+"','"+id+"','"+date+"','"+area+"','"+com+"','"+det+"','"+add+"','"+status+"')";

	st.executeUpdate(sql);
	response.sendRedirect("complaint2.jsp");
 %>