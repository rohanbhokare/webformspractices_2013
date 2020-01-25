<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default66.aspx.cs" Inherits="Default66" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter Email Address :
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="rev1" runat="server" ErrorMessage="Email Address is not valid" ControlToValidate="TextBox1" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
    
    </div>
    </form>
</body>
</html>
