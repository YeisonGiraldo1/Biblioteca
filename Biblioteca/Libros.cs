using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    internal class Libros
    {
        public int Id { get; set; }
        public string Autor { get; set; }

        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        public string Editorial { get; set; }

        public string Estado { get; set; }


        public string Nomenclatura { get; set; }

        public int  Num_Pag { get; set; }
        public int Year_Public { get; set; }

        public string Genero { get; set; }

        public void Registrar()
        {
            string sql = "INSERT INTO libros (Autor,Nombre,Cantidad,Editorial,Estado,Nomenclatura,Num_Pag,Year_Publi,Genero) VALUES ('" + Autor + "','" + Nombre + "'," + Cantidad + ",'" + Editorial + "','" + Estado + "','" + Nomenclatura + "'," + Num_Pag + "," + Year_Public + ",'" + Genero   + "')";
            //Conexion conexion = new Conexion();
            MySqlConnection conexion = Conexion.ConexionDB();
            conexion.Open();
            try
            {
                MySqlCommand stm = new MySqlCommand(sql,conexion);
                stm.ExecuteNonQuery();
                MessageBox.Show("LIBRO GUARDADO CON EXITO!.");
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message);
               
            }
            finally
            {
                conexion.Close();
            }
        }



        public MySqlDataReader Consultar()
        {
            
            string sql = "SELECT * FROM libros";
            MySqlConnection conexion = Conexion.ConexionDB();
            conexion.Open();
            try
            {
                MySqlCommand stm = new MySqlCommand(sql, conexion);
                MySqlDataReader libros = stm.ExecuteReader();
                return libros;
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message) ; 
                return null;
            }
        }




        public MySqlDataReader ConsultarunLibro(int id)
        {

            string sql = "SELECT * FROM libros WHERE id='" + id + "' ";
            MySqlConnection conexion = Conexion.ConexionDB();
            conexion.Open();
            try
            {
                MySqlCommand stm = new MySqlCommand(sql, conexion);
                MySqlDataReader libros = stm.ExecuteReader();
                return libros;
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message);
                return null;

            }
        }


        public void Actualizar()
        {
            string sql = "UPDATE libros SET Autor='" + Autor + "',Nombre = '" + Nombre+ "',Cantidad = '" +Cantidad+ "',Editorial = '" + Editorial + "',Estado = '" + Estado + "',Nomenclatura = '"+ Nomenclatura + "',Num_Pag = '"+ Num_Pag + "',Year_Publi = '" + Year_Public + "',Genero = '" + Genero + "' WHERE Id = '"+Id+"'";
            //Conexion conexion = new Conexion();
                   

        MySqlConnection conexion = Conexion.ConexionDB();
            conexion.Open();
            try
            {
                MySqlCommand stm = new MySqlCommand(sql, conexion);
                stm.ExecuteNonQuery();
                MessageBox.Show("LIBRO ACTUALIZADO CON EXITO!.");

            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message);

            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
