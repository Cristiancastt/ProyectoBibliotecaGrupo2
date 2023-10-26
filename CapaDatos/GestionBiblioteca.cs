using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class GestionBiblioteca
    {
        // TODO: Hacer todas las consultas

        const string cadConexion = "Data Source=.; Initial Catalog=bibliotecaG2; Integrated Security=SSPI; MultipleActiveResultSets=true";
        const string consCategoriaNombre = "SELECT isbn, titulo, editorial, sinopsis, caratula, cantidad_unidades, prestable, biblioteca_id FROM libros WHERE categoria = @categoria AND titulo = @titulo";
        const string consCategoriaId = "SELECT isbn, titulo, editorial, sinopsis, caratula, cantidad_unidades, prestable, biblioteca_id FROM libros WHERE categoria = @categoria AND isbn = @isbn";
        const string consNombre = "SELECT isbn, titulo, editorial, sinopsis, caratula, cantidad_unidades, prestable, biblioteca_id FROM libros WHERE isbn = @isbn";

        public ReadOnlyCollection<Libro> Libros(out string error, string consulta, bool scalar)
        {
            using (SqlConnection con = new SqlConnection(cadConexion))
            {
                error = "";
                List<Libro> listaLibros = new List<Libro>();
                try
                {
                    con.Open();
                    SqlCommand recolectarLibros = new SqlCommand(consulta, con);

                    if (scalar)
                    {
                        var datos = recolectarLibros.ExecuteScalar();
                    }
                    else
                    {
                        var datos = recolectarLibros.ExecuteReader();
                        if (!datos.HasRows)
                        {
                            error = "No hay libros.";
                            return listaLibros.AsReadOnly();
                        }
                        while (datos.Read())
                        {
                            string isbn = datos["isbn"].ToString();
                            string titulo = datos["titulo"].ToString();
                            string editorial = datos["editorial"].ToString();
                            string sinopsis = datos["sinopsis"].ToString();
                            string caratula = datos["caratula"].ToString();
                            int cantidadUnidades = (int)datos["cantidad_unidades"];
                            bool prestable = (bool)datos["prestable"];
                            int bibliotecaId = (int)datos["biblioteca_id"];
                            listaLibros.Add(new Libro(isbn, titulo, editorial, sinopsis, caratula, cantidadUnidades, prestable, bibliotecaId));
                        }
                    }
                }
                catch (Exception e)
                {
                    error = e.Message;
                    return null;
                }
                return listaLibros.AsReadOnly();
            }
        }
    }
}
