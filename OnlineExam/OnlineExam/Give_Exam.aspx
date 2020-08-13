<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Give_Exam.aspx.cs" Inherits="OnlineExam.Give_Exam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Give_Exam</title>

    <script>
        
        let i = 0;
        document.addEventListener("visibilitychange", function () {

            i++;
            document.title = document.visibilityState;
            console.log(document.visibilityState);


            window.open("Sorry.aspx");
            //window.location.href = "https://localhost:44383/Sorry.aspx";
        }); 

       

    </script>

</head>
<body>
    <form id="form1" runat="server">
       
            <div>&nbsp; 
                <br />
                <br />
            </div>
            <div>
                
                <asp:Panel ID="Panel1" runat="server"></asp:Panel>
                <br />
                <br />

            <asp:Button ID="btn_revQues" runat="server" Text="See all review question." OnClick="btn_revQues_Click" UseSubmitBehavior="false" />
                &nbsp;&nbsp;
            <asp:Label ID="lb_revQues" runat="server"></asp:Label>

                <br />
                <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" UseSubmitBehavior="false"/>
&nbsp;
            <asp:Label ID="lb_marks" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
