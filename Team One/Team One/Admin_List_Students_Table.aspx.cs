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
    public partial class Admin_List_Students_Table : System.Web.UI.Page
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
            String connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                using (SqlCommand Listing = new SqlCommand("[Procedures_AdminListStudents]", conn))
                {
                    Listing.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(Listing))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        GridView1.DataSource = dt;
                        GridView1.DataBind();

                        if (dt.Rows.Count == 0)
                        {
                            Response.Write("There are no students");
                        }

                    }
                }
            }
        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Main_Menu.aspx");
        }
    }
}