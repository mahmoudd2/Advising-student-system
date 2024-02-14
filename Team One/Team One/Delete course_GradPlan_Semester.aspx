<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete course_GradPlan_Semester.aspx.cs" Inherits="Team_One.Delete_course_GradPlan_Semester" %>

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
            <asp:TextBox ID="Sem_Code" runat="server"></asp:TextBox>
            <br />
            CourseID:
            <asp:TextBox ID="CourseID" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Delete" OnClick ="Delete"/>
        &nbsp;
            <asp:Button ID="Button2" runat="server" Text="Main Menu" OnClick="Menu" />
        </div>
    </form>
</body>
</html>
