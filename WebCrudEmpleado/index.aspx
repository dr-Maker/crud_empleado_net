<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebCrudEmpleado.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Empleados</title>
    <link href="Css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card">
                <div class="card-header">
                    <h1 class="text-center">Lista Empleados</h1>
                </div>
                <div class="card-body">
                    <asp:ImageButton ID="ibNuevo" runat="server" ImageUrl="~/Img/add.png" OnClick="ibnuevo_click" />
                    <asp:GridView ID="gvEmpleados" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-striped"
                        OnRowEditing="gvEmpleados_RowEditing" 
                        OnRowDeleting="gvEmpleados_RowDeleting"
                        >
                        <Columns>
                            <asp:BoundField DataField="num" HeaderText="Num.Empleado" />
                            <asp:BoundField DataField="nombres" HeaderText="Nombre" />
                            <asp:BoundField DataField="apellidos" HeaderText="Apellido" />
                            <asp:BoundField DataField="email" HeaderText="Email" />
                            <asp:BoundField DataField="telefono" HeaderText="Teléfono" />

                            <asp:CommandField ButtonType="Image" HeaderText="Editar" EditImageUrl="~/Img/editar.png"  ShowEditButton="True" />
                            <asp:CommandField ButtonType="Image" HeaderText="Eliminar" DeleteImageUrl="~/Img/borrar.png" ShowDeleteButton="True" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
