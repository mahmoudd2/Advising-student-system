using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_One
{
    public partial class Chrequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            if (string.IsNullOrEmpty(ch.Text) || string.IsNullOrEmpty(typ.Text)){

                Response.Write("you didn't provide the needed information, please enter the needed information");
            }
            else {
                string cm = com.Text;
                string type = typ.Text;
                int creditH = Int16.Parse(ch.Text);
                int uid = (int)Session["StudentID"];

                SqlCommand sndingcH = new SqlCommand("Procedures_StudentSendingCHRequest", conn);
                sndingcH.CommandType = CommandType.StoredProcedure;
                sndingcH.Parameters.Add(new SqlParameter("@StudentID", uid));
                sndingcH.Parameters.Add(new SqlParameter("@credit_hours", creditH));
                sndingcH.Parameters.Add(new SqlParameter("@type", type));
                sndingcH.Parameters.Add(new SqlParameter("@comment", cm));
                conn.Open();
                sndingcH.ExecuteNonQuery();
                conn.Close();
                Response.Write("Request sent successfully!");
            }
            
            
            
            
            
        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Student Main Menu.aspx");
        }
    }
}