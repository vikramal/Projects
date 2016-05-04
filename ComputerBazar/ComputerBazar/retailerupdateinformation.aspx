<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="retailerupdateinformation.aspx.cs" Inherits="ComputerBazar.retailerupdateinformation" %>

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
            height: 20px;
        }
        .style2
        {
            height: 22px;
        }
        .style3
        {
            height: 50px;
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
					<li><a href="retailerhome.aspx" title="Home">Home</a></li>
				    <li><a href="retaileraddproduct.aspx" title="Add Product">Add Product</a></li>
					<li><a href="retailerupdateproduct.aspx" title="Update Product">Update Product</a></li>
					<li><a href="retailerdeleteproduct.aspx" title="Delete Product">Delete Product</a></li>
					<li><a href="retailerupdateinformation.aspx" title="Update Information">Update Information</a></li>
					<li><a href="retailerchangepassword.aspx" title="Change Password">Change Password</a></li>
                    <li><a href="retailershowinvoices.aspx" title="Show Invoices">Show Invoices</a></li>
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
										<li><a href="#" title="Desktops"><span>Desktops</span></a></li>
										<li><a href="#" title="Laptops &amp; Notebooks"><span>Laptops &amp; Notebooks</span></a></li>
										<li><a href="#" title="Keyboard"><span>Keyboard</span></a></li>
										<li><a href="#" title="Mouse"><span>Mouse</span></a></li>
										<li><a href="#" title="Printers"><span>Printers</span></a></li>
										<li><a href="#" title="Scaners"><span>Scaners</span></a></li>
										<li><a href="#" title="Hard Disk"><span>HardDisks</span></a></li>
										<li><a href="#" title="Pendrives"><span>Pendrive</span></a></li>
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
						<!-- End Post -->
						<!-- Begin Products -->
						<div id="Div1">
                            <div>
                            <div>
                            <h2 align="center">
                                            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="X-Large" Text="Update Information" ForeColor="#77E906"></asp:Label>
                            </h2>
                            </div>
						<!-- End Post -->
						<!-- Begin Products -->
						<div id="products">
                            <div>
                            <table align="center" class="style1">
                                    <tr>
                                        <td class="style3" align="center" colspan="2">
                                            <asp:Label ID="message_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            <asp:Label ID="retd_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Retailer ID"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="id_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" ReadOnly="True"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            <asp:Label ID="retname_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Retailer Name"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="name_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="name_req" runat="server" 
                                                ControlToValidate="name_txt" ErrorMessage="!!Cannot Be Blank"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            <asp:Label ID="retemail_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Retailer E-mail Address"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="email_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="email_req" runat="server" 
                                                ControlToValidate="email_txt" ErrorMessage="!!Cannot Be Blank"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            <asp:Label ID="retadd_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Retailer Address"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="add_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Height="75px" TextMode="MultiLine" Width="223px" >
                                            </asp:TextBox>
                                            &nbsp;<asp:RequiredFieldValidator ID="add_req" runat="server" 
                                                ControlToValidate="add_txt" ErrorMessage="!!Cannot Be Blank"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            <asp:Label ID="retphno_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Retailer Ph no."></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="ph_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" MaxLength="10"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="phno_req" runat="server" 
                                                ControlToValidate="ph_txt" ErrorMessage="!!Cannot Be Blank"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            <asp:Label ID="rettinno_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Retailer Tin no."></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="tin_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="tin_req" runat="server" 
                                                ControlToValidate="tin_txt" ErrorMessage="!!Cannot Be Blank"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            <asp:Label ID="retpanno_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Retailer Pan no."></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="pan_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="pan_req" runat="server" 
                                                ControlToValidate="pan_txt" ErrorMessage="!!Cannot Be Blank"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            &nbsp;</td>
                                        <td>
                                            <asp:Button ID="update_but" runat="server" Text="Update" onclick="update_but_Click" 
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