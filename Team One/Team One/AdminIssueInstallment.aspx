﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminIssueInstallment.aspx.cs" Inherits="Team_One.AdminIssueInstallment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Please Enter Payment ID"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="paymentid" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Enter" OnClick="Button1_Click" />
        &nbsp;
            <asp:Button ID="Button2" runat="server" Text="Main Menu" OnClick="Menu" />
        </div>
    </form>
</body>
</html>