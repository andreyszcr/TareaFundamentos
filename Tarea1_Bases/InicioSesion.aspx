<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="Tarea1_Bases.InicioSesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    
    <link href="Hojas%20de%20Estilo/Login.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
       
    <div class="loginbox" runat="server">

        <img src="Imagenes/sesionSInMarcos.png" alt="Alternate Text" class="user "/>
        <h2 class="h2"> login</h2>

         

        <asp:Label ID="lbluser" runat="server" CssClass="lblUser" Text="Nombre Usuario"></asp:Label>
        <br />
        <asp:TextBox ID="txtUser" runat="server" CssClass="txtuser" placeholder="Username"></asp:TextBox>
        <br />
        <asp:Label ID="lblpassword"  runat ="server" CssClass="lblpassword" Text="contraseña"></asp:Label>
        <br />
        <asp:TextBox ID="txtpassword" runat="server" CssClass="txtpassword" placeholder="password" TextMode="Password"></asp:TextBox>
        <br />
        <asp:LinkButton ID="LbtnForget" runat="server" CssClass="btnforget" ForeColor="LightBlue" OnClick="LbtnForget_Click">Olvide la Contraseña</asp:LinkButton>
        <br />
        <asp:LinkButton ID="lbtnRegister" runat="server" CssClass="btnRegister" ForeColor="LightBlue" OnClick="lbtnRegister_Click">Registrarse</asp:LinkButton>
        <br />
        <asp:CheckBox ID="checksession" runat="server" ForeColor="#999999" Text="Recordar la proxima vez" OnCheckedChanged="checksession_CheckedChanged" />
        <br />
        <br />
        <asp:Button ID="btnEnter" runat="server" CssClass="btnenter" Text="Ingresar" OnClick="btnEnter_Click1"/>

    </div>
    </form>
</body>
</html>
