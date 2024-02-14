<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student Welcome Page.aspx.cs" Inherits="Team_One.mainmenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Main menu"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Log in" OnClick="Button2_Click" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="You Are Not A Student?" OnClick="Welcome_Page" />
        <br />
        <br />

    </form>
</body>
</html>
