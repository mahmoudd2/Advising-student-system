<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_GradPlan.aspx.cs" Inherits="Team_One.GradPlan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Student ID:
            <asp:TextBox ID="Studentid" runat="server"></asp:TextBox>
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" Text="View" OnClick="GradPlanView" />
    &nbsp;
        <asp:Button ID="Button2" runat="server" Text="Main Menu" OnClick="Menu" />
    </form>
</body>
</html>
