<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default31.aspx.cs" Inherits="Default31" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h3>GridView With BoundField</h3>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" Width="100%">
            <Columns>
                <asp:BoundField DataField="EmpId" HeaderText="Employee ID" />
                <asp:BoundField DataField="EmpName" HeaderText="Employee Name" />
                <asp:BoundField DataField="EmpSalary" HeaderText="Emp Salary" />
                <asp:BoundField DataField="EmpJob" HeaderText="Emp Job" />
                <asp:BoundField DataField="DeptName" HeaderText="Dept Name" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
