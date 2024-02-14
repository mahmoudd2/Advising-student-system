<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Advisors_Graduation_Plan.aspx.cs" Inherits="Team_One.FN_StudentViewGP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Main Menu" OnClick="Menu" />
            <br />
        </div>
    </form>
</body>
</html>
