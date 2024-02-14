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
    public partial class availablecoursesview : System.Web.UI.Page
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
                using (SqlCommand cmd = new SqlCommand("FN_SemsterAvailableCourses", conn))
                {
                    //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    if (Session["scode"] != null)
                    {

                        string semcode = (string)Session["scode"];

                        cmd.Parameters.Add(new SqlParameter("@semstercode", semcode));
                    }

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

        protected void SemCode(object sender, EventArgs e)
        {
            Response.Redirect("Student_availablecoursesview.aspx");
        }
    }
}