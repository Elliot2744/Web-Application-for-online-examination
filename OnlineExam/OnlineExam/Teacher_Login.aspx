<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Teacher_Login.aspx.cs" Inherits="OnlineExam.Teacher_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <title>Teacher Login</title>
		<!-- Meta tags -->
		<meta charset="UTF-8">
		<meta name="viewport" content="width=device-width, initial-scale=1.0">
		<meta http-equiv="X-UA-Compatible" content="ie=edge">
		<!-- //Meta tags -->
    <link rel="stylesheet" href="Material/TeacherLogin/css/teacher_registration_style.css" type="text/css" media="all" /><!-- Style-CSS -->
    <link href="Material/TeacherLogin/css/teacher_registration_font-awesome.css" rel="stylesheet"><!-- font-awesome-icons -->
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
							<span class="fa fa-envelope-o" aria-hidden="true"></span> <asp:TextBox ID="Temail_login" runat="server" TextMode="Email" placeholder="Email"></asp:TextBox>
						</div> <!-- Email -->
						
						<div class="form-input">
							<span class="fa fa-key" aria-hidden="true"></span><asp:TextBox ID="Tpassword_login" runat="server" TextMode="Password" placeholder="Password" ></asp:TextBox>
						</div> <!-- Password -->
						
						<div class="label_password">
							<asp:Label ID="lbl_TcheckPassword" runat="server" ForeColor="Red"></asp:Label>
						&nbsp;</div>


                        

						<div class="text-right">
							<asp:LinkButton ID="forgotPassword" runat="server" ForeColor="BlueViolet" OnClick="forgotPassword_Click">forgot password?</asp:LinkButton>
						</div>
                        
						
						<div class="login-remember d-grid">
							<asp:Button ID="Btn_TLogin" class="btn theme-button" runat="server" Text="Login" OnClick="Btn_TLogin_Click"  />
							<asp:Button ID="Btn_to_TRegistration" class="btn theme-button" runat="server" Text="SignUp" OnClick="Btn_to_TRegistration_Click"/>

						</div>
					</form>
					
				</div>
					
				</div>
			</div>
	</section>
    </form>
</body>
</html>
