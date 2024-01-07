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
    public partial class FmrListaMorosos : Form
    {
        public FmrListaMorosos()
        {
            InitializeComponent();
        }

        private void ListaMorosos_Load(object sender, EventArgs e)
        {

            //controlador.Morosos;
            string errores;
            DataMorosos.DataSource = null;
            DataMorosos.DataSource = Program.controller.Morosos(out errores);
            if (!string.IsNullOrEmpty(errores))
            {
                MessageBox.Show("Error: " + errores);

            }

        }
    }
}
