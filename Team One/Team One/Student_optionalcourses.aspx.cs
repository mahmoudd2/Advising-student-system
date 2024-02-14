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
    public partial class optionalcourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

          

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            if (string.IsNullOrEmpty(semnum.Text))
            {

                Response.Write("invalid semcode, please enter your semester code");
            }
            else
            {

                string semcode = semnum.Text;
                Session["semestercode"] = semcode;
                conn.Open();
                Response.Redirect("Student_optionalcoursesview.aspx");
                conn.Close();
            }
           
        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Student Main Menu.aspx");
        }
    }
}