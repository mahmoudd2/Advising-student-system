<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Procedures_AdminDeleteSlots.aspx.cs" Inherits="Team_One.Procedures_AdminDeleteSlots" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Please Enter Current Semester"></asp:Label>
            <br />
            <asp:TextBox ID="semester_ID" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Enter" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Slots_Table" runat="server" Text="Below is the Slots Table , if it is not shown then it is empty "></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <asp:Button ID="Button2" runat="server" Text="Main Menu" OnClick="Menu" />
        </div>
    </form>
</body>
</html>
