<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default70.aspx.cs" Inherits="Default70" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function clientValidate(source, args) {
            if (args.Value % 2 == 0) {
                args.IsValid = true;
            } else {
                args.IsValid = false;
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter Even Number :
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage=" Please Enter Even Value" ControlToValidate="TextBox1" ClientValidationFunction="clientValidate" SetFocusOnError="true" ></asp:CustomValidator>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
    
    </div>
    </form>
</body>
</html>
