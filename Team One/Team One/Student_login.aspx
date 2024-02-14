<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_login.aspx.cs" Inherits="Team_One.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Please log in:"></asp:Label>
            <br />
            <br />
            Username:<br />
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
            <br />
            password:<br />
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="login" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
