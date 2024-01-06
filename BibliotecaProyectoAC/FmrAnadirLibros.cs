using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaProyectoAC
{
    public partial class FmrAnadirLibros : Form
    {

        GestionBiblioteca controller = new GestionBiblioteca();


        public FmrAnadirLibros()
        {
            InitializeComponent();

        }
        private void AnadirLibros_Load(object sender, EventArgs e)
        {

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private string caratulaSeleccionada = "";
        private void BtnAñadirLibro_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text;
            string titulo = txtTitulo.Text;
            string sinopsis = txtSinopsis.Text;
            string unidades = txtUnidades.Text;
            string editorial = txtEditorial.Text;
            // Validaciones para comprobar que las cadenas no están vacías

            if (string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("El campo ISBN no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(titulo))
            {
                MessageBox.Show("El campo Título no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(sinopsis))
            {
                MessageBox.Show("El campo Sinopsis no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(unidades))
            {
                MessageBox.Show("El campo Unidades no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(editorial))
            {
                MessageBox.Show("El campo Editorial no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte prestable;
            if (PrestableSi.Checked)
            {
                prestable = 1;
            }
            else
            {
                prestable = 0;
            }
            int cantidad;
            if (int.TryParse(txtUnidades.Text, out cantidad))
            {
                
            }
            else
            {
                MessageBox.Show("Solo se permiten números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string carpetaCaratulas = Path.Combine(Application.StartupPath, "caratulas");

            // Si se ha seleccionado una carátula
            if (!string.IsNullOrEmpty(caratulaSeleccionada))
            {
                
            }
            else
            {
                MessageBox.Show("Debes seleccionar una carátula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvAutores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un autor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewSelectedRowCollection autoresSeleccionados = dgvAutores.SelectedRows;
            DataGridViewSelectedRowCollection categoriasSeleccionadas = dgvCategorias.SelectedRows;



            string errores;
            if (controller.AnadirLibro(isbn, titulo, editorial, sinopsis, caratulaSeleccionada, cantidad, prestable, autoresSeleccionados, categoriasSeleccionadas, out errores))
            {
                MessageBox.Show("El libro se ha añadido con éxito.");
            }
            else
            {
                MessageBox.Show("Error: " + errores);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imágenes|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaCaratula = openFileDialog.FileName;

                // Obtener la ruta de la carpeta "caratulas" en el proyecto
                string carpetaCaratulas = Path.Combine(Application.StartupPath, "caratulas");

                // Crear la carpeta si no existe
                if (!Directory.Exists(carpetaCaratulas))
                {
                    Directory.CreateDirectory(carpetaCaratulas);
                }

                // Obtener el nombre de archivo deseado (puedes personalizarlo)
                string nombreArchivo = "caratula_" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(rutaCaratula);

                // Combinar la ruta de la carpeta con el nombre de archivo
                string rutaGuardado = Path.Combine(carpetaCaratulas, nombreArchivo);

                // Copiar la imagen seleccionada a la carpeta "caratulas"
                File.Copy(rutaCaratula, rutaGuardado);

                // Mostrar la carátula en el PictureBox
                pictureBox1.Image = Image.FromFile(rutaGuardado);

                // Almacena la ruta de la carátula seleccionada en la variable "caratulaSeleccionada"
                caratulaSeleccionada = rutaGuardado;
            }
        }

        private void PrestableSi_CheckedChanged(object sender, EventArgs e)
        {
            if (PrestableSi.Checked)
            {
                PrestableNo.Checked = false;
            }
        }

        private void PrestableNo_CheckedChanged(object sender, EventArgs e)
        {
            if (PrestableNo.Checked)
            {
                PrestableSi.Checked = false;
            }
        }

        private void AnadirLibros_Load_1(object sender, EventArgs e)
        {
            dgvAutores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAutores.MultiSelect = true;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.MultiSelect = true;

            dgvCategorias.DataSource = null;
            this.ActualizarCategorias_Click(sender, e);

      
           this.ActualizarAutores_Click(sender, e);

        }

        private void ActualizarAutores_Click(object sender, EventArgs e)
        {
            string errores;
            DataTable autoresTable = controller.ObtenerAutoresNombre(out errores);
            dgvAutores.DataSource = autoresTable;
        }

        private void ActualizarCategorias_Click(object sender, EventArgs e)
        {
            string errores;
            DataTable categoriasTable = controller.ObtenerCategoriasNombre(out errores);
            dgvCategorias.DataSource = categoriasTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            String errores;
            if (controller.AgregarCategoria(txtCategoria.Text, out errores))
            {
                // Si la categoría se agrega con éxito
                MessageBox.Show("El registro se ha realizado con éxito.");
                txtCategoria.Clear();
                this.ActualizarCategorias_Click(sender, e); 
            }
            else
            {
                // Si hay un error al agregar la categoría
                MessageBox.Show("Error: " + errores);
                txtCategoria.Clear();
            }

        }

        private void BtnAnadirAutor_Click(object sender, EventArgs e)
        {
            String errores;
            if (controller.AgregarAutor(txtAutores.Text, out errores))
            {
                // Si el autor se agrega con éxito
                txtAutores.Clear();
                this.ActualizarAutores_Click(sender, e); // Actualiza la lista de autores
                MessageBox.Show("El registro se ha realizado con éxito.");
            }
            else
            {
                // Si hay un error al agregar el autor
                MessageBox.Show("Error: " + errores);
                txtAutores.Clear();
            }
        }

        private void BtnBuscarAutor_Click(object sender, EventArgs e)
        {
            string errores;
            DataTable autoresTable = controller.ObtenerAutorNombrePorTrozo( txtAutores.Text,out errores);
            dgvAutores.DataSource = autoresTable;

        }
    }
}
