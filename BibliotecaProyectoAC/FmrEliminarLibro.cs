using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaProyectoAC
{
    public partial class FmrEliminarLibro : Form
    {
        public FmrEliminarLibro()
        {
            InitializeComponent();
        }

        private void BtnEliminarLibro_Click(object sender, EventArgs e)
        {
            string isbn = textBox1.Text;

            if (!string.IsNullOrEmpty(isbn))
            {
                // Puedes realizar la eliminación del libro aquí
                string errores = "";
                GestionBiblioteca gestionBiblioteca = new GestionBiblioteca();
                bool eliminado = gestionBiblioteca.BorrarLibro(isbn, out errores);

                if (eliminado)
                {
                    MessageBox.Show("Libro eliminado con éxito.");
                }
                else
                {
                    MessageBox.Show("Error al eliminar el libro: " + errores);
                }

                // Limpia el TextBox después de eliminar el libro
                textBox1.Clear();
            }

        }

        private void EliminarLibro_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
