using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExam
{
    public partial class verifyStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            insert();
            sverify.Text = "Account Activation was Successfull";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("studentLogin.aspx");
        }

        void insert()
        {

            SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString.ToString());

            con1.Open();
            string q2 = "insert into studentdetails values(@p1,@p2,@p3,@p4,@p5)";

            SqlCommand cmd2 = new SqlCommand(q2, con1);
            cmd2.Parameters.AddWithValue("@p1", Session["name"].ToString());
            cmd2.Parameters.AddWithValue("@p2", Session["email"].ToString());
            cmd2.Parameters.AddWithValue("@p3", Session["dept"].ToString());
            cmd2.Parameters.AddWithValue("@p4", Session["clg"].ToString());

            cmd2.Parameters.AddWithValue("@p5", Session["pass"].ToString());

            cmd2.ExecuteNonQuery();




            string url = "studentLogin.aspx";
            string script = "window.onload = function(){ alert('";
            script += "Account Created";
            script += "');";
            script += "window.location = '";
            script += url;
            script += "'; }";
            ClientScript.RegisterStartupScript(this.GetType(), "Redirect", script,
                true);

        }

    }
}