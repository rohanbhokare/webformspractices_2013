<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default15.aspx.cs" Inherits="Default15" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <table>
            <tr>
                <td colspan="3" style="text-align:center"><h1>Update and delete Employee</h1></td>
            </tr>
            <tr>
                <td colspan="3" style="text-align:center"><asp:Label ID="lblstatus" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <th width="25%">Employee ID</th>
                <th width="2%">:</th>
                <td><asp:DropDownList ID="ddlEmpId" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlEmpId_SelectedIndexChanged" /></td>
            </tr >
            <tr>
                <th>Employee Name</th>
                <th>:</th>
                <td><asp:TextBox ID="txtEmpName" runat="server" /></td>
            </tr>
            <tr>
                <th>Employee Job</th>
                <th>:</th>
                <td><asp:TextBox ID="txtEmpJob" runat="server" /></td>
            </tr>
            <tr>
                <th>Employee Salary</th>
                <th>:</th>
                <td><asp:TextBox ID="txtEmpSal" runat="server" /></td>
            </tr>
            <tr>
                <th>Employee Department</th>
                <th>:</th>
                <td><asp:DropDownList ID="ddlDept" runat="server" /></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td>
                <asp:Button ID="btnUpdate" runat ="server" Text="Update" Enabled="false"  OnClick="btnUpdate_Click"/>&nbsp &nbsp
                <asp:Button ID="btnDelete" runat ="server" Text="Delete" Enabled="false" OnClick="btnDelete_Click" OnClientClick="return confirm('Are You Sure?')"/>&nbsp &nbsp
                <input type="reset" name="Reset" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
