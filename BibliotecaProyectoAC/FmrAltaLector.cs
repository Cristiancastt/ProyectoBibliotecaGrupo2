﻿using CapaDatos;
using System;
using System.Windows.Forms;

namespace BibliotecaProyectoAC
{
    public partial class FmrAltaLector : Form
    {
        public FmrAltaLector()
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
           
            string errores;
            if (Program.controller.AltaUsuario(nombre, contra, num, email, out errores))
            {
                MessageBox.Show("El registro se ha realizado con éxito.");
            }
            else
            {
                MessageBox.Show("Error: " + errores);
            }

        }

        private void FmrAltaLector_Load(object sender, EventArgs e)
        {

        }
    }
}
