<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="verifyUser.aspx.cs" Inherits="OnlineExam.verifyMail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Verification</title>
</head>
<body style="background-color:antiquewhite">
    <form id="form1" runat="server">
        <div>
            
            <asp:Label ID="lbl_welcome" runat="server" ForeColor="Blue"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_press" runat="server" ForeColor="Blue"></asp:Label>
            <br />
            <asp:Button ID="btn_final" runat="server" Text="Click" OnClick="btn_final_Click" />
            
        </div>
    </form>
</body>
</html>
