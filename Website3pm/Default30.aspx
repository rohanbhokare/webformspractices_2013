<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default30.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:RadioButton ID="rdb1" runat="server" Text="RadioButton1" GroupName="g"/>
        <asp:RadioButton ID="rdb2" runat="server" Text="RadioButton2" GroupName="g"/><br />
        <asp:Button ID="button1" runat="server" Text="submit" OnClick="button1_Click" /><br />
        <asp:Label ID="lbl" runat="server" />
    
    </div>
    </form>
</body>
</html>
