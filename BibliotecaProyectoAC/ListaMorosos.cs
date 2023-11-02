﻿using CapaDatos;
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
    public partial class ListaMorosos : Form
    {
        public ListaMorosos()
        {
            InitializeComponent();
        }

        private void ListaMorosos_Load(object sender, EventArgs e)
        {
            GestionBiblioteca controlador = new GestionBiblioteca();
            //controlador.Morosos;
            string errores;
            DataMorosos.DataSource = null;
            DataMorosos.DataSource = controlador.Morosos(out errores);
            if (string.IsNullOrEmpty(errores))
            {

            }
            else
            {
                MessageBox.Show("Error: " + errores);
            }
        }
    }
}
