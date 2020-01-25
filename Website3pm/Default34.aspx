<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default34.aspx.cs" Inherits="Default34" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DropDownList</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:DropDownList ID="ddl1" runat="server" AutoPostBack="True">
        <asp:ListItem Text="Select" Value="select" />
        <asp:ListItem Text="Option1" Value="opt1" />
        <asp:ListItem Text="Option2" Value="opt2" />
        <asp:ListItem Text="Option3" Value="opt3" />
    </asp:DropDownList>

        <asp:DropDownList ID="ddl2" runat="server" AutoPostBack="True" >
            <asp:ListItem Value="Select">Select</asp:ListItem>
            <asp:ListItem Value="Opt1">Option11</asp:ListItem>
            <asp:ListItem Value="Opt2">Option22</asp:ListItem>
            <asp:ListItem Value="opt3">Option333</asp:ListItem>
        </asp:DropDownList>
        <br /><asp:Label ID="lbl1" runat="server" />
        <br /><asp:Label ID="lbl2" runat="server" />
    </div>
    </form>
</body>
</html>
