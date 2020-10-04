using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelos
{
    public class Empleado
    {
        // atributos
        private int num;
        private string nombre;
        private string apellidos;
        private string email;
        private int telefono;

        //constructoress

        public Empleado()
        {
        }

        public Empleado(int num, string nombre, string apellidos, string email, int telefono)
        {
            this.num = num;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.email = email;
            this.telefono = telefono;
        }

        // get and set
        public int Num { get => num; set => num = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Email { get => email; set => email = value; }
        public int Telefono { get => telefono; set => telefono = value; }
    }
}