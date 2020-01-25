<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default26.aspx.cs" Inherits="Default26" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Product</title>
</head>
<body>
    <form id="form1" runat="server">
    <div >
        <div style="text-align:right"><a href="Default27.aspx">view Products</a></div>
        <h1>Insert Product Detail</h1>
    <table align="center">
        <tr>
            <th width="20%">Product Name</th>
            <th width="2%">:</th>
            <td>
                <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <th width="20%">Product Brand</th>
            <th width="2%">:</th>
            <td>
                <asp:TextBox ID="txtProductBrand" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <th width="20%">Product Price</th>
            <th width="2%">:</th>
            <td>
                <asp:TextBox ID="txtProductPrice" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <th width="20%">Product Desc</th>
            <th width="2%">:</th>
            <td>
                <asp:TextBox ID="txtProductDesc" runat="server" Rows="2" Columns="20" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <th width="20%">Product Image</th>
            <th width="2%">:</th>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <th width="20%">&nbsp;</th>
            <th width="2%">&nbsp;</th>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            </td>
        </tr>
        <tr>
            <th colspan="3"><asp:Label ID="lblStatus" runat="server"></asp:Label></th>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
