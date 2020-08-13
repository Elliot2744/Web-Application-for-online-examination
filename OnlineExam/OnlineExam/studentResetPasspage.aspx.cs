using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExam
{
    public partial class studentResetPasspage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString.ToString());

                con1.Open();
                String q1 = "update studentdetails set password=@p1 where semail=@p2";
                SqlCommand cmd1 = new SqlCommand(q1, con1);
                cmd1.Parameters.AddWithValue("@p1", Snewpass.Text);
                cmd1.Parameters.AddWithValue("@p2", Session["Sresetemail"].ToString());

                cmd1.ExecuteNonQuery();

            }
        }


        bool valid()
        {




            if (Snewpass.Text.Trim() == string.Empty)
            {
                Snewpass.Focus();
                Snewpass.BorderStyle = BorderStyle.Solid;
                Snewpass.BorderColor = Color.Red;
                Snewpass.ToolTip = "Enter Password";
                return false;
            }

            if (Scnewpass.Text.Trim() != Snewpass.Text)
            {
                Scnewpass.Focus();
                Scnewpass.BorderStyle = BorderStyle.Solid;
                Scnewpass.BorderColor = Color.Red;
                Scnewpass.ToolTip = "Password Not Matched";
                return false;
            }
            return true;

        }
    }
}