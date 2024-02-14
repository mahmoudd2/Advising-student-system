using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_One
{
    public partial class Welcome_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Student(object sender, EventArgs e)
        {
            Response.Redirect("Student Welcome Page.aspx");
        }

        protected void Advisor(object sender, EventArgs e)
        {
            Response.Redirect("Advisor's Welcome Page.aspx");
        }

        protected void Admin(object sender, EventArgs e)
        {
            Response.Redirect("Admin Login.aspx");
        }
    }
}