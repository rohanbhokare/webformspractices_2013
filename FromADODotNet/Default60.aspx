<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default60.aspx.cs" Inherits="Default60" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validation Control 1</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        EnterName :
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfv1" runat="server" ControlToValidate="TextBox1" SetFocusOnError="true" ForeColor="Red"    
    Display="Dynamic" ErrorMessage="Error "></asp:RequiredFieldValidator> </div>
        <asp:Button ID="btn" runat="server" Text="Submit" />
    </form>
</body>
</html>
