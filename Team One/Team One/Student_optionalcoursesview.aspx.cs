using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_One
{
    public partial class optionalcoursesview : System.Web.UI.Page
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
                using (SqlCommand cmd = new SqlCommand("Procedures_ViewOptionalCourse", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    if (Session["semestercode"] != null & Session["StudentID"] != null)
                    {

                        string semcode = (string)Session["semestercode"];
                        int uid = (int)Session["StudentID"];
                        cmd.Parameters.Add(new SqlParameter("@StudentID", uid));
                        cmd.Parameters.Add(new SqlParameter("@current_semester_code", semcode));



                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            GridView1.DataSource = dt;
                            GridView1.DataBind();




                        }

                    }
                    else
                    {
                        Response.Write("no");
                    }
                }
                conn.Close();
            }
        }
        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Student_optionalcourses.aspx");
        }
    }
}