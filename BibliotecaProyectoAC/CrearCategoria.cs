using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BibliotecaProyectoAC
{
    public partial class CrearCategoria : Form
    {
        GestionBiblioteca controller = new GestionBiblioteca();
        public CrearCategoria()
        {
            InitializeComponent();
        }

        private void BtnEliminarLibro_Click(object sender, EventArgs e)
        {
            String errores;
            if (!controller.AgregarCategoria(TxtNombreCategoria.Text, out errores)) {
                MessageBox.Show("Error", errores);
                TxtNombreCategoria.Clear();
                return;
            }
            
            if (controller.AgregarCategoria(TxtNombreCategoria.Text,out errores))
            {
                MessageBox.Show("El registro se ha realizado con éxito.");
            }
            else
            {
                MessageBox.Show("Error: " + errores);
            }


        }

        private void CrearCategoria_Load(object sender, EventArgs e)
        {

        }

        private void TxtNombreCategoria_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
