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
            
                using (MySqlConnection conn = GetConnection())
                {
                    
                    string id = txtid.Text;
                   // string contrasenaHash = HashPassword(txtpassword.Text);
                    string contrasena = txtpassword.Text;
                    conn.Open();

                    string query = "SELECT rol FROM usuario WHERE id = @id AND contrasena = @contrasena";
                    MySqlCommand comando = new MySqlCommand(query, conn);
                    comando.Parameters.AddWithValue("@id", txtid.Text);
                    comando.Parameters.AddWithValue("@contrasena", txtpassword.Text);
                    MySqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                    string rol = string.Empty;

                    if(reader.Read())
                    {
                        rol = reader["rol"].ToString();
                    }
                    reader.Close();

                    MySqlConnection rolConnection = null;

                    if(rol == "Admin")
                    {
                        rolConnection = GetAdminConnection();
                        
                    }
                    else if (rol == "usuario")
                    {
                        rolConnection = GetUserConnection();
                    }
                    else if (rol == "camionero")
                    {
                        rolConnection = GetCamioneroConnection();
                    }
                    else if (rol == "funcionario")
                    {
                        rolConnection = GetFuncionarioConnection();
                    }

                    if (rolConnection != null)
                    {
                        rolConnection.Open();
                        
                    }
                    

                    MessageBox.Show("Bienvenido user: " + txtid.Text + "Rol: " + rol);
                }

                else
                    {
                        MessageBox.Show("Usuario no encontrado");

                    }

                   // reader.Close();
                }
        }

        private MySqlConnection GetAdminConnection()
        {
            string adminConnectionString = "server=localhost;user=root;database=usuarios;port=3306;password=negritoBD123;";
            
            MySqlConnection adminConnection = new MySqlConnection(adminConnectionString);

            return adminConnection;
        }


        private MySqlConnection GetUserConnection()
        {
            string userConnectionString = "server=localhost;user=admin;database=nombreBaseDatos;port=3306;password=adminPassword;";
            
            MySqlConnection userConnection = new MySqlConnection(userConnectionString);

            return userConnection;
        }

        private MySqlConnection GetCamioneroConnection()
        {
            string camioneroConnectionString = "server=localhost;user=admin;database=nombreBaseDatos;port=3306;password=adminPassword;";
            
            MySqlConnection camioneroConnection = new MySqlConnection(camioneroConnectionString);

            return camioneroConnection;
        }

        private MySqlConnection GetFuncionarioConnection()
        {
            string funcionarioConnectionString = "server=localhost;user=admin;database=nombreBaseDatos;port=3306;password=adminPassword;";
            
            MySqlConnection funcionarioConnection = new MySqlConnection(funcionarioConnectionString);

            return funcionarioConnection;
        }


        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
