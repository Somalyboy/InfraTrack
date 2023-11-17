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
    public partial class Funcionario : Form
    {
        private string userRol;

        public Funcionario(string rol)
        {
            InitializeComponent();
            userRol = rol;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Funcionario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            string Lote = txtLote.Text;
            using (MySqlConnection conn = LogIn.GetConnectionByRole(userRol))
            {
                string sql = "SELECT * FROM Rel_Lote_Pedidos WHERE Lote = @Lote";

                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@Lote", Lote);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridViewLote.DataSource = table;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string idLote = txtLote.Text;
            string matriculaCamion = comboBoxCamiones.SelectedValue.ToString();

            string mensajeConfirmacion = $"¿Desea confirmar que el ID del lote {idLote} se ingresará en camion con matrícula: {matriculaCamion}?";
            DialogResult dialogResult = MessageBox.Show(mensajeConfirmacion, "Confirmación de Datos", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                InsertarTransporta(idLote, matriculaCamion);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string destinoSeleccionado = comboBoxDestino.SelectedItem.ToString();
            using (MySqlConnection conn = LogIn.GetConnectionByRole(userRol))
            {
                string sql = "SELECT * FROM Transporte WHERE Destino LIKE @Destino";

                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@Destino", "%" + destinoSeleccionado + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewDisponibilidad.DataSource = table;
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }
        
        private void InsertarTransporta(string idLote, string matriculaCamion)
        {
            using (MySqlConnection conn = LogIn.GetConnectionByRole(userRol))
            {
                string sql = "INSERT INTO Transporta (IdLote, Matricula) VALUES (@IdLote, @Matricula)";

                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@IdLote", idLote);
                    command.Parameters.AddWithValue("@Matricula", matriculaCamion);

                    try
                    {
                        conn.Open();
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("El transporte ha sido registrado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar el transporte.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al registrar el transporte: " + ex.Message);
                    }
                }
            }
        }


        private void LlenarComboBoxCamiones(string destino)
        {
            using (MySqlConnection conn = LogIn.GetConnectionByRole(userRol))
            {
                string sql = "SELECT Matricula FROM Camiones WHERE Destino = @Destino";

                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@Destino", destino);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);


                    comboBoxCamiones.DisplayMember = "Matricula";
                    comboBoxCamiones.ValueMember = "Matricula";
                    comboBoxCamiones.DataSource = dt;
                }
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            string idLote = txtLote.Text;
            string idPaquete = txtPaquete.Text;

            using (MySqlConnection conn = LogIn.GetConnectionByRole(userRol))
            {
                
                conn.Open();

                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string sql = "";
                    if (!string.IsNullOrEmpty(idLote))
                    {
                        sql = "DELETE FROM Lotes WHERE IdLote = @IdLote";
                    }
                    else if (!string.IsNullOrEmpty(idPaquete))
                    {
                        sql = "DELETE FROM Paquetes WHERE IdPaquete = @IdPaquete";
                    }
                    
                    using (MySqlCommand command = new MySqlCommand(sql, conn, transaction))
                    {
                        command.Parameters.AddWithValue("@IdLote", idLote);
                        command.Parameters.AddWithValue("@IdPaquete", idPaquete);
                        
                        command.ExecuteNonQuery();
                    }
                    
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }
    }
}
