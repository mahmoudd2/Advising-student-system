<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_Registerfirstmakeup.aspx.cs" Inherits="Team_One.Registerfirstmakeup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Register for first makeup exam<br />
            <asp:Label ID="Label25" runat="server" Text="CourseID:"></asp:Label>
            <asp:TextBox ID="CourseID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label03" runat="server" Text="Current Semester:"></asp:Label>
            <asp:TextBox ID="Curr_Sem" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
    &nbsp;
        <asp:Button ID="Button2" runat="server" Text="Main Menu" OnClick="Menu" />
    </form>
</body>
</html>
