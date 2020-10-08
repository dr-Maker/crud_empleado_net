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
        private string conx1 = "Data Source=localhost;Initial Catalog=net_crudempleado;Integrated Security=True";
        private string conx2 = "Data Source=localhost;Initial Catalog=net_crudempleado;User ID=admin;Password=sql";

        public DataTable ejecutarConsulta(SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            try
            {
                cmd.Connection = new SqlConnection(conx1);
                sda.Fill(dt);


                /*
                //Dato: equivalente al resultSet de JAVA 

                cmd.Connection.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                }
                cmd.Connection.Close();
                */
            }
            catch(SqlException exe)
            {
                dt = null;
            }
            return dt;
        }

        public bool ejecutarAccion(SqlCommand cmd)
        {
            bool std = true;
            try
            {
                cmd.Connection = new SqlConnection(conx2);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (SqlException exe)
            {
                std = false;
            }

            return std;
        }

    }
}