<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_List_Students_Table.aspx.cs" Inherits="Team_One.Admin_List_Students_Table" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" AutoGenerateColumns="true">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Main Menu" OnClick ="Menu"/>
    </form>
</body>
</html>
