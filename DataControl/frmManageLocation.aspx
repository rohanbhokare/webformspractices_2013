<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmManageLocation.aspx.cs" Inherits="_Default" Theme="DataControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .btn {
            background-color: Maroon;
            border-color: blue;
            color: White;
        }
        .td {
            float:left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
<table width="50%">
    <tr>
        <td width="100%">
            Location Name:
            <asp:TextBox ID="txtlocationSearch" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search" />
        </td>
    </tr>
    <tr>
        <td width="100%">
            <asp:Button ID="btnSelectAll" runat="server" Text="Select-All" />
            <asp:Button ID="btnDeSelectAll" runat="server" Text="De-select All" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" />
            <asp:Button ID="btnAddNew" runat="server" Text="Add New" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:GridView width="100%" ID="gvLocation" runat="server" AutoGenerateColumns="false" style="margin-right: 208px">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:CheckBox ID="chk" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ButtonType="Link" ShowEditButton="true" />
                    <asp:BoundField HeaderText="Location Name" DataField="LocationName" />
                    <asp:CheckBoxField HeaderText="Is Active" DataField="IsActive" /> 
                </Columns>
            </asp:GridView>
        </td>
    </tr>
        <tr>
        <td width="100%">
            <asp:Button ID="Button1" runat="server" Text="Select-All" />
            <asp:Button ID="Button2" runat="server" Text="De-select All" />
            <asp:Button ID="Button3" runat="server" Text="Delete" />
            <asp:Button ID="Button4" runat="server" Text="Add New" />
        </td>
    </tr>
</table>
    </form>
</body>
</html>
