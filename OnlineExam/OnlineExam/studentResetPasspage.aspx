<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentResetPasspage.aspx.cs" Inherits="OnlineExam.studentResetPasspage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 275px;
        }
        .auto-style2 {
            width: 275px;
            text-align: right;
        }
        .auto-style3 {
            width: 315px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
      
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="New password"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="Snewpass" runat="server" TextMode="Password" Width="244px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Confirm New Password"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="Scnewpass" runat="server" TextMode="Password" Width="240px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Reset password" Width="130px" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
      
    </form>
</body>
</html>
