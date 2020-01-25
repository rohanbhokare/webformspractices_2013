<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FileUploadChallengingAssig.aspx.cs" Inherits="Default38" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:lightblue">
    <form id="form1" runat="server">
    <div style="text-align:center">
        <br />
        <b>File Upload:</b>
        <asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="true"/>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Upload" OnClick="Button1_Click"  />
        <br />
        <asp:Label ID="lblResult1" runat="server" />
        <asp:Label ID="lblResult2" runat="server" />

    <br />
    </div>
    </form>
</body>
</html>
