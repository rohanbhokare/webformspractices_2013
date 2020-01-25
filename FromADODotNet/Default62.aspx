<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default62.aspx.cs" Inherits="Default62" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter Password :
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        Enter Confirm Password :
        <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:CompareValidator ID="cv1" runat="server" ErrorMessage="password and confirm password should be same" ControlToValidate="txtConfirmPassword" ControlToCompare="txtPassword" Type="String" Operator="Equal" SetFocusOnError="true"></asp:CompareValidator>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" />
    
    </div>
    </form>
</body>
</html>
