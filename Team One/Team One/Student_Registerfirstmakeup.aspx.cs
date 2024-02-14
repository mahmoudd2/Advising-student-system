using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_One
{
	public partial class Registerfirstmakeup : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			string connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
			int thestudentid = (int)Session["StudentID"];
			int thecourseid = Int16.Parse(CourseID.Text);
			string thecurrentsem = Curr_Sem.Text;
			using (SqlConnection conn = new SqlConnection(connStr))
			{
				using (SqlCommand Registerfirstmakeup = new SqlCommand("Procedures_StudentRegisterFirstMakeup", conn))
				{
					Registerfirstmakeup.CommandType = CommandType.StoredProcedure;
					Registerfirstmakeup.Parameters.AddWithValue("@StudentID", thestudentid);
					Registerfirstmakeup.Parameters.AddWithValue("@courseid", thecourseid);
					Registerfirstmakeup.Parameters.AddWithValue("@studentCurr_sem", thecurrentsem);
					conn.Open();
					Registerfirstmakeup.ExecuteNonQuery();
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