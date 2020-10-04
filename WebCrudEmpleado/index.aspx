<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebCrudEmpleado.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Empleados</title>
    <link href="Css/estilos.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="master">
           <h1>Lista Empleados</h1>

            <p>
                <asp:ImageButton  ID="ibNuevo" runat="server" ImageUrl="~/img/add.png" OnClick="ibnuevo_click"/> 

            </p>

            <asp:GridView ID="gvEmpleados" runat="server" CssClass="table" >
                           
            </asp:GridView>

        </div>
    </form>
</body>
</html>
