<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default27.aspx.cs" Inherits="Default27" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div style="text-align:right"><a href="Default26.aspx">Add Products</a></div>
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="2">
        <HeaderTemplate>
            VIEW PRODUCT
        </HeaderTemplate>
        <ItemTemplate>
            <table width="100%">
                <tr>
                    <td rowspan="4" width="33%"><asp:Image ID="Image1" runat="server" ImageUrl='<%#"~/ProductImages/"+ Eval("ProductImage") %>' widht="100px" Height="100px" /> </td>
                    <th width="32%">Products Name</th>
                    <th width="2%">:</th>
                    <td width="32%"><%# Eval("ProductNmae") %></td>
                </tr>
                <tr>
                    <th>Product Brand</th>
                    <th>:</th>
                    <td><%# Eval("ProductBrand") %></td>
                </tr>
                <tr>
                    <th>Product Price</th>
                    <th>:</th>
                    <td><%# Eval("ProductPrice") %></td>
                </tr>
                <tr>
                    <th>Product Desc</th>
                    <th>:</th>
                    <td><%# Eval("ProductDesc") %></td>
                </tr>
                <tr>
                    <th></th>
                    <th></th>
                    <td><asp:Button ID="btnAddToCart" runat="server" Text="ADD TO CART" /></td>
                </tr>
            </table>
        </ItemTemplate>
        <HeaderStyle HorizontalAlign="Center" />
        <ItemStyle BorderStyle="Double" BorderColor="Red" BackColor="MintCream" Font-Size="12px" />
    </asp:DataList>
    </div>
    </form>
</body>
</html>
