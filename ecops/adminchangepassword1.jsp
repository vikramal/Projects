<%@ page import="java.sql.*" %>

<%
	String old=request.getParameter("oldpassword_txt");
	String new1=request.getParameter("newpassword_txt");	
	String temp="";
	
	Class.forName("com.mysql.jdbc.Driver").newInstance();
		
	Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");

	Statement st=con.createStatement();
	
	ResultSet rs=st.executeQuery("select * from adminlogin where password='"+old+"'");
	
	while(rs.next())
	{
		temp=rs.getString(2);
	}
	
	if(temp.equals(""))
	{
		response.sendRedirect("adminchangepassworderror.html");
	}
	else
	{
		Connection con1=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
		Statement st1=con1.createStatement();
		String sql1="update adminlogin set password='"+new1+"' where password='"+old+"'";
		st1.executeUpdate(sql1);
		response.sendRedirect("adminchangepassword3.html");
	}
%>