using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
        
     public  class Lector
     {
        public int carnet;
        public string nombre;
        public string contraseña;
        public string telefono;
        public string email;

        public Lector()
        {

        }


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
