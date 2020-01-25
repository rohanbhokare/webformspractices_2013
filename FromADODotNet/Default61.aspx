<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default61.aspx.cs" Inherits="Default61" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:ListBox ID="listBoxCity" runat="server" SelectionMode="Multiple">
        <asp:ListItem Value="1">Hyderabad</asp:ListItem>
        <asp:ListItem Value="2">Mumbai</asp:ListItem>
        <asp:ListItem Value="3">Pune</asp:ListItem>
        <asp:ListItem Value="4">Goa</asp:ListItem>
    </asp:ListBox>
        <asp:RequiredFieldValidator ID="rfv1" runat="server" ControlToValidate="listBoxCity" InitialValue="" ErrorMessage="Error" ForeColor="Red"></asp:RequiredFieldValidator>

        <asp:DropDownList ID="ddl" runat="server">
            <asp:ListItem Value="0"></asp:ListItem>
            <asp:ListItem Value="1">Hyderabad</asp:ListItem>
            <asp:ListItem Value="2">Mumbai</asp:ListItem>
            <asp:ListItem Value="3">Pune</asp:ListItem>
            <asp:ListItem Value="4">Goa</asp:ListItem>
        </asp:DropDownList>
         <asp:RequiredFieldValidator ID="rfv2" runat="server" ControlToValidate="ddl" InitialValue="0" SetFocusOnError="true" ErrorMessage="Error" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
        <asp:Button ID="Button1" runat="server" Text="Submit" />
    </form>
</body>
</html>
