<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inventario.aspx.cs" Inherits="Tarea1_Bases.Inventario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <%-- hojas de estilo para el inventario  --%>
    <link href="Hojas%20de%20Estilo/Inventario.css" rel="stylesheet" />


</head>
<body>
    <form id="form1" runat="server">

        



        <div class="topnav">
              <a href="Menu.aspx">MenuPrincipal</a>
               <asp:LinkButton ID="lbtnCrear" runat="server" OnClick="lbtnCrear_Click">Crear Articulo</asp:LinkButton>
               <asp:LinkButton ID="lbtnGuardar" runat="server" OnClick="lbtnGuardar_Click">Guardar Articulo</asp:LinkButton>
               <asp:LinkButton ID="lbtnModificar" runat="server">Modificar</asp:LinkButton>
               <asp:LinkButton ID="lbtnEliminar" runat="server">Eliminar</asp:LinkButton>
               <asp:LinkButton ID="lbtnReportes" runat="server" OnClick="lbtnReportes_Click">Reportes</asp:LinkButton>
        </div>
           <br />
           <br />
           <br />
        <asp:Label ID="lblname" runat="server" Text="nombre " ForeColor="White"></asp:Label>

           <br />
        <br />
        <asp:TextBox ID="txtnombre" runat="server" placeholder="nombre" ></asp:TextBox>
        <asp:Label ID="lblast7" runat="server" Text="*" ForeColor="Red"></asp:Label>
           <br />
           <br />
        <asp:Label ID="lblnameproveedor" runat="server" Text="nombre del proveedor" ForeColor="White"></asp:Label>
           <br />
        <br />
        <asp:TextBox ID="txtnombreproveedor" runat="server" placeholder="nombre del empleado"></asp:TextBox>
        <asp:Label ID="lblast" runat="server" Text="*" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblnamearticulo" runat="server"  Text="nombre del articulo" ForeColor="White"></asp:Label>
        <br />
        <asp:TextBox ID="txtnamearticulo" runat="server" placeholder="nombre de producto"></asp:TextBox>
        <asp:Label ID="lblast2" runat="server" Text="*" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblcoantidad" runat="server" Text="cantidad del articulo" ForeColor="White"></asp:Label>
        <br />
        <asp:TextBox ID="txtcantidad" runat="server" TextMode="Number" placeholder="cantidad"></asp:TextBox>
        <asp:Label ID="lblast3" runat="server" Text="*" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblcosto" runat="server" Text="Costo" ForeColor="White"></asp:Label>
        <br />
        <asp:TextBox ID="txtcosto" runat="server" placeholder="costo"></asp:TextBox>
        <asp:Label ID="Lblast4" runat="server" Text="*" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblventa" runat="server" Text="Venta" ForeColor="White"></asp:Label>
        <br />
        <asp:TextBox ID="txtventa" runat="server" placeholder="venta"></asp:TextBox>
        <asp:Label ID="lblast5" runat="server" Text="*" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblnumOrden" runat="server" Text="Numero de Orden" ForeColor="White"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtnumOrden" runat="server" placeholder="numero de Orden"></asp:TextBox>
        <asp:Label ID="lblast6" runat="server" Text="*" ForeColor="Red"></asp:Label>

        <br />
        <br />

        
    </form>
</body>
</html>
