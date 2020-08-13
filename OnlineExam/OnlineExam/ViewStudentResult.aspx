<%@ Page Title="" Language="C#" MasterPageFile="~/StudentHome.Master" AutoEventWireup="true" CodeBehind="ViewStudentResult.aspx.cs" Inherits="OnlineExam.ViewStudentResult" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-wrapper">
        <div class="content-header">
            <div class="container-fluid">
                <h1>Result</h1>
                <asp:GridView ID="GridView1" runat="server" ></asp:GridView>
                </div>
            </div>
        </div>


</asp:Content>
