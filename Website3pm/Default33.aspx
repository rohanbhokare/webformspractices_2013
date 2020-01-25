<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default33.aspx.cs" Inherits="Default33" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:RadioButton ID="rdb1" runat="server" GroupName="g" Text="RadioButton1" AutoPostBack="true" OnCheckedChanged="rdb_CheckedChanged" />
        <asp:RadioButton ID="rdb2" runat="server" GroupName="g" Text="RadioButton2" AutoPostBack="true" OnCheckedChanged="rdb_CheckedChanged"/><br />
        <asp:Label ID="lbl" runat="server" /> 
    </div>
    </form>
</body>
</html>
