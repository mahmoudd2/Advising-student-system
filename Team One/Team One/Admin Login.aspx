<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin Login.aspx.cs" Inherits="Team_One.Admin_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Login</div>
        <p>
            UserID:</p>
        <p>
            <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
        </p>
        <p>
            Password:</p>
        <p>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="log" runat="server" Text="login" OnClick="login" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Not Admin?" OnClick="BACK" />
        </p>
        <p>
            <asp:Label ID="lblMessage" runat="server" Visible="false" ForeColor="Red"></asp:Label>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>