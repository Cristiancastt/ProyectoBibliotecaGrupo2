using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaProyectoAC
{
    public class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        public static GestionBiblioteca controller;
        
        [STAThread]
        static void Main()
        { 
            controller = new GestionBiblioteca();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FmrMenu());
           

        }
    }
}
