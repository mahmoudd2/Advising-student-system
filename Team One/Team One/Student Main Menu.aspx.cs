using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Student_Main_Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student_telephonenumber.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student_optionalcourses.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student_availablecourses.aspx");
        }

        protected void Button6_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Student_requiredcourses.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student_missingcourses.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student_sendingcr.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student_Chrequest.aspx");
        }

        protected void GradPlan_Courses(object sender, EventArgs e)
        {
            Response.Redirect("Student_View GradPlan.aspx");
        }

        protected void NotPaid_Installments(object sender, EventArgs e)
        {
            Response.Redirect("Student_View_NotPaid.aspx");
        }

        protected void Courses_ExamDetails(object sender, EventArgs e)
        {
            Response.Redirect("Student_ExamDetails.aspx");
        }

        protected void First_MakeUp(object sender, EventArgs e)
        {
            Response.Redirect("Student_Registerfirstmakeup.aspx");
        }

        protected void Second_MakeUp(object sender, EventArgs e)
        {
            Response.Redirect("Student_Registersecondmakeup.aspx");
        }

        protected void Courses_Slot_Instructor(object sender, EventArgs e)
        {
            Response.Redirect("Student_CourseSlotIns.aspx");
        }

        protected void Slot_Course_Instructor(object sender, EventArgs e)
        {
            Response.Redirect("Student_View_Slot.aspx");

        }

        protected void Instructor_Course(object sender, EventArgs e)
        {
            Response.Redirect("Student_ChooseInstructor.aspx");
        }

        protected void Courses_PreRequisites(object sender, EventArgs e)
        {
            Response.Redirect("Student_CoursePre.aspx");
        }

        protected void WelcomePage(object sender, EventArgs e)
        {
            Response.Redirect("Welcome Page.aspx");
        }
    }
}