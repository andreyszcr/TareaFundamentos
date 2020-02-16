<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Factura.aspx.cs" Inherits="Tarea1_Bases.Factura" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <link href="Hojas%20de%20Estilo/Factura.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 165px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="lblfactura" runat="server" Font-Size="Large" ForeColor="White" Text="Sistema de Facturacion"></asp:Label>
            <br />
            <br />
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">FECHA</td>
                <td>
                    <asp:TextBox ID="TXTFECHA" runat="server" Enabled="False" Width="137px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">CLIENTE</td>
                <td>
                    <asp:DropDownList ID="cmdcliente" runat="server" Width="403px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">PRODUCTO</td>
                <td>
                    <asp:DropDownList ID="cmdproducto" runat="server" Width="403px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">CANTIDAD</td>
                <td>&nbsp;
                    <asp:TextBox ID="txtcantidad" runat="server" Enabled="False" Width="137px"></asp:TextBox>
&nbsp;&nbsp;
                    <asp:Button ID="btnagregar" runat="server" Text="Agregar" Width="101px" />
                &nbsp;&nbsp;
                    <asp:Button ID="btnborrar" runat="server" Text="Borrar" Width="88px" />
                </td>
            </tr>
        </table>
        <asp:Label ID="lblmensaje" runat="server" Text=""></asp:Label><br /><br />

    </form>
</body>
</html>
