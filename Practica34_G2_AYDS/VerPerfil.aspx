<%@ Page Title="Ver Perfil" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerPerfil.aspx.cs" Inherits="Practica34_G2_AYDS.VerPerfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    


    <h3 style="color:#a50a0a;">Mi Perfil</h3>
    <div style="margin-left:80px; background-color:#343335; border-radius:20px; padding:20px; width: 60%; color:white;">

        <h4>Aqui podras visualizar tus datos.</h4>
    </div>
    <div>
        <table style="width: 60%; color:white;background-color:#2d2d31; margin-left: 78px; border-bottom-style:double; border-radius:20px; height: 131px;">
            <tr>
                <td style="width: 167px">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
                <td style="width: 179px">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Aceptar" style="background-color:black;"/>
                </td>
                <td>
                    <asp:Image ID="Image1" runat="server" Height="100px" ImageUrl="~/Imagenes/perfil.png" Width="116px" />
                </td>
            </tr>
            <br />
            <br /><br /><br />
        </table>
    </div>
    <div>

        <table style="width:60%; color:white;background-color:#2d2d31; margin-left: 78px; border-bottom-style:double; border-radius:20px;">
            <br />
            <tr>
                <td style="width: 115px">&nbsp;</td>
                <td style="width: 231px">DPI</td>
                <td>
                    <asp:Label ID="LabelDPI" runat="server" Text="LabelDPI"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 115px">&nbsp;</td>
                <td style="width: 231px">Nombre</td>
                <td>
                    <asp:Label ID="LabelNombre" runat="server" Text="LabelNombre"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 115px">&nbsp;</td>
                <td style="width: 231px">Apellido</td>
                <td>
                    <asp:Label ID="LabelApellido" runat="server" Text="LabelApellido"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 115px">&nbsp;</td>
                <td style="width: 231px">Correo</td>
                <td>
                    <asp:Label ID="LabelCorreo" runat="server" Text="LabelCorreo"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 115px">&nbsp;</td>
                <td style="width: 231px">Contraseña</td>
                <td>
                    <asp:Label ID="LabelPassword" runat="server" Text="LabelPassword"></asp:Label>
                </td>
            </tr>
            <br />
        </table>
        <br />

    </div>
</asp:Content>
