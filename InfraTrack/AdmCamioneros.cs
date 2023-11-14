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
    public partial class AdmCamioneros : Form
    {
        public AdmCamioneros()
        {
            InitializeComponent();
        }

        private void AdmCamioneros_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idCamion = txtIdCamion.Text;
            string connectionString = ""; 

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT 
                            a.Nombre, 
                            a.Direccion, 
                            rt.Fecha, 
                            rt.Hora 
                         FROM 
                            Transporte t
                         JOIN 
                            Rel_Almacenes_Transporta rt ON t.Matricula = rt.Matricula
                         JOIN 
                            Almacenes a ON rt.IdAlmacen = a.Id
                         WHERE 
                            t.Matricula = @IdCamion";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdCamion", idCamion);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewCamionero.DataSource = dt; 
                    }
                }
            }
        }
    }
}
