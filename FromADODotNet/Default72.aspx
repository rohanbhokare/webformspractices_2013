<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default72.aspx.cs" Inherits="Default72" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 127px;
        }
        .auto-style2 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

    <table width="100%" border="1">
        <tr style="background-color:aquamarine">
            <td colspan="2" align="center">
                User Registration/ Login Form
            </td>
        </tr>
        <tr>
            <td> 
                <table>
                    <tr>
                        <td colspan="3" align="center" class="auto-style2"></td>
                    </tr>
                       <tr>
                        <td class="auto-style1"> First Name</td>
                        <td width="2%">:</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="Reg"></asp:TextBox>
                           <asp:RequiredFieldValidator ID="rfv1" runat="server" ErrorMessage="Plz Enter Name" ValidationGroup="Reg" ControlToValidate="TextBox1" Display="None"  ></asp:RequiredFieldValidator>
                            </td>
                    </tr>
                       <tr>
                        <td class="auto-style1">LastName</td>
                        <td>:</td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" ValidationGroup="Reg"></asp:TextBox>
                           <asp:RequiredFieldValidator ID="rfv2" runat="server" ErrorMessage="Plz Enter Last Name" ControlToValidate="TextBox2" Display="None" ValidationGroup="Reg"  ></asp:RequiredFieldValidator>
                            </td>
                    </tr>
                       <tr>
                        <td class="auto-style1">EmailId</td>
                        <td>:</td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server" ValidationGroup="Reg"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfv3" runat="server" ErrorMessage="Plz Enter Email" ControlToValidate="TextBox3" Display="None" ValidationGroup="Reg"  ></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="rev1" runat="server"  ControlToValidate="TextBox3" ValidationGroup="Reg" ErrorMessage="Email is not Valide" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"  Display="None"></asp:RegularExpressionValidator>
                           </td>
                    </tr>
                       <tr>
                        <td class="auto-style1">Password</td>
                        <td>:</td>
                        <td>
                            <asp:TextBox ID="TextBox4" runat="server" ValidationGroup="Reg"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rev" runat="server" ErrorMessage="Plz Enter Password" ControlToValidate="TextBox4" Display="None" ValidationGroup="Reg"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                       <tr>
                        <td class="auto-style1">Confirm password</td>
                        <td>:</td>
                        <td>
                            <asp:TextBox ID="TextBox5" runat="server" ValidationGroup="Reg"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Plz Enter confirm Password" ControlToValidate="TextBox5" Display="None" ValidationGroup="Reg"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="CompareValidator" ControlToValidate="TextBox5" ControlToCompare="TextBox4" ValidationGroup="Reg" Display="None"></asp:CompareValidator>
                        </td>
                    </tr>
                       <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="Button" ValidationGroup="Reg" />
                           </td>
                    </tr>
                </table>
            </td>
            <td width="50%" valign="top">
                <table>
                    <tr>
                        <td colspan="3" class="auto-style2">Login</td>
                    </tr>
                    <tr>
                        <td>Login ID</td>
                        <td>:</td>
                        <td style="margin-left: 40px">
                            <asp:TextBox ID="TextBox6" runat="server" OnTextChanged="TextBox6_TextChanged" ValidationGroup="login"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Enter User Id" ControlToValidate="TextBox6" Display="None" ValidationGroup="login"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Password  
                        </td>
                        <td>:</td>
                        <td style="margin-left: 40px">
                            <asp:TextBox ID="TextBox7" runat="server" OnTextChanged="TextBox6_TextChanged" ValidationGroup="login"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="plz enter Password" ControlToValidate="TextBox7" Display="None" ValidationGroup="login"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td style="margin-left: 40px">
                            <asp:Button ID="Button2" runat="server" Text="Button" ValidationGroup="login" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="true" ShowSummary="false" ValidationGroup="Reg" />
        <asp:ValidationSummary ID="ValidationSummary2" runat="server" ShowMessageBox="true" ShowSummary="false" ValidationGroup="login" />
    </form>
</body>
</html>
