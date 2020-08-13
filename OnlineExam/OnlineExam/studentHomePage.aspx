<%@ Page Title="" Language="C#" MasterPageFile="~/StudentHome.Master" AutoEventWireup="true" CodeBehind="studentHomePage.aspx.cs" Inherits="OnlineExam.studentHomePage1" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content-wrapper">
        <div class="content-header">
            <div class="container-fluid">
   <!--place your content-->
                
                <asp:TextBox ID="tb_enter_rid" runat="server"></asp:TextBox>
                <asp:Button ID="btn_entereid" runat="server" Text="Button" OnClick="btn_entereid_Click" />
                
                

                <asp:Repeater ID="Repeater1" runat="server" >
                     <ItemTemplate>
            
            <section class="content">
      <div class="container-fluid">
    
             <div class="row">
          <div class="col-lg-3 col-6">
            <!-- small box -->
           <div class="small-box bg-info">
              <div class="inner">
                <h1><%#Eval("subject")%></h1>
                <p><%#Eval("syllabus")%> </p>
                  <p><%#Eval("date_time")%> </p>
                  <p><%#Eval("time_limit")%></p>
              </div>
                <div>
                <asp:LinkButton ID="lb_" runat="server" OnCommand="Click" CommandName="Click" CommandArgument='<%# Eval("eid") %>' >LinkButton</asp:LinkButton>
            </div>
            </div>
          </div>
        </div>
          </div>
   </section>

        </ItemTemplate>
        

                </asp:Repeater>
            
            
            
            
            </div>
            </div>
        </div>

</asp:Content>
