﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Libros libros = new Libros{ 
            Autor = autor.Text,
            Nombre = nombre.Text,
            Cantidad = Int32.Parse(cantidad.Text),
            Editorial = editorial.Text,
            Estado = estado.Text,
            Nomenclatura = nomenclatura.Text,
            Num_Pag = Int32.Parse(num_pag.Text),
            Year_Public = Int32.Parse(year_publi.Text),
            Genero = genero.Text,
                };

            libros.Registrar();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
