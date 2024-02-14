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
    public partial class AdminUpdateStudentStatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            if (string.IsNullOrEmpty(studentid.Text))
            {
                Response.Write("You did not provide a Student ID ,please enter a Student ID");
            }
            else
            {
                int id = Int16.Parse(studentid.Text);
                SqlCommand Updatestdstatus = new SqlCommand("Procedure_AdminUpdateStudentStatus", conn);

                Updatestdstatus.CommandType = CommandType.StoredProcedure;

                Updatestdstatus.Parameters.Add(new SqlParameter("@student_id", id));

                conn.Open();
                // SqlDataReader rdr = Updatestdstatus.ExecuteReader();
                Updatestdstatus.ExecuteNonQuery();
                Response.Write("Student Payment Status Updated Successfully");
                conn.Close();
            }
        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Main_Menu.aspx");
        }
    }
}