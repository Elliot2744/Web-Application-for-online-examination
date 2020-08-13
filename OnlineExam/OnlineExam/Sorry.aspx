<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sorry.aspx.cs" Inherits="OnlineExam.Sorry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sorry</title>

 <script type="text/javascript">
    /* document.addEventListener("visibilitychange", function () {

         i++;
         document.title = document.visibilityState;
         console.log(document.visibilityState);

        // window.location.href = "https://localhost:44383/studentLogin.aspx";
     }); */
</script>

</head>
<body onunload="fun();">

    <form id="form1" runat="server">
        <div>
            <h2 style="color:red">You are disqualified from the exam.<br /> Press the below button to continue</h2>
            <asp:Button ID="btn_ToLoginPage" runat="server" Text="Continue" OnClick="btn_ToLoginPage_Click" />
        </div>
    </form>

</body>
</html>
