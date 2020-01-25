<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default10.aspx.cs" Inherits="Default10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        th {
            text-align: right;
        }
    </style>
</head>
<body style="background-color:khaki">
    <form id="form1" runat="server">
        <h1 style="text-align:center"> Employee Details</h1>
        <div align="center">
        <table  style="background-color:lightcoral">
            
            <tr>
                <th width="49%">Employee Id </th>
                <th width="2%">:</th>
                <td> <asp:Label ID="lblEmpId" runat="server" /> </td>
            </tr>
            <tr>
                <th>Employee Name </th>
                <th>:</th>
                <td> <asp:Label ID="lblEmpName" runat="server" /> </td>
            </tr>
            <tr>
                <th>Employee Job </th>
                <th>:</th>
                <td> <asp:Label ID="lblEmpJob" runat="server" /> </td>
            </tr>
            <tr>
                <th>Employee Salary</th>
                <th>:</th>
                <td> <asp:Label ID="lblEmpSalary" runat="server" /> </td>
            </tr>
            <tr>
                <th>Depertmant Name </th>
                <th>:</th>
                <td> <asp:Label ID="lblDeptName" runat="server" /> </td>
            </tr>
            <tr>
                <td style="text-align:center" colspan="3">
                    <asp:Button ID="btnFirst" runat="server" Text="First" OnClick="btnFirst_Click" />&nbsp
                    <asp:Button ID="btnPrevious" runat="server" Text="Previous" OnClick="btnPrevious_Click" />&nbsp
                    <asp:Button ID="btnNext" runat="server" Text="Next" OnClick="btnNext_Click" />&nbsp
                    <asp:Button ID="btnLast" runat="server" Text="Last" OnClick="btnLast_Click" />&nbsp
                </td>
            </tr>
            <tr>
                <th style="text-align:center" colspan="3"><asp:Label ID="lblStatus" runat="server" /></th>
            </tr>
        </table>
            </div>
    </form>
</body>
</html>
