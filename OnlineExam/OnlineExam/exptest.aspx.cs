using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace Exam_app1
{
    public partial class exptest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            MailMessage mm = new MailMessage("jackken743@gmail.com","jackken743@gmail.com");
            mm.Subject = "test";
            mm.Body = "hey this is to test";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "jackken743@gmail.com",
                Password = "professionalskit"
            };
            smtp.EnableSsl = true;
            smtp.Send(mm);
        }
    }
}