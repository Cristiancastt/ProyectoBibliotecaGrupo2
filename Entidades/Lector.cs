using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Lector
     {
        public int Carnet { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Lector()
        {
        }

        public Lector(string nombre, string contraseña, string telefono, string email)
        {
            Nombre = nombre;
            Contraseña = contraseña;
            Telefono = telefono;
            Email = email;
        }
    }

    

}
