using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExam
{
    public partial class Teacher_forgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_ToSetNewPassword_Click(object sender, EventArgs e)
        {
            Session["forgotPassword_email"] = tb_Temail_newpassword.Text;
            
            sendMail("A request to change password was made. Click the below link to reset password.\n\n https://localhost:44383/Reset_password.aspx");

            redirect("Password reset link was send to your mail");

        }

        private void sendMail(string msg)
        {
            MailMessage mailMessage = new MailMessage("18it013@charusat.edu.in", tb_Temail_newpassword.Text);
            mailMessage.Subject = "Request For Change Password";
            mailMessage.Body = msg;

            SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
            sc.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "18it013@charusat.edu.in",
                Password = "uzumymw@#4"

            };

            sc.EnableSsl = true;
            sc.Send(mailMessage);
        }

        private void redirect(string message)
        {
            string url = "Teacher_Login.aspx";
            string script = "window.onload = function(){ alert('";
            script += message;
            script += "');";
            script += "window.location = '";
            script += url;
            script += "'; }";
            ClientScript.RegisterStartupScript(this.GetType(), "Redirect", script, true);
        }
    }
}