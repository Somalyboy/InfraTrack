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
        public static MySqlConnection con = new MySqlConnection("server=localhost; " +
            "database=usuarios; " +
            "Uid=root; " +
            "pwd=negritoBD123;"); 
            
        public static void iniciarConexion()
        {
            try
            {
                con.Open();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("error: " + ex);
                con.Close();
            }
        }
    }
}
