using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_One
{
    public partial class Admin_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void login(object sender, EventArgs e)
        {
            int UserID;
            if (!string.IsNullOrEmpty(txtUserID.Text))
            {
                try
                {
                    UserID = Int16.Parse(txtUserID.Text);
                }
                catch (Exception ex)
                {
                    Response.Write("Enter Correct Data");
                    return;
                }
            }
            else
            {
                Response.Write("Enter Correct Data");
                return;
            }
            string password = txtPassword.Text;


            int adminID = 12345;
            string adminPassword = "adminpassword";

            if (UserID == adminID && password == adminPassword)
            {

                lblMessage.Text = "Login successful! Welcome!";
                lblMessage.Visible = true;
                Response.Redirect("Admin_Main_Menu.aspx");
            }
            else
            {

                lblMessage.Text = "Invalid username or password";
                lblMessage.Visible = true;
            }
        }

        protected void BACK(object sender, EventArgs e)
        {
            Response.Redirect("Welcome Page.aspx");
        }
    }
}