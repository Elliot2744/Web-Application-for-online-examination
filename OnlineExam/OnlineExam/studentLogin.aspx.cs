using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace OnlineExam
{
    public partial class studentLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void Ssignup_Click(object sender, EventArgs e)
        {
            Response.Redirect("studentRegistration.aspx");
        }

        SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString.ToString());

        protected void Slogin_Click(object sender, EventArgs e)
        {
            if (valid())
            {


                con1.Open();
                String q1 = "select * from studentdetails where semail=@p1 and password=@p2";
                SqlCommand cmd1 = new SqlCommand(q1, con1);
                cmd1.Parameters.AddWithValue("@p1", Sloginemail.Text);
                cmd1.Parameters.AddWithValue("@p2", Sloginpass.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    Session["mail"] = Sloginemail.Text;
                    Response.Redirect("studentHomePage.aspx");
                }
                else
                {
                    Sloginerror.Text = "Invalid email or password";

                }
            }
        }


        bool valid()
        {

            Sloginerror.Text = "";
            if (Sloginemail.Text.Trim() == string.Empty)
            {
                Sloginemail.Focus();
                Sloginemail.BorderStyle = BorderStyle.Solid;
                Sloginemail.BorderColor = Color.Red;
                Sloginemail.ToolTip = "Enter Email";
                return false;

            }



            if (Sloginpass.Text.Trim() == string.Empty)
            {
                Sloginpass.Focus();
                Sloginpass.BorderStyle = BorderStyle.Solid;
                Sloginpass.BorderColor = Color.Red;
                Sloginpass.ToolTip = "Enter Password";
                return false;
            }
            return true;

        }

        protected void Sforgotpass_Click(object sender, EventArgs e)
        {
            Response.Redirect("studentForgotpassword.aspx");
        }

    }
}