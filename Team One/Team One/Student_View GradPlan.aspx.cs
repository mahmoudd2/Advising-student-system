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
	public partial class View_GradPlan : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if(!IsPostBack)
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
				int studentid = (int)Session["StudentID"];
				String requests = "SELECT * FROM dbo.FN_StudentViewGP(" + studentid.ToString() + ")";
				using(SqlCommand cmd = new SqlCommand(requests, conn))
				{
					cmd.CommandType = CommandType.Text;
					if (Session["StudenrID"] !=null)
					{
						int Student_id = (int)Session["StudentID"];
						cmd.Parameters.Add(new SqlParameter("StudentID" , Student_id));
						using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
						{
							DataTable dt = new DataTable();
							adapter.Fill(dt);
							GridView5.DataSource = dt;
							GridView5.DataBind();
							if(dt.Rows.Count == 0)
							{
								Response.Write("No data found");
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