using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_One
{
	public partial class View_NotPaid : System.Web.UI.Page
	{
		private DateTime Upcoming_Installment;
		private DateTime result;

		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void Button6_Click(object sender, EventArgs e)
        {
			int Student_id = Int16.Parse(Studentid2.Text);
			Session["StudentUpcoming_installment"] = Student_id;
			Upcoming_Installment = (DateTime)result;
			Response.Write("Upcoming Installment Deadline: " + Upcoming_Installment.ToString());
		}

		protected void TextBox1_TextChanged(object sender, EventArgs e)
		{

		}

        protected void Menu(object sender, EventArgs e)
        {
			Response.Redirect("Student Main Menu.aspx");
        }
    }
}