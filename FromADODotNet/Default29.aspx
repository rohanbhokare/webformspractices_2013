<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default29.aspx.cs" Inherits="Default29" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="2" Width="70%" OnEditCommand="DataList1_EditCommand" OnDeleteCommand="DataList1_DeleteCommand" OnUpdateCommand="DataList1_UpdateCommand" OnCancelCommand="DataList1_CancelCommand" OnItemDataBound="DataList1_ItemDataBound">
        <HeaderTemplate>
            Employee Data
        </HeaderTemplate>
        <ItemTemplate>
            <table width ="100%">
                <tr>
                    <td width="40%" align="right">Employee Name</td>
                    <td width="2%">:</td>
                    <td width="58%" align="left"><%# Eval("EmpName") %> </td>
                </tr>
                <tr>
                    <td align="right">Employee Job</td>
                    <td>:</td>
                    <td align="left"><%# Eval("EmpJob") %> </td>
                </tr>
                <tr>
                    <td align="right">Employee Salary</td>
                    <td>:</td>
                    <td align="left"><%# Eval("EmpSalary") %> </td>
                </tr>
                <tr>
                    <td align="right">Dept Name</td>
                    <td>:</td>
                    <td align="left"><%# Eval("DeptName") %> <asp:Label ID="lblDeptId" runat="server" Text='<%#Eval("DId") %>' Visible="false"></asp:Label> </td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td>
                        <asp:Button ID="btnEdit" runat="server" Text="Edit" CommandName="Edit" />
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClientClick="return confirm('Are You Sure?')" CommandName="Delete" CommandArgument='<%# Eval("EmpId") %>' />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    

        <EditItemTemplate>
            <table width ="100%">
                <tr>
                    <td width="35%" align="right">Employee Name</td>
                    <td width="2%">:</td>
                    <td width="65%" align="left"><asp:TextBox runat="server" ID="txtEmpName" Text='<%# Eval("EmpName") %>'></asp:TextBox> <asp:Label ID="lblEmpId" runat="server" Text='<%# Eval("EmpId") %>' Visible="false"></asp:Label> </td>
                </tr>
                <tr>
                    <td align="right">Employee Job</td>
                    <td>:</td>
                    <td align="left"> <asp:TextBox runat="server" ID="txtEmpJob" Text='<%# Eval("EmpJob") %>'></asp:TextBox></td>
                </tr>
                <tr>
                    <td align="right">Employee Salary</td>
                    <td>:</td>
                    <td align="left"> <asp:TextBox runat="server" ID="txtEmpSalary" Text='<%# Eval("EmpSalary") %>'></asp:TextBox></td>
                </tr>
                <tr>
                    <td align="right">Dept Name</td>
                    <td>:</td>
                    <td align="left"> <asp:DropDownList ID="ddlDept" runat="server"></asp:DropDownList> <asp:Label ID="lblDeptId" runat="server" Text='<%#Eval("DId") %>' Visible="false"></asp:Label> </td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td>
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" CommandName="Update" CommandArgument='<%# Eval("EmpId") %>' />
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" CommandName="Cancel" />
                    </td>
                </tr>
            </table>

        </EditItemTemplate>

        <FooterTemplate>
            End of Record
        </FooterTemplate>
        <FooterStyle HorizontalAlign="Center" />
        <HeaderStyle BackColor="YellowGreen" BorderStyle="Double" HorizontalAlign="Center" />
        <FooterStyle BackColor="YellowGreen" BorderStyle="Double" HorizontalAlign="Center" />
        <ItemStyle BorderStyle="Double" BorderColor="IndianRed" BackColor="WhiteSmoke" />
    </asp:DataList>
    </div>
    </form>
</body>
</html>
