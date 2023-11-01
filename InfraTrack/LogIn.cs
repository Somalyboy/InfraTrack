using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using System.Configuration;

namespace InfraTrack
{
    public partial class LogIn : Form
    {
        conexion u = new conexion();
        

        public LogIn()
        {
            InitializeComponent();
        }

        private MySqlConnection GetConnection()
        {
            string connectionString = "server=localhost;port=3306;database=usuarios;user=root;password=negritoBD123";
            return new MySqlConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = GetConnection())
            {
                bool exist;
                string id = txtid.Text;
                string contrasena = txtpassword.Text;
                conn.Open();
                string query = "SELECT * FROM usuarios WHERE id = @id AND contrasena = @contrasena";
                MySqlCommand comando = new MySqlCommand(query, conn);
                comando.Parameters.AddWithValue("@id", txtid.Text);
                comando.Parameters.AddWithValue("@contrasena", txtpassword.Text);
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Bienvenido, usuario nro: " + txtid.Text);
                   /* exist = true;
                    if (exist)
                    {
                        u.ObtenerRol(id, contrasena);
                    }*/
                }
                
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                }

                reader.Close();
            }

            }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
