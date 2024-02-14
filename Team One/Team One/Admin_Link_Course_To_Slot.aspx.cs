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
    public partial class Admin_Link_Instructor_ToCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Link(object sender, EventArgs e)
        {

            String connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int course_id = Int16.Parse(course.Text);
            int instructor_id = Int16.Parse(instructor.Text);
            int slot_id = Int16.Parse(slot.Text);


            SqlCommand Link = new SqlCommand("[Procedures_AdminLinkInstructor]", conn);
            Link.CommandType = System.Data.CommandType.StoredProcedure;
            Link.Parameters.Add(new SqlParameter("@cours_id", course_id));
            Link.Parameters.Add(new SqlParameter("@instructor_id", instructor_id));
            Link.Parameters.Add(new SqlParameter("@slot_id", slot_id));

            conn.Open();
            Link.ExecuteNonQuery();
            conn.Close();
            Response.Write("Semester Linked!");
        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Main_Menu.aspx");
        }
    }
}