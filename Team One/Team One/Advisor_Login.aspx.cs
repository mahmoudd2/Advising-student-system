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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void login(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            if (string.IsNullOrEmpty(Username.Text) || string.IsNullOrEmpty(Password.Text))
            {
                Response.Write("Please Fill All The Information!");
            }
            else
            {
                int advisor_id = Int16.Parse(Username.Text);
                String password = Password.Text;

                SqlCommand loginProc = new SqlCommand("[FN_AdvisorLogin]", conn);
                loginProc.CommandType = CommandType.StoredProcedure;
                loginProc.Parameters.Add(new SqlParameter("@advisor_Id", advisor_id));
                loginProc.Parameters.Add(new SqlParameter("@password", password));

                SqlParameter success = loginProc.Parameters.Add("success", SqlDbType.Bit);

                success.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                loginProc.ExecuteNonQuery();
                conn.Close();

                if (success.Value.ToString()=="True")
                {
                    Session["AdvisorID"] = advisor_id;
                    Response.Write("Login is successful");
                    Response.Redirect("Advisor's Main Menu.aspx");

                }
                else
                {
                    Response.Write("Login is Unsuccessful");
                }
            }
        }

        protected void Main_menu(object sender, EventArgs e)
        {
            Response.Redirect("Advisor's Main Menu.aspx");
        }
    }
}