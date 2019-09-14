<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="KorisnickiInterfejs.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 308px;
            text-align: right;
        }
        .style2
        {
            font-size: medium;
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
                <strong>PRIJAVA KORISNIKA</strong></td>
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
                <asp:Label ID="Label1" runat="server" 
                    style="font-size: medium; font-weight: 700" Text="Korisničko ime: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbKorisnickoIme" runat="server" Width="275px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label2" runat="server" 
                    style="font-size: medium; font-weight: 700" Text="Šifra:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txbSifra" runat="server" TextMode="Password" Width="274px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                <asp:Label ID="lblStatus" runat="server" Text="STATUS"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnPrijava" runat="server" onclick="btnPrijava_Click" 
                    Text="PRIJAVA" />
                <asp:Button ID="btnOdustani" runat="server" onclick="btnOdustani_Click" 
                    PostBackUrl="~/Default.aspx" Text="ODUSTANI" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
