<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Teacher_Registration.aspx.cs" Inherits="OnlineExam.Teacher_Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Teacher Registration</title>
		<!-- Meta tags -->
		<meta charset="UTF-8">
		<meta name="viewport" content="width=device-width, initial-scale=1.0">
		<meta http-equiv="X-UA-Compatible" content="ie=edge">
		<!-- //Meta tags -->
    <link rel="stylesheet" href="Material/TeacherRegistration/css/teacher_registration_style.css" type="text/css" media="all" /><!-- Style-CSS -->
    <link href="Material/TeacherRegistration/css/teacher_registration_font-awesome.css" rel="stylesheet"><!-- font-awesome-icons -->
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
							<span class="fa fa-user-o" aria-hidden="true"></span> <asp:TextBox ID="Tname" runat="server" TextMode="SingleLine" placeholder="Name" required></asp:TextBox>
						</div>   <!-- Name -->
						<div class="form-input">
							<span class="fa fa-envelope-o" aria-hidden="true"></span> <asp:TextBox ID="Temail" runat="server" TextMode="Email" placeholder="Email" required></asp:TextBox>
						</div> <!-- Email -->
						<div class="form-input">
                           
							<span class="fa fa-graduation-cap" aria-hidden="true"></span> <asp:TextBox ID="Tdept" runat="server" TextMode="SingleLine" placeholder="Department" required></asp:TextBox>
						</div> <!-- DEPT -->
						<div class="form-input">
							<span class="fa fa-university" ></span> <asp:TextBox ID="Tcollege" runat="server" TextMode="SingleLine" placeholder="College" required></asp:TextBox>
						</div> <!-- College -->
				
						<div class="form-input">
							<span class="fa fa-key" aria-hidden="true"></span><asp:TextBox ID="Tpassword" runat="server" TextMode="Password" placeholder="Password" required></asp:TextBox>
						</div> <!-- Password -->
						<div class="form-input">
							<span class="fa fa-key" aria-hidden="true"></span> <asp:TextBox ID="Tconfirm_password" runat="server" TextMode="Password" placeholder="Confirm Password" required ></asp:TextBox>
								
						</div> <!-- Confirm Password -->

                        <asp:Label ID="lbl_Tconfirm_password" runat="server" ForeColor="Red"></asp:Label>
						
						<div class="login-remember d-grid">
							<asp:Button ID="Btn_TRegistration" class="btn theme-button" runat="server" Text="SignUp" OnClick="Btn_TRegistration_Click1" />
							

						</div>
					</form>
					
				</div>
					
				</div>
			</div>
	</section>
    </form>
</body>
</html>
