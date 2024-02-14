﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_One
{
	public partial class CourseSlotIns : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string connstr = WebConfigurationManager.ConnectionStrings["Team_One"].ToString();
			SqlConnection conn = new SqlConnection(connstr);
			SqlCommand CourseSlotIns = new SqlCommand("Select * from Courses_Slots_Instructor", conn);
			conn.Open();
			SqlDataReader rdr = CourseSlotIns.ExecuteReader();
			GridView4.DataSource = rdr;
			GridView4.DataBind();
			conn.Close();
			Response.Write("Courses, their corresponding slot details, and instructor");
		}

        protected void GridView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Student Main Menu.aspx");
        }
    }
}