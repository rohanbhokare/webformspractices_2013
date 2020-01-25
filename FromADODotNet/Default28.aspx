<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default28.aspx.cs" Inherits="Default28" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:DataList ID="DataListOuter" Width="100%" runat="server" OnItemDataBound="DataListOuter_ItemDataBound">
        <HeaderTemplate>Employee Data</HeaderTemplate>
        <ItemTemplate>
            <table width="100%">
                <tr>
                    <th>
                         Department Name : <%#Eval("DeptName") %> <asp:Label ID="lblDeptId" runat="server" Visible="false" Text='<%# Eval("DeptId") %>'></asp:Label><br />
                    </th>
                </tr>
            </table>
            <asp:DataList ID="DataListInner" Width="100%" runat="server" OnItemDataBound="DataListInner_ItemDataBound">
                
                <HeaderTemplate>
                    <table width="100%">
                        <tr>
                            <th width="20%">EmpId</th>
                            <th width="20%">EmpName</th>
                            <th width="20%">EmpJob</th>
                            <th width="20%">EmpSalary</th>
                            <th width="20%">DepartmentName</th>
                        </tr>
                    </table>
                </HeaderTemplate>
                <ItemTemplate>
                    <table width="100%">
                        <tr>
                            <td width="20%"><%# Eval("EmpId") %></td>
                            <td width="20%"><%# Eval("EmpName") %></td>
                            <td width="20%"><%# Eval("EmpJob") %></td>
                            <td width="20%"><asp:Label ID="lblEmpSalary" runat="server" Text='<%# Eval("EmpSalary") %>'></asp:Label></td>
                            <td width="20%"><%# Eval("DeptName") %></td>
                        </tr>
                    </table>
                </ItemTemplate>
                <FooterTemplate>
                    <table width="100%">
                        <tr>
                            <td width="20%">Total Employee: <asp:Label ID="lblEmpCount" runat="server"></asp:Label> </td>
                            <td width="40%" colspan="2" align="right">Total Salary</td>
                            <td width="40%" colspan="2" align="left"><asp:Label ID="lblTotalSalary" runat="server"></asp:Label> </td>
                        </tr>
                    </table>
                </FooterTemplate>
                <HeaderStyle BackColor="WhiteSmoke" />
                <ItemStyle BackColor="WhiteSmoke" />
                <FooterStyle BackColor="WhiteSmoke" />
            </asp:DataList>
            <asp:Label ID="lblStatus" runat="server"></asp:Label>
        </ItemTemplate>
        <FooterTemplate>
            <table width="100%">
                        <tr>
                            <td width="20%">Grand Total Employee: <asp:Label ID="lblEmpCountGT" runat="server"></asp:Label> </td>
                            <td width="40%" colspan="2" align="right">Grand Total Salary</td>
                            <td width="40%" colspan="2" align="left"><asp:Label ID="lblTotalSalaryGT" runat="server"></asp:Label> </td>
                        </tr>
                    </table>
        </FooterTemplate>
        <ItemStyle BackColor="LightBlue" />
    </asp:DataList>

    </div>
    </form>
</body>
</html>
