using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Configuration;

namespace OnlineExam
{
    public partial class ViewStudentResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Bind();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString.ToString());

        void Bind()
        {
            con.Open();

            // string query = " (SELECT * FROM ExamDetails) INNER JOIN (select * from StudentExam where email=@p1) ON ExamDetails.eid = StudentExam.eid";

            string query = "SELECT subject,date_time,marks,email FROM ExamDetails inner JOIN StudentExam ON ExamDetails.eid = StudentExam.eid WHERE  StudentExam.email = @p1";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@p1", Session["mail"].ToString());
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
           // GridView1.Columns[].Visible = false;
            con.Close();
        }
    }
}//SELECT subject,date_time FROM ExamDetails INNER JOIN select marks from StudentExam where email=@p1 ON ExamDetails.eid = StudentExam.eid