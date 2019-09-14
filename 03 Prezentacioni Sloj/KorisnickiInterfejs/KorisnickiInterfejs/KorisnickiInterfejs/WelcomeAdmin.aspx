<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="WelcomeAdmin.aspx.cs" Inherits="KorisnickiInterfejs.WelcomeAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        DOBRODOSLI ADMINE,
        <asp:Label ID="lblImePrezime" runat="server" Text="IME I PREZIME Admina"></asp:Label>
        !</p>
    <p>
        &nbsp;</p>
</asp:Content>
