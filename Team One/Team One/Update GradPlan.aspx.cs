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
    public partial class Update_GradPlan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Update(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            int Student_id = Int16.Parse(StudentID.Text);
            String GradDate = Grad_date.Text;
            DateTime GrdDate;

            if (DateTime.TryParse(GradDate, out GrdDate))
            {
                SqlCommand Update = new SqlCommand("[Procedures_AdvisorUpdateGP]", conn);
                Update.CommandType = System.Data.CommandType.StoredProcedure;
                Update.Parameters.Add(new SqlParameter("@studentID", Student_id));
                Update.Parameters.Add(new SqlParameter("@expected_grad_date", GradDate));

                conn.Open();
                Update.ExecuteNonQuery();
                conn.Close();
                Response.Write("Graduation Date is updated!");
            }
        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Advisor's Main Menu.aspx");
        }
    }
}