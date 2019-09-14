<%@ Page Title="" Language="C#" MasterPageFile="~/Korisnik.Master" AutoEventWireup="true" CodeBehind="ModelTabelarniKorisnik.aspx.cs" Inherits="KorisnickiInterfejs.ModelTabelarniKorisnik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .style1
    {
        width: 175px;
    }
    .style2
    {
        font-size: large;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
    <tr>
        <td class="style1">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style1">
            &nbsp;</td>
        <td class="style2">
            <strong>TABELARNI PRIKAZ RACUNA</strong></td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style1">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style1">
            &nbsp;</td>
        <td>
            <asp:Label ID="Label1" runat="server" Text="SIFRA RACUNA"></asp:Label>
            <asp:TextBox ID="txbSifraRacunaFilter" runat="server"></asp:TextBox>
            <asp:Button ID="btnFiltriraj" runat="server" Text="FILTRIRAJ" 
                onclick="btnFiltriraj_Click" />
            <asp:Button ID="btnSvi" runat="server" Text="SVI" Width="83px" 
                onclick="btnSvi_Click" />
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style1">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style1">
            &nbsp;</td>
        <td>
            <asp:GridView ID="gvSpisakRacuna" runat="server" Height="175px" Width="383px">
            </asp:GridView>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style1">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>
