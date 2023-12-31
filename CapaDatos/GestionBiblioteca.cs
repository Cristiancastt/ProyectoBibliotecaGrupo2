﻿using Entidades;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class GestionBiblioteca
    {


        const string cadConexion = "Data Source = .; Initial Catalog = bibliotecaG2; Integrated Security = SSPI; MultipleActiveResultSets=true";

   

        public List<Lector> Morosos(out string errores)
        {
            List<Lector> morosos = new List<Lector>();
            errores = null;

            using (SqlConnection con = new SqlConnection(cadConexion))
            {
                try
                {
                    con.Open();
                    string consulta = "SELECT * FROM lectores l INNER JOIN prestamos p ON l.carnet = p.carnet WHERE p.fecha_devolucion < GETDATE()";

                    SqlCommand comando = new SqlCommand(consulta, con);
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Lector lector = new Lector
                        {
                            Carnet = (int)reader["carnet"],
                            Email = (string)reader["email"],
                            Telefono = (string)reader["telefono"],
                            Nombre = (string)reader["nombre"],
                            Contraseña = (string)reader["contraseña"]
                        };

                        morosos.Add(lector);
                    }

                    return morosos;
                }
                catch (Exception e)
                {
                    errores = e.Message;
                    return morosos;
                }
            }
        }









        public bool AltaUsuario(
            String nombre,
            string contra,
            string telefono,
            string email,
            out string errores
        )
        {
            errores = null;
            using (SqlConnection con = new SqlConnection(cadConexion))
            {
                try
                {
                    con.Open();
                    string consulta =
                        "INSERT INTO lectores (nombre, contraseña, telefono, email) VALUES (@nombre, @contra, @telefono, @email)";

                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@contra", contra);
                    comando.Parameters.AddWithValue("@telefono", telefono);
                    comando.Parameters.AddWithValue("@email", email);

                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas == 1)
                    {
                        return true;
                    }
                    else
                    {
                        // La inserción no se realizó correctamente
                        errores = "El registro no se completó correctamente.";
                        return false;
                    }
                }
                catch (Exception e)
                {
                    errores = e.Message;
                    return false;
                }
            }
        }

        public bool Prestar(
            String carnet,
            String isbn,
            DateTime fechaPrestamo,
            DateTime fechaDevolucion,
            out string errores
        )
        {
            errores = null;
            using (SqlConnection con = new SqlConnection(cadConexion))
            {
                try
                {
                    con.Open();

                    string esPrestable = "SELECT prestable FROM libros WHERE isbn = @isbn";
                    SqlCommand comandoEsPrestable = new SqlCommand(esPrestable, con);
                    comandoEsPrestable.Parameters.AddWithValue("@isbn", isbn);
                    var resultado = comandoEsPrestable.ExecuteScalar();
                    if (resultado != null)
                    {
                        bool prestable = (bool)resultado;
                        if (prestable)
                        {
                            // El libro es prestable (esPrestable == true)
                            // Realiza las acciones necesarias para gestionar un libro prestable.
                        }
                        else
                        {
                            errores = "El libro no se puede prestar";
                            return false;
                        }
                    }
                    else
                    {
                        errores = "El ISBN no existe.";
                        return false;
                    }
                    string consulta =
                        "INSERT INTO prestamos (carnet, isbn, fecha_prestamo, fecha_devolucion) VALUES (@carnet, @isbn, @fechaprestamo, @fechadevolucion)";

                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.Parameters.AddWithValue("@isbn", isbn);
                    comando.Parameters.AddWithValue("@carnet", carnet);
                    comando.Parameters.AddWithValue("@fechaprestamo", fechaPrestamo);
                    comando.Parameters.AddWithValue("@fechadevolucion", fechaDevolucion);

                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas == 1)
                    {
                        string consulta2 =
                            "UPDATE libros SET cantidad_unidades = cantidad_unidades - 1 WHERE isbn = @isbn";
                        SqlCommand comando2 = new SqlCommand(consulta2, con);
                        comando2.Parameters.AddWithValue("@isbn", isbn);
                        int filasAfectadas2 = comando2.ExecuteNonQuery();
                        if (filasAfectadas2 == 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        // La inserción no se realizó correctamente
                        errores = "El préstamo no se completó correctamente.";
                        return false;
                    }
                }
                catch (Exception e)
                {
                    errores = e.Message;
                    return false;
                }
            }
        }

        public List<Libro> BuscarLibroPorISBN(string isbn, out string errores)
        {
            List<Libro> librosEncontrados = new List<Libro>();
            errores = null;

            using (SqlConnection con = new SqlConnection(cadConexion))
            {
                try
                {
                    con.Open();

                    string consulta = "SELECT * FROM libros WHERE ISBN = @ISBN";

                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.Parameters.AddWithValue("@ISBN", isbn);

                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Libro libro = new Libro();
                        {
                            libro.isbn = reader["isbn"].ToString();
                            libro.titulo = reader["titulo"].ToString();
                            libro.editorial = reader["editorial"].ToString();
                            libro.sinopsis = reader["sinopsis"].ToString();
                            libro.caratula = reader["caratula"].ToString();
                            libro.cantidadUnidades = int.Parse(
                                reader["cantidad_unidades"].ToString()
                            );
                            libro.prestable = Convert.ToBoolean(reader["prestable"]);
                        }
                        ;

                        librosEncontrados.Add(libro);
                    }

                    return librosEncontrados;
                }
                catch (Exception e)
                {
                    errores = e.Message;
                    return librosEncontrados;
                }
            }
        }

        public List<Lector> BuscarLectorCarnet(string carnet, out string errores)
        {
            List<Lector> lectores = new List<Lector>();
            errores = "";

            using (SqlConnection con = new SqlConnection(cadConexion))
            {
                try
                {
                    con.Open();
                    string consulta = "SELECT * FROM Lectores WHERE carnet = @carnet";
                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.Parameters.AddWithValue("@carnet", carnet);
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Lector lector = new Lector();
                        {
                            lector.Carnet = reader.GetInt32(reader.GetOrdinal("carnet"));
                            lector.Nombre = reader.GetString(reader.GetOrdinal("nombre"));
                            lector.Contraseña = reader.GetString(reader.GetOrdinal("contraseña"));
                            lector.Telefono = reader.GetString(reader.GetOrdinal("telefono"));
                            lector.Email = reader.GetString(reader.GetOrdinal("email"));
                        }
                        
                        lectores.Add(lector);
                        
                    }

                    return lectores;
                }
                catch (Exception e)
                {
                    errores = e.Message;
                }
            }

            return lectores;
        }






        public DataTable ObtenerCategoriasNombre(out string error)
        {
            DataTable categoriasTable = new DataTable();
            error = "";

            using (SqlConnection con = new SqlConnection(cadConexion))
            {
                try
                {
                    con.Open();
                    string consulta = "SELECT descripcion FROM categorias";
                    SqlCommand recolectarCategorias = new SqlCommand(consulta, con);
                    SqlDataReader datos = recolectarCategorias.ExecuteReader();

                    if (!datos.HasRows)
                    {
                        error = "No hay categorías.";
                        return categoriasTable;
                    }

                    categoriasTable.Load(datos); // Cargar los datos en el DataTable
                }
                catch (Exception e)
                {
                    error = e.Message;
                }

                return categoriasTable;
            }
        }

        public DataTable ObtenerAutoresNombre(out string error)
        {
            DataTable autoresTable = new DataTable();
            error = "";

            using (SqlConnection con = new SqlConnection(cadConexion))
            {
                try
                {
                    con.Open();
                    string consulta = "SELECT nombre FROM autores";
                    SqlCommand recolectarAutores = new SqlCommand(consulta, con);
                    SqlDataReader datos = recolectarAutores.ExecuteReader();

                    if (!datos.HasRows)
                    {
                        error = "No hay autores.";
                        return autoresTable;
                    }

                    autoresTable.Load(datos); // Cargar los datos en el DataTable
                }
                catch (Exception e)
                {
                    error = e.Message;
                }

                return autoresTable;
            }
        }

        public bool AgregarAutor(String nombreAutor , out String error)
        {
            error = "";
            if (String.IsNullOrEmpty(nombreAutor))
            {
                error = "No puedes introducir una categoría vacía";
                return false;
            }
            using (SqlConnection con = new SqlConnection(cadConexion))
            {
                try
                {
                    con.Open();
                    string consulta = "INSERT INTO autores (nombre) VALUES (@nombreAutor)";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    cmd.Parameters.AddWithValue("@nombreAutor", nombreAutor);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // El autor se agregó con éxito
                       
                        return true;
                    }
                    else
                    {
                        error = "No se pudo agregar el autor.";
                        return false;
                    }
                }
                catch (Exception e)
                {
                    error = e.Message;
                    return false;
                }
            }
        }

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
                        bool prestable = (bool)datos["prestable"];
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

        public bool AnadirLibro(string isbn, string titulo, string editorial, string sinopsis, string caratulaSeleccionada, int cantidad, byte prestable, DataGridViewSelectedRowCollection autores, DataGridViewSelectedRowCollection categorias, out string errores)
        {
            errores = string.Empty;

            // Validaciones
            if (string.IsNullOrEmpty(isbn)) { errores = "El ISBN no puede estar vacío"; return false; }
            if (string.IsNullOrEmpty(titulo)) { errores = "El título no puede estar vacío"; return false; }
            if (string.IsNullOrEmpty(editorial)) { errores = "La editorial no puede estar vacía"; return false; }
            if (string.IsNullOrEmpty(sinopsis)) { errores = "La sinopsis no puede estar vacía"; return false; }
            if (string.IsNullOrEmpty(caratulaSeleccionada)) { errores = "La carátula no puede estar vacía"; return false; }
            if (autores.Count == 0) { errores = "Debe seleccionar al menos un autor"; return false; }
            if (categorias.Count == 0) { errores = "Debe seleccionar al menos una categoría"; return false; }

            // Verificar si el libro ya existe
            Libro libroBbDd = LibroPorIsbn(isbn, out errores);
            if (libroBbDd != null) { errores = "El libro ya existe"; return false; }

            try
            {
                using (SqlConnection con = new SqlConnection(cadConexion))
                {
                    con.Open();

                    // Insertar libro
                    string consultaLibro = "INSERT INTO libros (isbn, titulo, editorial, sinopsis, caratula, cantidad_unidades, prestable) VALUES (@isbn, @titulo, @editorial, @sinopsis, @caratula, @cantidad, @prestable)";
                    SqlCommand insertarLibro = new SqlCommand(consultaLibro, con);
                    insertarLibro.Parameters.AddWithValue("@isbn", isbn);
                    insertarLibro.Parameters.AddWithValue("@titulo", titulo);
                    insertarLibro.Parameters.AddWithValue("@editorial", editorial);
                    insertarLibro.Parameters.AddWithValue("@sinopsis", sinopsis);
                    insertarLibro.Parameters.AddWithValue("@caratula", caratulaSeleccionada);
                    insertarLibro.Parameters.AddWithValue("@cantidad", cantidad);
                    insertarLibro.Parameters.AddWithValue("@prestable", prestable);
                    insertarLibro.ExecuteNonQuery();

                    // Insertar relación libro-autor
                    foreach (DataGridViewRow filaAutor in autores)
                    {
                        string nombreAutor = filaAutor.Cells["nombre"].Value.ToString(); 
                        string consultaAutorId = "SELECT autor_id FROM autores WHERE nombre = @nombreAutor";
                        SqlCommand comandoAutorId = new SqlCommand(consultaAutorId, con);
                        comandoAutorId.Parameters.AddWithValue("@nombreAutor", nombreAutor);
                        int autorId = (int)comandoAutorId.ExecuteScalar();

                        string consultaLibroAutor = "INSERT INTO libros_autores (isbn, autor_id) VALUES (@isbn, @autorId)";
                        SqlCommand insertarLibroAutor = new SqlCommand(consultaLibroAutor, con);
                        insertarLibroAutor.Parameters.AddWithValue("@isbn", isbn);
                        insertarLibroAutor.Parameters.AddWithValue("@autorId", autorId);
                        insertarLibroAutor.ExecuteNonQuery();
                    }

                    // Insertar relación libro-categoría
                    foreach (DataGridViewRow filaCategoria in categorias)
                    {
                        string descripcionCategoria = filaCategoria.Cells["descripcion"].Value.ToString(); 
                        string consultaCategoriaId = "SELECT categoria_id FROM categorias WHERE descripcion = @descripcionCategoria";
                        SqlCommand comandoCategoriaId = new SqlCommand(consultaCategoriaId, con);
                        comandoCategoriaId.Parameters.AddWithValue("@descripcionCategoria", descripcionCategoria);
                        int categoriaId = (int)comandoCategoriaId.ExecuteScalar();

                        string consultaLibroCategoria = "INSERT INTO libros_categorias (isbn, categoria_id) VALUES (@isbn, @categoriaId)";
                        SqlCommand insertarLibroCategoria = new SqlCommand(consultaLibroCategoria, con);
                        insertarLibroCategoria.Parameters.AddWithValue("@isbn", isbn);
                        insertarLibroCategoria.Parameters.AddWithValue("@categoriaId", categoriaId);
                        insertarLibroCategoria.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                errores = "Error al añadir el libro: " + ex.Message;
                return false;
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
                    string sql = "Select isbn from prestamos where carnet = @idLector;";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@idLector", id);
                    SqlDataReader datos = cmd.ExecuteReader();
                    while (datos.Read())
                    {
                        Libro libro = new Libro();
                        libro.isbn = datos["isbn"].ToString();
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

        public bool Devoluciones(Libro libro, out string error)
        {
            error = null;
            using (SqlConnection con = new SqlConnection (cadConexion))
            {
                try
                {
                    con.Open();
                    string sql = "delete from prestamos where isbn = @isbnPrestado";
                    SqlCommand cmd  = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@isbnPrestado", libro.isbn);
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        // Se eliminaron filas correctamente
                        return true;
                    }
                    else
                    {
                        error = "No se encontraron registros para devolver el libro.";
                        return false;
                    }
                }
                catch (Exception e)
                {
                    error = "No se ha podido devolver el libre";
                    return false;
                }
            }
            return true;
        }










        public bool BorrarLibro(string isbn, out String error)
        {

            if (String.IsNullOrEmpty(isbn))
            {
                error = "El isbn no puede estar vacío";
                return false;
            }

            Libro buscar = LibroPorIsbn(isbn, out error);
            if (buscar == null)
            {
                error = "El libro no exise";
                return false;
            }


            using (SqlConnection con = new SqlConnection(cadConexion))
            {
                con.Open();
                SqlTransaction transaction = null;

                try
                {
                    transaction = con.BeginTransaction();

                    string eliminarLibro = "DELETE FROM libros_autores WHERE isbn = @isbn;\r\nDELETE FROM libros_categorias WHERE isbn = @isbn;\r\nDELETE FROM libros WHERE isbn = @isbn;";
                    using (SqlCommand eliminarComando = new SqlCommand(eliminarLibro, con, transaction))
                    {
                        eliminarComando.Parameters.AddWithValue("@isbn", isbn);
                        eliminarComando.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;

                }
                catch
                {
                    transaction?.Rollback();
                    string esPrestable = "SELECT prestable FROM libros WHERE isbn = @isbn";
                    SqlCommand comandoEsPrestable = new SqlCommand(esPrestable, con);
                    comandoEsPrestable.Parameters.AddWithValue("@isbn", isbn);
                    var resultado = comandoEsPrestable.ExecuteScalar();
                    if (resultado != null)
                    {
                        bool prestable = (bool)resultado;
                        if (prestable)
                        {
                            error = "El libro esta prestado. Primero hay que devolverlo para poder eliminarlo";
                        }
                        else
                        {
                            error = "Error. No se ha podido borra el libro.";

                        }

                    }
                    return false;
                }
            }
        }


      

        public DataTable ObtenerAutorNombrePorTrozo(string trozoNombre ,out String error)
        {
            error = "";
            DataTable autoresTable = new DataTable();

            using (SqlConnection con = new SqlConnection(cadConexion))
            {
                try
                {
                    con.Open();
                    string consulta = "SELECT nombre FROM autores WHERE nombre LIKE @trozoNombre";
                    SqlCommand recolectarAutores = new SqlCommand(consulta, con);
                    recolectarAutores.Parameters.AddWithValue("@trozoNombre", "%" + trozoNombre + "%");
                    SqlDataReader datos = recolectarAutores.ExecuteReader();

                    if (!datos.HasRows)
                    {
                        error = "No hay autores.";
                        return autoresTable;

                    }

                    autoresTable.Load(datos); // Cargar los datos en el DataTable

                }
                catch (Exception e)
                {
                    error = e.Message;
                    return autoresTable;
                }

                return autoresTable;
            }

        }






        public bool AgregarCategoria(string nombreCategoria, out string error)
        {
            error = "";
            if (String.IsNullOrEmpty(nombreCategoria)){
                error = "No puedes introducir una categoría vacía";
                return false;
            }
            using (SqlConnection con = new SqlConnection(cadConexion))
            {
                try
                {
                    con.Open();
                    string consulta = "INSERT INTO categorias (descripcion) VALUES (@nombreCategoria)";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    cmd.Parameters.AddWithValue("@nombreCategoria", nombreCategoria);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // La categoría se agregó con éxito
                        return true;
                    }
                    else
                    {
                        error = "No se pudo agregar la categoría.";
                        return false;
                    }
                }
                catch (Exception e)
                {
                    error = e.Message;
                    return false;
                }
            }
        }



    }
}
