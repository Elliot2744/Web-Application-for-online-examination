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

namespace OnlineExam
{
    public partial class Teacher_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString.ToString());
        protected void Btn_TLogin_Click(object sender, EventArgs e)
        {
            con.Open();

            string s = "Select * from Teacher_Details where email=@p1 AND password=@p2";

            SqlCommand cmd = new SqlCommand(s, con);

            cmd.Parameters.AddWithValue("@p1", Temail_login.Text);
            cmd.Parameters.AddWithValue("@p2", Tpassword_login.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                Session["Temail"] = Temail_login.Text;
                
                Response.Redirect("TeacherHomePage.aspx");
            }
            else
            {
                lbl_TcheckPassword.Text = "***Wrong Email or Password***";
            }
        }

        protected void Btn_to_TRegistration_Click(object sender, EventArgs e)
        {
            Response.Redirect("Teacher_Registration.aspx");
        }

        protected void forgotPassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("Teacher_forgotPassword.aspx");
        }

    }
}