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
    public partial class Teacher_ViewResult : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString.ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            Bind();
        }

        void Bind()
        {
            con.Open();

            // string query = " (SELECT * FROM ExamDetails) INNER JOIN (select * from StudentExam where email=@p1) ON ExamDetails.eid = StudentExam.eid";

            // string query = "SELECT subject,date_time,name,email,marks FROM ExamDetails inner JOIN StudentExam ON ExamDetails.eid = StudentExam.eid inner JOIN studentdetails  on StudentExam.email = studentdetails.email WHERE ExamDetails.temail = @p1";

            string query = "SELECT subject,date_time,name,semail,marks FROM ExamDetails inner JOIN StudentExam ON ExamDetails.eid = StudentExam.eid inner JOIN studentdetails  on StudentExam.email = studentdetails.semail WHERE ExamDetails.temail = @p1";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@p1", Session["Temail"].ToString());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            // GridView1.Columns[].Visible = false;
            con.Close();
        }
    }
}