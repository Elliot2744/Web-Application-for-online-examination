<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherHomePage1.aspx.cs" Inherits="OnlineExam.TeacherHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Enter subject:<asp:TextBox ID="tb_subject" runat="server"></asp:TextBox>
        <br />
        Enter syllabus:<asp:TextBox ID="tb_syllabus" runat="server"></asp:TextBox>
        <br />
        Enter date_time:<asp:TextBox ID="tb_date_tm" runat="server"></asp:TextBox>
        <br />
        Enter limit:<asp:TextBox ID="tb_tm_limit" runat="server"></asp:TextBox>
        <div>
            <asp:Button ID="btn" runat="server" OnClick="btn_Click" Text="generate" />
        &nbsp;<asp:Button ID="btn_result" runat="server"  Text="View Result" OnClick="btn_result_Click" />
        </div>
    </form>
</body>
</html>
