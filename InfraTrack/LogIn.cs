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

namespace InfraTrack
{
    public partial class LogIn : Form
    {
        Usuario u = new Usuario();
        conexion con = new conexion();

        

        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         //   string id = txtid.Text;
         //   string contrasena = txtpassword.Text;

            try
            {
                conexion.iniciarConexion();
                MessageBox.Show("conexion exitosa");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error:" + ex);
            }
            
        }
    }
}
