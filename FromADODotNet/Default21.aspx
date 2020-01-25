<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default21.aspx.cs" Inherits="Default21" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <table>
        <tr>
            <td> EmpName </td>
            <td>:</td>
            <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td> EmpJob </td>
            <td>:</td>
            <td><asp:TextBox ID="txtEmpJob" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td> EmpSalary </td>
            <td>:</td>
            <td><asp:TextBox ID="txtEmpSalary" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td> Dept Name</td>
            <td>:</td>
            <td>
                <asp:DropDownList ID="ddlDept" runat="server"></asp:DropDownList> </td>
        </tr>


        <tr>
            <td> &nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Close" Height="26px" OnClick="btnCancel_Click" />

            </td>
        </tr>


    </table>
        <asp:Label ID="lblStatus" runat="server"></asp:Label>
    </form>
</body>
</html>
