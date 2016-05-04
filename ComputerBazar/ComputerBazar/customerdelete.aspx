<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customerdelete.aspx.cs" Inherits="ComputerBazar.cutomerdelete" %>

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
            width: 615px;
        }
        .style2
        {
            height: 23px;
        }
        .style3
        {
            height: 30px;
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
							<h2>Customer Change Password</h2>
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
                                                Font-Size="Medium" Text="E-mail Address"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="email_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="name_req" runat="server" 
                                                ControlToValidate="email_txt" ErrorMessage="!!Cannot Be Blank"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            <asp:Label ID="custpass_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Password"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="pass_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" TextMode="Password" ></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="pass_req" runat="server" 
                                                ControlToValidate="pass_txt" ErrorMessage="!!Cannot Be Blank"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            <asp:Label ID="retphno_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Ph no."></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="ph_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" MaxLength="10" ></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="phno_req" runat="server" 
                                                ControlToValidate="ph_txt" ErrorMessage="!!Cannot Be Blank"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            &nbsp;</td>
                                        <td>
                                            <asp:Button ID="delete_but" runat="server" Text="Delete" onclick="save_but_Click" 
                                                Width="83px" Font-Bold="True" Font-Names="tahoma" Font-Size="Medium" />
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