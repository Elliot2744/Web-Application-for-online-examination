<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentLogin.aspx.cs" Inherits="OnlineExam.studentLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Meta tags -->
		<meta charset="UTF-8">
		<meta name="viewport" content="width=device-width, initial-scale=1.0">
		<meta http-equiv="X-UA-Compatible" content="ie=edge">
		<!-- //Meta tags -->
    <link rel="stylesheet" href="studentLogin/css/style.css" type="text/css" media="all" /><!-- Style-CSS -->
    <link href="studentLogin/css/font-awesome.css" rel="stylesheet"><!-- font-awesome-icons -->

</head>
<body>
    <form id="form1" runat="server">
      
	<section class="w3l-form-36">
		<div class="form-36-mian section-gap">
			<div class="wrapper">
				<div class="form-inner-cont">
					<h3>Login</h3>
					<form action="#" method="post" class="signin-form">
							


						<div class="form-input">
							<span class="fa fa-envelope-o" aria-hidden="true"></span> <asp:TextBox ID="Sloginemail" runat="server" placeholder="Email"></asp:TextBox>
						</div> <!--email-->
						<div class="form-input">
							<span class="fa fa-key" aria-hidden="true"></span>  <asp:TextBox ID="Sloginpass" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
					</div><!--password-->
						
							<div class="text-right">
                                <asp:LinkButton ID="Sforgotpass" runat="server" OnClick="Sforgotpass_Click">Forgot password ?</asp:LinkButton>
							</div>
						
							<div class="login-remember d-grid">
							<asp:Label ID="Sloginerror" runat="server" ForeColor="#CC0000"></asp:Label>
							</div>


						<div class="login-remember d-grid">	
								<asp:Button ID="Slogin" runat="server" Text="Login" class="btn theme-button" OnClick="Slogin_Click"/>
								<asp:Button ID="Ssignup" runat="server" Text="Signup" class="btn theme-button" OnClick="Ssignup_Click"/>		
						</div>
						

					</form>
					
			</div>
	
	</section>
    </form>
</body>
</html>

