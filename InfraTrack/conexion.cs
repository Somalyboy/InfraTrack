using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Windows.Forms;

namespace InfraTrack
{
    public class conexion
    {
       // private string _connectionString;
        
        public string ObtenerRol(string id, string contrasena)
        {
            using (MySqlConnection connection = new MySqlConnection())
            {
                connection.Open();
                string query = "SELECT rol.nombre FROM usuario INNER JOIN rol ON usuario.role_id = rol.id WHERE usuario.id = @id AND usuario.contrasena = @contrasena";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["nombre"].ToString(); //nombre = rol.nombre
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }

        }
    }
}
