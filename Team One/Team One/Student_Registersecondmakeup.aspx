<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_Registersecondmakeup.aspx.cs" Inherits="Team_One.Registersecondmakeup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Register for second makeup exam"></asp:Label>
            <br />
            CourseId:
            <asp:TextBox ID="CourseID" runat="server"></asp:TextBox>
            <br />
            Student Current Semester:
            <asp:TextBox ID="Curr_Sem" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Button2" runat="server" Text="Register" OnClick="Button2_Click" />
    &nbsp;
        <asp:Button ID="Button3" runat="server" Text="Main Menu" OnClick="Menu" />
    </form>
</body>
</html>
