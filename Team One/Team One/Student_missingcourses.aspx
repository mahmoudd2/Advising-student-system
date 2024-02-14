<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_missingcourses.aspx.cs" Inherits="Team_One.missingcourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true">
            </asp:GridView>
            <asp:Button ID="Button1" runat="server" Text="Main Menu" OnClick="Menu" />
        </div>
    </form>
</body>
</html>
