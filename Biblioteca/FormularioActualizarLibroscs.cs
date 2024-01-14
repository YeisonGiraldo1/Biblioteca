using MySql.Data.MySqlClient;
using System;
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
    public partial class FormularioActualizarLibroscs : Form
    {
        int idactualizar;
        public FormularioActualizarLibroscs(int id)
        {
            InitializeComponent();
            idactualizar = id;
            Libros libros = new Libros();
            MySqlDataReader arreglodeunlibro = libros.ConsultarunLibro(id);
            while (arreglodeunlibro.Read())
            {
                autor.Text = arreglodeunlibro.GetString(1);
                nombre.Text = arreglodeunlibro.GetString(2);
                cantidad.Text = arreglodeunlibro.GetString(3);
                editorial.Text = arreglodeunlibro.GetString(4);
                estado.Text = arreglodeunlibro.GetString(5);
                nomenclatura.Text = arreglodeunlibro.GetString(6);
                num_pag.Text = arreglodeunlibro.GetString(7);
                year_publi.Text = arreglodeunlibro.GetString(8);
                genero.Text = arreglodeunlibro.GetString(4);
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Libros libros = new Libros
            {
                Id = idactualizar,
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

            libros.Actualizar();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
