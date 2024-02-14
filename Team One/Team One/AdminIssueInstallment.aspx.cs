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
    public partial class AdminIssueInstallment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            if (string.IsNullOrEmpty(paymentid.Text))
            {
                Response.Write("You did not provide a Payment ID ,please enter a Payment ID");
            }
            else
            {
                int id = Int16.Parse(paymentid.Text);
                SqlCommand installIssue = new SqlCommand("Procedures_AdminIssueInstallment", conn);

                installIssue.CommandType = CommandType.StoredProcedure;

                installIssue.Parameters.Add(new SqlParameter("@payment_id", id));

                conn.Open();
                // SqlDataReader rdr = installIssue.ExecuteReader();
                installIssue.ExecuteNonQuery();
                Response.Write("Installment Issued Successfully");
                conn.Close();


            }
        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Main_Menu.aspx");
        }
    }
}