<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_requiredcoursesview.aspx.cs" Inherits="Team_One.requiredcoursesview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" >
            </asp:GridView>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Re-Enter Your Semester Code" OnClick="SemCode" />
        </div>
    </form>
</body>
</html>
