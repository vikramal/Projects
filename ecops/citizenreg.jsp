<%@ page import="java.sql.*" %>

<%

	String us=request.getParameter("username_txt");
	String pswd=request.getParameter("password_txt");	
	String name=request.getParameter("name_txt");
	String gender=request.getParameter("gender_rdo");
	String fname=request.getParameter("fathername_txt");
	String add=request.getParameter("address_txt");
	String land=request.getParameter("landmark_txt");
	String city=request.getParameter("city_txt");
	String pin=request.getParameter("pincode_txt");
	String national=request.getParameter("nationality_txt");
	String dob=request.getParameter("dateofbirth_txt");
	String mob=request.getParameter("mobilenum_txt");
	String phone=request.getParameter("landlinenum_txt");
	String email=request.getParameter("email_txt");
	String updoc="0";
	String temp="";

	Class.forName("com.mysql.jdbc.Driver").newInstance();
	Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
	Statement st=con.createStatement();
	ResultSet rs=st.executeQuery("select * from citizenreg where username='"+us+"'");
	while(rs.next())
	{
		temp=rs.getString(1);
	}
	if(temp.equals(""))
	{
		Connection con1=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
		Statement st1=con1.createStatement();
		String sql="insert into citizenreg values('"+us+"','"+pswd+"','"+name+"','"+gender+"','"+fname+"','"+add+"','"+land+"','"+city+"','"+pin+"','"+national+"','"+dob+"','"+mob+"','"+phone+"','"+email+"','"+updoc+"','Not Approved')";
		st.executeUpdate(sql);
		session.setAttribute("un",us);
		response.sendRedirect("citizenup.html");
	}
	else
	{
		response.sendRedirect("citizenregerror.html");
	}
%>