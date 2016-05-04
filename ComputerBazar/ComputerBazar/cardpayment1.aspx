<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cardpayment1.aspx.cs" Inherits="ComputerBazar.cardpayment1" %>

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
            width: 104%;
            height: 205px;
        }
        .style3
        {
            height: 66px;
        }
        .style4
        {
        }
        .style5
        {
            width: 218px;
            height: 38px;
        }
        .style6
        {
            height: 38px;
        }
        .style7
        {
            width: 218px;
            height: 51px;
        }
        .style8
        {
            height: 51px;
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
			<h1 id="logo"><a class="notext" href="#" title="ComputerBazar">Computer Bazar</a></h1>
		</div>
		<!-- End Header -->
		<!-- Begin Navigation -->
		<div id="navigation">
			<div class="shell">
				<ul>
					<li><a href="retailerhome.aspx" title="Home">Home</a></li>
					<li><a href="#" title="Account">Account</a></li>
                    <li><a href="#" title="Orders">Orders</a></li>
					<li><a href="#" title="Wishlist">Wishlist</a></li>
                    <li><a href="#" title="Recommendation">Recommendation</a></li>
					<li><a href="customerchangepassword.aspx" title="Change PAssword">Change Password</a></li>
                    <li><a href="#" title="Delete Account">Delete Account</a></li>
                    <li><a href="#" title="Log-out">Log-out</a></li>
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
										<li><a href="printer.aspx" title="Printers"><span>Printers</span></a></li>
										<li><a href="scanner.aspx" title="Scaners"><span>Scaners</span></a></li>
										<li><a href="harddisk.aspx" title="Hard Disk"><span>HardDisks</span></a></li>
										<li><a href="pendrive.aspx" title="Pendrives"><span>Pendrive</span></a></li>
										<li><a href="speaker.aspx" title="Speakers"><span>Speakers</span></a></li>
										<li><a href="headset.aspx" title="Headsets"><span>Headsets</span></a></li>
										<li class="last"><a href="other.aspx" title="OtherAccessories"><span>Other Accessories</span></a></li>
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
							<h2 style="color: #7AF303" align="center">Cash on Delivery<br />
                                <br />
                                        <asp:Label ID="message_lbl" runat="server" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium"></asp:Label>
                                    </h2>
						</div>
                        <div>          
                            <table class="style1">
                                <tr>
                                    <td class="style3" align="center" colspan="2">
                                        <asp:Label ID="viewcode_lbl" runat="server" 
                                            Text="Please Enter your Phone Number and Verification Code to complete your Order" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium" BackColor="White" 
                                            ForeColor="#000066"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" class="style5">
                                        <asp:Label ID="amount2_lbl" runat="server" Text="Amount Payable is " Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium"></asp:Label>
                                    </td>
                                    <td class="style6">
                                        <asp:Label ID="amount_lbl" runat="server" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style5">
                                        <asp:Label ID="enterphno_lbl" runat="server" Text="Enter Phone Number" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium"></asp:Label>
                                    </td>
                                    <td class="style6">
                                        <asp:TextBox ID="phno_txt" runat="server" Width="139px" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium"></asp:TextBox>
                                    &nbsp;&nbsp;
                                            <asp:RegularExpressionValidator ID="phno_valid" runat="server" 
                                                ControlToValidate="phno_txt" ErrorMessage="!!" SetFocusOnError="True" 
                                                ToolTip="Please Enter a 10 Digit No." ValidationExpression="^[0-9]{10}$" 
                                                Font-Bold="True" Font-Names="Tahoma" Font-Size="Medium" 
                                            ForeColor="Red"></asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style7">
                                        <asp:Label ID="entercode_lbl" runat="server" Text="Enter Verification  Code" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium"></asp:Label>
                                    </td>
                                    <td class="style8">
                                        <asp:TextBox ID="code_txt" runat="server" Width="140px" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style4" align="center" colspan="2">
                                        <asp:Button ID="finish_btn" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                            Font-Size="Medium" onclick="finish_btn_Click" Text="Finish" />
                                    </td>
                                </tr>
                            </table>
                        </div>
						<!-- End Post -->
						<!-- Begin Products -->
						<div id="products">
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
