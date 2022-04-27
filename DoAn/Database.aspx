<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Database.aspx.cs" Inherits="DoAn.Database" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Choose database</title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            text-align: right;
        }
        .auto-style3 {
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
                    <td class="auto-style3">
                        <asp:Label ID="NameInVietnamese" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="Red" Text="HỌC VIỆN CÔNG NGHỆ BƯU CHÍNH VIỄN THÔNG TP. HỒ CHÍ MINH"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="NameInEnglish" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Large" Text="POSTS AND TELECOMMUNICATIONS INSTITUTE OF TECHNOLOGY HO CHI MINH CITY"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            <table class="auto-style1" style="margin:auto; border: 5px solid red;">
                <tr>
                    <td class="auto-style1" colspan="2">
                        <asp:Label ID="ChooseDatabaseLabel" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Large" Text="CHOOSE DATABASE"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="DatabaseLabel" runat="server" CssClass="auto-style3" Font-Names="Arial" Font-Size="Medium" Text="Database"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="DatabaseDropDownList" runat="server" Font-Names="Arial" Font-Size="Medium">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="ToQueryBuilder" runat="server" Font-Names="Arial" Font-Size="Medium" Text="To query builder" OnClick="ToQueryBuilder_Click" Width="270px" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Button ID="ToCustomQuery" runat="server" Font-Names="Arial" Font-Size="Medium" OnClick="ToCustomQuery_Click" Text="To custom query" Width="270px" />
                    </td>
                </tr>
            </table>
            <br />
        </div>
    </form>
    </body>
</html>