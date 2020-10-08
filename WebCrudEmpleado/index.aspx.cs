using Buss;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCrudEmpleado
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = BussEmpleado.listar01();
            gvEmpleados.DataSource = dt;
            gvEmpleados.DataBind();
        }

        protected void ibnuevo_click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("nuevo.aspx");
        }


        protected void gvEmpleados_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int fila = e.NewEditIndex;
            string num = gvEmpleados.Rows[fila].Cells[0].Text;
            Response.Redirect("editar.aspx?id="+ num);
        }

  
    }

   
}