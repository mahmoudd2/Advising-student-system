<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Advisor_approve_reject_CH.aspx.cs" Inherits="Team_One.Advisor_approve_reject_CH" %>

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
            <asp:TextBox ID="Current_sem_code" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Proceed" OnClick="Proceed"/>
        &nbsp;
            <asp:Button ID="Button3" runat="server" Text="View Requests Table" OnClick="Requests_Table" />
&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Main Menu" OnClick="Menu" />
        </div>
    </form>
</body>
</html>
