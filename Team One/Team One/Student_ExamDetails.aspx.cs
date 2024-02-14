using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_One
{
	public partial class ExamDetails : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string connstr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
			SqlConnection conn = new SqlConnection(connstr);
			SqlCommand ExamDetails = new SqlCommand("Select * from Courses_MakeupExams", conn);
			conn.Open();
			SqlDataReader rdr = ExamDetails.ExecuteReader();
			GridView3.DataSource = rdr;
			GridView3.DataBind();
			conn.Close();
			Response.Write("Courses and their exam details");
		}

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Student Main Menu.aspx");
        }
    }
}