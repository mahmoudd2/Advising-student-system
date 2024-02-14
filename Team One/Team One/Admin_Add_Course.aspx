<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Add_Course.aspx.cs" Inherits="Team_One.Admin_Add_Course" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Major:<asp:TextBox ID="major" runat="server"></asp:TextBox>
        <p>
            Semester:<asp:TextBox ID="semester" runat="server"></asp:TextBox>
        </p>
        <p>
            Credit_Hours:<asp:TextBox ID="credit_hours" runat="server"></asp:TextBox>
        </p>
        <p>
            Course_Name:<asp:TextBox ID="name" runat="server"></asp:TextBox>
        </p>
        <p>
            Is_Offered:<asp:TextBox ID="is_offered" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="add"/>
    &nbsp;
        <asp:Button ID="Button2" runat="server" Text="Main Menu" OnClick="Menu" />
    </form>
</body>
</html>
