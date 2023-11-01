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
        //  public MySqlConnection conexion = new MySqlConnection();
        conexion c = new conexion();

      //  string rol_nombre = c.ObtenerRol.ToString(); //agggg

        public void identificarUsuario(string rol_nombre)
        {
            switch (rol_nombre)
            {
                case "Administrador":
                    InfraTrackApp form1 = new InfraTrackApp();
                    form1.Show();
                    break;

                case "User":
                  //  InfraTrackApp form1 = new InfraTrackApp();
                  //  form1.Show();
                    break;

                case "Funcionario":
                //    InfraTrackApp form1 = new InfraTrackApp();
                 //   form1.Show();
                    break;

                case "Chofer":
                 //   InfraTrackApp form1 = new InfraTrackApp();
                 //   form1.Show();
                    break;

                default:
                    // Rol no reconocido.
                    break;
            }
        }



    }
}
