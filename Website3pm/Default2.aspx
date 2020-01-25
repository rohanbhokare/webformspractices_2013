<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function validate(v) {
            if (select != "v") or(v != select)
            {
                var value1 = document.getElementById("txtnumber1").value;
                var value2 = document.getElementById("txtnumber2").value;
                var err="";
                if(value1=="" || value2=="")
                {
                    if(value1=="")
                        err += "please enter NUMBER1";
                    if(value2=="")
                        err +="please enert number2";
                    if(err!="")
                    {
                        document.getElementById("lblLabel").innerHTML=err;
                        return false;
                    }
                    else{
                        return true
                    }
                }
            }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <h1> Code-behind Model</h1>
        <asp:Label ID="lblLabel" runat="server" />
        <br />
        <b> Enter Number1</b>
        <asp:TextBox ID="txtnumber1" runat="server" />
        <b>Enter Number2 </b>
        <asp:TextBox ID="txtnumber2" runat="server" />
        <br />
        <asp:DropDownList ID="ddl1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddl1_SelectedIndexChanged">
            <asp:ListItem Text="Select" Value="select" />
            <asp:ListItem Text="ADD" Value="+" />
            <asp:ListItem Text="Substraction" Value="-" />
            <asp:ListItem Text="Multiplication" Value="*" />
            <asp:ListItem Text="Division" Value="/" />
        </asp:DropDownList>
        <br />
        <b>Result</b><asp:TextBox ID="txtresult" runat="server" />
    
    </div>
    </form>
</body>
</html>
