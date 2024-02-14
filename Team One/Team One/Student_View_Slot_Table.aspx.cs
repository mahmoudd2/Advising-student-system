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
	public partial class Student_View_Slot : System.Web.UI.Page
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
				int courseid = (int)Session["StudentViewSlotC"];
				int instructorid = (int)Session["StudentViewSlotI"];

                String requests = "SELECT * FROM dbo.FN_StudentViewSlot(" + courseid.ToString() +"," + instructorid.ToString() + ")";

                using (SqlCommand cmd = new SqlCommand(requests, conn))
				{
					cmd.CommandType = CommandType.Text;
					if (Session["StudentViewSlotC"] != null && Session["StudentViewSlotI"] != null)
					{
						int Course_id = (int)Session["StudentViewSlotC"];
						int Instructor_id = (int)Session["StudentViewSlotI"];
						cmd.Parameters.Add(new SqlParameter("@CourseID", Course_id));
						cmd.Parameters.Add(new SqlParameter("@InstructorID", Instructor_id));
						using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
						{
							DataTable dt = new DataTable();
							adapter.Fill(dt);
							GridView8.DataSource = dt;
							GridView8.DataBind();
							if (dt.Rows.Count == 0)
							{
								Response.Write("No data found");
							}

						}
					}
				}
			}
		}
	}
}