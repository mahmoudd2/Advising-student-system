<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Link_Student_ToCousreInstructor.aspx.cs" Inherits="Team_One.Admin_Link_Student_ToCousreInstructor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Course_ID"></asp:Label>
        <asp:TextBox ID="course" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Instructor_ID"></asp:Label>
            <asp:TextBox ID="instructor" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Student_ID"></asp:Label>
        <asp:TextBox ID="student" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Semester_Code"></asp:Label>
            <asp:TextBox ID="semester" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Link" OnClick="Link" />
    &nbsp;
        <asp:Button ID="Button2" runat="server" Text="Main Menu" OnClick="Menu" />
    </form>
</body>
</html>
