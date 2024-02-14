<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_View GradPlan.aspx.cs" Inherits="Team_One.View_GradPlan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns ="true">
        </asp:GridView>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Main Menu" OnClick="Menu" />
    </form>
</body>
</html>
