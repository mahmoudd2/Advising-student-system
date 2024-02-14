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
    public partial class Students_Courses_transcript : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);


            SqlCommand FN_StudentViewGP = new SqlCommand("Select * From Students_Courses_transcript ", conn);
            // Students_Courses_transcript.ExecuteNonQuery();


            conn.Open();
            SqlDataReader rdr = FN_StudentViewGP.ExecuteReader();
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