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
    public partial class AltaLector : Form
    {
        public AltaLector()
        {
            InitializeComponent();
        }

        private void BtnEliminarLibro_Click(object sender, EventArgs e)
        {
            String nombre = TxtNombre.Text;
            String contra = TxtContra.Text;
            String num = TxtTelefono.Text;
            String email = TxtEmail.Text;

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El campo nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación adicional para otros campos si es necesario
            if (string.IsNullOrEmpty(contra))
            {
                MessageBox.Show("El campo contraseña no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(num))
            {
                MessageBox.Show("El campo teléfono no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("El campo email no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GestionBiblioteca controlador = new GestionBiblioteca();
            string errores;
            if (controlador.AltaUsuario(nombre, contra, num, email, out errores))
            {
                MessageBox.Show("El registro se ha realizado con éxito.");
            }
            else
            {
                MessageBox.Show("Error: " + errores);
            }

        }
    }
}
