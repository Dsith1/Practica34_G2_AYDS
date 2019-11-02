<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Transferencia.aspx.cs" Inherits="Practica34_G2_AYDS.Transferencia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
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
    </form>
</body>
</html>
