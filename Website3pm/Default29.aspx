<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default29.aspx.cs" Inherits="Default29" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function SelectAll(ctr)
        {
            var checkboxcollection = document.getElementById('<%=Panel1.ClientID%>').getElementsByTagName('input');
            for (var i = 0; i < checkboxcollection.length; i++) {
                if(checkboxcollection[i].type.toString().toLowerCase()=="checkbox")
                    {
                    checkboxcollection[i].checked = ctr.checked;
                    }
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Panel ID="Panel1" runat="server" >
        <asp:CheckBox ID="chk1" runat="server" Text="item1" />
        <asp:CheckBox ID="Chk2" runat="server" Text="item2" />
        <asp:CheckBox ID="chk3" runat="server" Text="item3" />
        <asp:CheckBox ID="chk4" runat="server" Text="item4" />
        <asp:CheckBox ID="chk5" runat="server" Text="item5" />
    </asp:Panel>
       <asp:CheckBox ID="chkSelectAll" runat="server" Text="Select all" />
    </div>
    </form>
</body>
</html>
