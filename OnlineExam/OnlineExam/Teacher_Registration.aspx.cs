using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Net.Mail;

namespace OnlineExam
{
    public partial class Teacher_Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString.ToString());
        protected void Btn_TRegistration_Click1(object sender, EventArgs e)
        {
            if(Validate() && samePassword())
            {
                if(checkExistence())
                {
                    Tname.Text = "";
                    Temail.Text = "";
                    Tdept.Text = "";
                    Tcollege.Text = "";
                    redirect("You are Already Registered");

                   
                }
                else
                {
                    sendMail("Hello " + Tname.Text.ToString() + ", Please click on the following link to complete the registration.\n\n https://localhost:44383/verifyUser.aspx ");

                    Session["Tname"] = Tname.Text.ToUpper();
                    Session["Temail"] = Temail.Text;
                    Session["Tdept"] = Tdept.Text.ToUpper();
                    Session["Tcollege"] = Tcollege.Text.ToUpper();
                    Session["Tpassword"] = Tpassword.Text;


                    
                    Response.Redirect("Test.aspx");
                }
            }
        }

        private void sendMail(string msg)
        {
            MailMessage mailMessage = new MailMessage("18it013@charusat.edu.in", Temail.Text);
            mailMessage.Subject = "Verification mail";
            mailMessage.Body = msg;

            SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
            sc.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "squad.onlineexam@gmail.com",
                Password = "squad123"

            };

            sc.EnableSsl = true;
            sc.Send(mailMessage);
        }

        private bool Validate()
        {
            if (Tname.Text.Trim() == "")
            {
                Tname.Focus();
                Tname.BorderColor = Color.Red;
                Tname.BorderStyle = BorderStyle.Solid;
                Tname.BorderColor = Color.Red;
                Tname.ToolTip = "Please enter Proper Values";
                return false;
            }
            else if (Tdept.Text.Trim() == "")
            {
                Tdept.Focus();
                Tdept.BorderColor = Color.Red;
                Tdept.BorderStyle = BorderStyle.Solid;
                Tdept.BorderColor = Color.Red;
                Tdept.ToolTip = "Please enter Proper Values";
                return false;
            }
            else if (Tcollege.Text.Trim() == "")
            {
                Tcollege.Focus();
                Tcollege.BorderColor = Color.Red;
                Tcollege.BorderStyle = BorderStyle.Solid;
                Tcollege.BorderColor = Color.Red;
                Tcollege.ToolTip = "Please enter Proper Values";
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool samePassword()
        {
            if(Tpassword.Text == Tconfirm_password.Text)
            {
                return true;
            }else
            {
                lbl_Tconfirm_password.Text = "Password Doesn't match";
                return false;
            }
        }

        private bool checkExistence()
        {
            con.Open();

            string s1 = "Select * from Teacher_Details where email=@p1";

            SqlCommand cmd1 = new SqlCommand(s1, con);

            cmd1.Parameters.AddWithValue("@p1", Temail.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd1);

            DataTable dt = new DataTable();

            da.Fill(dt);
            con.Close();

            if (dt.Rows.Count > 0)
            {
                return true;
            }else
            {
                return false;
            }
        }  // returns true when user is already registered.

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

        private void redirect_temp(string message)
        {
            string url = "Teacher_Registration.aspx";
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