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

        private string userRol;

        public Camionero(string rol)
        {
            InitializeComponent();
            userRol = rol;
        }

        private void Camionero_Load(object sender, EventArgs e)
        {

        }

        private void Camionero_Load_1(object sender, EventArgs e)
        {

        }
        
        public void button3_Click(object sender, EventArgs e)
        {
            
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
            string query = "UPDATE Transporte SET Estado = @estado WHERE Matricula = @matricula";

            using (MySqlConnection conn = LogIn.GetConnectionByRole(userRol))
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@matricula", matricula);
                command.Parameters.AddWithValue("@estado", estado);

                conn.Open();
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

        private void btnComenTrayecto_Click(object sender, EventArgs e)
        {
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void chkTerminarTrayecto_CheckedChanged(object sender, EventArgs e)
        {
            txtRuta.Enabled = true;
        }

        private void btnCrearTrayecto_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string idTrayecto = txtTrayecto.Text;
            string idCamion = txtMatricula.Text;
            string ciudadInicial = txtCiudad1.Text;
            string ciudadFinal = txtCiudad2.Text;
            string ruta = txtRuta.Text;
            
            if (!string.IsNullOrWhiteSpace(idTrayecto) && !string.IsNullOrWhiteSpace(idCamion) &&
                !string.IsNullOrWhiteSpace(ciudadInicial) && !string.IsNullOrWhiteSpace(ciudadFinal) &&
                !string.IsNullOrWhiteSpace(ruta))
            {
                try
                {
                    InsertarTrayectoYRuta(idTrayecto, idCamion, ciudadInicial, ciudadFinal, ruta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar los datos: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa todos los datos requeridos.");
            }
        }

        private void InsertarTrayectoYRuta(string idTrayecto, string idCamion, string ciudadInicial, string ciudadFinal, string ruta)
        {
            using (MySqlConnection conn = LogIn.GetConnectionByRole(userRol))
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                MySqlTransaction transaction = conn.BeginTransaction();

                command.Connection = conn;
                command.Transaction = transaction;

                try
                {
                    command.CommandText = "INSERT INTO Trayecto (IdTrayecto, IdCamion, CiudadInicial, CiudadFinal) VALUES (@idTrayecto, @idCamion, @ciudadInicial, @ciudadFinal)";
                    command.Parameters.AddWithValue("@idTrayecto", idTrayecto);
                    command.Parameters.AddWithValue("@idCamion", idCamion);
                    command.Parameters.AddWithValue("@ciudadInicial", ciudadInicial);
                    command.Parameters.AddWithValue("@ciudadFinal", ciudadFinal);
                    command.ExecuteNonQuery();
                    
                    command.CommandText = "INSERT INTO Ruta (Ruta) VALUES (@ruta)";
                    command.Parameters.AddWithValue("@ruta", ruta);
                    command.ExecuteNonQuery();
                    
                    long rutaId = command.LastInsertedId;
                    
                    command.CommandText = "INSERT INTO Rel_Trayecto_Ruta (IdTrayecto, RutaId) VALUES (@idTrayecto, @rutaId)";
                    command.Parameters.AddWithValue("@rutaId", rutaId);
                    command.ExecuteNonQuery();
                    
                    transaction.Commit();
                    MessageBox.Show("Trayecto y Ruta creados con éxito.");
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
