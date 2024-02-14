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
    public partial class telephonenumber : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            int id = Convert.ToInt32(Session["userid"]);
            string numb = phonenumber.Text;
            SqlCommand addnum = new SqlCommand("Procedures_StudentaddMobile", conn);
            addnum.CommandType = CommandType.StoredProcedure;
            addnum.Parameters.Add(new SqlParameter("@mobile_number", numb));
            addnum.Parameters.Add(new SqlParameter("@StudentID", id));
            Response.Write( "this number has been added successfully:" + numb );
            phonenumber.Text = " ";
            conn.Open();
            addnum.ExecuteNonQuery();
            conn.Close();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student Main Menu.aspx");

        }
    }
}