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
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void registerMethod(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            if (string.IsNullOrEmpty(firstname.Text) || string.IsNullOrEmpty(lastname.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(password.Text) || string.IsNullOrEmpty(faculty.Text) || string.IsNullOrEmpty(major.Text) || string.IsNullOrEmpty(semester.Text))
            {

                Response.Write("Missing information!, please continue filling the boxes below");
            }
            else
            {

                string fn = firstname.Text;
                string ln = lastname.Text;
                string em = email.Text;
                string pass = password.Text;
                string fac = faculty.Text;
                string maj = major.Text;
                int sem = Int16.Parse(semester.Text);


                SqlCommand register = new SqlCommand("Procedures_StudentRegistration", conn);
                register.CommandType = CommandType.StoredProcedure;
                register.Parameters.Add(new SqlParameter("@first_name", fn));
                register.Parameters.Add(new SqlParameter("@last_name", ln));
                register.Parameters.Add(new SqlParameter("@password", pass));
                register.Parameters.Add(new SqlParameter("@faculty", fac));
                register.Parameters.Add(new SqlParameter("@email", em));
                register.Parameters.Add(new SqlParameter("@major", maj));
                register.Parameters.Add(new SqlParameter("@Semester", sem));

                SqlParameter id = register.Parameters.Add("@Student_id", SqlDbType.Int);
                id.Direction = ParameterDirection.Output;
                conn.Open();
                register.ExecuteNonQuery();
                conn.Close();
                int studentid = Convert.ToInt32(id.Value);
                Response.Write("registeration successful here is your id:" + studentid);
                Response.Write("please click the next button");
            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student_login.aspx");
        }
    }
}