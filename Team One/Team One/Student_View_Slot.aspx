<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_View_Slot.aspx.cs" Inherits="Team_One.ViewStudent_View_Slot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label11" runat="server" Text="CourseID:"></asp:Label>
            <asp:TextBox ID="Courseid" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="Label22" runat="server" Text="InstructorID:"></asp:Label>
        <asp:TextBox ID="Instructorid" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button11" runat="server" Text="View" OnClick="Button11_Click" />
        &nbsp;
            <asp:Button ID="Button12" runat="server" Text="Main Menu" OnClick="Menu" />
        </p>
    </form>
</body>
</html>
