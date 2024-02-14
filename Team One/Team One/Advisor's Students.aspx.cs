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
    public partial class Advisor_s_Students : System.Web.UI.Page
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

                int advisor_id = (int)Session["AdvisorID"];
                String AStudent = "SELECT * FROM Student WHERE advisor_id = " + advisor_id.ToString();

                using (SqlCommand cmd = new SqlCommand(AStudent, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    if (Session["AdvisorID"] != null)
                    {
                        int Advisor_id = (int)Session["AdvisorID"];

                        cmd.Parameters.Add(new SqlParameter("@AdvisorID", Advisor_id));

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