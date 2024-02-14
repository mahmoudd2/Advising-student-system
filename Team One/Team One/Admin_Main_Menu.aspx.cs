using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Team_One
{
    public partial class Admin_Main_Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Add_Course.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Add_Semester.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_List_Pending_Requests.aspx"); 
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Link_Course_To_Slot.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Link_Student_ToCousreInstructor.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Link_Student_ToAdvisor.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_List_Students_Table.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_View_DetailsOf_Instructor_WithAssignedCourse.aspx");
        }
        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Fetch_Semesters_Along_OfferedCourses.aspx");
        }
        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Listed_Advisors_Table.aspx");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Student_Payment.aspx");

        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Students_Courses_transcript.aspx");

        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Advisors_Graduation_Plan.aspx");

        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Semster_offered_Courses.aspx");
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_view_Students.aspx");
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Procedures_AdminDeleteCourse.aspx");
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminUpdateStudentStatus.aspx");
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminIssueInstallment.aspx");
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            Response.Redirect("Procedures_AdminDeleteSlots.aspx");
        }

        protected void Button20_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminAddExam.aspx");
        }

        protected void WelcomePage(object sender, EventArgs e)
        {
            Response.Redirect("Welcome Page.aspx");
        }
    }
}