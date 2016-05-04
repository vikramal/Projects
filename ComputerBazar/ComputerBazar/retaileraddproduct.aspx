﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="retaileraddproduct.aspx.cs" Inherits="ComputerBazar.addproduct" %>

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
            height: 373px;
        }
        .style2
        {
            height: 59px;
        }
        .style3
        {
            height: 30px;
        }
    </style>
    </head>
<body>
	<form id="form1" runat="server">
	<!-- Begin Wrapper --><div id="wrapper">
		<!-- Begin Search -->
		<div id="search">
			<div class="shell">
					&nbsp;<div class="cl">&nbsp;</div>
			</div>
		</div>
		<!-- End Search -->
		<!-- Begin Header -->
		<div id="header" class="shell">
			<h1 id="logo"><a class="notext" href="#" title="PC Store">PC Store</a></h1>
		</div>
		<!-- End Header -->
		<!-- Begin Navigation
         -->
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
			<div class="cl">&nbsp;</div>
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
						<div id="products">
                            <div>
                            <h2 align="center">
                                            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="X-Large" Text="Add Product" ForeColor="#77E906"></asp:Label>
                                        <br />
                            </h2>
                                <table align="center" class="style1">
                                    <tr>
                                        <td class="style2" colspan="2" align="center">
                                            <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="pid_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Product ID" ForeColor="#77E906"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="pid_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" BorderStyle="Solid" Width="200px"></asp:TextBox>
                                        &nbsp;
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                ControlToValidate="pid_txt" ErrorMessage="*" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" 
                                                ToolTip="Product ID required."></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="pname_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Product Name" ForeColor="#77E906"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="pname_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" BorderStyle="Solid" Width="200px"></asp:TextBox>
                                        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                ControlToValidate="pname_txt" ErrorMessage="*" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" 
                                                ToolTip="Product name required."></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="pcat_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Product Category" ForeColor="#77E906"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="pcat_drop" runat="server" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" Width="205px">
                                                <asp:ListItem>laptop</asp:ListItem>
                                                <asp:ListItem>desktop</asp:ListItem>
                                                <asp:ListItem>monitor</asp:ListItem>
                                                <asp:ListItem>motherboard</asp:ListItem>
                                                <asp:ListItem>processor</asp:ListItem>
                                                <asp:ListItem>ram</asp:ListItem>
                                                <asp:ListItem>harddisk</asp:ListItem>
                                                <asp:ListItem>keyboard</asp:ListItem>
                                                <asp:ListItem>mouse</asp:ListItem>
                                                <asp:ListItem>speaker</asp:ListItem>
                                                <asp:ListItem>headphone</asp:ListItem>
                                                <asp:ListItem>printer</asp:ListItem>
                                                <asp:ListItem>pendrive</asp:ListItem>
                                            </asp:DropDownList>
                                        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                ControlToValidate="pcat_drop" ErrorMessage="*" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" 
                                                ToolTip="Product category required."></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="pcname_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Company Name" ForeColor="#77E906"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="cname_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" BorderStyle="Solid" Width="200px"></asp:TextBox>
                                        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                ControlToValidate="cname_txt" ErrorMessage="*" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" 
                                                ToolTip="Company name required."></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="pdesc_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Product Description" ForeColor="#77E906"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="pdesc_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" TextMode="MultiLine" Width="200px"></asp:TextBox>
                                        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                                ControlToValidate="pdesc_txt" ErrorMessage="*" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" 
                                                ToolTip="Production description required."></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style3">
                                            <asp:Label ID="pprice_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Product Price" ForeColor="#77E906"></asp:Label>
                                        </td>
                                        <td class="style3">
                                            <asp:TextBox ID="price_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" BorderStyle="Solid" Width="200px" 
                                                ontextchanged="price_txt_TextChanged"></asp:TextBox>
                                        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                ControlToValidate="price_txt" ErrorMessage="*" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" 
                                                ToolTip="Product price required."></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="pimage_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Medium" Text="Product Image" ForeColor="#77E906"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:FileUpload ID="img_upload" runat="server" Font-Bold="True" 
                                                Font-Size="Medium" Width="277px" BorderStyle="Solid" />
                                        &nbsp;
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                                ControlToValidate="img_upload" ErrorMessage="*" Font-Bold="True" 
                                                Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" ToolTip="Upload image."></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="2">
                                            &nbsp;
                                            <asp:Button ID="save_but" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                                Font-Size="Small" Text="SAVE" onclick="product" Width="65px" />
                                        &nbsp;&nbsp;&nbsp;&nbsp;
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
					<div class="cl">&nbsp;ddwadwaddwaddddddddwa</div>
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

