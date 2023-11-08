using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Windows.Forms;

namespace InfraTrack
{
    using MySqlConnector;

    public class conexion
    {
        private string connectionString;

        public conexion()
        {
            connectionString = "server=localhost;port=3306;database=usuarios;user=root;password=negritoBD123;";
        }

        public MySqlConnection GetConexion()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
