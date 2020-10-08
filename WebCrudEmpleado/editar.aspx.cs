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
    public partial class editar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
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

        protected void btnGrabar_click(object sender, EventArgs e)
        {
            try
            {
                Empleado emp = new Empleado();
                emp.Num = int.Parse(textNum.Text);
                emp.Nombre = textNombres.Text;
                emp.Apellidos = textApellidos.Text;
                emp.Email = textEmail.Text;
                emp.Telefono = int.Parse(TextTelefono.Text);
                BussEmpleado.Update(emp);

                Response.Redirect("index.aspx");
            }
            catch (Exception exe)
            {
            }

        }
    }
}