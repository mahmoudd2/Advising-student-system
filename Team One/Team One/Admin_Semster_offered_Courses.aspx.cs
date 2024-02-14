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
    public partial class Semster_offered_Courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand offeredcourses = new SqlCommand("Select * From Semster_offered_Courses", conn);

            conn.Open();
            SqlDataReader rdr = offeredcourses.ExecuteReader();
            GridView1.DataSource = rdr;
            GridView1.DataBind();
            conn.Close();
        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Main_Menu.aspx");
        }
    }
}