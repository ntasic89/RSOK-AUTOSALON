<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="KorisnickiInterfejs._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
    {
        font-weight: 700;
            font-size: large;
        }
    .style2
    {
        text-decoration: none;
    }
    .style3
    {
        text-decoration: underline;
        text-align: center;
        font-size: x-large;
    }
        .style5
        {
            font-size: medium;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <p class="style3">
        <strong style="text-align: center">DOBRODOŠLI!</strong></p>
<p class="style1">
        NA NAŠEM SAJTU MOŽETE POGLEDATI SVE AKTUELNE OPEL MODELE ZA 2019.GODINU.</p>
<p>
        <span class="style5">OSOBE ZA KONTAKT: <strong>Nemanja Tasić</strong></p>
<p>
        E- mail: <a class="style2" href="mailto:ntasic89@gmail.com"><strong>
        ntasic89@gmail.com</strong></a></p>
<p>
        Radno vreme: </span><strong><span class="style5">Svakim radnim danom od 9h do 16h.</span></strong></p>
</asp:Content>
