<%@ Page Title="" Language="C#" MasterPageFile="~/TeacherHome.Master" AutoEventWireup="true" CodeBehind="TeacherHomePage.aspx.cs" Inherits="OnlineExam.TeacherHomePage1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="content-wrapper">
        <div class="content-header">
            <div class="container-fluid">
                  Enter subject:<asp:TextBox ID="tb_subject" runat="server"></asp:TextBox>
        <br />
        Enter syllabus:<asp:TextBox ID="tb_syllabus" runat="server"></asp:TextBox>
        <br />
        Enter date_time:<asp:TextBox ID="tb_date_tm" runat="server"></asp:TextBox>
        <br />
        Enter limit:<asp:TextBox ID="tb_tm_limit" runat="server"></asp:TextBox>
        <div>
            <asp:Button ID="btn" runat="server" OnClick="btn_Click" Text="generate" />
        &nbsp;
        </div>
            </div>
        </div>
        </div>


</asp:Content>
