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

        private void button2_Click(object sender, EventArgs e)
        {
            string idTrayecto = txtTrayecto.Text;
            string connectionString = "";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT 
                            r.NombreRuta, 
                            d.NombreDepartamento,
                            a.Nombre as NombreAlmacen, 
                            tr.Fecha, 
                            tr.Hora
                         FROM 
                            Trayecto tr
                         JOIN 
                            Rel_Trayecto_Ruta rtr ON tr.IdTrayecto = rtr.IdTrayecto
                         JOIN 
                            Ruta r ON rtr.IdRuta = r.IdRuta
                         JOIN 
                            Departamento d ON r.IdDepartamento = d.IdDepartamento
                         JOIN 
                            Almacenes a ON d.IdDepartamento = a.IdDepartamento
                         WHERE 
                            tr.IdTrayecto = @IdTrayecto
                         ORDER BY 
                            tr.Fecha, tr.Hora;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdTrayecto", idTrayecto);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridViewTrayecto.DataSource = dt;
                    }
                }
            }
        }

        private void ConfigureDataGridView()
        {
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "Confirmado";
            chk.Name = "chk";
            dataGridViewTrayecto.Columns.Add(chk);
        }


        private void dataGridViewTrayecto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTrayecto.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                if (Convert.ToBoolean(dataGridViewTrayecto.Rows[e.RowIndex].Cells["chk"].Value) == false)
                {
                    if (MessageBox.Show("¿Confirmas que el lote ha sido entregado?", "Confirmar Entrega", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        dataGridViewTrayecto.Rows[e.RowIndex].Cells["chk"].Value = true;

                        int loteId = Convert.ToInt32(dataGridViewTrayecto.Rows[e.RowIndex].Cells["IdLote"].Value);

                        ActualizarEstadoLote(loteId, true);
                    }
                    else
                    {
                        dataGridViewTrayecto.Rows[e.RowIndex].Cells["chk"].Value = false;
                    }
                }
            }
        }


        private void ActualizarEstadoLote(int loteId, bool entregado)
        {
            string connectionString = "";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE Lotes SET Estado = @Estado WHERE IdLote = @IdLote";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Estado", entregado);
                        command.Parameters.AddWithValue("@IdLote", loteId);

                        command.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al actualizar el estado del lote: " + ex.Message);
                }
            }

        }
    }
}



