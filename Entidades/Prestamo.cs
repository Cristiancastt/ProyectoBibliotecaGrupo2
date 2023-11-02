using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Prestamo
    {
        public int PrestamoId { get; set; }
        public int Carnet { get; set; }
        public string Isbn { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public Lector Lector { get; set; }
        public Libro Libro { get; set; }

        public Prestamo()
        {
        }

        public Prestamo(int carnet, string isbn, DateTime fechaPrestamo, DateTime fechaDevolucion)
        {
            Carnet = carnet;
            Isbn = isbn;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaDevolucion;
        }
    }
}
