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
    public partial class FmrMenu : Form
    {
        public FmrMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FrmAnadirLibro().Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new FmrDevolverLibro().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FmrPrestarLibro().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            new FmrAltaLector().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new FmrListaMorosos().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FmrEliminarLibro().Show();
        }
    }
}
