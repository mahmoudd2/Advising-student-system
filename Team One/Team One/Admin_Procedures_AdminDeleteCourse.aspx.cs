using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_One
{
    public partial class Procedures_AdminDeleteCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand courses_registered = new SqlCommand("Select course_id From PreqCourse_course", conn);

            conn.Open();
            SqlDataReader rdr = courses_registered.ExecuteReader();
            GridView1.DataSource = rdr;
            GridView1.DataBind();
            conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            if (string.IsNullOrEmpty(course_ID.Text))
            {
                Response.Write("You did not provide a course_ID ,please enter a valid course_ID from list above");
            }
            else 
            {
                int id = Int16.Parse(course_ID.Text);
                SqlCommand DeleteCourse = new SqlCommand("Procedures_AdminDeleteCourse", conn);

                DeleteCourse.CommandType = CommandType.StoredProcedure;

                DeleteCourse.Parameters.Add(new SqlParameter("@courseID",id ));

                conn.Open();
               // SqlDataReader rdr = DeleteCourse.ExecuteReader();
                DeleteCourse.ExecuteNonQuery();
                Response.Write("Course deleted successfully");
                conn.Close();

            }
            
        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Main_Menu.aspx");
        }
    }
}