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
    public partial class missingcourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                BindGridview();
            }

        }

        private void BindGridview()
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Procedures_ViewMS", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    if (Session["StudentID"] != null)
                    {
                        int uid = (int)Session["StudentID"];
                        cmd.Parameters.Add(new SqlParameter("@StudentID", uid));

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                            if(dt.Rows.Count == 0)
                            {
                                Response.Write("There Are No Missing Courses");
                            }
                        }
                    }
                }
            }
        } 

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Student Main Menu.aspx");
        }
    }
}