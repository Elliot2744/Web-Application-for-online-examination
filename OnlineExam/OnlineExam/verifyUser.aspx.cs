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
    public partial class verifyMail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = "Hello " + Session["Tname"].ToString() + ", You are Registered Successfully.";
            lbl_press.Text = "Please click below button to continue";
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString.ToString());

        protected void btn_final_Click(object sender, EventArgs e)
        {
            insertData();

            Session.Abandon();

            Response.Redirect("Teacher_Login.aspx");
        }

        private void insertData()
        {
            con.Open();
            string s = "Insert into Teacher_Details values (@p1,@p2,@p3,@p4,@p5)";

            SqlCommand cmd = new SqlCommand(s, con);

            cmd.Parameters.AddWithValue("@p1", Session["Tname"].ToString());
            cmd.Parameters.AddWithValue("@p2", Session["Temail"].ToString());
            cmd.Parameters.AddWithValue("@p3", Session["Tdept"].ToString());
            cmd.Parameters.AddWithValue("@p4", Session["Tcollege"].ToString());
            cmd.Parameters.AddWithValue("@p5", Session["Tpassword"].ToString());

            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}