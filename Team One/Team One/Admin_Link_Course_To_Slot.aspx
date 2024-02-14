<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Link_Course_To_Slot.aspx.cs" Inherits="Team_One.Admin_Link_Instructor_ToCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Course_ID:<asp:TextBox ID="course" runat="server"></asp:TextBox>
        </div>
        <p>
        <asp:Label ID="Label1" runat="server" Text="Instructor_ID"></asp:Label>
            :<asp:TextBox ID="instructor" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Slot_ID"></asp:Label>
            :<asp:TextBox ID="slot" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Link" OnClick="Link"/>
    &nbsp;
        <asp:Button ID="Button2" runat="server" Text="Main Menu" OnClick="Menu" />
    </form>
</body>
</html>
