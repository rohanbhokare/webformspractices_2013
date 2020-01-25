<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default32.aspx.cs" Inherits="Default32" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script type="text/javascript">
        function f1() {
            var a =document.getElementById('<%=rdb1.ClientID%>').checked;
            var b = document.getElementById('<%=rdb2.ClientID%>').checked;
            if (a==true || b==true) {
                return true;
            }
            else {
                alert("no selected");
                return false;
            }


        }
    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:RadioButton ID="rdb1" runat="server" GroupName="G" Text="Male"/>
        <asp:RadioButton ID="rdb2" runat="server" GroupName="G" Text="Female" />
        <asp:Button ID="Button1" Text="Submit" OnClientClick="javascript:return f1()" OnClick="Button1_Click" runat="server" />
        <asp:Label ID="Label1" Text="" runat="server" />

    </div>
    </form>
</body>
</html>
