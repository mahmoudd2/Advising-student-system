<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome Page.aspx.cs" Inherits="Team_One.Welcome_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Choose What Type Of User Are You.<br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Student" OnClick="Student" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Advisor" OnClick="Advisor" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Admin" OnClick="Admin" />
        </div>
    </form>
</body>
</html>
