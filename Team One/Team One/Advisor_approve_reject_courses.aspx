<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Advisor_approve_reject_courses.aspx.cs" Inherits="Team_One.Advisor_approve_reject_courses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            RequestID:
            <asp:TextBox ID="RequestID" runat="server"></asp:TextBox>
            <br />
            Current Semester Code:
            <asp:TextBox ID="Sem_Code" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Proceed" OnClick="Proceed" />
        &nbsp;
            <asp:Button ID="Button3" runat="server" Text="View Request Table" OnClick="Request_table" />
&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Main Menu" OnClick="Menu" style="height: 35px" />
        </div>
    </form>
</body>
</html>
