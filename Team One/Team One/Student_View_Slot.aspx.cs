using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_One
{
	public partial class ViewStudent_View_Slot : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void Button11_Click(object sender, EventArgs e)
        {
			int Course_id = Int16.Parse(Courseid.Text);
			int Instructor_id = Int16.Parse(Instructorid.Text);
			Session["StudentViewSlotC"] = Course_id;
			Session["StudentViewSlotI"] = Instructor_id;
			Response.Redirect("Student_View_Slot_Table.aspx");

        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Student Main Menu.aspx");
        }
    }
}