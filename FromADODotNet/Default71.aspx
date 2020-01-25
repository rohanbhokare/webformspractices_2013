<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default71.aspx.cs" Inherits="Default71" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter FirstName
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfv1" runat="server" ErrorMessage="plz enter First Name" ControlToValidate="txtName" Display="None"></asp:RequiredFieldValidator>
        <br />
        Enter Last Name<asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfv2" runat="server" ErrorMessage="plz enter Last Name" ControlToValidate="txtLastName" Display="None"></asp:RequiredFieldValidator>
        <br />
        Enter Email Address<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
&nbsp;<asp:RegularExpressionValidator ID="rev1" runat="server" ErrorMessage="not valide Email" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="None" ></asp:RegularExpressionValidator>
        <br />
        Enter Password
        <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfv3" runat="server" ErrorMessage="please Enter pwd" ControlToValidate="txtPwd" Display="None"></asp:RequiredFieldValidator>
        <br />
        Enter confirm Password<asp:TextBox ID="txtConfirmPwd" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfv4" runat="server" ErrorMessage="plz Enter confirm pwd" ControlToValidate="txtConfirmPwd" Display="None"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="cv1" runat="server" ErrorMessage="pwd and confirm pwd not same" ControlToValidate="txtConfirmPwd" ControlToCompare="txtPwd" Display="None"></asp:CompareValidator>
    <asp:ValidationSummary ID="vs1" runat="server" HeaderText="Error Detail" ShowMessageBox="true" ShowSummary="false" />

        <asp:Button ID="btn1" runat="server" Text="Submit" />
    </div>
    </form>
</body>
</html>
