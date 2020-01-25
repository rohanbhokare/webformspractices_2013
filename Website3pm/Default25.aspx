<%@ Page Language="C#" AutoEventWireup="false"  CodeFile="Default25.aspx.cs" Inherits="Default25" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:CheckBox ID="CheckBox1" runat="server" Text="Show Image" AutoPostBack="True" onCheckedChanged="CheckBox1_CheckedChanged"/>
        <br />
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Image/img3.jpg" height="200" Width="200" Visible="false" />
    </div>
    </form>
</body>
</html>
