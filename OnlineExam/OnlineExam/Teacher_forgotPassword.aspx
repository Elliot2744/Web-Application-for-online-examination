<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Teacher_forgotPassword.aspx.cs" Inherits="OnlineExam.Teacher_forgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Enter your email :
            <asp:TextBox ID="tb_Temail_newpassword" runat="server" Width="302px"></asp:TextBox>
            <br />
            <asp:Button ID="btn_ToSetNewPassword" runat="server" OnClick="btn_ToSetNewPassword_Click" Text="Send" />
        </div>
    </form>
</body>
</html>
