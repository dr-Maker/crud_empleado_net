using Data;
//using System;
using System.Collections.Generic;
using System.Data;
//using System.Linq;
//using System.Web;
using System.Data.SqlClient;
using Modelos;

namespace Buss
{
    public class BussEmpleado
    {
        static BaseDatos db = new BaseDatos();

        public static DataTable listar01()
        {
            //string sql = " select * from empleado ";
            SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = CommandType.Text;  //Si es query escrita
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = sql;
            cmd.CommandText = "sp_listar_empleado";
            // DataTable dt = db.ejecutarConsulta(cmd);
            //return dt;
            return db.ejecutarConsulta(cmd);
        }


        public static List<Empleado> Listar()
        {

            List<Empleado> lista = new List<Empleado>();
            string sql = " select * from empleado ";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            DataTable dt = db.ejecutarConsulta(cmd);

            Empleado emp;

            foreach (DataRow row in dt.Rows)
            {
            int num = int.Parse(row["num"].ToString());
            string nombres = row["nombres"].ToString();
            string apellidos = row["apellidos"].ToString();
            string email = row["email"].ToString();
            int telefono = int.Parse(row["telefono"].ToString());

            emp = new Empleado(num, nombres, apellidos, email, telefono);
            }

            emp = null;

            return lista;
        }

        public static Empleado buscar(int num)
        {
           
           // string sql = " select * from empleado where num =" +num;
            SqlCommand cmd = new SqlCommand();
           // cmd.CommandType = CommandType.Text;
            cmd.CommandType = CommandType.StoredProcedure;
            // cmd.CommandText = sql;
            cmd.CommandText = "sp_buscar_empleado";
            cmd.Parameters.Add("@num", SqlDbType.Int).Value = num;


            DataTable dt = db.ejecutarConsulta(cmd);
            Empleado emp;
            if (dt != null && dt.Rows.Count> 0)
            {
                string nombres = dt.Rows[0]["nombres"].ToString();
                string apellidos = dt.Rows[0]["apellidos"].ToString();
                string email = dt.Rows[0]["email"].ToString();
                int telefono = int.Parse(dt.Rows[0]["telefono"].ToString());

                emp = new Empleado(num, nombres, apellidos, email, telefono);
            }
            else
            {
                emp = null;
            }
            return emp;
        }

        public static bool Insert(Empleado emp)
        {
            //string sql = "insert into empleado";
            //sql += "(nombres, apellidos, email, telefono)";
            //sql += "values('"+ emp.Nombre+"','"+emp.Apellidos+"','"+emp.Email+"','"+emp.Telefono+"')";
            SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = CommandType.Text;
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = sql;
            cmd.CommandText = "sp_insert_empleado";
            cmd.Parameters.Add("@nombres", SqlDbType.VarChar, 50).Value = emp.Nombre;
            cmd.Parameters.Add("@apellidos", SqlDbType.VarChar, 50).Value = emp.Apellidos;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = emp.Email;
            cmd.Parameters.Add("@telefono", SqlDbType.Int).Value = emp.Telefono;
            return db.ejecutarAccion(cmd);
        }

        public static bool Update(Empleado emp)
        {
            /*string sql = "updare empleado set ";
            sql += "nombres = '"+ emp.Nombre + "',";
            sql += "apellidos = '" + emp.Apellidos + "',";
            sql += "email = '" + emp.Email  + "',";
            sql += "telefono = '" + emp.Telefono + "'";
            sql += "where num = '" + emp.Num + "'";*/
            SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = CommandType.Text;
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = sql;

            cmd.CommandText = "sp_update_empleado";
            cmd.Parameters.Add("@num", SqlDbType.Int).Value = emp.Num;
            cmd.Parameters.Add("@nombres", SqlDbType.VarChar, 50).Value = emp.Nombre;
            cmd.Parameters.Add("@apellidos", SqlDbType.VarChar, 50).Value = emp.Apellidos;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = emp.Email;
            cmd.Parameters.Add("@telefono", SqlDbType.Int).Value = emp.Telefono;

            return db.ejecutarAccion(cmd);
        }

        public static bool Delete(int num)
        {
            //string sql = "delete from empleado where num = " + num;
            SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = CommandType.Text;
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = sql;
            cmd.CommandText = "sp_delete_empleado";
            cmd.Parameters.Add("@num", SqlDbType.Int).Value = num;
            return db.ejecutarAccion(cmd);
        }
    }
}