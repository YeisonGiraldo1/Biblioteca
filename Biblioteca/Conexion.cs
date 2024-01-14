using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Biblioteca
{
    internal class Conexion
    {
        public static MySqlConnection ConexionDB()
        { 
        string datosconexion = "Database=biblioteca;Data Source=localhost;User Id=root;Password=";
            try
            {
                MySqlConnection con = new MySqlConnection(datosconexion);
                return con;
            }
            catch (MySqlException error)
            {

                MessageBox.Show(error.Message);
                return null;
            }
    }
    }
}
