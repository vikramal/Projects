<%@page language="java" session="true" 
import="java.io.*,java.util.*,java.io.*,java.sql.*,javax.servlet.*"%> 

<% 

String username=(String) session.getAttribute("un");

//to get the content type information from JSP Request Header 
String contentType = request.getContentType(); 

if (contentType != null && contentType.indexOf("multipart/form-data") >= 0) 
{ 
DataInputStream in = new DataInputStream(request.getInputStream()); 
//we are taking the length of Content type data 
int formDataLength = request.getContentLength(); 
byte dataBytes[] = new byte[formDataLength]; 
int byteRead = 0; 
int totalBytesRead = 0; 
//this loop converting the uploaded file into byte code 
while (totalBytesRead < formDataLength) 
{ 
byteRead = in.read(dataBytes, totalBytesRead, formDataLength); 
totalBytesRead += byteRead; 
} 
String file = new String(dataBytes); 
//for saving the file name 

String saveFile = file.substring(file.indexOf("filename=") + 10);
saveFile = saveFile.substring(0, saveFile.indexOf("\n"));
saveFile = saveFile.substring(0, saveFile.indexOf("\""));  


int lastIndex = contentType.lastIndexOf("="); 
String boundary = contentType.substring(lastIndex + 1); 
int pos; 

pos = file.indexOf("filename="); 
pos = file.indexOf("\n", pos) + 1; 
pos = file.indexOf("\n", pos) + 1; 
pos = file.indexOf("\n", pos) + 1; 
int boundaryLocation = file.indexOf(boundary, pos) - 4; 
int startPos = file.substring(0, pos).getBytes().length; 
int endPos = file.substring(0, boundaryLocation).getBytes().length; 
// creating a new file with the same name and writing the content in new file 
FileOutputStream fileOut = new FileOutputStream("C:\\apache-tomcat-4.1.36\\webapps\\ROOT\\ecops\\uploads\\"+saveFile+""); 
fileOut.write(dataBytes, startPos, (endPos - startPos)); 
fileOut.flush(); 
fileOut.close(); 



Class.forName("com.mysql.jdbc.Driver").newInstance();

Connection con=DriverManager.getConnection("jdbc:mysql://localhost/ecops","root","");
Statement st=con.createStatement();
String sql="update citizenreg set uoloadoc='"+saveFile+"' where username='"+username+"'";
st.executeUpdate(sql);

response.sendRedirect("citizenreg1.html");

} 
%>