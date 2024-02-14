<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update GradPlan.aspx.cs" Inherits="Team_One.Update_GradPlan" %>

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
            New Graduation Date:
            <asp:TextBox ID="Grad_date" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Update" />
        &nbsp;
            <asp:Button ID="Button2" runat="server" Text="Main Menu" OnClick="Menu" />
        </div>
    </form>
</body>
</html>
