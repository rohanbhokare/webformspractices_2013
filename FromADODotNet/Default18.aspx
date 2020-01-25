<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default18.aspx.cs" Inherits="Default18" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Repeater ID="Repeater" runat="server">
        <HeaderTemplate>
            <h2>Employee Data</h2>
        </HeaderTemplate>
        <ItemTemplate>
            <div style="background-color:green;color:white">
                <%# Eval("EmpId") %>|
                <%# Eval("EmpName") %>|
                <%#Eval("EmpJob") %>|
                <%# Eval("EmpSalary","{0:c}") %>|
                <%# Eval("DeptName") %>
            </div>
        </ItemTemplate>
        <AlternatingItemTemplate>
            <div style="background-color:red;color:white">
                <%# Eval("EmpId") %>|
                <%# Eval("EmpName") %>|
                <%#Eval("EmpJob") %>|
                <%# Eval("EmpSalary","{0:c}") %>|
                <%# Eval("DeptName") %>
            </div>
        </AlternatingItemTemplate>
        <SeparatorTemplate>
            <hr />
        </SeparatorTemplate>
        <FooterTemplate>
            <p >End Of Records</p>
        </FooterTemplate>
    </asp:Repeater>
    </div>
    </form>
</body>
</html>
