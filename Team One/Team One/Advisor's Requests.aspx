<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Advisor's Requests.aspx.cs" Inherits="Team_One.Advisor_s_Requests" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true">
            </asp:GridView>
            <br />
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="CH_requests">Approve Or Reject CH Requests</asp:LinkButton>
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="Courses_requests">Approve Or Reject Courses Requests</asp:LinkButton>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Main Menu" OnClick="Menu" />
        &nbsp;</div>
    </form>
</body>
</html>

