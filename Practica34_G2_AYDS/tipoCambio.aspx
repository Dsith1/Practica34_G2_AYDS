<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="tipoCambio.aspx.cs" Inherits="Practica34_G2_AYDS.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%: Title %></h2>
    <h3>Tipo de cambio.</h3>
    <div>
        <table style="width: 100%;">
            <tr>
                <td style="width: 132px">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
                <td>

                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />

                </td>
                <td>

                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />

                </td>
                <td style="width: 132px">
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Image ID="Image1" runat="server" Height="100px" ImageUrl="~/Imagenes/consultar.jpg" Width="116px" />
                </td>
            </tr>
        </table>
    </div>
    <div>

    </div>

</asp:Content>
