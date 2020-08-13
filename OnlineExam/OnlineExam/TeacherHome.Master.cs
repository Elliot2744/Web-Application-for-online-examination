using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExam
{
    public partial class TeacherHome : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString.ToString());

            con1.Open();
            String q1 = "select * from Teacher_Details where email=@p1";
            SqlCommand cmd1 = new SqlCommand(q1, con1);
            cmd1.Parameters.AddWithValue("@p1", Session["Temail"].ToString());

            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                Thomename.Text = dt.Rows[0]["name"].ToString();
            }

        }

        protected void shome_home_Click(object sender, EventArgs e)
        {

            Response.Redirect("studentHomePage.aspx");
        }

        protected void shome_logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Teacher_Login.aspx");
        }

        protected void shome_contact_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Teacher_ViewResult.aspx");
        }
    }
}