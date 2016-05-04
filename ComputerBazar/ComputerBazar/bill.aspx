<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bill.aspx.cs" Inherits="ComputerBazar.bill1" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 62%;
        }
        .style2
        {
            height: 22px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1" align="center">
            <tr>
                <td align="center" colspan="2">
                    <asp:Label ID="title_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                        Font-Size="X-Large" Text="Computer Bazar"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="custname_lbl" runat="server" Font-Bold="True" 
                        Font-Names="Tahoma" Font-Size="Medium"></asp:Label>
                </td>
                <td rowspan="3">
                    <asp:Label ID="address_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                        Font-Size="Medium"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="cno_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                        Font-Size="Medium"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="email_lbl" runat="server" Font-Bold="True" Font-Names="Tahoma" 
                        Font-Size="Medium"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2" colspan="2" align="center">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                CellPadding="4" ForeColor="Black" Width="560px" 
                        Font-Bold="True" Font-Names="Tahoma" Font-Size="Medium" 
                        BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
                        CellSpacing="2" >
                            <Columns>
                            <asp:BoundField DataField="orderid" HeaderText="Order ID" />
                            <asp:BoundField DataField="orderdate" HeaderText="Order Date" />
                            <asp:BoundField DataField="pname" HeaderText="Product Name" />
                            <asp:BoundField DataField="pdescription" HeaderText="Product Description" />
                            <asp:BoundField DataField="pprice" HeaderText="Price" />
                            <asp:BoundField DataField="rname" HeaderText="Retailer Name" />
                            </Columns>
                                <FooterStyle BackColor="#CCCCCC" />
                                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" 
                                    HorizontalAlign="Left" />
                                <RowStyle BackColor="White" />
                                <SelectedRowStyle BackColor="#000099" ForeColor="White" Font-Bold="True" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                            </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="style2" align="center">
                    &nbsp;</td>
                <td class="style2" align="center">
                    <asp:Label ID="grandtotal_lbl" runat="server" Font-Bold="True" 
                        Font-Names="Tahoma" Font-Size="Medium"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2" align="center">
                <asp:Button ID="printButton" runat="server" Text="Print" 
                        OnClientClick="javascript:window.print();" Height="26px" />
                    &nbsp;</td>
                <td class="style2" align="center">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
