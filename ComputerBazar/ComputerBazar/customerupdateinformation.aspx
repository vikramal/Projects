<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customerupdateinformation.aspx.cs" Inherits="ComputerBazar.customerupdateinformation" %>

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
            height: 25px;
        }
        .style3
        {
            width: 302px;
        }
        .style4
        {
            height: 25px;
            width: 302px;
        }
        .style5
        {
            height: 46px;
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
			<h1 id="logo"><a class="notext" href="#" title="Computer Bazar">Computer Bazar</a></h1>
		</div>
		<!-- End Header -->
		<!-- Begin Navigation -->
		<div id="navigation">
			<div class="shell">
				<ul>
					<li><a href="customerhome.aspx" title="Home">Home</a></li>
					<li><a href="customeraccount.aspx" title="Account">Account</a></li>
                    <li><a href="customerupdateinformation.aspx" title="Update Information">Update Information</a></li>
                    <li><a href="customerorder.aspx" title="Orders">Orders</a></li>
					<li><a href="customerchangepassword.aspx" title="Change PAssword">Change Password</a></li>
                    <li><a href="customerdelete.aspx" title="Delete Account">Delete Account</a></li>
                    <li><a href="index.aspx" title="Log-out">Log-out</a></li>
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
						<ul>
							<li class="widget">
								<h2>Categories</h2>
								<div class="widget-entry">
									<ul>
										<li><a href="desktop.aspx" title="Desktops"><span>Desktops</span></a></li>
										<li><a href="laptop.aspx" title="Laptops &amp; Notebooks"><span>Laptops &amp; Notebooks</span></a></li>
										<li><a href="keyboard.aspx" title="Keyboard"><span>Keyboard</span></a></li>
										<li><a href="mouse.aspx" title="Mouse"><span>Mouse</span></a></li>
										<li><a href="motherboard.aspx" title="MotherBoard"><span>MotherBoard</span></a></li>
                                        <li><a href="#" title="Printers"><span>Printers</span></a></li>
										<li><a href="#" title="Hard Disk"><span>HardDisks</span></a></li>
										<li><a href="pendrive.aspx" title="Pendrives"><span>Pendrive</span></a></li>
										<li><a href="#" title="Speakers"><span>Speakers</span></a></li>
										<li><a href="#" title="Headsets"><span>Headsets</span></a></li>
										<li class="last"><a href="#" title="OtherAccessories"><span>Other Accessories</span></a></li>
									</ul>
								</div>
							</li>
							<li class="widget">
								<h2>Information</h2>
								<div class="widget-entry">
									<ul>
										<li><a href="#" title="About Us"><span>About Us</span></a></li>
										<li><a href="#" title="Privacy Policy"><span>Privacy Policy</span></a></li>
										<li><a href="#" title="Terms &amp; Conditions"><span>Terms &amp; Conditions</span></a></li>
										<li><a href="#" title="Contact Us"><span>Contact Us</span></a></li>
										<li class="last"><a href="#" title="Site Map"><span>Site Map</span></a></li>
									</ul>
								</div>
							</li>
							<li class="widget select-widget">
								<h2>Brands</h2>
								<div class="widget-entry">
									<div class="selectbox">
										<span class="currentItem">--- <span>Please Select</span> ---</span>
										<div class="list">
											<ul>
												<li class="active"><a href="#" title="Please Select">Please Select</a></li>
												<li><a href="#" title="Brand 1">Brand 1</a></li>
												<li><a href="#" title="Brand 2">Brand 2</a></li>
												<li><a href="#" title="Brand 3">Brand 3</a></li>
											</ul>
										</div>
										<select>
											<option value="option" selected="selected">Please Select</option>
											<option value="option1">Brand 1</option>
											<option value="option2">Brand 2</option>
											<option value="option3">Brand 3</option>
										</select>
									</div>
									<div class="cl">&nbsp;</div>
								</div>
							</li>
							<li class="widget">
								<h2>Shopping Card</h2>
								<div class="widget-entry">
									<a href="#" class="items" title="Shopping Card Items">0 items</a>
								</div>
							</li>
						</ul>
					</div>
					<!-- End Sidebar -->
					<!-- Begin Content -->
					<div id="content">
						<!-- Begin Post -->
						<div class="post">
							<h2>Welcome to ComputerBazar.com</h2>
							<p>
                                ComputerBazar.com is India’s largest e-commerce marketplace. 
                                ComputerBazarprovides a platform for vendors across the country to connect with 
                                millions of customers. The platform has the widest assortment of products from 
                                thousands of national, international and regional brands across diverse 
                                categories like &nbsp;Desktops &nbsp;Laptops
                                    
                                And Other Computer Accesories And Also This Portal Also allows u to Customize 
                                Your Personal Computer For ur Need . Grab your favorite products @ best prices 
                                and save the one thing that matters most to you - &quot;Your Money&quot;.
                                ComputerBazar.com
                                has a network of more than 500 Merchants/Brands, and has over 10,000 members 
                                (which is 1 out of every 10&nbsp; internet users in the country) and caters to 
                                the shopping needs of customers across 400+ towns and cities.
                            </p>
						</div>
						<!-- End Post -->
						<!-- Begin Products -->
						<div id="products">
							<h2>Customer Update Information</h2>
                            <div>

                                <table class="style1">
                                    <tr>
                                        <td align="center" class="style5" colspan="2">
                    <asp:Label ID="message_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                        Font-Size="X-Large"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" class="style3">
                                            <asp:Label ID="name_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Name"></asp:Label>
                                        </td>
                                        <td align="left">
                                            <asp:TextBox ID="name_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium"></asp:TextBox>
                                        &nbsp;&nbsp;
                                            <asp:RequiredFieldValidator ID="name_req" runat="server" 
                                                ControlToValidate="name_txt" ErrorMessage="*" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" 
                                                ToolTip="Cannot be empty "></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" class="style3">
                                            &nbsp;<asp:Label ID="mobno_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="Medium" Text="Mobile No."></asp:Label>
                                        </td>
                                        <td align="left">
                                            <asp:TextBox ID="mobno_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium"></asp:TextBox>
                                        &nbsp;&nbsp;
                                            <asp:RequiredFieldValidator ID="mobile_req" runat="server" 
                                                ControlToValidate="mobno_txt" ErrorMessage="*" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" 
                                                ToolTip="Cannot be empty "></asp:RequiredFieldValidator>
                                        &nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:RegularExpressionValidator ID="phno_valid" runat="server" 
                                                ControlToValidate="mobno_txt" ErrorMessage="!!" SetFocusOnError="True" 
                                                ToolTip="Please Enter a 10 Digit No." ValidationExpression="^[0-9]{10}$" 
                                                Font-Bold="True" Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red"></asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" class="style3">
                                            <asp:Label ID="landno_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Landline No."></asp:Label>
                                        </td>
                                        <td align="left">
                                            <asp:TextBox ID="landno_txt" runat="server" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium"></asp:TextBox>
                                        &nbsp;&nbsp;
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" class="style3">
                                            <asp:Label ID="gender_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Gender"></asp:Label>
                                        </td>
                                        <td align="left">
                                            <asp:DropDownList ID="gender_list" runat="server" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium">
                                                <asp:ListItem>Male</asp:ListItem>
                                                <asp:ListItem>Female</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" class="style3">
                                            <asp:Label ID="address_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Street Address"></asp:Label>
                                        </td>
                                        <td align="left">
                                            <asp:TextBox ID="address_txt" runat="server" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" Height="80px" TextMode="MultiLine" 
                                                Width="160px"></asp:TextBox>
                                        &nbsp;&nbsp;
                                            <asp:RequiredFieldValidator ID="address_req" runat="server" 
                                                ControlToValidate="address_txt" ErrorMessage="*" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" 
                                                ToolTip="Cannot be empty "></asp:RequiredFieldValidator>
                                            </td>
                                    </tr>
                                    <tr>
                                        <td align="center" class="style4">
                                            <asp:Label ID="landmark_lbl" runat="server" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" Text="Landmark"></asp:Label>
                                        </td>
                                        <td align="left" class="style2">
                                            <asp:TextBox ID="landmark_txt" runat="server" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium"></asp:TextBox>
                                        &nbsp;&nbsp;
                                            <asp:RequiredFieldValidator ID="landmark_req" runat="server" 
                                                ControlToValidate="landmark_txt" ErrorMessage="*" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" 
                                                ToolTip="Cannot be empty "></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" class="style3">
                                            <asp:Label ID="city_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="City"></asp:Label>
                                        </td>
                                        <td align="left">
                                            <asp:TextBox ID="city_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium"></asp:TextBox>
                                        &nbsp;&nbsp;
                                            <asp:RequiredFieldValidator ID="city_req" runat="server" 
                                                ControlToValidate="city_txt" ErrorMessage="*" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" 
                                                ToolTip="Cannot be empty "></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" class="style3">
                                            <asp:Label ID="state_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="State"></asp:Label>
                                        </td>
                                        <td align="left">
                                            <asp:TextBox ID="state_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium"></asp:TextBox>
                                        &nbsp;&nbsp;
                                            <asp:RequiredFieldValidator ID="state_req" runat="server" 
                                                ControlToValidate="state_txt" ErrorMessage="*" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" 
                                                ToolTip="Cannot be empty "></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" class="style3">
                                            <asp:Label ID="country_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Country"></asp:Label>
                                        </td>
                                        <td align="left">
                                            <asp:TextBox ID="country_txt" runat="server" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ReadOnly="True">INDIA</asp:TextBox>
                                            <asp:Label ID="pin_lbl0" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Small" Text="** ComputerBazar Services available only in INDIA"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" class="style3">
                                            <asp:Label ID="pin_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Pincode"></asp:Label>
                                        </td>
                                        <td align="left">
                                            <asp:TextBox ID="pincode_txt" runat="server" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" 
                                                ontextchanged="pincode_txt_TextChanged"></asp:TextBox>
                                        &nbsp;&nbsp;
                                            <asp:RequiredFieldValidator ID="pincode_req" runat="server" 
                                                ControlToValidate="pincode_txt" ErrorMessage="*" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" 
                                                ToolTip="Cannot be empty "></asp:RequiredFieldValidator>
                                        &nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:RegularExpressionValidator ID="pincode_valid" runat="server" 
                                                ControlToValidate="pincode_txt" ErrorMessage="!!" SetFocusOnError="True" 
                                                ToolTip="Please Enter a 6 Digit No." ValidationExpression="^[0-9]{6}$" 
                                                Font-Bold="True" Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red"></asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" class="style3">
                                            &nbsp;</td>
                                        <td align="left">
                                            <asp:Button ID="save_but" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Save" onclick="save_but_Click" />
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
