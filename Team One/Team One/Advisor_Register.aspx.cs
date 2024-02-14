using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading.Tasks;

namespace Team_One
{
    public partial class Advisor_Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String advisor_name = Advisor_name.Text;
            String pass = password.Text;
            String email = Email.Text;
            String office = Office.Text;

            SqlCommand Register = new SqlCommand("[Procedures_AdvisorRegistration]", conn);
            Register.CommandType = CommandType.StoredProcedure;
            Register.Parameters.Add(new SqlParameter("@advisor_name", advisor_name));
            Register.Parameters.Add(new SqlParameter("@password", pass));
            Register.Parameters.Add(new SqlParameter("@email", email));
            Register.Parameters.Add(new SqlParameter("@office", office));

            SqlParameter Advisor_id = Register.Parameters.Add("Advisor_id", SqlDbType.Int);

            Advisor_id.Direction = ParameterDirection.Output;

            conn.Open();
            Register.ExecuteNonQuery();
            Session["AdvisorID"] = Advisor_id;


            conn.Close();
            Response.Write(Advisor_id.Value);
        }

        protected void Login_Page(object sender, EventArgs e)
        {
            Response.Redirect("Advisor_Login.aspx");
        }

        protected void Main_menu(object sender, EventArgs e)
        {
            Response.Redirect("Advisor's Welcome Page.aspx");
        }
    }
}