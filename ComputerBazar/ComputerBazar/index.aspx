<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ComputerBazar.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
 <script type="text/javascript" language="javascript">
     function DisableBackButton() {
         window.history.forward()
     }
     DisableBackButton();
     window.onload = DisableBackButton;
     window.onpageshow = function (evt) { if (evt.persisted) DisableBackButton() }
     window.onunload = function () { void (0) }
</script>
<head runat="server">
    <title>ComputerBazar.com</title>
	<meta http-equiv="Content-type" content="text/html; charset=utf-8" />
	<link rel="shortcut icon" href="css/images/favicon.ico" />
	<link rel="stylesheet" href="css/style.css" type="text/css" media="all" />
	
	<script src="js/jquery-1.6.2.min.js" type="text/javascript" charset="utf-8"></script>
	
	<script src="js/jquery.jcarousel.min.js" type="text/javascript" charset="utf-8"></script>
	<script src="js/functions.js" type="text/javascript" charset="utf-8"></script>
    </head>
<body>
	<form id="form1" runat="server">
	<!-- Begin Wrapper -->
	<div id="wrapper">
		<!-- Begin Search -->
		<div id="search">
			<asp:HyperLink ID="adminlogin_link" runat="server" 
                NavigateUrl="~/adminlogin.aspx">Admin Login</asp:HyperLink>
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
										<li><a href="termsandconditions.aspx" title="Terms &amp; Conditions"><span>Terms &amp; Conditions</span></a></li>
										<li><a href="contactus.aspx" title="Contact Us"><span>Contact Us</span></a></li>
									</ul>
								</div>
							</li>
						</ul>
					</div>
					<!-- End Sidebar -->
					<!-- Begin Content -->
					<div id="content">
						<!-- Begin Post -->
						<div class="post">
							<h2 style="color: #7EFF00">Welcome to ComputerBazar.com</h2>
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
                            <div style="height: 409px">
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                CellPadding="4" Width="759px" 
                                    Font-Bold="True" Font-Names="Courier New" Font-Size="Small" 
                                    Height="250px" HorizontalAlign="Center" ForeColor="#333333" 
                                    GridLines="None" >
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                            <asp:BoundField DataField="pname" HeaderText="Product Name" />
                            <asp:BoundField DataField="cname" HeaderText="Company Name" />
                            <asp:BoundField DataField="pdescription" HeaderText="Product Description" />
                            <asp:BoundField DataField="pprice" HeaderText="Price" />
                            <asp:ImageField DataImageUrlField="pimage" HeaderText="Photo" ControlStyle-Height="100" ControlStyle-Width="100">
                            <ControlStyle Height="100px" Width="100px"></ControlStyle>
                            </asp:ImageField>
                            <asp:HyperLinkField Text="Buy" DataNavigateUrlFields="pid" 
                                DataNavigateUrlFormatString="viewproduct.aspx?pid={0}" />
                            </Columns>

                                <EditRowStyle BackColor="#999999" />
                                <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#284775" />
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                            </asp:GridView>
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
		<!-- End Footer -->
	</div>
	<!-- End Wrapper -->
    </form>
</body>
</html>

