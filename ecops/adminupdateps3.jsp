<%@ page import="java.sql.*" %>
	<%
		String name=request.getParameter("psarea");
		String head=request.getParameter("pshead");
		String contact=request.getParameter("psphone");
		String address=request.getParameter("psadd");
		String d=request.getParameter("psdate");
		
		Class.forName("com.mysql.jdbc.Driver").newInstance();
		
		Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
		
		Statement st=con.createStatement();
		
		String sql="update psdetails set head='"+head+"',contact='"+contact+"',address='"+address+"',date='"+d+"' where area='"+name+"'";
		
		st.executeUpdate(sql);
		
		response.sendRedirect("adminupdateps4.jsp");
		
	%>