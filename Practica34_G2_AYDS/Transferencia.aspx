<%@ Page Title="Transferencia" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Transferencia.aspx.cs" Inherits="Practica34_G2_AYDS.Transferencia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
       <div>
            No. Cuenta A Debitar&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:TextBox ID="txtCuenta1" runat="server"></asp:TextBox>
            <br />
            <br />
            No. Cuenta a Acreditar<br />
            <asp:TextBox ID="txtCuenta2" runat="server"></asp:TextBox>
            <br />
            <br />
            Monto<br />
            <asp:TextBox ID="txtmonto" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <asp:Label ID="lblRespuestaT" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnTransferencia" runat="server" OnClick="btnTransferencia_Click" Text="Transferir" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnLimpiar" runat="server" OnClick="btnLimpiar_Click" Text="Limpiar" />
        </div>
</asp:Content>
