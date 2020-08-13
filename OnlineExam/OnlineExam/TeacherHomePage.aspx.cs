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
using System.Globalization;



namespace OnlineExam
{
    public partial class TeacherHomePage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString.ToString());

        protected void btn_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int nid = r.Next(0, 10000);
            string rid = "eid_" + nid.ToString() + tb_date_tm.Text;

            con.Open();

            string query = "INSERT INTO  ExamDetails  VALUES(@p1,@p2,@p3,@p4,@p5,@p6)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@p1", Session["Temail"].ToString());
            cmd.Parameters.AddWithValue("@p2", rid);
            cmd.Parameters.AddWithValue("@p3", tb_subject.Text);
            cmd.Parameters.AddWithValue("@p4", tb_syllabus.Text);
            cmd.Parameters.AddWithValue("@p5", tb_date_tm.Text);
            cmd.Parameters.AddWithValue("@p6", tb_tm_limit.Text);

            cmd.ExecuteNonQuery();

            con.Close();

            Session["Trid"] = rid;
            Response.Redirect("SetQuestionPaper.aspx");

        }

    }
}