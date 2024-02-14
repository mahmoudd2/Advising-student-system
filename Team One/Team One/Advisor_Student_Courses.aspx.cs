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
    public partial class Advisor_Student_Courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }
        }

        private void BindGridView()
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("[Procedures_AdvisorViewAssignedStudents]", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (Session["AdvisorID"] != null & Session["Major"] != null)
                    {
                        int Advisor_id = (int)Session["AdvisorID"];
                        String major = (String)Session["Major"];
                        
                        cmd.Parameters.Add(new SqlParameter("@AdvisorID", Advisor_id));
                        cmd.Parameters.Add(new SqlParameter("@major", major));

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }

                    }
                }
            }
        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Advisor's Main Menu.aspx");
        }
    }
}