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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AnadirLibros().Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new DevolverLibro().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new PrestarLibro().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            new AltaLector().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new ListaMorosos().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new EliminarLibro().Show();
        }
    }
}
