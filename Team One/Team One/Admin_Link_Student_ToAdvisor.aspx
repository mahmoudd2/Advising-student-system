<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Link_Student_ToAdvisor.aspx.cs" Inherits="Team_One.Admin_Link_Student_ToAdvisor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Student_ID"></asp:Label>
            <asp:TextBox ID="student" runat="server"></asp:TextBox>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Advisor_ID"></asp:Label>
            <asp:TextBox ID="advisor" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" Text="Link" OnClick="Link"/>
    &nbsp;
        <asp:Button ID="Button2" runat="server" Text="Main Menu" OnClick="Menu" />
    </form>
</body>
</html>
