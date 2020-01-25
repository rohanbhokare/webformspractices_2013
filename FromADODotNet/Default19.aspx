<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default19.aspx.cs" Inherits="Default19" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    th{
    text-align:left;
    }
        </style>
</head>

<body>
    <form id="form1" runat="server">
    <table>
        <tr>
            <th>Enter Name:</th>
            <td>
                <asp:TextBox ID="txtName" runat ="server" />
            </td>
        </tr>
        <tr>
            <th>Enter Subject:</th>
            <td>
                <asp:TextBox ID="txtSubject" runat ="server" />
            </td>
        </tr>
        <tr>
            <th style="vertical-align:top">Enter Comment:</th>
            <td>
                <asp:TextBox ID="txtComment" runat ="server" TextMode="MultiLine" Rows ="5" Columns ="50" />
            </td>
        </tr>
        <tr>
            <td>

            </td>
            <td><asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /> </td>
        </tr>
    </table>
        <asp:Repeater ID="Repeter1" runat ="server">
            <HeaderTemplate >
                <table style="border: 1px solid red; width: 500px">
                    <tr style="background-color: #00cccc; color: darkblue">
                        <td>
                            <b>Comments</b>
                        </td>                         
                    </tr> 
                    </table>                    
             </HeaderTemplate>
            <ItemTemplate>
                <table>
                <tr style="background-color:lightpink">
                    <th width="20%">Subject &nbsp <%#Eval("Subject") %></th>
                    <td> </td>
                </tr>
                 <tr>
                    <td colspan="2"><%#Eval("Comment") %>    </td>
                </tr>
                <tr style="background-color:lightpink">
                    <td width="50%"><b>Posted By</b> : &nbsp <%#Eval("UserName") %></td>
                    <td width="50%"><b>Posted Date</b> : &nbsp <%#Eval("PostedDate") %></td>
                </tr>
                </table>
            </ItemTemplate>
            <FooterTemplate>
            </FooterTemplate>
            <SeparatorTemplate>
                <br />
            </SeparatorTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
