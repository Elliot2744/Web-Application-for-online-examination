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
    public partial class Reset_password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString.ToString());

        protected void btn_resetPwd_Click(object sender, EventArgs e)
        {
            if (samePassword())
            {
                con.Open();

                string s = "UPDATE Teacher_Details SET password=@p1 WHERE email=@p2";

                SqlCommand cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@p1", tb_newPwd.Text);
                cmd.Parameters.AddWithValue("@p2", Session["forgotPassword_email"].ToString());

                cmd.ExecuteNonQuery();

                con.Close();

                Response.Write("<script>alert('Password Changed Successfully')</script>");

                Session.Abandon();
            }
            
        }

        private bool samePassword()
        {
            if (tb_newPwd.Text == tb_newPwd_confirm.Text)
            {
                return true;
            }
            else
            {
                lbl_wrongCpwd.Text = "***Password Doesn't match";
                return false;
            }
        }
    }
}