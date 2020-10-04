using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Data
{
    public class BaseDatos
    {
        string conx = "Data Source=localhost;Initial Catalog=net_crudempleado;Integrated Security=True";

        public DataTable ejecutarConsulta(SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            try
            {
                cmd.Connection = new SqlConnection(conx);
                sda.Fill(dt);
            }
            catch(SqlException exe)
            {
                dt = null;
            }
            return dt;
        }

    }
}