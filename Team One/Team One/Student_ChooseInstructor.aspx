<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_ChooseInstructor.aspx.cs" Inherits="Team_One.ChooseInstructor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label50" runat="server" Text="StudentID:"></asp:Label>
            <asp:TextBox ID="Student" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="Label51" runat="server" Text="InstructorID:"></asp:Label>
        <asp:TextBox ID="Instructor" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label52" runat="server" Text="CourseID:"></asp:Label>
        <asp:TextBox ID="CourseID" runat="server"></asp:TextBox>
        <br />
        Semester Code:
        <asp:TextBox ID="SemCode" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Choose" OnClick="Choose" />
&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Main Menu" OnClick="Menu" />
    </form>
</body>
</html>
