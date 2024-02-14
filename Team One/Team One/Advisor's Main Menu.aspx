<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Advisor's Main Menu.aspx.cs" Inherits="Team_One.Adviosr_s_Main_Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            1)
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="View_Advising_Students">View Your Advising Students</asp:LinkButton>
            <br />
            2)
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="Insert_GradPlan">Insert GradPlan</asp:LinkButton>
            <br />
            3)
            <asp:LinkButton ID="LinkButton3" runat="server" OnClick="Insert_Course">Insert Course</asp:LinkButton>
            <br />
            4)
            <asp:LinkButton ID="LinkButton4" runat="server" OnClick="Update_GradDate">Update GradDate</asp:LinkButton>
            <br />
            5)
            <asp:LinkButton ID="LinkButton5" runat="server" OnClick="Delete_Course">Delete Course From GradPlan</asp:LinkButton>
            <br />
            6)
            <asp:LinkButton ID="LinkButton6" runat="server" OnClick="View_Students_Major">View All Advising Students From Certain Major</asp:LinkButton>
            <br />
            7)
            <asp:LinkButton ID="LinkButton7" runat="server" OnClick="View_Requests">View Your Requests</asp:LinkButton>
            <br />
            8)
            <asp:LinkButton ID="LinkButton8" runat="server" OnClick="View_Pending_Requests" >View Your Pending Requests</asp:LinkButton>
            <br />
            9)
            <asp:LinkButton ID="LinkButton9" runat="server" OnClick="Approve_Reject_CH">Approve/Reject Credit Hours Requests</asp:LinkButton>
            <br />
            10)
            <asp:LinkButton ID="LinkButton10" runat="server" OnClick="Approve_Reject_Courses">Approve/Reject Courses Courses Request</asp:LinkButton>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Welocme Page" OnClick="Menu" />
        </div>
    </form>
</body>
</html>
