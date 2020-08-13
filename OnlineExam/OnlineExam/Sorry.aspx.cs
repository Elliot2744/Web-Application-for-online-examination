using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExam
{
    public partial class Sorry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void btn_ToLoginPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("studentLogin.aspx");
        }

        
    }
}