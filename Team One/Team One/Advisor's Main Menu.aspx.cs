using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_One
{
    public partial class Adviosr_s_Main_Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void View_Advising_Students(object sender, EventArgs e)
        {
            Response.Redirect("Advisor's Students.aspx");
        }

        protected void Insert_GradPlan(object sender, EventArgs e)
        {
            Response.Redirect("Advisor_Student_GradPlan.aspx");
        }

        protected void Insert_Course(object sender, EventArgs e)
        {
            Response.Redirect("NewCourses_GradPlan.aspx");
        }

        protected void Update_GradDate(object sender, EventArgs e)
        {
            Response.Redirect("Update GradPlan.aspx");
        }

        protected void Delete_Course(object sender, EventArgs e)
        {
            Response.Redirect("Delete course_GradPlan_Semester.aspx");
        }

        protected void View_Students_Major(object sender, EventArgs e)
        {
            Response.Redirect("View_Students_major_courses.aspx");
        }

        protected void View_Requests(object sender, EventArgs e)
        {
            Response.Redirect("Advisor's Requests.aspx");
        }

        protected void View_Pending_Requests(object sender, EventArgs e)
        {
            Response.Redirect("Advisor's Pending Requests.aspx");
        }

        protected void Approve_Reject_CH(object sender, EventArgs e)
        {
            Response.Redirect("Advisor_approve_reject_CH.aspx");
        }

        protected void Approve_Reject_Courses(object sender, EventArgs e)
        {
            Response.Redirect("Advisor_approve_reject_courses.aspx");
        }

        protected void Menu(object sender, EventArgs e)
        {
            Response.Redirect("Welcome Page.aspx");
        }
    }
}