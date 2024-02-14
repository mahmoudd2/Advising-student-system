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
    public partial class Advisor_approve_reject_courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Proceed(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int Request_id = Int16.Parse(RequestID.Text);
            String Current_Semester_Code = Sem_Code.Text;

            SqlCommand Proceed = new SqlCommand("[Procedures_AdvisorApproveRejectCourseRequest]", conn);
            Proceed.CommandType = CommandType.StoredProcedure;
            Proceed.Parameters.Add(new SqlParameter("@requestID", Request_id));
            Proceed.Parameters.Add(new SqlParameter("@current_semester_code", Current_Semester_Code));

            conn.Open();
            Proceed.ExecuteNonQuery();
            conn.Close();

        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Advisor's Main Menu.aspx");
        }

        protected void Request_table(object sender, EventArgs e)
        {
            Response.Redirect("Advisor's Requests.aspx");
        }
    }
}