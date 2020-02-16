<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="Tarea1_Bases.Registrarse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <link href="Hojas%20de%20Estilo/Register.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">

        <div class="loginbox">

              <img src="Imagenes/sesionSInMarcos.png" alt="Alternate Text" class="user "/>
              <h2 class="h2">Login</h2>
        
        <asp:Label ID="lblname" runat="server" CssClass="lblname" Text="name"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtname" runat="server" CssClass="txtname" placeholder="name"></asp:TextBox>
              <asp:Label ID="Lblast" runat="server" Text="*" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LbLastname" runat="server" CssClass="lblLastname" Text="Last name"></asp:Label>
        <br />
        <asp:TextBox ID="txtLastname" runat="server" CssClass="txtlastname" placeholder="last name"></asp:TextBox>
              <asp:Label ID="Lblast2" runat="server" Text="*" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblemail" runat="server" CssClass="lblemail" Text="email"></asp:Label>
        <br />
        <asp:TextBox ID="txtemail" runat="server" CssClass="txtemail" placeholder="email"></asp:TextBox>
              <asp:Label ID="Lblast3" runat="server" Text="*" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblpassword" runat="server" CssClass="lblpassword" Text="password"></asp:Label>
        <br />
        <asp:TextBox ID="txtpassword" runat="server" CssClass="txtpassword" placeholder="password" TextMode="Password"></asp:TextBox>
              <asp:Label ID="Lblast4" runat="server" Text="*" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="lblvalidatepassword" runat="server" CssClass="lblpassword1" Text="validate password"></asp:Label>
        <br />
        <asp:TextBox ID="txtpassword1" runat="server" CssClass="txtpassword1"  placeholder="validate password"></asp:TextBox>
              <asp:Label ID="lblast5" runat="server" Text="*" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="btnregiter" runat="server" CssClass="btnRegister" Text="Registrar" OnClick="btnregiter_Click" />
    
    </div>
    </form>
</body>
</html>
