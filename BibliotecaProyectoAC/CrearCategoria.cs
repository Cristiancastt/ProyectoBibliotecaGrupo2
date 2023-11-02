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
            if (!controller.AgregarCategoria(txtNombreCategoria.Text, out errores)) {
                MessageBox.Show("Error", errores);
                txtNombreCategoria.Clear();
                
            }
            
        }

        private void CrearCategoria_Load(object sender, EventArgs e)
        {

        }

    }
}
