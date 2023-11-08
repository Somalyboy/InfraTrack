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
    public partial class AdmAlmacenes : Form
    {
        public AdmAlmacenes()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string IdAlmacen = txtAlmacen.Text; 
            DataTable resultados = BuscarAlmacen(IdAlmacen);
        }

        public DataTable BuscarAlmacen(string NombreAlmacen)
        {
            DataTable dt = new DataTable(); 
            using (MySqlConnection conn = new conexion().GetConexion())
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(NombreAlmacen))
                    {
                        conn.Open();
                        string query = "SELECT * FROM Almacenes WHERE Nombre LIKE @Nombre";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Nombre", "%" + NombreAlmacen + "%"); 

                            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                            {
                                da.Fill(dt); 
                            }
                        }
                        
                        dataGridViewAlmacen.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); 
                }
            }
            return dt; 
        }

    }
}
