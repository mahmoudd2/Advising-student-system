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
    public partial class Procedures_AdminDeleteSlots : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            String connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand slotss = new SqlCommand("Select * From Slot where Slot.slot_id is not null and Slot.course_id is not null", conn);

            conn.Open();
            SqlDataReader rdr = slotss.ExecuteReader();
            GridView1.DataSource = rdr;
            GridView1.DataBind();
            conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            String connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            if (string.IsNullOrEmpty(semester_ID.Text))
            {
                Response.Write("You did not provide a Semester , please write the Current Semester");
            }
            else
            {
                string semestercode = semester_ID.Text;
                SqlCommand DeleteSlot = new SqlCommand("Procedures_AdminDeleteSlots", conn);

                DeleteSlot.CommandType = CommandType.StoredProcedure;

                DeleteSlot.Parameters.Add(new SqlParameter("@current_semester", semestercode));

                conn.Open();
                // SqlDataReader rdr = DeleteCourse.ExecuteReader();
                DeleteSlot.ExecuteNonQuery();
                Response.Write("Slots that are not provided in current semester are deleted successfully");
                conn.Close();
            }
        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Main_Menu.aspx");
        }
    }
}