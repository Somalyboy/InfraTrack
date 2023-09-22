using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace InfraTrack
{
    class Usuario
    {
        public MySqlCommand comando;        
        public MySqlDataReader reader;

      /*  public bool validar(string id, string contrasena)
        {

            comando.CommandText = "select * from usuario where id = @id AND contrasena = @contrasena";
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@contrasena", contrasena);
            comando.Prepare();
            

            if (reader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/


    }
}
