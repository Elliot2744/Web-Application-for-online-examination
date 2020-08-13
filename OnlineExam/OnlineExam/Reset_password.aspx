<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reset_password.aspx.cs" Inherits="OnlineExam.Reset_password" %>

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
<body style="background-color:antiquewhite">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <br />
            <br />
            <br />
            <br />
            Enter New Password:
            <asp:TextBox ID="tb_newPwd" runat="server" TextMode="Password"></asp:TextBox>

            <br />
&nbsp;Confirm Password:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tb_newPwd_confirm" runat="server" TextMode="Password"></asp:TextBox>

            <br />

            <asp:Label ID="lbl_wrongCpwd" runat="server" ForeColor="Red"></asp:Label>

            <br />

            <asp:Button ID="btn_resetPwd" runat="server" Text="Reset Password" OnClick="btn_resetPwd_Click"  />
        </div>

       
    </form>
</body>
</html>
