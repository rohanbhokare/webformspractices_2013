<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default20.aspx.cs" Inherits="Default20" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <style>
        td, th {
            text-align:center;
        }


    </style>
<body>
    <form id="form1" runat="server">
    <asp:Repeater ID="Repeter1" runat="server" OnItemCommand="Repeter1_ItemCommand" OnItemDataBound="Repeter1_ItemDataBound">
        <HeaderTemplate>
            <table width="100%" border="1">
            <tr style="background-color:#00A352">
                <th colspan="6" >Employee Data</th>
            </tr>
            <tr style="background-color:#00cc66">
                <th width="20%"></th>
                <th width="10%">EmpId</th>
                <th width="15%">EmpName</th>
                <th width="20%">EmpJob</th>
                <th width="15%">EmpSalary</th>
                <th width="20%">DeptName</th>
            </tr>
             </table>
        </HeaderTemplate>
       <ItemTemplate>
            <table width="100%" border="1">
               <tr style="background-color:#66E0A3;">
                <td width="20%">
                    <asp:Button ID="btnEdit" runat="server" Text="Edit" CommandName="Edit" CommandArgument='<%#Eval("EmpId") %>' />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" CommandName="Delete" CommandArgument='<%#Eval("EmpId") %>' OnClientClick="return confirm('Ae you sure?');" />
                </td>
                 
                <td width="10%"><%#Eval("EmpId") %></td>
                <td width="15%"><%#Eval("EmpName") %></td>
                <td width="20%"><%#Eval("EmpJob") %></td>
                <td width="15%"><asp:Label ID="lblSalary" runat="server" Text='<%#Eval("EmpSalary") %>'></asp:Label></td>
                <td width="20%"><%#Eval("DeptName") %></td>
            </tr>
            </table>
            </ItemTemplate>
        
        <AlternatingItemTemplate>
                        <table border="1" width="100%">
               <tr style="background-color:#B2F0D1;">
                <td width="20%">
                    <asp:Button ID="btnEdit" runat="server" Text="Edit" CommandName="Edit" CommandArgument='<%#Eval("EmpId") %>' />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" CommandName="Delete" CommandArgument='<%#Eval("EmpId") %>' onClientClick="return confirm('Are You Sure');" />
                </td>
                 
                <td width="10%"><%#Eval("EmpId") %></td>
                <td width="15%"><%#Eval("EmpName") %></td>
                <td width="20%"><%#Eval("EmpJob") %></td>
                <td width="15%"><asp:Label ID="lblSalary" runat="server" Text='<%#Eval("EmpSalary") %>'></asp:Label></td>
                <td width="20%"><%#Eval("DeptName") %></td>
            </tr>
            </table>

        </AlternatingItemTemplate>    
        <FooterTemplate>
            <table width="100%" border="1">
                <tr style="background-color:#00cc66;">
                <th width="20%" style="text-align:right;">No. of Employees</th>
                <th width="10%" style="text-align:left;"><asp:Label ID="lblTotalRecords" runat="server"></asp:Label></th>
                <th width="35%" colspan="2" style="text-align:right;" >Total Salary</th>
                <th width="35%" colspan="2" style="text-align:left;"><asp:Label ID="lblGrandTotalSalary" runat="server"></asp:Label></th>
                </tr>
            </table>
        </FooterTemplate>
    </asp:Repeater>
    </form>
</body>
</html>
