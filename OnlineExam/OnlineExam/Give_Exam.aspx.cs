using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Drawing;

namespace OnlineExam
{

    public partial class Give_Exam : System.Web.UI.Page
    {
        List<string> fetchAns = new List<string>();
        List<string> ans = new List<string>();
        int tot = 0;
        int cnt = 0; // shows marks
        string s = "";
        static int atmp;
        static int load = 0;
        static bool tabChange = false;
        static int cntAttempt;

        protected void Page_Load(object sender, EventArgs e)
        {
              checkAttempt();

              if (atmp < 2)
              {
                  getQues();

              }
              else
              {
                  redirect("Only One Response can be submited.");
              }
        }

       

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString.ToString());


        void getQues()
        {
            con.Open();

            string query = "Select * from QuestionBank Where eid = @p1" ;

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@p1", Session["click_eid"].ToString());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            con.Close();

            tot = dt.Rows.Count;

            int i = 0;
            int j = dt.Columns.Count;

            while (i < dt.Rows.Count)
            {
                fetchAns.Add(dt.Rows[i]["answer"].ToString()); // Fetch all the correct answers from given table and stores in fetchAns List.

                Label newLineque = new Label();
                newLineque.Text = "<br/>";
                Panel1.Controls.Add(newLineque);


                Label no = new Label();
                no.Text = (i + 1).ToString() + " ";
                Panel1.Controls.Add(no);

                Label ques = new Label();
                ques.Text = dt.Rows[i]["questions"].ToString();
                Panel1.Controls.Add(ques);

                Label space = new Label();
                space.Text = "   ";
                Panel1.Controls.Add(space);

                CheckBox cb = new CheckBox();
                cb.ID = "Question" + (i + 1).ToString();
                cb.Text = "Mark for Later.";
                cb.CheckedChanged += new EventHandler(CheckBox_Checked);
                Panel1.Controls.Add(cb);

                Label newLineque1 = new Label();
                newLineque1.Text = "<br/>";
                Panel1.Controls.Add(newLineque1);

                RadioButtonList rbl = new RadioButtonList();
                rbl.ID = "rbl_options" + i.ToString();
                for (int k = 3; k <= j - 2; k++)
                {
                    rbl.Items.Add(dt.Rows[i][k].ToString());
                    
                }
                Panel1.Controls.Add(rbl);

               
                i++;


            }

        }  //Loads all the question from given table.

        private void CheckBox_Checked(object sender, EventArgs e)
        {
            
            CheckBox cb = (sender as CheckBox);
            Label lb = (sender as Label);
            if (cb.Checked)
            {
                cb.Text = "Left";

                s = s + cb.ID.ToString() + ", ";
                
            }

            lb_revQues.Text = s;
        }

        void check()
        {

            getSelectedAns();



            for (int i = 0; i < tot; i++)
            {
                if (ans[i].Equals(fetchAns[i]))
                {
                    cnt++;
                }
            }

            lb_marks.Text = "Marks are: " + cnt.ToString();
        } // checks the questions and set marks.

        void getSelectedAns()
        {
            string temp;
            int x;
            foreach (Control rbl in Panel1.Controls)
            {
                if (rbl is RadioButtonList)
                {
                    temp = ((RadioButtonList)rbl).SelectedIndex.ToString();
                    x = Int32.Parse(temp) + 1;
                    ans.Add(x.ToString());
                }
            }
        }   // stores all the selected ans in List.


        protected void Button1_Click(object sender, EventArgs e)
        {
                check();
                insertData();

        }

       void insertData()
        {


            try
            {
                con.Open();

                string query = "UPDATE StudentExam SET marks=@p1 WHERE email=@p2 AND eid=@p3";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@p1", cnt.ToString());
                cmd.Parameters.AddWithValue("@p2", Session["mail"].ToString());
                cmd.Parameters.AddWithValue("@p3", Session["click_eid"].ToString());
                

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();
            }

        } //insert data into database.

        void checkAttempt()
        {
            con.Open();

            string query = "SELECT * FROM StudentExam WHERE eid=@p1 and email=@p2";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@p1", Session["click_eid"].ToString());
            cmd.Parameters.AddWithValue("@p2", Session["mail"].ToString());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
               atmp = Int32.Parse(dt.Rows[0]["Attemp"].ToString());
            }


            con.Close();

        } 

        private void redirect(string message)
        {
            string url = "studentLogin.aspx";
            string script = "window.onload = function(){ alert('";
            script += message;
            script += "');";
            script += "window.location = '";
            script += url;
            script += "'; }";
            ClientScript.RegisterStartupScript(this.GetType(), "Redirect", script, true);
        }

        protected void btn_revQues_Click(object sender, EventArgs e)
        {

        }

        
    }
}

// cntAttempt+1

/*  void fetchDataFromExams()
        {
            try
            {
                con.Open();

                string query = "SELECT * FROM Exams WHERE examid = @p1";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@p1", Session["examid"].ToString());

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    subect = dt.Rows[0]["subject"].ToString();
                    date_time = dt.Rows[0]["date_time"].ToString();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();
            }

        }*/   //to get subject and date_time information from Exams table.
