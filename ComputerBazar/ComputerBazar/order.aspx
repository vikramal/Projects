﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="order.aspx.cs" Inherits="ComputerBazar.order" %>

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
            height: 702px;
        }
        .style3
        {
            height: 23px;
        }
        .style9
        {
            height: 35px;
            }
        .style11
        {
            height: 35px;
            width: 302px;
        }
        .style13
        {
            height: 34px;
        }
        .style14
        {
            height: 24px;
        }
        .style15
        {
            height: 93px;
        }
    </style>
    </head>
<body>
	<form id="form1" runat="server">
	<!-- Begin Wrapper --><div id="wrapper">
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
							<h2 style="color: #7BF901">Welcome to ComputerBazar.com</h2>
						</div>
                        <div>
                            
                            <table class="style1" align="center" cellpadding="4">
                                <tr>
                                    <td colspan="3" class="style13">
                                        <asp:Label ID="message_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                            Font-Size="Medium" ForeColor="Red"></asp:Label>
                                    </td>

                                </tr>
                                <tr>
                                    <td colspan="2" rowspan="1">
                                        <asp:Label ID="orderid_lbl" runat="server" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium" ForeColor="#77E906">Order ID</asp:Label>
                                    </td>

                                    <td align="char">
                                        &nbsp;&nbsp;
                                        <asp:TextBox ID="orderid_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                            Font-Size="Medium" ReadOnly="True" Width="215px"></asp:TextBox>
                                    </td>

                                </tr>
                                <tr>
                                    <td colspan="2" rowspan="1">
                                        <asp:Label ID="orderdate_lbl" runat="server" Text="Order Date" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium" ForeColor="#77E906"></asp:Label>
                                    </td>

                                    <td align="char">
                                        &nbsp;&nbsp;
                                        <asp:TextBox ID="orderdate_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                            Font-Size="Medium" Height="23px" ontextchanged="orderdate_txt_TextChanged" 
                                            ReadOnly="True" Width="215px"></asp:TextBox>
                                    </td>

                                </tr>
                                <tr>
                                    <td colspan="3" rowspan="1">
                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                CellPadding="4" ForeColor="#333333" GridLines="None" Width="560px" >
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                            <asp:BoundField DataField="pname" HeaderText="Product Name" />
                            <asp:BoundField DataField="pdescription" HeaderText="Product Description" />
                            <asp:BoundField DataField="pprice" HeaderText="Price" />
                            <asp:ImageField DataImageUrlField="pimage" HeaderText="Photo" ControlStyle-Height="100" ControlStyle-Width="100">
