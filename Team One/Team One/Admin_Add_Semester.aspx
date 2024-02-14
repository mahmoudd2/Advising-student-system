<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Add_Semester.aspx.cs" Inherits="Team_One.Admin_Add_Semester" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Start Date:
            <asp:TextBox ID="Start_date" runat="server"></asp:TextBox>
            <br />
            End Date:
            <asp:TextBox ID="End_date" runat="server"></asp:TextBox>
            <br />
            Semester Code:
            <asp:TextBox ID="Sem_Code" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Add" />
        &nbsp;
            <asp:Button ID="Button2" runat="server" Text="Main Menu" OnClick="Menu" />
        </div>
    </form>
</body>
</html>
