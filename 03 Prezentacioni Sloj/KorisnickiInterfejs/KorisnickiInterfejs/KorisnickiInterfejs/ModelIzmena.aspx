<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ModelIzmena.aspx.cs" Inherits="KorisnickiInterfejs.ModelIzmena" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .style1
    {
            width: 208px;
            text-align: right;
        }
    .style2
    {
        font-size: large;
    }
        .style3
        {
            width: 208px;
            text-align: right;
            height: 130px;
        }
        .style4
        {
            height: 130px;
        }
        .style7
        {
            height: 29px;
        }
        .style16
        {
            width: 208px;
            text-align: right;
            height: 29px;
        }
        .style17
        {
            width: 208px;
            text-align: right;
            height: 33px;
        }
        .style18
        {
            height: 33px;
        }
        .style19
        {
            width: 208px;
            text-align: right;
            height: 74px;
        }
        .style20
        {
            height: 74px;
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
            <strong>UNOS PODATAKA O MODELU </strong></td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style16">
            </td>
        <td class="style7">
            </td>
        <td class="style7">
            </td>
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
        <td class="style17">
            NAZIV MODELA</td>
        <td class="style18">
            <asp:TextBox ID="txbNazivModela" runat="server"></asp:TextBox>
        </td>
        <td class="style18">
            </td>
    </tr>
    <tr>
        <td class="style19">
            MOTOR(ccm)</td>
        <td class="style20">
            <asp:TextBox ID="txbMotor" runat="server"></asp:TextBox>
        </td>
        <td class="style20">
            </td>
    </tr>
     
    <tr>
        <td class="style1">
            <br />
            GODINA PROIZVODNJE<table style="width: 100%;">
            </table>
        </td>
        <td>
            <br />
            <asp:TextBox ID="txbGodina" runat="server"></asp:TextBox>
        </td>
        <td>
            </td>
    </tr>

    <tr>
        <td class="style1">
            &nbsp;</td>
        <td class="style2">
            <asp:Button ID="btnIzmeni" runat="server" Text="Izmeni" 
                onclick="btnIzmeni_Click" Width="110px" />
            <%--<asp:Button ID="btnSnimiIzmenu" runat="server" onclick="btnSnimiIzmenu_Click" 
                Text="SNIMI IZMENU" />--%>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3">
            </td>
        <td class="style4">
            <table style="width: 100%;">
            </table>
        </td>
        <td class="style4">
            </td>
    </tr>
</table>
</asp:Content>
