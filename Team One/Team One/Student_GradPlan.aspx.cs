using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_One
{
	public partial class GradPlan : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		
		protected void GradPlanView(object sender, EventArgs e)
		{
			int Student_id = Int16.Parse(Studentid.Text);
			Session["StudentViewGP"] = Student_id;
			Response.Redirect("Student_View GradPlan.aspx");
		}

        protected void Menu(object sender, EventArgs e)
        {
			Response.Redirect("Student Main Menu.aspx");
        }
    }
}