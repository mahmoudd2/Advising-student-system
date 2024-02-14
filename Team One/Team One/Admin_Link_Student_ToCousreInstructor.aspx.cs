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
    public partial class Admin_Link_Student_ToCousreInstructor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Link(object sender, EventArgs e)
        {

            String connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int course_id;
            int instructor_id;
            int student_id;
            String semester_code = semester.Text;

            if (!string.IsNullOrEmpty(course.Text))
            {
                try
                {
                    course_id = Int16.Parse(course.Text);
                }
                catch (Exception ex)
                {
                    Response.Write("Enter Correct Data");
                    return;
                }
            }
            else
            {
                Response.Write("Enter Correct Data");
                return;
            }
            if (!string.IsNullOrEmpty(instructor.Text))
            {
                try
                {
                    instructor_id = Int16.Parse(instructor.Text);
                }
                catch (Exception ex)
                {
                    Response.Write("Enter Correct Data");
                    return;
                }
            }
            else
            {
                Response.Write("Enter Correct Data");
                return;
            }
            if (!string.IsNullOrEmpty(student.Text))
            {
                try
                {
                    student_id = Int16.Parse(student.Text);
                }
                catch (Exception ex)
                {
                    Response.Write("Enter Correct Data");
                    return;
                }
            }
            else
            {
                Response.Write("Enter Correct Data");
                return;
            }

            if (!String.IsNullOrEmpty(semester_code))
            {
                SqlCommand Link = new SqlCommand("[Procedures_AdminLinkStudent]", conn);
                Link.CommandType = System.Data.CommandType.StoredProcedure;
                Link.Parameters.Add(new SqlParameter("@cours_id", course_id));
                Link.Parameters.Add(new SqlParameter("@instructor_id", instructor_id));
                Link.Parameters.Add(new SqlParameter("@studentID", student_id));
                Link.Parameters.Add(new SqlParameter("@semester_code", semester_code));

                conn.Open();
                Link.ExecuteNonQuery();
                conn.Close();
                Response.Write("Student Linked to course!");
            } else
            {
                Response.Write("Enter Correct Data");
                return;
            }
        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Main_Menu.aspx");
        }
    }
}