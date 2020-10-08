<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="eliminar.aspx.cs" Inherits="WebCrudEmpleado.eliminar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Css/bootstrap.css" rel="stylesheet" />
    <title>Eliminar</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card">

            <div class="card-header">
                <h1 class="text-center">Eliminar</h1>
            </div>

                    <div class="card-body">
        

                            <div class="form-group row">
                                    <asp:Label CssClass="col-sm-2 col-form-label" Text="Num.Empleado" runat="server"></asp:Label>
                                     <div class="col-sm-10">
                                        <asp:TextBox ReadOnly="true" ID="TextNum" CssClass="form-control" runat="server"></asp:TextBox>
                                     </div>
                                </div>

                                <div class="form-group row">
                                    <asp:Label class="col-sm-2 col-form-label" Text="Nombres" runat="server"></asp:Label>
                                     <div class="col-sm-10">
                                        <asp:TextBox ID="textNombres" class="form-control" runat="server"></asp:TextBox>
                                     </div>
                                </div>

                                <div class="form-group row">
                                    <asp:Label class="col-sm-2 col-form-label" Text="Apellidos" runat="server"></asp:Label>
                                     <div class="col-sm-10">
                                        <asp:TextBox ID="textApellidos" class="form-control" runat="server"></asp:TextBox>
                                     </div>
                                </div>

                                <div class="form-group row">
                                    <asp:Label class="col-sm-2 col-form-label" Text="Email" runat="server"></asp:Label>
                                     <div class="col-sm-10">
                                        <asp:TextBox ID="textEmail" class="form-control" runat="server"></asp:TextBox>
                                     </div>
                                </div>


                              <div class="form-group row">
                                    <asp:Label class="col-sm-2 col-form-label" Text="Teléfono" runat="server"></asp:Label>
                                     <div class="col-sm-10">
                                        <asp:TextBox ID="TextTelefono" class="form-control" runat="server"></asp:TextBox>
                                     </div>
                               </div>
                               
                         

                           <div class="form-group row">
                               <div class="col-sm-10">
                                 <asp:Button ID="btnGrabar" runat="server" Text="Grabar" CssClass="btn btn-success" OnClick="btnGrabar_click"/>
                           
                               </div>
                         </div>
                                  
                        </div>
                    </div>
                </div>
    </form>
</body>
</html>
