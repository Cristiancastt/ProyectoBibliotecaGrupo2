using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class GestionBiblioteca
    {

        //todo Hacer todas las consultas
        const string cadConexion = "Data Source = .; Initial Catalog = bibliotecaG2; Integrated Security = SSPI; MultipleActiveResultSets=true";



        //public ReadOnlyCollection<Libro> LibrosDeCategoriaPorid (out string error, String consulta)
        //{
        //    using (SqlConnection con = new SqlConnection(cadConexion))
        //    {
        //        error = "";
        //        List<Libro> listaLibros = new List<Libro>();
        //        try
        //        {
        //            con.Open();
        //            const string consNombre = "Select * from categorias where isbn = @isbn";
        //            SqlCommand recolectarLibros = new SqlCommand(consulta, con);
        //            SqlDataReader datos = recolectarLibros.ExecuteReader();
        //            if (!datos.HasRows)
        //            {
        //                error = "No hay libros.";
        //                return listaLibros.AsReadOnly();
        //            }
        //            while (datos.Read())
        //            {
        //                string isbn = datos["isbn"].ToString();
        //                string titulo = datos["titulo"].ToString();
        //                string editorial = datos["editorial"].ToString();
        //                string sinopsis = datos["sinopsis"].ToString();
        //                string caratula = datos["caratula"].ToString();
        //                int cantidadUnidades = (int)datos["cantidad_unidades"];
        //                bool prestable = (bool)datos["prestable"];
        //                int bibliotecaId = (int)datos["biblioteca_id"];
        //                listaLibros.Add(new Libro(isbn, titulo, editorial, sinopsis, caratula, cantidadUnidades, prestable));
        //                if (!String.IsNullOrEmpty(error))
        //                {
        //                    return listaLibros.AsReadOnly();
        //                }
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            error = e.Message;
        //            return null;
        //        }
        //        return listaLibros.AsReadOnly();
        //    }

        //}


        public Libro LibroPorIsbn(String isbnConsulta, out String error)
        {
            using (SqlConnection con = new SqlConnection(cadConexion))
            {
                error = "";
                Libro lib;
                try
                {
                    con.Open();
                    string consulta = "Select * from Libros where isbn = @isbn";
                    SqlCommand recolectarUsuario = new SqlCommand(consulta, con);
                    recolectarUsuario.Parameters.AddWithValue("@isbn", isbnConsulta);
                    SqlDataReader datos = recolectarUsuario.ExecuteReader();
                    if (datos.Read())
                    {
                        string isbn = datos["isbn"].ToString();
                        string titulo = datos["titulo"].ToString();
                        string editorial = datos["editorial"].ToString();
                        string sinopsis = datos["sinopsis"].ToString();
                        string caratula = datos["caratula"].ToString();
                        int cantidadUnidades = (int)datos["cantidad_unidades"];
                        byte prestable = (byte)datos["prestable"];
                        lib = new Libro(isbn , titulo,editorial,sinopsis,caratula,cantidadUnidades,prestable );
                        if (!String.IsNullOrEmpty(error))
                        {

                            return null;
                        }
                        return lib;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception e)
                {
                    error = e.Message;
                    return null;
                }
            }

        }

        public bool anadirLibro(String isbn, String titulo, String editorial, String sinopsis,String caratulaSeleccionada, int cantidad, byte prestable, String autor , String categoria , out String errores)
        {
            if (String.IsNullOrEmpty(isbn))
            {
                errores = "El nombre no puede estar vacío";
                return false;
            }
              if (String.IsNullOrEmpty(titulo))
            {
                errores = "El titulo no puede estar vacío";
                return false;
            }
            if (String.IsNullOrEmpty(editorial))
            {
                errores = "El editorial no puede estar vacío";
                return false;
            }
            if (String.IsNullOrEmpty(sinopsis))
            {
                errores = "El sinopsis no puede estar vacío";
                return false;
            }
            if (String.IsNullOrEmpty(caratulaSeleccionada))
            {
                errores = "La caratula no puede estar vacío";
                return false;
            }
            if (String.IsNullOrEmpty(cantidad.ToString()))
            {
                errores = "El nombre no puede estar vacío";
                return false;
            }
            if (String.IsNullOrEmpty(prestable.ToString()))
            {
                errores = "El prestable no puede estar vacío";
                return false;
            }
            if (!String.IsNullOrEmpty(autor.ToString()))
            {
                errores = "El autor no puede estar vacío";
                return false;
            }
            if (!String.IsNullOrEmpty(categoria.ToString()))
            {
                errores = "La categoria no puede estar vacía";
                return false;
            }
            Libro aux = new Libro(isbn);
            Libro libroBbDd = LibroPorIsbn(isbn, out errores);
            if (libroBbDd != null && libroBbDd.Equals(aux)) {
                errores = "El libro ya existe";
                return false;
            }


            using (SqlConnection con = new SqlConnection(cadConexion))
            {
                con.Open();

                string consultaAutor = "IF NOT EXISTS (SELECT 1 FROM autores WHERE nombre = @autor) INSERT INTO autores (nombre) VALUES (@autor)";
                SqlCommand insertarAutor = new SqlCommand(consultaAutor, con);
                insertarAutor.Parameters.AddWithValue("@autor", autor);
                insertarAutor.ExecuteNonQuery();
            }

            // Insertar la categoría si no existe
            using (SqlConnection con = new SqlConnection(cadConexion))
            {
                con.Open();

                string consultaCategoria = "IF NOT EXISTS (SELECT 1 FROM categorias WHERE descripcion = @categoria) INSERT INTO categorias (descripcion) VALUES (@categoria)";
                SqlCommand insertarCategoria = new SqlCommand(consultaCategoria, con);
                insertarCategoria.Parameters.AddWithValue("@categoria", categoria);
                insertarCategoria.ExecuteNonQuery();
            }

            // Insertar el libro
            using (SqlConnection con = new SqlConnection(cadConexion))
            {
                con.Open();

                string consulta = "INSERT INTO Libros (isbn, titulo, editorial, sinopsis, caratula, cantidad_unidades, prestable) VALUES (@isbn, @titulo, @editorial, @sinopsis, @caratula, @cantidad, @prestable)";
                SqlCommand insertarLibro = new SqlCommand(consulta, con);
                insertarLibro.Parameters.AddWithValue("@isbn", isbn);
                insertarLibro.Parameters.AddWithValue("@titulo", titulo);
                insertarLibro.Parameters.AddWithValue("@editorial", editorial);
                insertarLibro.Parameters.AddWithValue("@sinopsis", sinopsis);
                insertarLibro.Parameters.AddWithValue("@caratula", caratulaSeleccionada);
                insertarLibro.Parameters.AddWithValue("@cantidad", cantidad);
                insertarLibro.Parameters.AddWithValue("@prestable", prestable);

                int filasAfectadas = insertarLibro.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
        }
    }
}
