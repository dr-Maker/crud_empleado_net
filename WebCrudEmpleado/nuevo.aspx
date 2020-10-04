<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="nuevo.aspx.cs" Inherits="WebCrudEmpleado.nuevo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Nuevo Empleado</title>
    <link href="Css/estilos.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="master">
            <p>
                <asp:Label Text="Nombres" runat="server"></asp:Label>
                <asp:TextBox ID="textNombres" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label Text="Apellidos" runat="server"></asp:Label>
                <asp:TextBox ID="textApellidos" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label Text="Email" runat="server"></asp:Label>
                <asp:TextBox ID="textEmail" runat="server"></asp:TextBox>
            </p>
             <p>
                <asp:Label Text="Teléfono" runat="server"></asp:Label>
                <asp:TextBox ID="TextTelefono" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="btnGrabar" runat="server" Text="Grabar" OnClick="btnGrabar_click"/>
            </p>
        </div>
    </form>
</body>
</html>
