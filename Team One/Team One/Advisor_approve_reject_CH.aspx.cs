using Microsoft.Win32;
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
    public partial class Advisor_approve_reject_CH : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Proceed(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int Request_id = Int16.Parse(RequestID.Text);
            String Current_Semester_Code = Current_sem_code.Text;

            SqlCommand Proceed = new SqlCommand("[Procedures_AdvisorApproveRejectCHRequest]", conn);
            Proceed.CommandType = CommandType.StoredProcedure;
            Proceed.Parameters.Add(new SqlParameter("@requestID", Request_id));
            Proceed.Parameters.Add(new SqlParameter("@current_sem_code", Current_Semester_Code));

            conn.Open();
            Proceed.ExecuteNonQuery();
            conn.Close();

        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Advisor's Main Menu.aspx");
        }

        protected void Requests_Table(object sender, EventArgs e)
        {
            Response.Redirect("Advisor's Requests.aspx");
        }
    }
}