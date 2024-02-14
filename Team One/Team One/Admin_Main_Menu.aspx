<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Main_Menu.aspx.cs" Inherits="Team_One.Admin_Main_Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            `````````````````````````````````````````````````````````````````````````&nbsp;<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <asp:Button ID="Button1" runat="server" Text="Add New Course" Width="436px" OnClick="Button1_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <asp:Button ID="Button2" runat="server" Text="Add New Semester" Width="436px" OnClick="Button2_Click" />
            <br />
        </div>
        <p>
            <asp:Button ID="Button3" runat="server" Text="List Pending Requests" Width="434px" OnClick="Button3_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;</p>
        <p>
            <asp:Button ID="Button4" runat="server" Text="Link Instructor To Course" Width="518px" OnClick="Button4_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
        <p>
            <asp:Button ID="Button5" runat="server" Text="Link Student To Course" Width="517px" OnClick="Button5_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
        <p>
            <asp:Button ID="Button6" runat="server"  Text="Link Student To Advisor" Width="519px" OnClick="Button6_Click"/>
        </p>
        <p>
            <asp:Button ID="Button7" runat="server" Text="List Students With Their Advisors" Width="706px" OnClick="Button7_Click" />
        </p>
        <p>
            <asp:Button ID="Button8" runat="server" Text="Instructors With their Assigned Course" Width="716px" OnClick="Button8_Click" />
        </p>
        <p>
            <asp:Button ID="Button9" runat="server" Text="Semesters Along With Offered Course" Width="717px" OnClick="Button9_Click" />
        </p>
        <p>
            <asp:Button ID="Button10" runat="server" Text="List All Advisors" Width="606px" OnClick="Button10_Click" />
        </p>
            <asp:Label ID="Label1" runat="server" Text="Student_Payments"></asp:Label>
&nbsp;&nbsp;
    <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="Click Here" />
    <br />
    <br />
    Student_Courses_Transcript&nbsp;
    <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="Click Here" />
    <br />
    <br />
    FN_StudentView_GradPlan&nbsp;
    <asp:Button ID="Button13" runat="server" OnClick="Button13_Click" Text="Click Here" />
    <br />
    <br />
    Semester_offered_Couses&nbsp;
    <asp:Button ID="Button14" runat="server" OnClick="Button14_Click" Text="Click Here" />
    <br />
    <br />
    View_Students&nbsp;
    <asp:Button ID="Button15" runat="server" OnClick="Button15_Click" Text="Click Here" />
    <br />
    <br />
    Delete_Course&nbsp;
    <asp:Button ID="Button16" runat="server" OnClick="Button16_Click" Text="Click Here" />
    &nbsp;<br />
    <br />
    UpdateStudentStatus&nbsp;
    <asp:Button ID="Button17" runat="server" OnClick="Button17_Click" Text="Click Here" />
    <br />
    <br />
    Issue_Installments&nbsp;
    <asp:Button ID="Button18" runat="server" OnClick="Button18_Click" Text="Click Here" />
    <br />
    <br />
    Delete_Slots&nbsp;
    <asp:Button ID="Button19" runat="server" OnClick="Button19_Click" Text="Click Here" />
    <br />
    <br />
    Add_Exam&nbsp;
    <asp:Button ID="Button20" runat="server" OnClick="Button20_Click" Text="Click Here" />
        <br />
        <br />
        <asp:Button ID="Button21" runat="server" Text="Welcome Page" OnClick="WelcomePage" />
    <br />
    </form>
</body>
</html>
