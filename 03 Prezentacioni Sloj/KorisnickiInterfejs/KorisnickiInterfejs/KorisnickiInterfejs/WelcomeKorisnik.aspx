<%@ Page Title="" Language="C#" MasterPageFile="~/Korisnik.Master" AutoEventWireup="true" CodeBehind="WelcomeKorisnik.aspx.cs" Inherits="KorisnickiInterfejs.WelcomeKorisnik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        DOBRODOSLI KORISNICE,
        <asp:Label ID="lblImePrezime" runat="server" Text="IME I PREZIME KORISNIKA"></asp:Label>
        !</p>
    <p>
        &nbsp;</p>
</asp:Content>

