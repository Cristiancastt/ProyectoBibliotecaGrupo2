using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class GestionBiblioteca
    {
       
            
            const string cadConexion = "Data Source = .; Initial Catalog = bibliotecaG2; Integrated Security = SSPI; MultipleActiveResultSets=true";
        const string consCatONom = "Select isbn , titulo , editorial , sinopsis , caratula , [cantidad_unidades] , prestable , [biblioteca_id] where categoria...";
            public ReadOnlyCollection<Libro> Libros(out string error) {
            using (SqlConnection con = new SqlConnection(cadConexion))
            {
                error = "";
                List<Libro> listaLibros = new List<Libro>();
                try 
                { 
                con.Open();
                    string consulta = "Select isbn , titulo , editorial , sinopsis , caratula , [cantidad_unidades] , prestable , [biblioteca_id] ";
                    SqlCommand recolectarLibros = new SqlCommand(consulta , con);
                    SqlDataReader datos = recolectarLibros.ExecuteReader();
                    if(!datos.HasRows) 
                    {
                        error = "No hay libros.";
                        return listaLibros.AsReadOnly();
                    }
                    while(datos.Read()) 
                    {
                        string isbn = datos["isbn"].ToString();
                        string titulo = datos["titulo"].ToString();  
                        string editorial = datos["editorial"].ToString();
                        string sinopsis = datos["sinopsis"].ToString() ;
                        string caratula = datos["caratula"].ToString();
                        int cantidadUnidades = (int) datos["cantidad_unidades"];
                        bool prestable = (bool)datos["prestable"];
                        int bibliotecaId = (int)datos["biblioteca_id"];
                        listaLibros.Add(new Libro(isbn, titulo, editorial, sinopsis, caratula, cantidadUnidades, prestable, bibliotecaId));
                        if (!String.IsNullOrEmpty(error))
                        {
                            return listaLibros.AsReadOnly();
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
