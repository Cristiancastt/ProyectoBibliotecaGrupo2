using Entidades;
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

namespace CapaDatos
{
    public class GestionBiblioteca
    {

        //todo Hacer todas las consultas
        const string cadConexion = "Data Source = .; Initial Catalog = bibliotecaG2; Integrated Security = SSPI; MultipleActiveResultSets=true";


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

        public bool prestar(
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

        public List<Libro> buscarLibroPorISBN(string isbn, out string errores)
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

        public List<Lector> buscarLectorCarnet(string carnet, out string errores)
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
                            lector.carnet = reader.GetInt32(reader.GetOrdinal("carnet"));
                            lector.nombre = reader.GetString(reader.GetOrdinal("nombre"));
                            lector.contraseña = reader.GetString(reader.GetOrdinal("contraseña"));
                            lector.telefono = reader.GetString(reader.GetOrdinal("telefono"));
                            lector.email = reader.GetString(reader.GetOrdinal("email"));
                        }
                        ;
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

        public void borrarLibro(string isbn, out String error)
        {

            if (String.IsNullOrEmpty(isbn))
            {
                error = "El isbn no puede estar vacío";
            }

            Libro buscar = LibroPorIsbn(isbn, out error);
            if (buscar == null)
            {
                error = "El libro no exise";
            }


            using (SqlConnection con = new SqlConnection(cadConexion))
            {
                try
                {
                    con.Open();

                    string eliminarLibro = "DELETE FROM libros WHERE isbn = @isbn";
                    using (SqlCommand eliminarComando = new SqlCommand(eliminarLibro))
                    {
                        eliminarComando.Parameters.AddWithValue("@isbn", isbn);
                        eliminarComando.ExecuteNonQuery();

                    }

                }
                catch
                {
                    error = "Error. No se ha podido borra el libro.";
                }
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
