<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Advisor_Login.aspx.cs" Inherits="Team_One.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Login:<br />
            <br />
            Username:
            <asp:TextBox ID="Username" runat="server"></asp:TextBox>
            <br />
            <br />
            Password:
            <asp:TextBox ID="Password" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="SignIn" runat="server" OnClick="login" Text="Log in" />
        &nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Main Menu" OnClick="Main_menu" />
        </div>
    </form>
</body>
</html>
