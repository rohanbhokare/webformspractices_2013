<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default23.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:CheckBox ID="CheckBox1" runat="server" Checked="true" Text="CheckBox1 Option" />
        </br> 
        <asp:CheckBox ID="CheckBox2" runat="server" Text="CheckBox2 Option" />
        </br></br>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" text="Submit"/>
        </br>
        <asp:Label ID="Label1" runat="server" />
    
    </div>
    </form>
</body>
</html>
