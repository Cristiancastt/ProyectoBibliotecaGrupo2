using CapaDatos;
using Entidades;
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
    public partial class FmrDevolverLibro : Form
    {
        GestionBiblioteca controlador = new GestionBiblioteca();
        public FmrDevolverLibro()
        {
            InitializeComponent();
        }

        private void BtnEliminarLibro_Click(object sender, EventArgs e)
        {
            string errores = "";
            if (DataLibros.SelectedRows.Count > 0)
            {
                // Obtiene la primera fila seleccionada (asumimos que solo se selecciona una)
                DataGridViewRow selectedRow = DataLibros.SelectedRows[0];
                // Puedes acceder a las celdas de la fila por índice o por nombre de columna
                Libro libDevolver = new Libro(selectedRow.Cells["isbn"].Value.ToString());
                bool devuelto = controlador.Devoluciones(libDevolver, out errores);
                if (devuelto)
                {
                    MessageBox.Show("El libro se ha devuelto con exito");
                }
                else
                {
                    MessageBox.Show("Error: " + errores);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string error = "";
            DataLibros.DataSource = controlador.ListPrestados(textBox1.Text, out error);
            if (string.IsNullOrEmpty(error))
            {

            }
            else
            {
                MessageBox.Show("Error: " + error);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DevolverLibro_Load(object sender, EventArgs e)
        {
            
        }

    }
}
