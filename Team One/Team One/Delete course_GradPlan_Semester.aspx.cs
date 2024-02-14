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
    public partial class Delete_course_GradPlan_Semester : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Delete(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            int Student_id = Int16.Parse(StudentID.Text);
            String Semester_Code = Sem_Code.Text;
            int Course_id = Int16.Parse(CourseID.Text);

            SqlCommand Delete = new SqlCommand("[Procedures_AdvisorDeleteFromGP]", conn);
            Delete.CommandType = System.Data.CommandType.StoredProcedure;
            Delete.Parameters.Add(new SqlParameter("@studentID", Student_id));
            Delete.Parameters.Add(new SqlParameter("@sem_code", Semester_Code));
            Delete.Parameters.Add(new SqlParameter("@courseID", Course_id));

            conn.Open();
            Delete.ExecuteNonQuery();
            conn.Close();
            Response.Write("Course Deleted Successully!");

        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Advisor's Main Menu.aspx");
        }
    }
}