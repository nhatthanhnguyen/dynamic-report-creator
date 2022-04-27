<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DoAn.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login server</title>
    <style type="text/css">
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            text-align: right;
        }
        .auto-style4 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td rowspan="2">
                        <asp:Image ID="Image1" runat="server" Height="70px" ImageUrl="~/Image/ptit.png" Width="50px" />
                    </td>
                    <td>
                        <asp:Label ID="NameInVietnamese" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="Red" Text="HỌC VIỆN CÔNG NGHỆ BƯU CHÍNH VIỄN THÔNG TP. HỒ CHÍ MINH"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="NameInEnglish" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Large" Text="POSTS AND TELECOMMUNICATIONS INSTITUTE OF TECHNOLOGY HO CHI MINH CITY"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            <table class="auto-style1" style="margin: auto; border: 5px solid red">
                <tr>
                    <td class="auto-style2" colspan="2">
                        <asp:Label ID="HeaderLabel" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Large" Text="LOGIN TO SERVER"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="ServerNameLabel" runat="server" Font-Names="Arial" Font-Size="Medium" Text="Server name"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:DropDownList ID="ServerNameDropDownList" runat="server" Font-Names="Arial" Font-Size="Medium">
                            <asp:ListItem>DESKTOP-18L9IFI</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="LoginLabel" runat="server" Font-Names="Arial" Font-Size="Medium" Text="Username"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="UsernameTextBox" runat="server" Font-Names="Arial" Font-Size="Medium"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="PasswordLabel" runat="server" Font-Names="Arial" Font-Size="Medium" Text="Password"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="PasswordTextBox" runat="server" Font-Names="Arial" Font-Size="Medium" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="ConnectButton" runat="server" Font-Names="Arial" Font-Size="Medium" OnClick="ConnectButton_Click" Text="Connect" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
