<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_CoursePre.aspx.cs" Inherits="Team_One.CoursePre" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView2" runat="server" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
            </asp:GridView>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Main Menu" OnClick="Menu" />
        </div>
    </form>
</body>
</html>
