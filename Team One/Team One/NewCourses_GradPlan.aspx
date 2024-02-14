<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewCourses_GradPlan.aspx.cs" Inherits="Team_One.NewCourses_GradPlan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            StudentID:
            <asp:TextBox ID="StudentID" runat="server"></asp:TextBox>
            <br />
            Semester Code:
            <asp:TextBox ID="Semester_Code" runat="server"></asp:TextBox>
            <br />
            Course Name:
            <asp:TextBox ID="Course_Name" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick= "Insert_course" Text="Insert" />
        &nbsp;
            <asp:Button ID="Button2" runat="server" Text="Main Menu" OnClick="Menu" />
        </div>
    </form>
</body>
</html>