<ControlStyle Height="100px" Width="100px"></ControlStyle>
                                </asp:ImageField>
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
                                    <td colspan="2" class="style14">
                                        <asp:Label ID="grandtotal_lbl" runat="server" Text="Grand Total" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium" ForeColor="#77E906"></asp:Label>
                                    </td>

                                    <td align="char" class="style14">
                                        &nbsp;&nbsp;
                                        <asp:TextBox ID="grandtotal_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                            Font-Size="Medium" ReadOnly="True" Width="215px"></asp:TextBox>
                                    </td>

                                </tr>
                                <tr>
                                    <td colspan="2" rowspan="1">
                                        <asp:Label ID="name_lbl" runat="server" Text="Name" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium" ForeColor="#7EFF00"></asp:Label>
                                    </td>

                                    <td align="char">
                                        &nbsp;&nbsp;
                                        <asp:TextBox ID="name_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                            Font-Size="Medium" Width="215px"></asp:TextBox>
                                    &nbsp;<asp:RequiredFieldValidator ID="name_req" runat="server" 
                                            ControlToValidate="name_txt" ErrorMessage="*" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" ToolTip="Enter Name "></asp:RequiredFieldValidator>
                                    </td>

                                </tr>
                                <tr>
                                    <td colspan="2" rowspan="1">
                                        <asp:Label ID="phno_lbl" runat="server" Text="Phone No." Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium" ForeColor="#7EFF00"></asp:Label>
                                    </td>

                                    <td align="char">
                                        &nbsp;&nbsp;
                                        <asp:TextBox ID="phno_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                            Font-Size="Medium" ReadOnly="True" Width="215px"></asp:TextBox>
                                    </td>

                                </tr>
                                <tr>
                                    <td colspan="2" rowspan="1">
                                        <asp:Label ID="email_lbl" runat="server" Text="E-mail" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium" ForeColor="#7EFF00"></asp:Label>
                                    &nbsp;
                                    </td>

                                    <td align="char">
                                        &nbsp;&nbsp;
                                        <asp:TextBox ID="email_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                            Font-Size="Medium" ReadOnly="True" Width="215px"></asp:TextBox>
                                    </td>

                                </tr>
                                <tr>
                                    <td colspan="2" class="style15">
                                        <asp:Label ID="address_lbl" runat="server" Text="Address" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium" ForeColor="#7EFF00"></asp:Label>
                                    </td>

                                    <td align="char" class="style15">
                                        &nbsp;&nbsp;
                                        <asp:TextBox ID="address_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                            Font-Size="Medium" Height="81px" TextMode="MultiLine" Width="215px" ></asp:TextBox>
                                    &nbsp;<asp:RequiredFieldValidator ID="address_req" runat="server" 
                                            ControlToValidate="address_txt" ErrorMessage="*" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" ToolTip="Enter Address "></asp:RequiredFieldValidator>
                                    </td>

                                </tr>
                                <tr>
                                    <td colspan="2" class="style3">
                                        <asp:Label ID="landmark_lbl" runat="server" Text="Landmark" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium" ForeColor="#7EFF00"></asp:Label>
                                    </td>

                                    <td align="char" class="style3">
                                        &nbsp;&nbsp;
                                        <asp:TextBox ID="landmark_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                            Font-Size="Medium" Width="215px"></asp:TextBox>
                                    &nbsp;<asp:RequiredFieldValidator ID="landmark_req" runat="server" 
                                            ControlToValidate="landmark_txt" ErrorMessage="*" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" ToolTip="Enter Landmark"></asp:RequiredFieldValidator>
                                    </td>

                                </tr>
                                <tr>
                                    <td class="style3" colspan="2" rowspan="1">
                                        <asp:Label ID="city_lbl" runat="server" Text="City" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium" ForeColor="#7EFF00"></asp:Label>
                                    </td>

                                    <td align="char" class="style3">
                                        &nbsp;&nbsp;
                                        <asp:TextBox ID="city_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                            Font-Size="Medium" Width="215px"></asp:TextBox>
                                    &nbsp;<asp:RequiredFieldValidator ID="city_req" runat="server" 
                                            ControlToValidate="city_txt" ErrorMessage="*" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" ToolTip="Enter City"></asp:RequiredFieldValidator>
                                    </td>

                                </tr>
                                <tr>
                                    <td class="style3" colspan="2">
                                        <asp:Label ID="state_lbl" runat="server" Text="State" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium" ForeColor="#77E906"></asp:Label>
                                    </td>

                                    <td align="char" class="style3">
                                        &nbsp;&nbsp;
                                        <asp:TextBox ID="state_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                            Font-Size="Medium" Width="215px"></asp:TextBox>
                                    &nbsp;<asp:RequiredFieldValidator ID="state_req" runat="server" 
                                            ControlToValidate="state_txt" ErrorMessage="*" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" ToolTip="Enter State "></asp:RequiredFieldValidator>
                                    </td>

                                </tr>
                                <tr>
                                    <td class="style3" colspan="2">
                                        <asp:Label ID="pincode_lbl" runat="server" Text="Pincode" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium" ForeColor="#77E906"></asp:Label>
                                    </td>

                                    <td align="char" class="style3">
                                        &nbsp;&nbsp;
                                        <asp:TextBox ID="pincode_txt" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                            Font-Size="Medium" Width="215px"></asp:TextBox>
                                    &nbsp;<asp:RequiredFieldValidator ID="pincode_req" runat="server" 
                                            ControlToValidate="pincode_txt" ErrorMessage="*" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium" ForeColor="Red" ToolTip="Enter Pincode "></asp:RequiredFieldValidator>
                                        <br />
                                    </td>

                                </tr>
                                <tr>
                                    <td align="center" class="style3" colspan="3" rowspan="1">
                                        <asp:Label ID="payment_lbl" runat="server" Text="Payment Options" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Medium" ForeColor="#7EFF00"></asp:Label>
                                    </td>

                                </tr>
                                <tr>
                                    <td align="center" class="style11" rowspan="1">
                                        <asp:RadioButton ID="cash_radio" runat="server" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Large" Text="Cash on Delivery" 
                                            GroupName="pay" ForeColor="#7EFF00" />
                                    </td>

                                    <td align="center" class="style9" colspan="2">
                                        <asp:RadioButton ID="card_radio" runat="server" Font-Bold="True" 
                                            Font-Names="Tahoma" Font-Size="Large" Text="Debit Card / Credit Card" 
                                            GroupName="pay" ForeColor="#7EFF00" />
                                    </td>

                                </tr>
                                <tr>
                                    <td align="center" class="style3" colspan="2" rowspan="1">
                                        <asp:Button ID="clear_btn" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                            Font-Size="Small" Text="Clear" onclick="clear_btn_Click" Width="76px" />
                                    </td>

                                    <td align="center" class="style3">
                                        <asp:Button ID="payment_btn" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                                            Font-Size="Small" onclick="payment_btn_Click" Text="Proceed to pay" />
                                    </td>

                                </tr>
                                </table>
                            
                            
                        </div>

                        &nbsp;
                        &nbsp;

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