using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_One
{
    public partial class View_Students_major_courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void View(object sender, EventArgs e)
        {
            String Major = major.Text;
            Session["Major"] = Major;
            Response.Redirect("Advisor_Student_Courses.aspx");
        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Advisor's Main Menu.aspx");
        }
    }
}