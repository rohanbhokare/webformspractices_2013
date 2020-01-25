<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default25.aspx.cs" Inherits="Default25" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:DataList ID="DataList1" runat="server" Width="100%" OnEditCommand="DataList1_EditCommand" OnCancelCommand="DataList1_CancelCommand" OnItemDataBound="DataList1_ItemDataBound" OnUpdateCommand="DataList1_UpdateCommand" OnDeleteCommand="DataList1_DeleteCommand">
        <HeaderTemplate>
            <table width="100%">
                <tr>
                    <th width="15%">Action</th>
                    <th width="15%">Emp Id</th>
                    <th width="15%">Emp Name</th>
                    <th width="20%">Emp Jpb</th>
                    <th width="20%">Emp Salary</th>
                    <th width="15%">Dept Name</th>
                </tr>
            </table>
        </HeaderTemplate>
        <ItemTemplate>
            <table width="100%">
                <tr>
                    <th width="15%">
                        <asp:LinkButton ID="lnkBtnEdit" runat="server" Text="Edit" CommandName="edit"></asp:LinkButton>
                        &nbsp
                        <asp:LinkButton ID="lnkBtnDelete" runat="server" Text="Delete" CommandName="Delete" CommandArgument='<%# Eval("EmpId") %>' OnClientClick="return confirm('Are you Sure?')"></asp:LinkButton>
                    </th>
                    <th width="15%"><%# Eval("EmpId") %></th>
                    <th width="15%"><%# Eval("EmpName") %></th>
                    <th width="20%"><%# Eval("EmpJob") %></th>
                    <th width="20%"><%# Eval("EmpSalary") %></th>
                    <th width="15%"><%# Eval("DeptName") %></th>
                </tr>
            </table>
        </ItemTemplate>
        <EditItemTemplate>
            <table width="100%">
                <tr>
                    <th width="15%">
                        <asp:LinkButton ID="lnkUpdate" runat="server" Text="Update" CommandName="Update"></asp:LinkButton>
                        &nbsp
                        <asp:LinkButton ID="lnkCancel" runat="server" Text="Cancel" CommandName="Cancel"></asp:LinkButton>
                    </th>
                     <th width="15%"><asp:Label ID="lblEmpId" runat="server" Text='<%# Eval("EmpId") %>'></asp:Label></th>
                    <th width="25%"><asp:TextBox ID="txtEmpName" runat="server" Text='<%# Eval("EmpName") %>'></asp:TextBox></th>
                    <th width="20%"><asp:TextBox ID="txtEmpJob" runat="server" Text='<%# Eval("EmpJob") %>'></asp:TextBox></th>
                    <th width="20%"><asp:TextBox ID="txtEmpSalary"  runat="server" Text='<%# Eval("EmpSalary") %>'></asp:TextBox></th>
                    <th width="15%">
                        <asp:DropDownList ID="ddlDept" runat="server" ></asp:DropDownList>
                        <asp:Label ID="lblDeptId" runat="server"  Text='<%# Eval("DId")%>' Style="display:none" ></asp:Label>
                    </th>
                </tr>
            </table>
        </EditItemTemplate>
        <SelectedItemTemplate>

        </SelectedItemTemplate>
        <SelectedItemStyle BackColor="YellowGreen" />
        <FooterTemplate>
            <span> End Of Records </span>
        </FooterTemplate>
        <HeaderStyle />
        <FooterStyle Font-Underline="true" Font-Bold="true"  />
    </asp:DataList>
    </div>
    </form>
</body>
</html>