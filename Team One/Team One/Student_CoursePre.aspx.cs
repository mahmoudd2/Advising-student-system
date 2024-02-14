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
	public partial class CoursePre : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string connstr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
			SqlConnection conn = new SqlConnection(connstr);
			SqlCommand CoursePre = new SqlCommand("Select * from view_Course_prerequisites", conn);
			conn.Open();
			SqlDataReader rdr = CoursePre.ExecuteReader();
			GridView2.DataSource = rdr;
			GridView2.DataBind();
			conn.Close();
			Response.Write("Courses and their Prerequisites");
		}

		protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Student Main Menu.aspx");
        }
    }
}