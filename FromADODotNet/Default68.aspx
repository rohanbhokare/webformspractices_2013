<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default68.aspx.cs" Inherits="Default68" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter Pin Code :
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter Vaild pincode" ControlToValidate="TextBox1" ValidationExpression="\d{6}" SetFocusOnError="true"></asp:RegularExpressionValidator>
        <br />
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
    </div>
    </form>
</body>
</html>
