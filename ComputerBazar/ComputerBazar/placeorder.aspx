<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="placeorder.aspx.cs" Inherits="ComputerBazar.placeorder" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
            width: 225px;
        }
        .style3
        {
            height: 44px;
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
										<li><a href="printer.aspx" title="Printers"><span>Printers</span></a></li>
										<li><a href="scanner.aspx" title="Scaners"><span>Scaners</span></a></li>
										<li><a href="hdd.aspx" title="Hard Disk"><span>HardDisks</span></a></li>
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
							<h2>Welcome to ComputerBazar.com</h2>
						</div>
                        <div>
                            
                            <table class="style1" align="center">
                                <tr>
                                    <td colspan="4" align="center">
                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                CellPadding="4" ForeColor="#333333" GridLines="None" Width="560px" 
                                onselectedindexchanged="GridView1_SelectedIndexChanged">
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                            <asp:ImageField DataImageUrlField="pimage" HeaderText="Photo" ControlStyle-Height="100" ControlStyle-Width="100">
                            <ControlStyle Height="100px" Width="100px"></ControlStyle>
                            </asp:ImageField>
                            <asp:BoundField DataField="pname" HeaderText="Product Name" />
                            <asp:BoundField DataField="pdescription" HeaderText="Product Description" />
                            <asp:BoundField DataField="pprice" HeaderText="Price" />
                            <asp:BoundField DataField="rname" HeaderText="Retailer Name" />
                            <asp:BoundField DataField="uname" HeaderText="User Name" />

                            </Columns>
                                <EditRowStyle BackColor="#999999" />
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#284775" ForeColor="White" 
                                    HorizontalAlign="Center" />
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                <SelectedRowStyle BackColor="#E2DED6" ForeColor="#333333" Font-Bold="True" />
                                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                            </asp:GridView>
                                        &nbsp;</td>

                                </tr>
                                <tr>
                                    <td align="center" class="style3" colspan="2">
                                        <asp:Label ID="amount1_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                            Font-Size="Large" Text="Grand Total"></asp:Label>
                                    </td>

                                    <td align="center" class="style3" colspan="2">
                                        <asp:Label ID="amount_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                            Font-Size="Large"></asp:Label>
                                    </td>

                                </tr>
                                <tr>
                                    <td align="center">
                                        <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                            Font-Size="Small" onclick="Button1_Click" Text="Continue Sopping" 
                                            Width="144px" />
                                    </td>

                                    <td align="center" class="style2" colspan="2">
                                        <asp:Button ID="Button2" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                            Font-Size="Small" Text="Place Order" onclick="Button2_Click" />
                                    </td>

                                    <td align="center">
                                        <asp:Button ID="Button3" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                            Font-Size="Small" onclick="Button3_Click" Text="Delete Cart" />
                                    </td>

                                </tr>
                            </table>
                            
                            
                            
                        </div>
						<!-- End Post -->
						<!-- Begin Products -->
						<div id="products">
                  			<div class="cl">&nbsp;`<br />
                            </div>
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