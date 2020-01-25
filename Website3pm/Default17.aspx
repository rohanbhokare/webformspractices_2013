<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default17.aspx.cs" Inherits="Default17" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="<b >R</b>oha<u>N</u>" AccessKey="r" AssociatedControlID="TextBox1"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" />
        <br />
        <asp:Label ID="Label2" runat="server" AccessKey="o" AssociatedControlID="TextBox2" Text="Hello"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
