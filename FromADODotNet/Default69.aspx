<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default69.aspx.cs" Inherits="Default69" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter Password :
        <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox><asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Password should have 1 small 1 capital letter and 1 digit and more tha 6 char and less then 16 " OnServerValidate="CustomValidator1_ServerValidate" ControlToValidate="TextBox1"  ></asp:CustomValidator>
        <br />
        <asp:Button ID="btn1" runat="server" Text="Submit" OnClick="btn1_Click" />
    
    </div>
    </form>
</body>
</html>
