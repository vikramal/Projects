<%@ page import="java.sql.*" %>

<%

	String pid=request.getParameter("id_txt");
	String area=request.getParameter("area_txt");
	String zone=request.getParameter("zone_txt");
	String head=request.getParameter("head_txt");
	String contactnum=request.getParameter("contactnum_txt");
	String address=request.getParameter("address_txt");	

	String x="";
	
	Class.forName("com.mysql.jdbc.Driver").newInstance();

	Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");

	Statement st=con.createStatement();

	ResultSet rs=st.executeQuery("select * from policestation where pid='"+pid+"'");

	while(rs.next())
	{
		x=rs.getString(1);
	}

	if(x.equals(""))
	{
		
		String sql="insert into policestation values('"+pid+"','"+area+"','"+zone+"','"+head+"','"+contactnum+"','"+address+"')";

		st.executeUpdate(sql);

		response.sendRedirect("addpolicestation3.jsp");
	}
	else
	{
		response.sendRedirect("addpolicestationerror.html");
	}

%>