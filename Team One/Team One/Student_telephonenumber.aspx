<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_telephonenumber.aspx.cs" Inherits="Team_One.telephonenumber" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please insert your telephone number(s):<br />
            <br />
            <asp:TextBox ID="phonenumber" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Main Menu" OnClick="Button2_Click" />
            <br />
        </div>
    </form>
</body>
</html>
