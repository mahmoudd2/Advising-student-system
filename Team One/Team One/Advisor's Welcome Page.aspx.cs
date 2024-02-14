using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_One
{
    public partial class Main_Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_page(object sender, EventArgs e)
        {
            Response.Redirect("Advisor_Register.aspx");
        }

        protected void Login_Page(object sender, EventArgs e)
        {
            Response.Redirect("Advisor_Login.aspx");
        }

        protected void Welcome_page(object sender, EventArgs e)
        {
            Response.Redirect("Welcome Page.aspx");
        }
    }
}