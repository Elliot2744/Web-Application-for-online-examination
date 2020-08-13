<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SetQuestionPaper.aspx.cs" Inherits="OnlineExam.SetQuestionPaper" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lb_ques" runat="server"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="tb" runat="server" TextMode="MultiLine"></asp:TextBox>
            <br />
            <asp:Label ID="options" runat="server">OPTIONS : </asp:Label>
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="ans"/>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="ans"/>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="ans"/>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:RadioButton ID="RadioButton4" runat="server" GroupName="ans" />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Ques" />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Submit" />
            <asp:Panel ID="Panel1" runat="server" Height="65px">
            </asp:Panel>
        </div>
    </form>
</body>

</html>
