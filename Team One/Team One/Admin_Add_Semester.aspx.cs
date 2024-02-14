using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_One
{
    public partial class Admin_Add_Semester : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String Start_Date = Start_date.Text;
            String End_Date = End_date.Text;
            String Semester_Code = Sem_Code.Text;
            DateTime StartDate;
            DateTime EndDate;

            if(DateTime.TryParse(Start_Date , out StartDate) && DateTime.TryParse(End_Date, out EndDate) && Semester_Code != null && Semester_Code != "") 
            {
                SqlCommand Add = new SqlCommand("[AdminAddingSemester]", conn);
                Add.CommandType = System.Data.CommandType.StoredProcedure;
                Add.Parameters.Add(new SqlParameter("@start_date", Start_Date));
                Add.Parameters.Add(new SqlParameter("@end_date", End_Date));
                Add.Parameters.Add(new SqlParameter("@semester_code", Semester_Code));

                try
                {
                    conn.Open();
                    Add.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("Semester Added!");
                } catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }

            } else
            {
                Response.Write("Enter correct data");
            }
        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Main_Menu.aspx");
        }
    }
}