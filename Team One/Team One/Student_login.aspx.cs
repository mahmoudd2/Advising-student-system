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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            if (string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(password.Text))
            {

                Response.Write("invalid ID or password, please enter your your ID and password");
            }
            else
            {

                int id = Convert.ToInt32(username.Text);
                Session["StudentID"] = id;

                string pass = password.Text;
                SqlCommand fun = new SqlCommand("FN_StudentLogin", conn);
                fun.CommandType = CommandType.StoredProcedure;
                fun.Parameters.Add(new SqlParameter("@Student_id", id));
                fun.Parameters.Add(new SqlParameter("@password", pass));

                SqlParameter succ = fun.Parameters.Add("succ", SqlDbType.Bit);
                succ.Direction = ParameterDirection.ReturnValue;
                conn.Open();
                fun.ExecuteNonQuery();
                conn.Close();
                if (succ.Value.ToString() == "True")
                {
                    Session["StudentID"] = id;
                    Response.Redirect("Student Main Menu.aspx");
                }
                else
                    Response.Write("Incorrect Username Or Password");

                Response.Redirect("Student Main Menu.aspx");
            }
        }
    }
}