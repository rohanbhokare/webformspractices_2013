<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default26.aspx.cs" Inherits="Default26" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:CheckBox ID="chk1" runat="server" text="Option1"/>
        <asp:CheckBox ID="chk2" runat="server" text="Option2"/>
        <asp:CheckBox ID="chk3" runat="server" text="Option3"/>
        <asp:CheckBox ID="chk4" runat="server" text="Option4"/>
        <asp:CheckBox ID="CheckBox1" runat="server" text="new"/>

        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" onclick="btnSubmit_Click"/>
        <br />              
        <asp:Label ID="lbl" runat="server" />
    
    </div>
    </form>
</body>
</html>
