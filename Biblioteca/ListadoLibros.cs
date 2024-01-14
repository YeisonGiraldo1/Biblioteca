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
    public partial class ListadoLibros : Form
    {
        public ListadoLibros()
        {
            InitializeComponent();
            Libros libros = new Libros();
            MySqlDataReader arreglolibros = libros.Consultar();

            while (arreglolibros.Read())
                {
                tablalibros.Rows.Add(
                    arreglolibros.GetString(0),
                    arreglolibros.GetString(1),
                    arreglolibros.GetString(2),
                    arreglolibros.GetString(3),
                    arreglolibros.GetString(5)
                    );
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void ListadoLibros_Load(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formulariolibros = new Form1();   
            formulariolibros.Show();
        }


        private int ConsultarId()
        {

            try
            {
                int id = int.Parse(tablalibros.Rows[tablalibros.CurrentRow.Index].Cells[0].Value.ToString());
                return id;
            }
            catch (Exception)
            {
                return 0;
                
            }
        }


        private void ModificarLibro_Click(object sender, EventArgs e)
        {

            int id = ConsultarId();
            FormularioActualizarLibroscs formularioactualizarlibros = new  FormularioActualizarLibroscs(id);
            formularioactualizarlibros.Show();
          
        }
    }
}
