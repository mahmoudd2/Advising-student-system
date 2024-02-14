<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminAddExam.aspx.cs" Inherits="Team_One.AdminAddExam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label4" runat="server" Text="The Following Table Shows Current Makeup Exams"></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Please Enter Exam Type"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="examtype" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Please Enter Exam Date and Time"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="examdate" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Please Enter Course_id"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="courseid" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Enter" OnClick="Button1_Click" />
        &nbsp;
            <asp:Button ID="Button2" runat="server" Text="Main Menu" OnClick="Menu" />
        </div>
    </form>
</body>
</html>
