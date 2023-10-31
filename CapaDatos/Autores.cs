using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    // Creo que no es necesaria porque no podemos acceder a su clave ya que es un id que autoincrementa. La solucion es que la Clase Libros tenga una propiedad Autores que recibe el nombre del autor
    public class Autores
    {
       public String Nombre { get; set; }
        private int Id { get; set; }

        public Autores(string nombre)
        {
            Nombre = nombre;
        }

        public Autores()
        {

        }

        

    }
}
