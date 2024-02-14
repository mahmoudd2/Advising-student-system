using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_One
{
	public partial class Registersecondmakeup : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button2_Click(object sender, EventArgs e)
		{
			string connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            int thestudentid = (int)Session["StudentID"];
            int thecourseid = Int16.Parse(CourseID.Text);
            string thecurrentsem = Curr_Sem.Text;
            using (SqlConnection conn = new SqlConnection(connStr))
			{
				using (SqlCommand Registersecondmakeup = new SqlCommand("Procedures_StudentRegisterSecondMakeup", conn))
				{
					Registersecondmakeup.CommandType = CommandType.StoredProcedure;
					Registersecondmakeup.Parameters.AddWithValue("@StudentID", thestudentid);
					Registersecondmakeup.Parameters.AddWithValue("@courseid", thecourseid);
					Registersecondmakeup.Parameters.AddWithValue("@studentCurr_sem", thecurrentsem);
					conn.Open();
					Registersecondmakeup.ExecuteNonQuery();
					conn.Close();
				}
			}
		}

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Student Main Menu.aspx");
        }
    }
}