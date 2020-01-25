<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DataBoundControls.aspx.cs" Inherits="DataBoundControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1> Data Controls </h1>
        <table>
            <tr>
                <td width="25%">Data-Bound Controls</td>
                <td width="2%">:</td>
                <td width="30%"><asp:DropDownList ID="DropDownList1" runat="server" Width="100%" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>Repeater</asp:ListItem>
                        <asp:ListItem>DataList</asp:ListItem>
                        <asp:ListItem>GridView</asp:ListItem>
                        <asp:ListItem>DetailsView</asp:ListItem>
                        <asp:ListItem>FormView</asp:ListItem>
                    <asp:ListItem>ListView</asp:ListItem>
                    </asp:DropDownList>
                 </td>
                <td width="43%"></td>
            </tr>
            <tr>
                <td>Data Source Controls </td>
                <td>:</td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server" Width="100%">
                        <asp:ListItem>SqlDataSource</asp:ListItem>
                        <asp:ListItem>ObjectDataSource</asp:ListItem>
                        <asp:ListItem>AccessDataSource</asp:ListItem>
                        <asp:ListItem>XmlDataSource</asp:ListItem>
                        <asp:ListItem>SiteMapDataSource</asp:ListItem>
                        <asp:ListItem>LinqDataSource</asp:ListItem>
                        <asp:ListItem>EntityDataSource</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>DataPager </td>
                <td>:</td>
                <td></td>
            </tr>
            <tr>
                <td>Chart</td>
                <td>:</td>
                <td></td>
            </tr>
            <tr>
                <td>QueryExtender</td>
                <td>:</td>
                <td></td>
            </tr>
    </table>
        <br />
        <br />
        <asp:Label ID ="lblContent" runat ="server" />
    </div>
        <div>

        </div>
    </form>
</body>
</html>
