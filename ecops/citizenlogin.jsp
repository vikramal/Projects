<%@ page import="java.sql.*" %>

<%

	String username=request.getParameter("username_txt");
	String password=request.getParameter("password_txt");
	String temp="";
	String name="";
	String status="";
	
	Class.forName("com.mysql.jdbc.Driver").newInstance();

	Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");

	Statement st=con.createStatement();
	
	ResultSet rs=st.executeQuery("select * from citizenreg where username='"+username+"' and password='"+password+"'");

	while(rs.next())
	{
		status=rs.getString(16);
		temp=rs.getString(1);
		name=rs.getString(3);
	}
	
	
		if(temp.equals(""))
		{
			response.sendRedirect("citizenloginerror.html");
		}
		
		else if(status.equals("Not Approved"))
		{
			response.sendRedirect("citizenloginstatus.html");
		}


		else 
		{
			session.setAttribute("user",username);
			session.setAttribute("name",name);
			response.sendRedirect("citizenhome.jsp");
		}
%>