<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_Chrequest.aspx.cs" Inherits="Team_One.Chrequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Please insert the needed information:"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Credit hours:"></asp:Label>
            <br />
            <asp:TextBox ID="ch" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Type:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Comment:"></asp:Label>
            <br />
            <asp:TextBox ID="typ" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="com" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Request" OnClick="Button1_Click" />
        &nbsp;
            <asp:Button ID="Button2" runat="server" Text="Main Menu" OnClick="Menu" />
        </div>
    </form>
</body>
</html>
