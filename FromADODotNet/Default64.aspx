<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default64.aspx.cs" Inherits="Default64" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter Salary :
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Salary should be Above or equal to 15000" ControlToValidate="TextBox1" ValueToCompare="15000" Operator="GreaterThanEqual" Type="Currency" SetFocusOnError="true"></asp:CompareValidator>
    
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" />
    
    </div>
    </form>
</body>
</html>
