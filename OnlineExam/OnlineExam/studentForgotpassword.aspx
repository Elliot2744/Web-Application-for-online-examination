<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentForgotpassword.aspx.cs" Inherits="OnlineExam.studentForgotpassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 370px;
        }
        .auto-style3 {
            width: 345px;
            text-align: center;
        }
        .auto-style4 {
            width: 370px;
            text-align: right;
        }
        .auto-style5 {
            width: 345px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Reset Password"></asp:Label>
                    <br />
                    <br />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label2" runat="server" Text="Enter your Email :"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="Sresetpassemail" runat="server" Width="277px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Sreset" runat="server" OnClick="Button1_Click" Text="Send Reset Link" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        
    </form>
</body>
</html>
