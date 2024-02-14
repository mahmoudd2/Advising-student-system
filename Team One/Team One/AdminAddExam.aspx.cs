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
    public partial class AdminAddExam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand examtobeadded = new SqlCommand("Select* From MakeUp_Exam", conn);

            conn.Open();
            SqlDataReader rdr = examtobeadded.ExecuteReader();
            GridView1.DataSource = rdr;
            GridView1.DataBind();
            conn.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            SqlConnection conn = new SqlConnection(connStr);


            if (string.IsNullOrEmpty(examtype.Text) || string.IsNullOrEmpty(examdate.Text) || string.IsNullOrEmpty(courseid.Text))
            {
                Response.Write("You left a field(or more) empty,please fill all fields");
            }
            else
            {
                string type = examtype.Text;
                string dateexam = examdate.Text;
                string idcourse = courseid.Text;


                SqlCommand addExam = new SqlCommand("Procedures_AdminAddExam", conn);

                addExam.CommandType = CommandType.StoredProcedure;

                addExam.Parameters.Add(new SqlParameter("@Type", type));
                addExam.Parameters.Add(new SqlParameter("@date", dateexam));
                addExam.Parameters.Add(new SqlParameter("@courseID", idcourse));

                conn.Open();
                // SqlDataReader rdr = addExam.ExecuteReader();
                addExam.ExecuteNonQuery();
                Response.Write("Exam Added successfully");
                conn.Close();
            }
        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Main_Menu.aspx");
        }
    }
}