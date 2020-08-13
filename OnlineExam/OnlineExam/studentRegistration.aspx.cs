using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Net.Mail;
using System.Data;

namespace OnlineExam
{
    public partial class studentRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString.ToString());


        bool valid()
        {
            if (Sname.Text.Trim() == string.Empty)
            {
                Sname.Focus();
                Sname.BorderStyle = BorderStyle.Solid;
                Sname.BorderColor = Color.Red;
                Sname.ToolTip = "Enter Name";
                return false;
            }

            if (Semail.Text.Trim() == string.Empty)
            {
                Semail.Focus();
                Semail.BorderStyle = BorderStyle.Solid;
                Semail.BorderColor = Color.Red;
                Semail.ToolTip = "Enter Email";
                return false;

            }

            if (Sdept.Text.Trim() == string.Empty)
            {
                Sdept.Focus();
                Sdept.BorderStyle = BorderStyle.Solid;
                Sdept.BorderColor = Color.Red;
                Sdept.ToolTip = "Enter Department";
                return false;
            }

            if (Sclg.Text.Trim() == string.Empty)
            {
                Sclg.Focus();
                Sclg.BorderStyle = BorderStyle.Solid;
                Sclg.BorderColor = Color.Red;
                Sclg.ToolTip = "Enter College";
                return false;
            }



            if (Spass.Text.Trim() == string.Empty)
            {
                Spass.Focus();
                Spass.BorderStyle = BorderStyle.Solid;
                Spass.BorderColor = Color.Red;
                Spass.ToolTip = "Enter Password";
                return false;
            }

            if (Scpass.Text.Trim() != Spass.Text)
            {
                Scpass.Focus();
                Scpass.BorderStyle = BorderStyle.Solid;
                Scpass.BorderColor = Color.Red;
                Scpass.ToolTip = "Password Not Matched";
                return false;
            }
            return true;

        }

        protected void Ssignup_Click(object sender, EventArgs e)
        {
            if (valid())
            {


                con1.Open();
                String q1 = "select * from studentdetails where email=@e1";
                SqlCommand cmd1 = new SqlCommand(q1, con1);
                cmd1.Parameters.AddWithValue("@e1", Semail.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    string url = "studentLogin.aspx";
                    string script = "window.onload = function(){ alert('";
                    script += "Account Already Exist";
                    script += "');";
                    script += "window.location = '";
                    script += url;
                    script += "'; }";
                    ClientScript.RegisterStartupScript(this.GetType(), "Redirect", script,
                        true);
                }

                else
                {
                    string name = Sname.Text.ToUpper();
                    string email = Semail.Text;
                    string dept = Sdept.Text.ToUpper();
                    string clg = Sclg.Text.ToUpper();
                    string pass = Spass.Text;

                    Session["name"] = name;
                    Session["email"] = email;
                    Session["dept"] = dept;
                    Session["clg"] = clg;
                    Session["pass"] = pass;

                    sendmail(name);

                }
                con1.Close();
            }
        }

        void sendmail(string name)
        {
            MailMessage mm = new MailMessage("squad.onlineexam@gmail.com", Semail.Text);
            mm.Subject = "welcome to online exam";
            mm.Body = "Hello " + name + ", Welcome to online examination system. please click below link to verify your accont\n\n https://localhost:44383/verifyStudent.aspx";
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

    }
}