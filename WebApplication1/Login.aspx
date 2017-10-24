<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" >

<html>
<head runat="server">
    <title></title>
</head>
<body style="color: deepskyblue; background-color:grey">
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <div align="center">
            <table> 
                <tr>
                    <td align="right" style="padding-top:32px">
                        <asp:Label runat="server" >User Name:</asp:Label>
                    </td>
                    <td style="padding-top:32px">
                        <asp:TextBox runat="server" id="txtUserName"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <asp:Label runat="server" >Password:</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" id="txtPassword" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" colspan="2" style="padding-top:8px">
                        <asp:Button runat="server" id="btnSubmit" Text="Login" OnClick="btnSubmit_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
