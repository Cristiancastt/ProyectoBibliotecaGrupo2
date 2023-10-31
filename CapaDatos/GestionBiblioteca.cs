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

        public List<Libro> ListPrestados(string id, out string error) // Devuelve una lista de libros que son prestados por el lector
        {
            List<Libro> listaLibros = new List<Libro>();
            error = null;
            if (String.IsNullOrWhiteSpace(id))
            {
                error = "Debes completar el campo id";
                return listaLibros;
            }

            using (SqlConnection con = new SqlConnection(cadConexion))
            {
                try
                {
                    con.Open();
                    string sql = "Select isbn from prestamos where carnet = @idLector and fecha_devolucion = null";
                    SqlCommand cmd = new SqlCommand(sql);
                    cmd.Parameters.AddWithValue("@idLector", id);
                    SqlDataReader datos = cmd.ExecuteReader();
                    while (datos.Read())
                    {
                        Libro libro = new Libro();
                        libro.isbn = datos.["isbn"].ToString();
                        listaLibros.Add(libro);
                    }
                }
                catch (Exception e)
                {
                    error = e.Message; return null;
                }
            }
            return listaLibros;
        }

        public Boolean Devoluciones(Libro libro, out string error)
        {
            error = null;
            using (SqlConnection con = new SqlConnection (cadConexion))
            {
                try
                {
                    con.Open();
                    string sql = "update prestamos set fecha_prestamo = @fechaActual";
                    SqlCommand cmd  = new SqlCommand(sql);
                    cmd.Parameters.AddWithValue("@fechaActual", DateTime.Now);
                }
                catch (Exception e)
                {
                    error = "No se ha podido devolver el libre";
                    return false;
                }
            }
            return true;
        }

    }
}
