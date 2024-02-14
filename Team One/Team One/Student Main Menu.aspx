<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student Main Menu.aspx.cs" Inherits="WebApplication1.Student_Main_Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Button ID="Button3" runat="server" Text="Add telephonenumber" OnClick="Button3_Click" />
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" Text="View optional courses" OnClick="Button4_Click" />
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" Text="View available courses" OnClick="Button5_Click" />
        <br />
        <br />
        <asp:Button ID="Button6" runat="server" Text="View Required courses" OnClick="Button6_Click1" />
        <br />
        <br />
        <asp:Button ID="Button7" runat="server" Text="View missing courses" OnClick="Button7_Click" />
        <br />
        <br />
        <asp:Button ID="Button8" runat="server" Text="Course request" OnClick="Button8_Click" />
        <br />
        <br />
        <asp:Button ID="Button9" runat="server" Text="Credit hour request" OnClick="Button9_Click" />
        <br />
        <br />
        <asp:Button ID="Button10" runat="server" Text="View GradPlan And Courses" OnClick="GradPlan_Courses" />
        <br />
        <br />
        <asp:Button ID="Button11" runat="server" Text="View Upcoming NotPaid Installments" OnClick="NotPaid_Installments"/>
        <br />
        <br />
        <asp:Button ID="Button12" runat="server" Text="View All Courses And Exam Details" OnClick="Courses_ExamDetails" />
        <br />
        <br />
        <asp:Button ID="Button13" runat="server" Text="Register For First MakeUp" OnClick="First_MakeUp" />
        <br />
        <br />
        <asp:Button ID="Button14" runat="server" Text="Register For Second MakeUp" OnClick="Second_MakeUp" />
        <br />
        <br />
        <asp:Button ID="Button15" runat="server" Text="View All Courses & Slots & Instructor Details" OnClick="Courses_Slot_Instructor" />
        <br />
        <br />
        <asp:Button ID="Button16" runat="server" Text="View All Slots Of a Course Taught By A Certain Instructor" OnClick="Slot_Course_Instructor" />
        <br />
        <br />
        <asp:Button ID="Button17" runat="server" Text="Choose An Instructor For A Course" OnClick="Instructor_Course" />
        <br />
        <br />
        <asp:Button ID="Button18" runat="server" Text="View All Details For All Courses Along With Their Prerequisites" OnClick="Courses_PreRequisites" />
          
            <br />
            <br />
            <br />
            <asp:Button ID="Button19" runat="server" Text="Welcome Page" OnClick="WelcomePage" />
          
        </div>
    </form>
</body>
</html>
