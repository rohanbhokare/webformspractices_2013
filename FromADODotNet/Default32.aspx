<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default32.aspx.cs" Inherits="Default32" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="false" AllowPaging="true" AllowSorting="true" DataKeyNames="EmpId" EmptyDataText="No Data" Width="100%" BorderColor="YellowGreen" BorderStyle="Double" GridLines="Both" OnRowEditing="GridView1_RowEditing" OnRowDeleting="GridView1_RowDeleting" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnPageIndexChanging="GridView1_PageIndexChanging" OnSorting="GridView1_Sorting" Caption="Employee Data" CaptionAlign="Top" PageSize="5">
        <Columns>
            <asp:CommandField ShowEditButton="true" EditText="EdiT" ShowDeleteButton="true" DeleteText="Delete" />
            <asp:BoundField DataField="EmpId" HeaderText="Emp ID" ReadOnly="true" SortExpression="EmpId" />
            <asp:BoundField DataField="EmpName" HeaderText="Emp Name" SortExpression="EmpName" />
            <asp:BoundField DataField="EmpJob" HeaderText="Emp Job" SortExpression="EmpJob" />
            <asp:BoundField DataField="EmpSalary" HeaderText="Emp Salary" SortExpression="EmpSalary" />
            <asp:BoundField DataField="DId" HeaderText="Dept Name" SortExpression="DId" />
        </Columns>
    </asp:GridView>
    </div>
    </form>
</body>
</html>