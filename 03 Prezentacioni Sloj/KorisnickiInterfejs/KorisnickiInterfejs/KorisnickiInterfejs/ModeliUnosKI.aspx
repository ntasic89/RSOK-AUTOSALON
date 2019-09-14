<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ModeliUnosKI.aspx.cs" Inherits="KorisnickiInterfejs.ModeliUnosKI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
    {
            width: 220px;
            text-align: right;
        }
    .style2
    {
        font-size: large;
            width: 685px;
        }
        .style3
        {
            width: 220px;
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
            text-align: left;
        }
        .style16
        {
            width: 220px;
            text-align: right;
            height: 29px;
        }
        .style17
        {
            width: 220px;
            text-align: right;
            height: 33px;
        }
        .style18
        {
            height: 33px;
        }
        .style20
        {
            height: 18px;
        }
        .style21
        {
            width: 220px;
            text-align: right;
            height: 18px;
        }
        .style24
        {
            width: 685px;
        }
        .style25
        {
            height: 29px;
            text-align: left;
            width: 685px;
        }
        .style26
        {
            height: 33px;
            width: 685px;
        }
        .style27
        {
            height: 18px;
            width: 685px;
        }
        .style29
        {
            height: 130px;
            width: 685px;
        }
        .style30
        {
            width: 202px;
        }
        .style31
        {
            width: 220px;
            text-align: right;
            height: 47px;
        }
        .style32
        {
            height: 47px;
            width: 685px;
        }
        .style33
        {
            height: 47px;
        }
        .style34
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
    <tr>
        <td class="style1">
            &nbsp;</td>
        <td class="style24">
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
        <td class="style25">
            </td>
        <td class="style7">
            </td>
    </tr>
    <tr>
        <td class="style1">
            SIFRA MODELA</td>
        <td class="style24">
            <asp:TextBox ID="txbSifraModela" runat="server"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style17">
            NAZIV MODELA</td>
        <td class="style26">
            <asp:TextBox ID="txbNazivModela" runat="server"></asp:TextBox>
        </td>
        <td class="style18">
            </td>
    </tr>
    <tr>
        <td class="style17">
            PROIZVODJAC</td>
        <td class="style26">
            <asp:DropDownList ID="ddlProizvodjac" runat="server" Height="24px" Width="273px" 
                AutoPostBack="True" onselectedindexchanged="ddlRoba_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
        <td class="style18">
            </td>
    </tr>
    <tr>
        <td class="style17">
            MOTOR(ccm)&nbsp;</td>
        <td class="style26">
            <asp:TextBox ID="txbMotor" runat="server" ontextchanged="txbMotor_TextChanged"></asp:TextBox>
        </td>
        <td class="style18">
            </td>
    </tr>
    <tr>
        <td class="style21">
            <table style="width: 100%; height: 12px;">
                <tr>
                    <td class="style30">
                        BOJA</td>
                </tr>
            </table>
        </td>
        <td class="style27">
            <asp:DropDownList ID="ddlBoja" runat="server" 
                onselectedindexchanged="ddlBoja_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
        </td>
        <td class="style20">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style31">
            <asp:Label ID="Label1" runat="server" Text="GODIJNA PROIZVODNJE"></asp:Label>
            <br />
            </td>
        <td class="style32">
            <asp:TextBox ID="txbGodina" runat="server" Height="23px" 
                style="text-align: left" Width="195px"></asp:TextBox>
            <br />
            <br />
        </td>
        <td class="style33">
            </td>
    </tr>
    <tr>
        <td class="style3">
            </td>
        <td class="style29">
            <table class="style34">
                <tr>
                    <td>
            <asp:Label ID="lblStatus" runat="server" Text="STATUS"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
            <asp:Button ID="btnSnimi" runat="server" Text="SNIMI" Width="89px" 
                onclick="btnSnimi_Click" />
            <asp:Button ID="btnOdustani" runat="server" Text="ODUSTANI" 
                onclick="btnOdustani_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </td>
        <td class="style4">
            </td>
    </tr>
</table>
</asp:Content>
