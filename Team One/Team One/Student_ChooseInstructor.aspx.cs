using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_One
{
	public partial class ChooseInstructor : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Student Main Menu.aspx");
        }

        protected void Choose(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            int thestudentid = Int16.Parse(Student.Text);
            int theinstructorid = Int16.Parse(Instructor.Text);
            int thecourseid = Int16.Parse(CourseID.Text);
            String Sem_Code = SemCode.Text;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand ChooseInstructor = new SqlCommand("Procedures_ChooseInstructor", conn))
                {
                    ChooseInstructor.CommandType = CommandType.StoredProcedure;
                    ChooseInstructor.Parameters.AddWithValue("@StudentID", thestudentid);
                    ChooseInstructor.Parameters.AddWithValue("@CourseID", thecourseid);
                    ChooseInstructor.Parameters.AddWithValue("@instrucorID", theinstructorid);
                    ChooseInstructor.Parameters.AddWithValue("@current_semester_code", Sem_Code);
                    conn.Open();
                    ChooseInstructor.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}