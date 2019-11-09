<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsumoWeb.aspx.cs" Inherits="Practica34_G2_AYDS.ConsumoWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Dia"></asp:Label>
            <br />
            <asp:TextBox ID="txtDia" runat="server" Width="465px"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Ver Dia" />
        </div>
    </form>
</body>
</html>
