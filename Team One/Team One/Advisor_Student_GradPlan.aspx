<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Advisor_Student_GradPlan.aspx.cs" Inherits="Team_One.Student_GradPlan" %>

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
            Semester Code :
            <asp:TextBox ID="Semester_Code" runat="server"></asp:TextBox>
            <br />
            Semester Credit Hours :
            <asp:TextBox ID="Sem_Credit_Hours" runat="server"></asp:TextBox>
            <br />
            Expected Graduation Date:
            <asp:TextBox ID="Expected_Grad_Date" runat="server"></asp:TextBox>
&nbsp;<br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Insert" Text ="Insert" />
        &nbsp;
            <asp:Button ID="Button2" runat="server" Text="Main Menu" OnClick="Menu" />
        </div>
    </form>
</body>
</html>
