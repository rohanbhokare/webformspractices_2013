<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default65.aspx.cs" Inherits="Default65" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter Age :
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Range Must be in between 18 to 60" ControlToValidate="TextBox1" Type="Integer" MinimumValue="18" MaximumValue="60"></asp:RangeValidator>
        <br />
        <asp:Button ID="Btn" runat="server" Text="Submit" />
    
    </div>
    </form>
</body>
</html>
