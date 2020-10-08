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
    public partial class eliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int num = Convert.ToInt32(Request["id"].ToString());
                Empleado emp = BussEmpleado.buscar(num);
                textNum.Text = emp.Num.ToString();
                textNombres.Text = emp.Nombre;
                textApellidos.Text = emp.Apellidos;
                textEmail.Text = emp.Email;
                TextTelefono.Text = emp.Telefono.ToString();
            }
        }

        protected void btnEliminar_click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(textNum.Text);
                BussEmpleado.Delete(num);
                Response.Redirect("index.aspx");

            }
            catch (Exception exe)
            {
            }
        }
    }
}