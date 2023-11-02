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
    public partial class AnadirLibros : Form
    {

        GestionBiblioteca controller = new GestionBiblioteca();


        public AnadirLibros()
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
            string isbn = TxtISBN.Text;
            string titulo = TxtTitulo.Text;
            string sinopsis = TxtSinopsis.Text;
            string unidades = TxtUnidades.Text;
            string editorial = TxtEditorial.Text;
            string autor = TxtAutores.Text;
            string categoria = DataCategorias.SelectedRows.ToString();
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

            if (string.IsNullOrEmpty(autor))
            {
                MessageBox.Show("El campo Autor no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (int.TryParse(TxtUnidades.Text, out cantidad))
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
            
            string errores;
            if (controller.anadirLibro(isbn, titulo, editorial, sinopsis, caratulaSeleccionada, cantidad, prestable,autor ,categoria, out errores))
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
            DataCategorias.DataSource = null;
            string errores;
            DataTable categoriasTable = controller.ObtenerCategoriasNombre(out errores);
            DataCategorias.DataSource = categoriasTable;
        }
    }
}
