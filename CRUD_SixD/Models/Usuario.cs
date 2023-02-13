using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_SixD.Models
{
    public class Usuario
    {
        public int usuId { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public Usuario() { }

        public Usuario(int id, string nombre, string apellido) {
            usuId = id;
            Nombre = nombre;
            Apellido = apellido;
        }
        public Usuario(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}