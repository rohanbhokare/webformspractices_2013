<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default27.aspx.cs" Inherits="Default27" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    
<head runat="server">
    
    <title></title>
    <script type="text/javascript">
        function validate(obj) {
            if (obj.checked==true) {
                if (document.getElementById('<%=HFCount.ClientID%>').value >= 3) {
                    obj.checked = false;
                    alert("cant select more than 3")
                }
                else {
                    document.getElementById('<%=HFCount.ClientID%>').value =parseInt(document.getElementById('<%=HFCount.ClientID%>').value )+ 1;
                }
            }
            else {
                if(obj.checked==false){
                    if (document.getElementById('<%=HFCount.ClientID%>').value <=1) {
                        obj.checked = true;
                    alert("Atlest one should be selected");
                    }
                    else {
                        document.getElementById('<%=HFCount.ClientID%>').value = parseInt(document.getElementById('<%=HFCount.ClientID%>').value) - 1;
                       
                    }
                }

            }

        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel id="Panel1" runat="server">
            <asp:CheckBox id="chk1" runat="server" text="Item1" /> <br />
            <asp:CheckBox ID="chk2" runat="server" Text="Item2" /><br />
            <asp:CheckBox ID="chk3" runat="server" Text="Item3" /><br />
            <asp:CheckBox ID="chk4" runat="server" Text="Item4" /><br />
        </asp:Panel>
    <asp:HiddenField ID="HFCount" runat="server" value="0"/>
    </div>
    </form>
</body>
</html>
