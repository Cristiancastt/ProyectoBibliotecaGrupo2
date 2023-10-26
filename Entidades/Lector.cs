using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
        
     public  class Lector
     {
        private int carnet;
        private string nombre;
        private string contraseña;
        private string telefono;
        private string email;

        public Lector(int carnet, string nombre, string contraseña, string telefono, string email)
        {
            this.carnet = carnet;
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.telefono = telefono;
            this.email = email;
        }
    }

    

}
