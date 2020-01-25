<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default22.aspx.cs" Inherits="Default22" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    table,td{
        border:dashed;
        border-width:1px; 
    }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="divDept" style="margin-left:150px;margin-right:150px;">
        <asp:Repeater ID="RepeaterDept" runat="server" OnItemDataBound="RepeaterDept_ItemDataBound" >
            <HeaderTemplate >
                <table>
                    <tr>
                        <th><h1>Employee Data Depertment-Wise</h1></th>
                    </tr>
                </table>
            </HeaderTemplate>
            <ItemTemplate>
               <b>Depertment Name :</b>
                <%# Eval("DeptName")%> 
                <asp:Label ID="lblDeptId" runat="server" Text='<%# Eval("DeptId")%>' style="display:none"></asp:Label>
                <div class="divEmp">
                    <asp:Repeater ID="RepeaterEmp" runat="server" OnItemDataBound="RepeaterEmp_ItemDataBound">
                        <HeaderTemplate>
                            <table width="100%">
                                <tr>
                                    <td width="20%">EmpId</td>
                                    <td width="20%">EmpName</td>
                                    <td width="20%">EmpJob</td>
                                    <td width="20%">EmpSalary</td>
                                    <td width="20%">DeptName</td>
                                </tr>
                            </table>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <table width="100%">
                                <tr>
                                    <td width="20%"><%# Eval("EmpId")%></td>
                                    <td width="20%"><%# Eval("EmpName")%></td>
                                    <td width="20%"><%# Eval("EmpJob")%></td>
                                    <td width="20%"><asp:Label ID="lblSalary" runat="server" Text='<%# Eval("EmpSalary")%>'></asp:Label></td>
                                    <td width="20%"><%# Eval("DeptName")%></td>
                                </tr>
                            </table>
                        </ItemTemplate>
                        <FooterTemplate>
                            <table width="100%">
                                <tr>
                                    <td width="20%">TotalEmploye : <asp:Label ID="lblTotalEmp" runat="server"></asp:Label></td>
                                    <td width="40%" colspan="2" style="text-align:right">TotalSalary :</td>
                                    <td width="40%" colspan="2" style="text-align:left"><asp:Label ID="Label1" runat="server"></asp:Label> </td>
                                </tr>
                            </table>
                        </FooterTemplate>
                    </asp:Repeater>
                </div>
               <asp:Label ID="lblStatus" runat="server" />
            </ItemTemplate>
            <FooterTemplate>
               <br /> <b>Grand Total Employee:</b> <asp:Label ID="lblGTEmployee" runat="server"></asp:Label>&nbsp &nbsp <b>Grand Total Salary : </b> <asp:Label ID="lblGTSalary" runat="server"></asp:Label>
            </FooterTemplate>
            <SeparatorTemplate>
                <br />
            </SeparatorTemplate>
        </asp:Repeater>
            
            </div>
    </div>
    </form>
</body>
</html>
