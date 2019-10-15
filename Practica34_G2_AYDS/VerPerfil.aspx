<%@ Page Title="Ver Perfil" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerPerfil.aspx.cs" Inherits="Practica34_G2_AYDS.VerPerfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Aqui podras visualizar tus datos.</h3>
    <div>
        <table style="width: 100%;">
            <tr>
                <td style="width: 132px">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Aceptar" />
                </td>
                <td>
                    <asp:Image ID="Image1" runat="server" Height="100px" ImageUrl="~/Imagenes/perfil.png" Width="116px" />
                </td>
            </tr>
        </table>
    </div>
    <div>

    </div>
</asp:Content>
