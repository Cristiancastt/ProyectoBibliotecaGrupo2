using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        private int isbn { get; set; }
        private string titulo { get; set; }
        private string editorial { get; set; }
        private string sinopsis { get; set; }
        private string caratula { get; set; }
        private int cantidadUnidades { get; set; }
        private bool prestable { get; set; }
        private int bibliotecaId { get; set; }


        public Libro(int isbn, string titulo, string editorial, string sinopsis, string caratula, int cantidadUnidades, bool prestable, int bibliotecaId)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.editorial = editorial;
            this.sinopsis = sinopsis;
            this.caratula = caratula;
            this.cantidadUnidades = cantidadUnidades;
            this.prestable = prestable;
            this.bibliotecaId = bibliotecaId;
        }
    }
}
