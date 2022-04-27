<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewReport.aspx.cs" Inherits="DoAn.ViewReport" %>

<%@ Register assembly="DevExpress.XtraReports.v19.2.Web.WebForms, Version=19.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraReports.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View report</title>
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
            <dx:ASPxWebDocumentViewer ID="ASPxWebDocumentViewer1" runat="server">
            </dx:ASPxWebDocumentViewer>
        </div>
    </form>
</body>
</html>
