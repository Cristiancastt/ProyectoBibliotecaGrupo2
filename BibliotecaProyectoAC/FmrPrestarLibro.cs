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
    public partial class FmrPrestarLibro : Form
    {
        GestionBiblioteca controlador = new GestionBiblioteca();
        public FmrPrestarLibro()
        {
            InitializeComponent();
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            String carnet = txtCarnet.Text;
            if (string.IsNullOrEmpty(carnet))
            {
                MessageBox.Show("El campo Carnet no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string errores;
            DataUsuarios.DataSource = null;
            DataUsuarios.DataSource = controlador.BuscarLectorCarnet(carnet, out errores);
            if (string.IsNullOrEmpty(errores))
            {

            }
            else
            {
                MessageBox.Show("Error: " + errores);
            }


        }

        private void BtnEliminarLibro_Click(object sender, EventArgs e)
        {
            String isbn = TxtISBN.Text;
            if (string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("El campo ISBN no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string errores;
            DataLibro.DataSource = null;
            var libro = controlador.BuscarLibroPorISBN(isbn, out errores);
            DataLibro.DataSource = libro;
            if (string.IsNullOrEmpty(errores))
            {

            }
            else
            {
                MessageBox.Show("Error: " + errores);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Verifica si hay al menos una fila seleccionada
            string carnet = null;
            if (DataUsuarios.SelectedRows.Count > 0)
            {
                // Obtiene la primera fila seleccionada (asumimos que solo se selecciona una)
                DataGridViewRow selectedRow = DataUsuarios.SelectedRows[0];
                // Puedes acceder a las celdas de la fila por índice o por nombre de columna
                carnet = selectedRow.Cells["Carnet"].Value.ToString();
            }
            string isbn = null;
            if (DataLibro.SelectedRows.Count > 0)
            {
                // Obtiene la primera fila seleccionada (asumimos que solo se selecciona una)
                DataGridViewRow selectedRow = DataLibro.SelectedRows[0];
                // Puedes acceder a las celdas de la fila por índice o por nombre de columna
                isbn = selectedRow.Cells["isbn"].Value.ToString();
            }

            DateTime fechaPrestamo;
            if (string.IsNullOrEmpty(TxtPrestamo.Text))
            {
                fechaPrestamo = DateTime.Now;
            }
            else if (!DateTime.TryParse(TxtPrestamo.Text, out fechaPrestamo))
            {
                MessageBox.Show("El campo fecha prestamo parece estar en un formato incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime fechaDevolucion;
            if (string.IsNullOrEmpty(TxtDevolucion.Text))
            {
                fechaDevolucion = fechaPrestamo.AddDays(15);
            }
            else if (!DateTime.TryParse(TxtDevolucion.Text, out fechaDevolucion))
            {
                MessageBox.Show("El campo fecha devolucion parece estar en un formato incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string errores;
            if (controlador.Prestar(carnet, isbn, fechaPrestamo, fechaDevolucion, out errores))
            {
                MessageBox.Show("El préstamo se ha realizado con éxito.");
            }
            else
            {
                MessageBox.Show("Error: " + errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FmrAltaLector().Show();
        }

        private void FmrPrestarLibro_Load(object sender, EventArgs e)
        {

        }
    }
}
