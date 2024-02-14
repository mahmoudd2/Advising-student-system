<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_sendingcr.aspx.cs" Inherits="Team_One.sendingcr" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Please enter the required information:"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="CourseID:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Type:<br />
            <asp:TextBox ID="cid" runat="server" Width="170px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="type" runat="server"></asp:TextBox>
            <br />
            <br />
            Comment:<br />
            <asp:TextBox ID="cm" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Finish" OnClick="Button1_Click" />
            &nbsp;
            <asp:Button ID="Button2" runat="server" Text="Main Menu" OnClick="Menu" />
            <br />
        </div>
    </form>
</body>
</html>
