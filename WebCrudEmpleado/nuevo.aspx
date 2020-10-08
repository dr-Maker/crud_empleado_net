<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="nuevo.aspx.cs" Inherits="WebCrudEmpleado.nuevo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Nuevo Empleado</title>
    <link href="Css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card">
                <div class="card-header">
                    <h1 class="text-center">Nuevo Empleado</h1>
                </div>
                <div class="card-body">

                    <div class="form-group row">
                        <asp:Label class="col-sm-2 col-form-label" Text="Nombres" runat="server"></asp:Label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="textNombres" class="form-control" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="txtNombresValdiador" runat="server" ErrorMessage="El Nombre es requerido" ControlToValidate="textNombres" CssClass="text-danger"/>
                        </div>
                    </div>
                    <div class="form-group row">
                        <asp:Label class="col-sm-2 col-form-label" Text="Apellidos" runat="server"></asp:Label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="textApellidos" class="form-control" runat="server"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="textApellidosValidador" runat="server" ErrorMessage="El Apellido es requerido" ControlToValidate="textApellidos" CssClass="text-danger"/>
                        </div>
                    </div>
                    <div class="form-group row">
                        <asp:Label class="col-sm-2 col-form-label" Text="Email" runat="server"></asp:Label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="textEmail" class="form-control" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="textEmailValidador" runat="server" ErrorMessage="El Email es requerido" ControlToValidate="textEmail" CssClass="text-danger"/>
                            <asp:RegularExpressionValidator ID="textEmailValidadorFormato" runat="server" ErrorMessage="Formato de correo inválido" ControlToValidate="textEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="text-danger" />
                        </div>
                    </div>
                    <div class="form-group row">
                        <asp:Label class="col-sm-2 col-form-label" Text="Teléfono" runat="server"></asp:Label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="TextTelefono" class="form-control" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="TextTelefonoValidador" runat="server" ErrorMessage="El Telefóno es requerido" ControlToValidate="TextTelefono" CssClass="text-danger"/>
                            <asp:RegularExpressionValidator ID="txtTelefonoNumerico" runat="server" ErrorMessage="Favor ingresar solo Números formato 123456789" ControlToValidate="TextTelefono" ValidationExpression="\d{9}" CssClass="text-danger"/>
                        </div>
                    </div>
                    <div class="form-group row">
                        <div class="col-sm-10">
                            <asp:Button ID="btnGrabar" runat="server" Text="Grabar" CssClass="btn btn-primary" OnClick="btnGrabar_click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
