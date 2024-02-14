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
    public partial class NewCourses_GradPlan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Insert_course(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            int Student_id = Int16.Parse(StudentID.Text);
            String Sem_code = Semester_Code.Text;
            String CourseName = Course_Name.Text;

            SqlCommand Insert = new SqlCommand("[Procedures_AdvisorAddCourseGP]", conn);
            Insert.CommandType = System.Data.CommandType.StoredProcedure;
            Insert.Parameters.Add(new SqlParameter("@student_id", Student_id));
            Insert.Parameters.Add(new SqlParameter("@Semester_code", Sem_code));
            Insert.Parameters.Add(new SqlParameter("@course_name", CourseName));

            conn.Open();
            Insert.ExecuteNonQuery();
            conn.Close();
            Response.Write("Course Added!");
        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Advisor's Main Menu.aspx");
        }
    }
}