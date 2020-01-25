<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default28.aspx.cs" Inherits="Default28" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:CheckBox ID="chkSelectall" runat ="server" AutoPostBack="true" Text="Select ALL" OnCheckedChanged="chkSelectall_CheckedChanged"/>
        <asp:Panel ID="panel1" runat="server">
            <asp:CheckBox ID="chk1" runat="server" Text="Item1" />
            <asp:CheckBox ID="chk2" runat="server" Text="Item2" />
            <asp:CheckBox ID="chk3" runat="server" Text="Item3" />
            <asp:CheckBox ID="chk4" runat="server" Text="Item4" />
        </asp:Panel>

    </div>
    </form>
</body>
</html>
