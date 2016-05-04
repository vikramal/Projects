<%@ page import="java.sql.*" %>
<%  
  
  String user = (String) session.getAttribute("un");
	String filename="";
	
	Class.forName("com.mysql.jdbc.Driver").newInstance();

	Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
	Statement st=con.createStatement();

	ResultSet rs=st.executeQuery("select * from citizenreg where username='"+user+"'");

	while(rs.next())
	{
		filename=rs.getString(15);
	}

	String filepath = "C:\\apache-tomcat-4.1.36\\webapps\\ROOT\\ecops\\uploads\\"; 
	response.setContentType("APPLICATION/OCTET-STREAM"); 
	response.setHeader("Content-Disposition","attachment; filename=\"" + filename + "\""); 

  java.io.FileInputStream fileInputStream = new java.io.FileInputStream(filepath + filename);
		  
  int i; 
  while ((i=fileInputStream.read()) != -1) 
  {
    out.write(i); 
  } 
  fileInputStream.close(); 
%> 