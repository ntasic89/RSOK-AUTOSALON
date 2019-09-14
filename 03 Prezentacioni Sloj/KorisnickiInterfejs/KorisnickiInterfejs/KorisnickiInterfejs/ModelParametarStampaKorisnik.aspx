<%@ Page Title="" Language="C#" MasterPageFile="~/Korisnik.Master" AutoEventWireup="true" CodeBehind="ModelParametarStampaKorisnik.aspx.cs" Inherits="KorisnickiInterfejs.ModelParametarStampaKorisnik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
        text-align: right;
        width: 260px;
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
                <asp:Label ID="Label1" runat="server" style="text-align: right" 
                    Text="Naziv modela"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbFilter" runat="server" Width="233px"></asp:TextBox>
                <asp:Button ID="btnFilterStampa" runat="server" onclick="btnFilterStampa_Click" 
                    Text="PRIKAZI FILTRIRANI SPISAK ZA STAMPU" Width="417px" />
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
