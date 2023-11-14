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
    public partial class Camionero : Form
    {
        InfraTrackApp app = new InfraTrackApp();
        AdmCamioneros a = new AdmCamioneros();
       
        
        public Camionero()
        {
            InitializeComponent();
        }

        private void Camionero_Load(object sender, EventArgs e)
        {

        }

        private void Camionero_Load_1(object sender, EventArgs e)
        {

        }
        
        public void button3_Click(object sender, EventArgs e)
        {
            a.Show();
           
            
        }

        public void ComenTrayecto_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string matricula = txtMatricula.Text;
            bool? estado = comboBoxEstado.SelectedItem as bool?;

            if (!string.IsNullOrWhiteSpace(matricula) && estado.HasValue)
            {
                try
                {
                    ActualizarEstadoCamion(matricula, estado.Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el estado: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa todos los datos requeridos.");
            }
        }

        private void ActualizarEstadoCamion(string matricula, bool estado)
        {
            string connectionString = "tu_cadena_de_conexion_a_mysql";
            string query = "UPDATE Transporte SET Estado = @estado WHERE Matricula = @matricula";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@matricula", matricula);
                command.Parameters.AddWithValue("@estado", estado);

                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Estado actualizado con éxito.");
                }
                else
                {
                    MessageBox.Show("Error.");
                }
            }
        }

    }
}
