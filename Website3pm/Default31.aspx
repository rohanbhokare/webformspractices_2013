<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default31.aspx.cs" Inherits="Default31" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:RadioButton ID="rdb1" runat="server" Text="Radio Button 1" Checked="true" GroupName="grp" AutoPostBack="true" OnCheckedChanged="rdb1_CheckedChanged" />
    <asp:RadioButton ID="rdb2" runat="server" Text="Radio Button 2"  GroupName="grp" AutoPostBack="true" OnCheckedChanged="rdb1_CheckedChanged" />
        <asp:Panel ID="Panel1" runat="server" Visible="true" BorderStyle="Solid" BorderColor="Red" BorderWidth="2px" ForeColor="Maroon" Width="200px" HorizontalAlign="Justify">
            <h3>Content and other control releted to RadioButton1 </h3>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Visible="false" BorderStyle="Solid" BorderColor="Green" BorderWidth="2px" ForeColor="Maroon" Width="200px" HorizontalAlign="Justify" >
            <h3>Content and other control releted to RadioButton2 </h3>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
