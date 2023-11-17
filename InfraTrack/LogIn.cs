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
using Newtonsoft.Json;


namespace InfraTrack
{
    public partial class LogIn : Form
    {
        private InfraTrackApp _infraTrackApp;
        
        public LogIn(InfraTrackApp infraTrackApp)
        {
            InitializeComponent();
            _infraTrackApp = infraTrackApp;
        }
        

        private MySqlConnection GetConnection()
        {
            string username = "Usuario_Administrativo";
            string password = "123";
            string ip = "localhost";
            string database = "usuarios";
            string connectionString = $"server={ip};port=3306;database={database};user={username};password={password}";
          //  string connectionString = $"server=localhost;port=3306;database=usuarios;user=root;password=negritoBD123";
            return new MySqlConnection(connectionString);
        }


        //hash sha256//falta guardar pwd hasheada en sistema
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
                    string contrasena = txtpassword.Text;
                    conn.Open();

                    string query = "SELECT rol.Nombre_Rol, usuario.Usuario FROM usuario " +
                           "JOIN posee ON usuario.Cedula = posee.Cedula " +
                           "JOIN rol ON posee.Id_Rol = rol.Id_Rol " +
                           "WHERE usuario.Cedula = @cedula AND usuario.contrasena = @contrasena";

                    MySqlCommand comando = new MySqlCommand(query, conn);
                    comando.Parameters.AddWithValue("@cedula", id);
                    comando.Parameters.AddWithValue("@contrasena", contrasena);
                    MySqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string rol = reader["Nombre_Rol"].ToString();
                        string Usuario = reader["Usuario"].ToString();
                        reader.Close();

                        MySqlConnection rolConnection = GetConnectionByRole(rol);
                        _infraTrackApp.HabilitarPorRol(rol);
                        _infraTrackApp.Identificar_Usuario(Usuario);
                         
                        this.Close();
                        //  MessageBox.Show("Bienvenido " + nombreCompleto + ", Rol: " + rol);

                        
                        var usuarioInfo = new
                        {
                            Rol = rol,
                            Usuario = Usuario
                        };
                        
                        string jsonUsuario = JsonConvert.SerializeObject(usuarioInfo);
                        

                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Por el momento solo obtenemos los datos-API off 
        private void AccederInformacionUsuario()
        {
            string jsonUsuario;
            
            dynamic usuarioInfo = JsonConvert.DeserializeObject(jsonUsuario);
            
            string rol = usuarioInfo.Rol;
            string usuario = usuarioInfo.Usuario;

        }

        public static MySqlConnection GetConnectionByRole(string rol)
        {

            MySqlConnection conn = null;
            string username = "";
            string password = "";
            string ip = "localhost";
            string database = "usuarios";

            string connectionString = $"server={ip};port=3306;database={database};user={username};password={password}";
            switch (rol)
            {
                case "Administrativo":
                    conn = new MySqlConnection(connectionString);
                    username = "Usuario_Administrativo";
                    password = "123";
                    //c.Show();
                    break;

                case "Chofer":
                //  conn = new MySqlConnection("server=localhost;port=3306;database=infratrack;user=root;password=asgjqh");                    break;      

                case "Almacenero":
                //  conn = new MySqlConnection("server=localhost;port=3306;database=infratrack;user=root;password=asgjqh");                    break;

                case "Cliente":
                  //  conn = new MySqlConnection("server=localhost;port=3306;database=infratrack;user=root;password=asgjqh");
                    break;
            }

            return conn;
        }
        
        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
