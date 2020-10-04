using Buss;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCrudEmpleado
{
    public partial class nuevo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGrabar_click(object sender, EventArgs e)
        {
            try
            {
                int num = 0;
                string nombres = textNombres.Text;
                string apellidos = textApellidos.Text;
                string email = textEmail.Text;
                int telefono = int.Parse(TextTelefono.Text);
                Empleado emp = new Empleado(num,nombres,apellidos,email,telefono);
                BussEmpleado.Insert(emp);
                Response.Redirect("index.aspx");
            }
            catch (Exception exe)
            {
            }

        }
    }
}