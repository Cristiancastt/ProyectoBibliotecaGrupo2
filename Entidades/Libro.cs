using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        public string isbn { get; set; }
        public string titulo { get; set; }
        public string editorial { get; set; }
        public string sinopsis { get; set; }
        public string caratula { get; set; }
        public int cantidadUnidades { get; set; }
        public bool prestable { get; set; }


        public Libro(string isbn, string titulo, string editorial, string sinopsis, string caratula, int cantidadUnidades, bool prestable)
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
