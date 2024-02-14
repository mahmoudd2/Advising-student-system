<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Advisor_Register.aspx.cs" Inherits="Team_One.Advisor_Register" Async ="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
           Advisor Register:<br />
            <br />
            Name:
            <asp:TextBox ID="Advisor_name" runat="server"></asp:TextBox>
            <br />
            <br />
            Password:
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
            <br />
            Email:
            <asp:TextBox ID="Email" runat="server"></asp:TextBox>
            <br />
            <br />
            Office:
            <asp:TextBox ID="Office" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="register" runat="server" onClick="Register" Text="Register" />
            &nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Login_Page" Text="Next" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Already Have An Account ?" OnClick="Main_menu"/>
        </div>
    </form>
</body>
</html>
