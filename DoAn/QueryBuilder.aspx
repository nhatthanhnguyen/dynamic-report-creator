<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryBuilder.aspx.cs" Inherits="DoAn.QueryBuilder" %>

<%@ Register assembly="DevExpress.XtraReports.v19.2.Web.WebForms, Version=19.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraReports.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Query builder</title>
    <style type="text/css">

        
        .auto-style1 {
            text-align: center;
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
            <table class="dxflInternalEditorTable">
                <tr>
                    <td>
                        <table class="dxflInternalEditorTable" style="border: 5px solid red; width:auto; height:90px">
                            <tr>
                                <td class="auto-style1">
                                    <asp:Label ID="NameReportLabel" runat="server" Font-Names="Arial" Font-Size="Medium" Text="Name of report" Font-Bold="True"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="NameReportTextbox" runat="server" Font-Names="Arial" Font-Size="Medium"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>
                        <table class="dxflInternalEditorTable" style="margin:auto; border: 5px solid red; width:auto; height:90px">
                            <tr>
                                <td class="auto-style1">
                                    <asp:Label ID="PageSetupLabel" runat="server" Font-Names="Arial" Font-Size="Medium" Text="Page setup" Font-Bold="True"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:RadioButtonList ID="PageSetupRadioList" runat="server" Font-Names="Arial" Font-Size="Medium">
                                        <asp:ListItem Selected="True">Portail</asp:ListItem>
                                        <asp:ListItem>Landscape</asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            <dx:ASPxQueryBuilder ID="ASPxQueryBuilder1" runat="server" OnSaveQuery="ASPxQueryBuilder1_SaveQuery" Height="500px" Width="90%">
            </dx:ASPxQueryBuilder>
        </div>
    </form>
</body>
</html>
