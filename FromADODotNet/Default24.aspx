<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default24.aspx.cs" Inherits="Default24" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:DataList ID="DataList1" runat="server">
        <HeaderTemplate>
            <b>Employee Data</b>
        </HeaderTemplate>
        <ItemTemplate>
            |<%#Eval("EmpId") %>|
            <%#Eval("EmpName") %>|
            <%#Eval("EmpJob") %>|
            <%#Eval("EmpSalary") %>|
            <%#Eval("DeptName") %>|
        </ItemTemplate>
        <FooterTemplate>
            <b>End of Records</b>
        </FooterTemplate>
        <HeaderStyle HorizontalAlign="Center" BorderStyle="Dotted" />
        <FooterStyle BackColor="WhiteSmoke" />
        <ItemStyle />
        <AlternatingItemStyle />

    </asp:DataList>
    </div>
    </form>
</body>
</html>
