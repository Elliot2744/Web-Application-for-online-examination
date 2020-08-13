<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentRegistration.aspx.cs" Inherits="OnlineExam.studentRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    	<!-- Meta tags -->
		<meta charset="UTF-8"/>
		<meta name="viewport" content="width=device-width, initial-scale=1.0"/>
		<meta http-equiv="X-UA-Compatible" content="ie=edge"/>
		<!-- //Meta tags -->
    <link rel="stylesheet" href="studentRegistration/css/style.css" type="text/css" media="all" /><!-- Style-CSS -->
    <link href="studentRegistration/css/font-awesome.css" rel="stylesheet"/><!-- font-awesome-icons -->
</head>
<body>
    <form id="form1" runat="server">
        
	<section class="w3l-form-36">
		<div class="form-36-mian section-gap">
			<div class="wrapper">
				<div class="form-inner-cont">
					<h3>Create your account</h3>
					<form action="#" method="post" class="signin-form">
						<div class="form-input">
							<span class="fa fa-user-o" aria-hidden="true"></span> <asp:TextBox ID="Sname" runat="server" placeholder="Name" required></asp:TextBox>
						</div> <!--name-->
						<div class="form-input">
							<span class="fa fa-envelope-o" aria-hidden="true"></span> <asp:TextBox ID="Semail" runat="server" placeholder="Email" required></asp:TextBox>
						</div> <!--email-->
						<div class="form-input">
							<span class="fa fa-graduation-cap" aria-hidden="true"></span> <asp:TextBox ID="Sdept" runat="server" placeholder="Department" required></asp:TextBox>
						</div><!--dept-->
						<div class="form-input">
							<span class="fa fa-university" ></span> <asp:TextBox ID="Sclg" runat="server" placeholder="College name" required></asp:TextBox> 
						</div><!--clg-->
						
						<!--MOBILE no-->
						
						<div class="form-input">
							<span class="fa fa-key" aria-hidden="true"></span>  <asp:TextBox ID="Spass" runat="server" placeholder="Password" required TextMode="Password"></asp:TextBox>
						</div><!--password-->
						<div class="form-input">
							<span class="fa fa-key" aria-hidden="true"></span> <asp:TextBox ID="Scpass" runat="server" placeholder="Confirm Password " required TextMode="Password"></asp:TextBox>
						</div><!--confirm password-->
						
						<div class="login-remember d-grid">
							<asp:Button ID="Ssignup" runat="server" Text="Signup" class="btn theme-button" OnClick="Ssignup_Click" />
						</div>
					</form>
					

				</div>
		
	</section>

    </form>
</body>
</html>