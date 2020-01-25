<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default67.aspx.cs" Inherits="Default67" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Enter Web-site URL :
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please Enter valid url" ControlToValidate="TextBox1" SetFocusOnError="true" ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?" ></asp:RegularExpressionValidator>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" />
    </form>
</body>
</html>
