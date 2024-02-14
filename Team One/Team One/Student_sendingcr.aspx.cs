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
    public partial class sendingcr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            if (string.IsNullOrEmpty(cid.Text) || string.IsNullOrEmpty(type.Text))
            {

                Response.Write("you didn't provide all the needed information, please enter the needed information");
            }
            else
            {
                string com = cm.Text;
                string typ = type.Text;
                int courseid = Int16.Parse(cid.Text);
                int uid = (int)Session["StudentID"];

                SqlCommand sndingcr = new SqlCommand("Procedures_StudentSendingCourseRequest", conn);
                sndingcr.CommandType = CommandType.StoredProcedure;
                sndingcr.Parameters.Add(new SqlParameter("@StudentID", uid));
                sndingcr.Parameters.Add(new SqlParameter("@courseID", courseid));
                sndingcr.Parameters.Add(new SqlParameter("@type", typ));
                sndingcr.Parameters.Add(new SqlParameter("@comment", com));


                //SqlParameter id = sndingcr.Parameters.Add("@Student_id", SqlDbType.Int);
                // id.Direction = ParameterDirection.Output;
                conn.Open();
                sndingcr.ExecuteNonQuery();
                conn.Close();
                Response.Write("Request sent successfully");




            }
        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Student Main Menu.aspx");
        }
    }
}