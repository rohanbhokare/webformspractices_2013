<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default8.aspx.cs" Inherits="Default8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        th {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Insert Employee Data</h1>
        <table >
            <tr>
                <th colspan="3" style="text-align:center">
                    <asp:Label ID="lblStatus" runat="server" />
                </th>
            </tr>
            <tr>
                <th width="20%">Employee Name</th>
                <th width="2%"> :</th>
                <td><asp:TextBox ID="txtEmpName" runat="server"/></td>
            </tr>
            <tr>
                <th>Employee Job</th>
                <th>:</th>
                <td><asp:TextBox ID="txtEmpJob" runat="server" /></td>
            </tr>
            <tr>
                <th>Employee Salary</th>
                <th>:</th>
                <td><asp:TextBox ID="txtEmpSal" runat="server"/></td>
            </tr>
            <tr>
                <th>Departmant Name</th>
                <th>:</th>
                <td><asp:DropDownList ID="ddlEmpDept" runat="server"/></td>
            </tr>
            <tr>
                <th></th>
                <th></th>
                <td><asp:Button ID="btnSave" runat="server" text="Save" OnClick="btnSave_Click"/></td>
            </tr>
        </table>
    </form>
</body>
</html>
