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
    public partial class Student_GradPlan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Insert(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            if (Session["AdvisorID"] != null)
            {
                int Student_id = Int16.Parse(StudentID.Text);
                int Advisor_id = (int)Session["AdvisorID"];
                String Sem_code = Semester_Code.Text;
                int Semester_credit_hours = Int16.Parse(Sem_Credit_Hours.Text);
                String GradDate = Expected_Grad_Date.Text;
                DateTime GrdDate;

                if (DateTime.TryParse(GradDate, out GrdDate))
                {
                    SqlCommand Insert = new SqlCommand("[Procedures_AdvisorCreateGP]", conn);
                    Insert.CommandType = System.Data.CommandType.StoredProcedure;
                    Insert.Parameters.Add(new SqlParameter("@student_id", Student_id));
                    Insert.Parameters.Add(new SqlParameter("@advisor_id", Advisor_id));
                    Insert.Parameters.Add(new SqlParameter("@Semester_code", Sem_code));
                    Insert.Parameters.Add(new SqlParameter("@sem_credit_hours", Semester_credit_hours));
                    Insert.Parameters.Add(new SqlParameter("@expected_graduation_date", GradDate));

                    conn.Open();
                    Insert.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("Graduation Plan Added!");
                }
            }

        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Advisor's Main Menu.aspx");
        }
    }
}