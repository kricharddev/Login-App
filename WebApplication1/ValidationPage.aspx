<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationPage.aspx.cs" Inherits="WebApplication1.ValidationPage" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Successful</title>
</head>
<body runat="server" style="color: deepskyblue; background-color:grey">
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <div runat="server" align="center">
            <table> 
                <tr>
                    <td align="center" colspan="2" style="padding-top:48px">
                        <asp:Label runat="server" Font-Size="Large" Font-Italic="true">Login Successful!</asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2" style="padding-top:16px">
                        <asp:Label runat="server" Font-Size="Large" >Welcome,</asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2">
                        <asp:Label runat="server" id="lblFirstName" Font-Size="Large"></asp:Label>
                        <asp:Label runat="server" id="lblLastName" Font-Size="Large"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2" style="padding-top:16px">
                        <asp:Button runat="server" id="btnLogout" Text="Logout" OnClick="btnSubmit_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
