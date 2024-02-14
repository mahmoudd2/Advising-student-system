<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_View_NotPaid.aspx.cs" Inherits="Team_One.View_NotPaid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="StudentID:"></asp:Label>
            <asp:TextBox ID="Studentid2" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </div>
        <asp:Button ID="Button6" runat="server" Text="View" OnClick="Button6_Click" />
    &nbsp;
        <asp:Button ID="Button7" runat="server" Text="Main Menu" OnClick="Menu" />
    </form>
</body>
</html>
