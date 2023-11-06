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
using System.Security.Cryptography;

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

        //hash sha256
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
      

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    
                    string id = txtid.Text;
                   // string contrasenaHash = HashPassword(txtpassword.Text);
                    string contrasena = txtpassword.Text;
                    conn.Open();
                    string query = "SELECT * FROM usuarios WHERE id = @id AND contrasena = @contrasena";
                    MySqlCommand comando = new MySqlCommand(query, conn);
                    comando.Parameters.AddWithValue("@id", txtid.Text);
                    comando.Parameters.AddWithValue("@contrasena", contrasena);
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }


        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
