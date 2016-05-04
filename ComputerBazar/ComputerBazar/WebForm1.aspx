<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ComputerBazar.WebForm1" %>

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
					<li><a href="adminhome.aspx" title="Home">Home</a></li>
				    <li><a href="confirmretailer.aspx" title="Confirm Retailer">Confirm Retailer</a></li>
					<li><a href="deleteretailer.aspx" title="Delete Reatailer">Delete Retailer</a></li>
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
						</ul>
					</div>
					<!-- End Sidebar -->
					<!-- Begin Content -->
					<div id="content">
						<!-- Begin Post -->
						<div class="post">
							<h2 style="color: #91BE23">Welcome to ComputerBazar.com</h2>
						</div>
						<!-- End Post -->
						<!-- Begin Products -->
						<div id="products">
                  			<div class="cl">&nbsp;</div>
						</div>
                        <div>

                            <table class="style1">
                                <tr>
                                    <td>
                                        <asp:Label ID="retailernamr_lbl" runat="server" Text="Retailer name"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="retailername_list" runat="server" 
                                            onselectedindexchanged="retailername_list_SelectedIndexChanged">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="date_lbl" runat="server" Text="Date"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True"></asp:TextBox>
                                        <br />
                                        <asp:Calendar ID="Calendar1" runat="server" 
                                            onselectionchanged="Calendar1_SelectionChanged"></asp:Calendar>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        <asp:Button ID="details_but" runat="server" Text="Details" 
                                            onclick="details_but_Click" />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                CellPadding="4" ForeColor="#333333" GridLines="None" Width="585px">
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                            <asp:BoundField DataField="orderid" HeaderText="Order ID" />
                            <asp:BoundField DataField="orderdate" HeaderText="Order date" />
                            <asp:BoundField DataField="pid" HeaderText="Product ID" />
                            <asp:BoundField DataField="pname" HeaderText="Product Name" />
                            <asp:BoundField DataField="pprice" HeaderText="Price" />
                            <asp:BoundField DataField="rname" HeaderText="Retailer Name" />
                            <asp:BoundField DataField="uname" HeaderText="User Name" />
                            <asp:ImageField DataImageUrlField="pimage" HeaderText="Photo" ControlStyle-Height="100" ControlStyle-Width="100">
                            <ControlStyle Height="100px" Width="100px"></ControlStyle>
                            </asp:ImageField>
                            </Columns>
                                <EditRowStyle BackColor="#999999" />
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                            </asp:GridView>
                                        &nbsp;</td>
                                </tr>
                            </table>

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
