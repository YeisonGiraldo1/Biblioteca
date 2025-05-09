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
    public partial class PanelLibros : Form
    {
        public PanelLibros()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private Form formularioacivo = null;
        private void AbrirFormularioSecundario(Form formulariosecundario)
        {
            
                
                formularioacivo = formulariosecundario;
                formulariosecundario.TopLevel = false;
                formulariosecundario.FormBorderStyle = FormBorderStyle.None;
                formulariosecundario.Dock = DockStyle.Fill;
                PanelFormularios.Controls.Add(formulariosecundario);
                PanelFormularios.Tag = formulariosecundario;
                formulariosecundario.BringToFront();
                formulariosecundario.Show();
            


        }

        private void MenuEfecto()
        {
if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
else
                panel1.Visible = false;
        }

        private void btn_libros_Click(object sender, EventArgs e)
        {
            MenuEfecto();
            
        }

        private void btn_registrolibros_Click(object sender, EventArgs e)
        {
            MenuEfecto();
            AbrirFormularioSecundario(new Form1());
        }

        private void btn_listadolibros_Click(object sender, EventArgs e)
        {
            MenuEfecto();
            AbrirFormularioSecundario(new ListadoLibros());
        }
    }
}
