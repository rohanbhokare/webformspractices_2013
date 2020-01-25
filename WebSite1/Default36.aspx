<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default36.aspx.cs" Inherits="Default36" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function f1() {
                        if ((document.getElementById('<%=txtEnter.ClientID %>').value) == "") {
                            alert("Please Enter Text");
                            return false;
                        }
                        if ((document.getElementById('<%= rdb1.ClientID%>').checked==true) ||(document.getElementById('<%= rdb2.ClientID%>').checked==true)){
                            return true;
                        }
                        else {
                            alert("select ListBox");
                            return false;
                        }
                     }
    </script>
</head>
<body style="background-color:lightblue">
    <form id="form1" runat="server">
        <center>
    <div>
    <asp:Label ID="label1" runat="server" Text="Enter Text : " />
        <asp:TextBox ID="txtEnter" runat="server"/>
        <br />
        <asp:RadioButton ID="rdb1" runat="server" GroupName="G" Text="ListBox 1" />
        <asp:RadioButton ID="rdb2" runat="server" GroupName="G" Text="ListBix 2"/>
        <br />
        <asp:Button id="btnAdd" runat="server" text="ADD" OnClientClick="JavaScript:return f1()"/>
        <table>
            <tr>
                <td>ListBox1</td>
                <td></td>
                <td>ListBox2</td>
            </tr>
            <tr>
                <td rowspan="4">  <asp:ListBox ID="ListBox1" runat="server" Rows="7" SelectionMode="Multiple" Width="150px"/></td>
                <td><asp:Button ID="btn1" runat="server" Text=" > " /></td>
                <td rowspan="4">  <asp:ListBox ID="ListBox2" runat="server" Rows="7" SelectionMode="Multiple" Width="150px"/></td>
            </tr>
            <tr>
                <td><asp:Button ID="btn2" runat="server" Text=" < " /></td>
            </tr>
            <tr>
                <td><asp:Button ID="btn3" runat="server" Text=">>" /></td>
            </tr>
            <tr>
                <td><asp:Button ID="btn4" runat="server" Text="<<"/></td>
            </tr>
        </table>
        <asp:Label ID="lblResult" runat="server" />
    </div>
            </center>
    </form>
</body>
</html>
