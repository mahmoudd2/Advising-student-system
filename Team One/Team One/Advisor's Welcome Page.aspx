<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Advisor's Welcome Page.aspx.cs" Inherits="Team_One.Main_Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Advisor Main Menu.css" />
</head>
<body>
    <form id="form1" runat="server">
        <h1>
            Welcome Advisor!</h1>
        <p>
            New Here?<asp:Button ID="Button1" runat="server" Text="Register" OnClick="Register_page" />
        </p>
        <p>
            Already Registered ?&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Login" OnClick="Login_Page" Width="80px" />
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" Text="You Are Not An Advisor?" OnClick="Welcome_page" />
        </p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
