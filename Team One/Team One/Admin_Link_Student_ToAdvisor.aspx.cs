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
    public partial class Admin_Link_Student_ToAdvisor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Link(object sender, EventArgs e)
        {

            String connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int student_id;
            int advisor_id;
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

            if (!string.IsNullOrEmpty(advisor.Text))
            {
                try
                {
                    advisor_id = Int16.Parse(student.Text);
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
            SqlCommand Link = new SqlCommand("[Procedures_AdminLinkStudentToAdvisor]", conn);
            Link.CommandType = System.Data.CommandType.StoredProcedure;
            Link.Parameters.Add(new SqlParameter("@studentID", student_id));
            Link.Parameters.Add(new SqlParameter("@advisorID", advisor_id));
            

            conn.Open();
            Link.ExecuteNonQuery();
            conn.Close();
            Response.Write("Student Linked!");
        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Main_Menu.aspx");
        }
    }
}