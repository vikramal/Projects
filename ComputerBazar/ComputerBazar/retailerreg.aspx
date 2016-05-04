<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="retailerreg.aspx.cs" Inherits="ComputerBazar.retailerreg" %>

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
            width: 248px;
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
			<h1 id="logo"><a class="notext" href="#" title="PC Store">PC Store</a></h1>
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
		<!-- End Slider -->
		<!-- Begin Main -->
		<div id="main">
			<!-- Begin Inner -->
			<div class="inner">
				<div class="shell">
					<!-- Begin Left Sidebar -->
					<div id="left-sidebar" class="sidebar">
					</div>
					<!-- End Sidebar -->
					<!-- Begin Content -->
					<div id="content">
						<!-- Begin Post -->
						<!-- End Post -->
						<!-- Begin Products -->
						<div id="products">
							<h2>Retailer Registeration Form</h2>
                            <div>

                                <table align="center" class="style1">
                                    <tr>
                                        <td class="style2">
                                            <asp:Label ID="retd_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Retailer ID"></asp:Label>
                                        </td>
                                        <td>
                                            &nbsp;
                                            <asp:TextBox ID="id_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" ReadOnly="True" Width="215px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            <asp:Label ID="retname_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Retailer Name"></asp:Label>
                                        </td>
                                        <td>
                                            &nbsp;
                                            <asp:TextBox ID="name_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Width="215px"></asp:TextBox>
                                            &nbsp;<asp:RequiredFieldValidator ID="name_req" runat="server" 
                                                ControlToValidate="name_txt" ErrorMessage="*" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" 
                                                ToolTip="Retailer name required."></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            <asp:Label ID="retpass_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Retailer Password"></asp:Label>
                                        </td>
                                        <td>
                                            &nbsp;
                                            <asp:TextBox ID="pass_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" TextMode="Password" Width="215px" ></asp:TextBox>
                                            &nbsp;<asp:RequiredFieldValidator ID="pass_req" runat="server" 
                                                ControlToValidate="pass_txt" ErrorMessage="*" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" 
                                                ToolTip="Retailer Password required"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            <asp:Label ID="retrepass_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Retailer re-type Password"></asp:Label>
                                        </td>
                                        <td>
                                            &nbsp;
                                            <asp:TextBox ID="repass_txt" runat="server" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" TextMode="Password" Width="215px"></asp:TextBox>
                                            &nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" 
                                                ControlToCompare="pass_txt" ControlToValidate="repass_txt" 
                                                ErrorMessage="*" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" 
                                                ToolTip="Password and Retype Password must be Same"></asp:CompareValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            <asp:Label ID="retemail_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Retailer E-mail Address"></asp:Label>
                                        </td>
                                        <td>
                                            &nbsp;&nbsp;
                                            <asp:TextBox ID="email_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Width="215px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="email_req" runat="server" 
                                                ControlToValidate="email_txt" ErrorMessage="*" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" 
                                                ToolTip="E-mail ID required"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            <asp:Label ID="retadd_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Retailer Address"></asp:Label>
                                        </td>
                                        <td>
                                            &nbsp;&nbsp;
                                            <asp:TextBox ID="add_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Height="75px" TextMode="MultiLine" Width="215px"></asp:TextBox>
                                            &nbsp;<asp:RequiredFieldValidator ID="add_req" runat="server" 
                                                ControlToValidate="add_txt" ErrorMessage="*" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" 
                                                ValidationGroup="Address Required"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            <asp:Label ID="retphno_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Retailer Ph no."></asp:Label>
                                        </td>
                                        <td>
                                            &nbsp;&nbsp;
                                            <asp:TextBox ID="ph_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" MaxLength="10" Width="215px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="phno_req" runat="server" 
                                                ControlToValidate="ph_txt" ErrorMessage="*" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ForeColor="#FF111D" 
                                                ToolTip="Enter Phone number"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            <asp:Label ID="rettinno_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Retailer Tin no."></asp:Label>
                                        </td>
                                        <td>
                                            &nbsp;&nbsp;
                                            <asp:TextBox ID="tin_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Width="215px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="tin_req" runat="server" 
                                                ControlToValidate="tin_txt" ErrorMessage="*" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" 
                                                ToolTip="Enter Tin number"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            <asp:Label ID="retpanno_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Retailer Pan no."></asp:Label>
                                        </td>
                                        <td>
                                            &nbsp;&nbsp;
                                            <asp:TextBox ID="pan_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Width="215px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="pan_req" runat="server" 
                                                ControlToValidate="pan_txt" ErrorMessage="*" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" 
                                                ToolTip="Enter Pan number"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;&nbsp;
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

