using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        private string isbn { get; set; }
        private string titulo { get; set; }
        private string editorial { get; set; }
        private string sinopsis { get; set; }
        private string caratula { get; set; }
        private int cantidadUnidades { get; set; }
        private byte prestable { get; set; }


        public Libro(string isbn, string titulo, string editorial, string sinopsis, string caratula, int cantidadUnidades, byte prestable)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.editorial = editorial;
            this.sinopsis = sinopsis;
            this.caratula = caratula;
            this.cantidadUnidades = cantidadUnidades;
            this.prestable = prestable;
        }

        public Libro()
        {
        }

        public Libro(string isbn)
        {
            this.isbn = isbn;
        }

        public override bool Equals(object obj)
        {
            return obj is Libro libro &&
                   isbn.Equals(libro.isbn , StringComparison.OrdinalIgnoreCase );
        }

        public override int GetHashCode()
        {
            return 1553653001 + EqualityComparer<string>.Default.GetHashCode(isbn);
        }
    }
}
