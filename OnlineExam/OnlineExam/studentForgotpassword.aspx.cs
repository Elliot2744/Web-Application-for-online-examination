using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExam
{
    public partial class studentForgotpassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        void sendmail()
        {
            MailMessage mm = new MailMessage("squad.onlineexam@gmail.com", Sresetpassemail.Text);
            mm.Subject = "Request for change password";
            mm.Body = "A request to change password was made. Click below link to reset password\n\n https://localhost:44383/studentResetPasspage.aspx";
            mm.BodyEncoding = System.Text.Encoding.GetEncoding("utf-8");
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "squad.onlineexam@gmail.com",
                Password = "squad123"
            };
            smtp.EnableSsl = true;
            smtp.Send(mm);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            sendmail();
            Session["Sresetemail"] = Sresetpassemail.Text;
            Response.Write("<script>alert('Password reset link was sent ')</script>");
        }
    }
}