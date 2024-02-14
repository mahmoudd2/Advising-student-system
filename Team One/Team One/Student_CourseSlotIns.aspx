<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_CourseSlotIns.aspx.cs" Inherits="Team_One.CourseSlotIns" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView4" runat="server" OnSelectedIndexChanged="GridView4_SelectedIndexChanged">
            </asp:GridView>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Main Menu" OnClick="Menu" />
        </div>
    </form>
</body>
</html>
