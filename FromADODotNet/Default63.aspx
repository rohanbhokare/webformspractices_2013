<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default63.aspx.cs" Inherits="Default63" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter Joining Date :
        <asp:TextBox ID="txtJDate" runat="server"></asp:TextBox>
        <br />
        Enter Relieving Date:
        <asp:TextBox ID="txtRDate" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="cv1" runat="server" ErrorMessage="Relive date should be more than joining date" ControlToValidate="txtRDate" ControlToCompare="txtJDate" Type="Date" Operator="GreaterThan" SetFocusOnError="true"></asp:CompareValidator>
        <br />
        <asp:Button ID="btnsubmit" runat="server" Text="Submit" />
    
    </div>
    </form>
</body>
</html>
