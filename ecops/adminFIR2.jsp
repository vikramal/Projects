<%@ page import="java.sql.*" %>
<%
	
	String firno = request.getParameter("fir");
	String ps=request.getParameter("area_txt");
	String crime = request.getParameter("crime_txt");
	String act = request.getParameter("act_txt");
	String date1 = request.getParameter("date_txt");
	String date2 = request.getParameter("date1_txt");
	String delay = request.getParameter("reason_txt");
	String add1 = request.getParameter("address_txt");
	String suspect = request.getParameter("suspect_txt");
	String name = request.getParameter("name_txt");
	String fname = request.getParameter("fname_txt");
	String dob = request.getParameter("dob_txt");
	String nation = request.getParameter("national_txt");
	String idproof = request.getParameter("id_txt");
	String id = request.getParameter("proof_txt");
	String contact = request.getParameter("cno_txt");
	String add2 = request.getParameter("add_txt");
	String status="FIR Lodged";
		
	Class.forName("com.mysql.jdbc.Driver").newInstance();
	
	Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
	
	Statement st=con.createStatement();
	
	String sql="insert into fir values('"+firno+"','"+ps+"','"+crime+"','"+act+"','"+date1+"','"+date2+"','"+delay+"','"+add1+"','"+suspect+"','"+name+"','"+fname+"','"+dob+"','"+nation+"','"+idproof+"','"+id+"','"+contact+"','"+add2+"','"+status+"')";
	
	st.executeUpdate(sql);
	
	response.sendRedirect("adminfir3.jsp");
	
%>