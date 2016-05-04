<%@ page import="java.sql.*" %>

<%

	String username=request.getParameter("username_txt");
	String password=request.getParameter("password_txt");

	String temp="";
	
	Class.forName("com.mysql.jdbc.Driver").newInstance();

	Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");

	Statement st=con.createStatement();
	
	ResultSet rs=st.executeQuery("select * from adminlogin where username='"+username+"' and password='"+password+"'");

	while(rs.next())
	{
		temp=rs.getString(1);
	}

	if(temp.equals(""))
	{
		response.sendRedirect("adminloginerror.html");
	}
	else
	{
		session.setAttribute("user",username);
		response.sendRedirect("adminhome.jsp");
	}
	
	
%>