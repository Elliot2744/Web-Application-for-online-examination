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
    public partial class SetQuestionPaper : System.Web.UI.Page
    {
        static int num = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            lb_ques.Text = "Question number" + num.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            tb.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";

        }




        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString.ToString());
        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();

            string query1 = "Insert into QuestionBank VALUES (@p1,@p2,@p3,@p4,@p5,@P6,@p7)";
            SqlCommand cmd = new SqlCommand(query1, con);

            cmd.Parameters.AddWithValue("@p1", Session["Trid"].ToString());
            cmd.Parameters.AddWithValue("@p2", tb.Text);
            cmd.Parameters.AddWithValue("@p3", TextBox1.Text);
            cmd.Parameters.AddWithValue("@p4", TextBox2.Text);
            cmd.Parameters.AddWithValue("@p5", TextBox3.Text);
            cmd.Parameters.AddWithValue("@p6", TextBox4.Text);
            cmd.Parameters.AddWithValue("@p7", getAns().ToString());
            cmd.ExecuteNonQuery();
            con.Close();

            num++;

        }

        private int getAns()
        {

            if (RadioButton1.Checked)
            {
                return 1;
            }

            if (RadioButton2.Checked)
            {
                return 2;
            }

            if (RadioButton3.Checked)
            {
                return 3;
            }

            return 4;

        }
    }
}