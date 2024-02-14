<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Procedures_AdminDeleteCourse.aspx.cs" Inherits="Team_One.Procedures_AdminDeleteCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label2" runat="server" Text="These are the existing course_IDs"></asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Enter course_ID to be deleted from above"></asp:Label>
        <br />
        <asp:TextBox ID="course_ID" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Enter" OnClick="Button1_Click" />
    &nbsp;
        <asp:Button ID="Button2" runat="server" Text="Main Menu" OnClick="Menu" />
    </form>
</body>
</html>
