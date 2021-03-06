﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customerreg.aspx.cs" Inherits="ComputerBazar.customerreg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>ComputerBazar.com</title>
	<meta http-equiv="Content-type" content="text/html; charset=utf-8" />
	<link rel="shortcut icon" href="css/images/favicon.ico" />
	<link rel="stylesheet" href="css/style.css" type="text/css" media="all" />
	
	<script src="js/jquery-1.6.2.min.js" type="text/javascript" charset="utf-8"></script>
	
	<script src="js/jquery.jcarousel.min.js" type="text/javascript" charset="utf-8"></script>
	<script src="js/functions.js" type="text/javascript" charset="utf-8"></script>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
        }
        .style3
        {
            height: 63px;
        }
        .style4
        {
            height: 29px;
        }
    </style>
</head>
<body>
	<form id="form1" runat="server">
	<!-- Begin Wrapper -->
	<div id="wrapper">
		<!-- Begin Search -->
		<div id="search">
			<br />
		</div>
		<!-- End Search -->
		<!-- Begin Header -->
		<div id="header" class="shell">
			<h1 id="logo"><a class="notext" href="index.html" title="ComputerBazar">ComputerBazar</a></h1>
		</div>
		<!-- End Header -->
		<!-- Begin Navigation -->
		<div id="navigation">
			<div class="shell">
				<ul>
					<li><a href="index.aspx" title="Home">Home</a></li>
				    <li><a href="retailerreg.aspx" title="Retalier Registration">Retailer Registration</a></li>
					<li><a href="customerreg.aspx" title="Customer Registration">Customer Registration</a></li>
					<li><a href="retailerlogin.aspx" title="Retailer Login">retailer Login</a></li>
					<li><a href="customerlogin.aspx" title="Customer Login">Customer Login</a></li>
                    <li><a href="#" title="About-us">About-us</a></li>
				</ul>
				<div class="cl">&nbsp;</div>
			</div>
		</div>
		<!-- End Navigation -->
		<!-- Begin Slider -->
		<div id="slider">
			<div id="Div1">
			<div class="slider-outer">
				<div class="slider-inner shell">
					<!-- Begin Slider Items -->
					<ul class="slider-items">
						<li>
							<img src="css/images/slide-img1.jpg" alt="Slide Image 1" />
							<div class="slide-entry">
								<h2>Some Tittle Here</h2>
								<h3>Sed condimentum metus at risus </h3>
								<p>Maecenas eget purus arcu, in vestibulum libero. Ali-quam facilisis rhoncus eros, quis rutrum dolor tincid-unt ac. Duis vel consequat justo.</p>
							</div>
							<a href="#" class="more" title="View More">View More</a>
						</li>
						<li>
							<img src="css/images/slide-img1.jpg" alt="Slide Image 2" />
							<div class="slide-entry">
								<h2>Some Tittle Here</h2>
								<h3>Sed condimentum metus at risus </h3>
								<p>Maecenas eget purus arcu, in vestibulum libero. Ali-quam facilisis rhoncus eros, quis rutrum dolor tincid-unt ac. Duis vel consequat justo.</p>
							</div>
							<a href="#" class="more" title="View More">View More</a>
						</li>
						<li>
							<img src="css/images/slide-img1.jpg" alt="Slide Image 3" />
							<div class="slide-entry">
								<h2>Some Tittle Here</h2>
								<h3>Sed condimentum metus at risus </h3>
								<p>Maecenas eget purus arcu, in vestibulum libero. Ali-quam facilisis rhoncus eros, quis rutrum dolor tincid-unt ac. Duis vel consequat justo.</p>
							</div>
							<a href="#" class="more" title="View More">View More</a>
						</li>
						<li>
							<img src="css/images/slide-img1.jpg" alt="Slide Image 4" />
							<div class="slide-entry">
								<h2>Some Tittle Here</h2>
								<h3>Sed condimentum metus at risus </h3>
								<p>Maecenas eget purus arcu, in vestibulum libero. Ali-quam facilisis rhoncus eros, quis rutrum dolor tincid-unt ac. Duis vel consequat justo.</p>
							</div>
							<a href="#" class="more" title="View More">View More</a>
						</li>
						<li>
							<img src="css/images/slide-img1.jpg" alt="Slide Image 5" />
							<div class="slide-entry">
								<h2>Some Tittle Here</h2>
								<h3>Sed condimentum metus at risus </h3>
								<p>Maecenas eget purus arcu, in vestibulum libero. Ali-quam facilisis rhoncus eros, quis rutrum dolor tincid-unt ac. Duis vel consequat justo.</p>
							</div>
							<a href="#" class="more" title="View More">View More</a>
						</li>
					</ul>
					<!-- End Slider Items -->
					<div class="cl">&nbsp;</div>
					<div class="slider-controls">
						
					</div>
				</div>
			</div>
			<div class="cl">&nbsp;<br />
            </div>
		</div>
			<div class="cl">&nbsp;<br />
            </div>
		</div>
		<!-- End Slider -->
		<!-- Begin Main -->
		<div id="main">
			<!-- Begin Inner -->
			<div class="inner">
				<div class="shell">
					<!-- Begin Left Sidebar -->
					<div id="left-sidebar" class="sidebar">
						<ul>
						</ul>
					</div>
					<!-- End Sidebar -->
					<!-- Begin Content -->
					<div id="content">
						<!-- Begin Post -->
						<div class="post">
							<h2 style="color: #92C10F">Welcome to ComputerBazar.com</h2>
						</div>
						<!-- End Post -->
						<!-- Begin Products -->
						<div id="products">
							<h2 align="center" style="font-size: x-large; color: #96C424;">Customer Registeration Form</h2>
                            <div>

                                <table align="center" class="style1">
                                    <tr>
                                        <td class="style3" align="center" colspan="2">
                                            <asp:Label ID="message_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Small"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            <asp:Label ID="custemail_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="E-mail Address" ForeColor="#93C20F"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="email_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Width="215px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="name_req" runat="server" 
                                                ControlToValidate="email_txt" ErrorMessage="*" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" 
                                                ToolTip="Enter E-mail adress"></asp:RequiredFieldValidator>
                                        &nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:RegularExpressionValidator ID="email_valid" runat="server" 
                                                ControlToValidate="email_txt" ErrorMessage="!!" SetFocusOnError="True" 
                                                ToolTip="Please Enter Correct E-mail address" 
                                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                                Font-Bold="True" Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red"></asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            <asp:Label ID="custpass_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Password" ForeColor="#93C20F"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="pass_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" TextMode="Password" Width="215px" ></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="pass_req" runat="server" 
                                                ControlToValidate="pass_txt" ErrorMessage="*" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" ToolTip="Enter Password"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            <asp:Label ID="custrepass_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Re-type Password" ForeColor="#93C20F"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="repass_txt" runat="server" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" TextMode="Password" Width="215px"></asp:TextBox>
                                            <asp:CompareValidator ID="repass_comp" runat="server" 
                                                ControlToCompare="pass_txt" ControlToValidate="repass_txt" 
                                                ErrorMessage="*" Font-Bold="True" Font-Names="Tahoma" Font-Size="Medium" 
                                                ForeColor="Red" ToolTip="Password &amp; Re-type Password Should be same"></asp:CompareValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style4">
                                            <asp:Label ID="retphno_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Mobile number" ForeColor="#93C20F"></asp:Label>
                                        </td>
                                        <td class="style4">
                                            <asp:TextBox ID="ph_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" MaxLength="10" Width="215px" 
                                                ontextchanged="ph_txt_TextChanged" ></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="phno_req" runat="server" 
                                                ControlToValidate="ph_txt" ErrorMessage="*" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" 
                                                ToolTip="Cannot Be Blank"></asp:RequiredFieldValidator>
                                            &nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:RegularExpressionValidator ID="phno_valid" runat="server" 
                                                ControlToValidate="ph_txt" ErrorMessage="!!" SetFocusOnError="True" 
                                                ToolTip="Please Enter a 10 Digit No." ValidationExpression="^[0-9]{10}$" 
                                                Font-Bold="True" Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red"></asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            &nbsp;</td>
                                        <td>
                                            <asp:Button ID="save_but" runat="server" Text="Save" onclick="save_but_Click" 
                                                Width="66px" Font-Bold="True" Font-Names="tahoma" Font-Size="Medium" />
                                        </td>
                                    </tr>
                                </table>

                            </div>
                  			<div class="cl">&nbsp;</div>
						</div>
						<!-- End Products -->
					</div>
					<!-- End Content -->
					<!-- Begin Right Sidebar -->
					
					
					<!-- End Sidebar -->
					<div class="cl">&nbsp;</div>
				</div>
			</div>
			<!-- End Inner -->
		</div>
		<!-- End Main -->
		<!-- Begin Footer -->
		<div id="footer">
			<div class="shell">
				<p>Copyright &copy;ComputerBazar 2014. Design by: VMV Team. All Rights Reserved. </p>
				<div class="cl">&nbsp;</div>
			</div>
		</div>
		<!-- End Footer -->
	</div>
	<!-- End Wrapper -->
    </form>
</body>
</html>

