<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default23.aspx.cs" Inherits="Default23RepeaterAssignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            text-align:center;
            background-color:#E65C00;
        }

        td {
            text-align:center;
            border-style:solid;
            border-width:thin;
        }
        table {
            border-style:solid;
            border-width:thin;
        }
        div {
            margin-bottom:0px;
            margin-top:0px;
        }
       /*.tblDept {
         ;  
        }*/
        .divLocation {
            background-color:#ff6600;
            text-align:center; 
            margin-left:150px; 
            margin-right:150px;
            margin-top:10px;
        }
        .divDept {
            background-color:#FFB280;
            margin-left:10px;
            margin-right:10px;
            margin-bottom:20px;
        }
        .divEmp {
            background-color:#FFE0CC;
            margin-left:10px;
            margin-right:10px;
            margin-bottom:20px;
            
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="divLocation">
    <asp:Repeater ID="RepeaterLocation" runat="server" OnItemDataBound="RepeaterLocation_ItemDataBound">
        <HeaderTemplate> 
            <div style="background-color:#ff6600">
                <h1>Locations-wise Employee Data</h1>
            </div>
        </HeaderTemplate>
        <ItemTemplate><b>Location : </b> <%# Eval("LocationName") %> <asp:Label ID="lblLocationId" runat="server" Text='<%# Eval("LocationId") %>' Visible="false" />
                                <div class="divDept"> 
                <asp:Repeater ID="RepeaterDept" runat="server" OnItemDataBound="RepeaterDept_ItemDataBound">
                    <ItemTemplate>
                        <b>Dept Name : </b> <%# Eval("DeptName") %> <asp:Label ID="lblDeptId" runat ="server"  Text='<%# Eval("DeptId") %>' Visible="false" />
                        <div class="divEmp">
                            <asp:Repeater ID="RepeaterEmp" runat="server" OnItemDataBound="RepeaterEmp_ItemDataBound">
                            <HeaderTemplate>
                                <table class="tblDept" width="100%">
                                    <tr>
                                        <th width="20%"> EmpId </th>
                                        <th width="20%"> Emp Name </th>
                                        <th width="20%"> Emp Job </th>
                                        <th width="20%"> EmpSalary </th>
                                        <th width="20%"> DeptName </th>
                                    </tr>
                                </table>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <table class="tblDept" width="100%">
                                    <tr>
                                        <td width="20%"> <%# Eval("EmpId") %> </td>
                                        <td width="20%"> <%# Eval("EmpName") %> </td>
                                        <td width="20%"> <%# Eval("EmpJob") %> </td>
                                        <td width="20%"> <asp:Label ID="lblSalary" runat="server" Text='<%# Eval("EmpSalary") %>'/> </td>
                                        <td width="20%"> <%# Eval("DeptName") %> </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                            <FooterTemplate>
                                <table class="tblDept" width="100%">
                                    <tr>
                                        <th width="20%" style="text-align:left">Total Employee : <asp:Label ID="lblEmpCount" runat="server" /></th>
                                        <th width="20%" colspan="2" style="text-align:right">Total Salary :</th>
                                        <th width="20%" colspan="2" style="text-align:left"><asp:Label ID="lblEmpTotalSalary" runat="server" /></th>
                                    </tr>
                                </table>
                            </FooterTemplate>
                        </asp:Repeater>
                        </div>  <%--divEmp end--%>
                        <asp:Label ID="lblDeptStatus" runat="server" />
                        <asp:Label ID="lblEmpStatus" runat="server" />
                    </ItemTemplate>
                    <FooterTemplate>
                        <table width="100%">
                                <tr>
                                    <th width="20%" style="text-align:left">Total Employee(Location): <asp:Label ID="lblDeptEmpCount" runat="server" /></th>
                                    <th width="20%" colspan="2" style="text-align:right">Total Salary(Location):</th>
                                    <th width="20%" colspan="2" style="text-align:left"><asp:Label ID="lblDeptEmpTotalSalary" runat="server" /></th>
                                </tr>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
                                            </div>  <%--divDept end--%>
        </ItemTemplate>
        <FooterTemplate>
            <table width="100%">
                                <tr>
                                    <th width="20%" style="text-align:left">Grand Total Employee: <asp:Label ID="lblGTEmployee" runat="server" /></th>
                                    <th width="20%" colspan="2" style="text-align:right">Grand Total Salary</th>
                                    <th width="20%" colspan="2" style="text-align:left"><asp:Label ID="lblGTSalary" runat="server" /></th>
                                </tr>
                            </table>
             </FooterTemplate>
    </asp:Repeater>
                </div><%-- divlocation end--%>
    </form>
</body>
</html>
