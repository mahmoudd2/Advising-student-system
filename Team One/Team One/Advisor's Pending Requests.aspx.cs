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
    public partial class Advisor_s_Pending_Requests : System.Web.UI.Page
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

                using (SqlCommand cmd = new SqlCommand("[Procedures_AdvisorViewPendingRequests]", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (Session["AdvisorID"] != null)
                    {
                        int advisorid = (int)Session["AdvisorID"];
                        cmd.Parameters.Add(new SqlParameter("@Advisor_ID", advisorid));

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            GridView1.DataSource = dt;
                            GridView1.DataBind();

                            if (dt.Rows.Count == 0)
                            {
                                Response.Write("There are no pending requests for this advisor");
                            }
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