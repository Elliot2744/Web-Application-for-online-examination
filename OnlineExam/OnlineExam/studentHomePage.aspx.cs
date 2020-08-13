using System;
using System.Collections.Generic;
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
    public partial class studentHomePage1 : System.Web.UI.Page
    {
        static int cntAttempt;
        protected void Page_Load(object sender, EventArgs e)
        {
            fetchExams();

        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString.ToString());

        protected void btn_entereid_Click(object sender, EventArgs e)
        {
            insertIntoStudentExam();

            
        }

        void insertIntoStudentExam()
        {
            con.Open();


            string query = "INSERT INTO StudentExam VALUES(@p1,@p2,@p3,@p4)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@p1", Session["mail"].ToString());
            cmd.Parameters.AddWithValue("@p2", tb_enter_rid.Text);
            cmd.Parameters.AddWithValue("@p3", "0");
            cmd.Parameters.AddWithValue("@p4", 0);

            cmd.ExecuteNonQuery();
            con.Close();

            fetchExams();

        }

        void fetchExams()
        {
            con.Open();
            string query = "SELECT * FROM ExamDetails WHERE eid in (Select eid FROM StudentExam Where email=@p1)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@p1", Session["mail"].ToString());

            SqlDataAdapter da = new SqlDataAdapter(cmd);


            DataSet ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            Repeater1.DataSource = ds;
            Repeater1.DataBind();


            con.Close();
        }

       void checkAtt(string eid_1)
        {
            con.Open();
            string query = "SELECT * FROM StudentExam WHERE eid=@p1 AND email=@p2";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@p1", eid_1);
            cmd.Parameters.AddWithValue("@p2", Session["mail"].ToString());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                cntAttempt = Int32.Parse(dt.Rows[0]["Attemp"].ToString());
            }

            con.Close();

        }

        void insertAttempt(string eid_1)
        {
            con.Open();

        
            string query1 = "UPDATE StudentExam SET Attemp=@p1 WHERE eid=@p2 AND email=@p3";

            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd1.Parameters.AddWithValue("@p1", (0));
            cmd1.Parameters.AddWithValue("@p2", eid_1);
            cmd1.Parameters.AddWithValue("@p3", Session["mail"].ToString());

            cmd1.ExecuteNonQuery();

            con.Close();
        }

        protected void Click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "Click")
            {
               Session["click_eid"]  = e.CommandArgument;

               checkAtt(Session["click_eid"].ToString());

               insertAttempt(Session["click_eid"].ToString());

                Response.Redirect("Give_Exam.aspx");
            }
        }
    }
}