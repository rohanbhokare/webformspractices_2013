<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default33.aspx.cs" Inherits="Default33" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="true" AllowSorting="true" AutoGenerateColumns="false" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnSorting="GridView1_Sorting" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="3" DataKeyNames="EmpId" EmptyDataText="No Data Avalible" Width="100%" GridLines="Both" OnRowDataBound="GridView1_RowDataBound">
        <Columns>
            <asp:TemplateField HeaderStyle-Width="10%">
                <ItemTemplate>
                    <asp:LinkButton ID="lnkBtnEdit" runat="server" Text="Edit" CommandName="Edit" ToolTip="Edit Record" />
                    &nbsp;
                    <asp:LinkButton ID="lnkBtnDelete" runat="server" Text="Delete" CommandName="Delete"></asp:LinkButton>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:LinkButton ID="lnkBtnUpdate" runat="server" Text="Update" CommandName="Delete">
                         <asp:LinkButton ID="lnkBtnCancel" runat="server" Text="Cancel" CommandName="Cancel"></asp:LinkButton>
                    </asp:LinkButton>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Emp Id" SortExpression="EmpId" >
                <ItemTemplate>
                    <%# Eval("EmpId") %>
                </ItemTemplate>
                <EditItemTemplate>
                    <%#Eval("EmpId") %>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Employee Name" SortExpression="EmpName">
                <ItemTemplate>
                    <%# Eval("EmpName") %>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtEmpName" runat="server" Text='<%# Eval("EmpName") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Emp Job" SortExpression="EmpJob">
                <ItemTemplate>
                    <%# Eval("EmpJob") %>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox id="txtEmpJob" runat="server" Text='<%# Eval("EmpJob") %>'
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Emp Salary" SortExpression="EmpSalary">
                <ItemTemplate>
                    <%# Eval("EmpSalary") %>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox id="txtEmpSalary" runat="server" Text='<%# Eval("EmpSalary") %>'
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Dept Id" SortExpression="DId">
                <ItemTemplate>
                    <%# Eval("DId") %>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:DropDownList ID="ddlDept" runat="server"></asp:DropDownList>
                    <asp:Label id="lbldeptId" runat="server" Text='<%# Eval("DId") %>' style="display:none"></asp:Label>
                </EditItemTemplate>
            </asp:TemplateField>
        </Columns>

    </asp:GridView>
    </div>
    </form>
</body>
</html>
