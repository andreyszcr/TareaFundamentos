<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Tarea1_Bases.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <link href="Hojas%20de%20Estilo/Menu.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
            <div class="topnav ">
             <a  href="Inventario.aspx">Inventario</a>
             <a href="Almacen.aspx">Almacen</a>
             <a href="Factura.aspx">Factura</a>
             <asp:LinkButton ID="lbtnCerrarSesion" runat="server" OnClick="lbtnCerrarSesion_Click">Cerrar Sesion</asp:LinkButton>
        </div>
         

    </form>
</body>
</html>