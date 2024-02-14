using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_One
{
    public partial class Admin_Add_Course : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String Major = major.Text;
            int sem;
            int Credit_hours;
            String Name = name.Text;
            int offered;
            if (!string.IsNullOrEmpty(semester.Text))
            {
                try
                {
                    sem = Int16.Parse(semester.Text);
                }
                catch(Exception ex)
                {
                    Response.Write("Enter Correct Data");
                    return;
                }
            } else
            {
                Response.Write("Enter Correct Data");
                return;
            }
            if (!string.IsNullOrEmpty(credit_hours.Text))
            {
                try
                {
                    Credit_hours = Int16.Parse(credit_hours.Text);
                }
                catch(Exception ex)
                {
                    Response.Write("Enter Correct Data");
                    return;
                }
            }
            else
            {
                Response.Write("Enter Correct Data");
                return;
            }
            if (!string.IsNullOrEmpty(is_offered.Text))
            {
                try
                {


                    offered = Int16.Parse(is_offered.Text);
                }
                catch (Exception ex)
                {
                    Response.Write("Enter Correct Data"); 
                    return;
                }
            }
            else
            {
                Response.Write("Enter Correct Data");
                return;
            }


            if (offered == 1 || offered == 0 && Name !=null  && Name !=null)
            {
                SqlCommand Add = new SqlCommand("[Procedures_AdminAddingCourse]", conn);
                Add.CommandType = System.Data.CommandType.StoredProcedure;
                Add.Parameters.Add(new SqlParameter("@major", Major));
                Add.Parameters.Add(new SqlParameter("@semester", sem));
                Add.Parameters.Add(new SqlParameter("@credit_hours", Credit_hours));
                Add.Parameters.Add(new SqlParameter("@name", Name));
                Add.Parameters.Add(new SqlParameter("@is_offered", offered));
                try
                {
                    conn.Open();
                    Add.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("Course Added!");
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
            else
            {
                Response.Write("Is_Offered should be 1 or 0");
            }
        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Main_Menu.aspx");
        }
    }
}