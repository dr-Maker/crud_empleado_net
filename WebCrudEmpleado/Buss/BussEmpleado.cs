using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Modelos;

namespace Buss
{
    public class BussEmpleado
    {
        static BaseDatos db = new BaseDatos();

        public static DataTable listar01()
        {
            string sql = " select * from empleado ";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            DataTable dt = db.ejecutarConsulta(cmd);
            return dt;
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
           
            string sql = " select * from empleado where num =" +num;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            DataTable dt = db.ejecutarConsulta(cmd);
            Empleado emp;
            if (dt != null)
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

        public static void Insert(Empleado emp)
        {
            string sql = "insert into empleado";
            sql += "(nombres, apellidos, email, telefono)";
            sql += "values('"+ emp.Nombre+"','"+emp.Apellidos+"','"+emp.Email+"','"+emp.Telefono+"')";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            db.ejecutarConsulta(cmd);
        }

        public static void Update(Empleado emp)
        {
            string sql = "updare empleado set ";
            sql += "nombres = '"+ emp.Nombre + "',";
            sql += "apellidos = '" + emp.Apellidos + "',";
            sql += "email = '" + emp.Email  + "',";
            sql += "telefono = '" + emp.Telefono + "'";
            sql += "where num = '" + emp.Num + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            db.ejecutarConsulta(cmd);
        }

        public static void Delete(int num)
        {
            string sql = "delete from empleado where num = " + num;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            db.ejecutarConsulta(cmd);
        }
    }
}