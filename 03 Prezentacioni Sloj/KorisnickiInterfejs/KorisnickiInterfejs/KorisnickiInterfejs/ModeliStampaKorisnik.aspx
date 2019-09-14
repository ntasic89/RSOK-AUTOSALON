<%@ Page Title="" Language="C#" MasterPageFile="~/Korisnik.Master" AutoEventWireup="true" CodeBehind="ModeliStampaKorisnik.aspx.cs" Inherits="KorisnickiInterfejs.ModeliStampaKorisnik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style6
        {
            width: 230px;
        }
        .style7
        {
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style7">
                <asp:Label ID="lblSpisak" runat="server" Text="Spisak Modela"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td>
                <asp:GridView ID="gvSpisakRacuna" runat="server" Height="192px" Width="425px" 
                    onselectedindexchanged="gvSpisakRacuna_SelectedIndexChanged">
                </asp:GridView>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

