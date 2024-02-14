<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_Students_major_courses.aspx.cs" Inherits="Team_One.View_Students_major_courses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Major:
            <asp:TextBox ID="major" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="View" OnClick="View" />
        &nbsp;
            <asp:Button ID="Button2" runat="server" Text="Main Menu" OnClick="Menu" />
        </div>
    </form>
</body>
</html>
