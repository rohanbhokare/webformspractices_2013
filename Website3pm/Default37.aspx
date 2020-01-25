<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default37.aspx.cs" Inherits="Default37" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <b>UploadFile:</b><asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="true" />
        <br />
        <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" />
        <br />
        <asp:Label ID="lblresult" runat="server" />
    </div>
    </form>
</body>
</html>
