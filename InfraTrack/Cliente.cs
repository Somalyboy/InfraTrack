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
    public partial class Cliente : Form
    {
        private string userRol;

        public Cliente(string rol)
        {
            InitializeComponent();
            userRol = rol;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuscarLotes();
        }

        private void BuscarLotes()
        {
            using (MySqlConnection conn = LogIn.GetConnectionByRole(userRol))
            {
                try
                {
                    conn.Open();

                    if (!string.IsNullOrWhiteSpace(txtPedido.Text))
                    {
                        string query = "SELECT * FROM Pedidos WHERE Id_Pedido = @Id_Pedido";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id_Pedido", txtPedido.Text);

                            DataTable dt = new DataTable();
                            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                            {
                                da.Fill(dt);
                                dataGridViewLote.DataSource = dt;
                                dataGridViewLote.Visible = true;
                            } 
                        } 
                    }
                    else
                    {
                        MessageBox.Show("El id es incorrecto o no existe.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            } 
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        public void ConsultarEstadoPaquete(string idPaquete)
        {
            txtPedido.Text = idPaquete;

            using (MySqlConnection conn = LogIn.GetConnectionByRole(userRol))
            {
                conn.Open();
                
                string query= @"
            SELECT CASE 
                     WHEN t.Estado = 1 THEN 'En camino'
                     ELSE 'En depósito'
                   END as Estado,
                   a.Nombre as AlmacenDestino
            FROM Lotes l
            JOIN Transporte t ON l.Id = t.IdLote
            JOIN Almacenes a ON t.IdAlmacen = a.Id
            WHERE l.IdPaquete = @IdPaquete";

                
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@IdPaquete", idPaquete);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblEstado.Text = reader["Estado"].ToString();
                            lblAlmacenDestino.Text = reader["AlmacenDestino"].ToString();
                            
                            lblDemoraEstimada.Text = CalcularDemoraEstimada(); /*+ " horas";*/
                            //Falta obtener la matricula y la ruta del transporte correctamente 
                        }
                        else
                        {
                          
                        }
                    }
                }
            }
        }
        
        public int CalcularDemoraEstimada(int idRutaDelTransporte, string matriculaDelCamion)
        {
            int totalAlmacenesEnRuta = 0;
            int almacenesEntregados = 0;

            using (MySqlConnection conn = LogIn.GetConnectionByRole(userRol))
            {
                conn.Open();
                
                string queryTotalAlmacenes = @"
            SELECT COUNT(DISTINCT ral.Id_Almacen) AS TotalAlmacenesEnRuta
            FROM Ruta r
            JOIN Rel_Trayecto_Ruta rtr ON r.Id_Ruta = rtr.Id_Ruta
            JOIN Trayecto t ON rtr.Id_Trayecto = t.Id_Trayecto
            JOIN Rel_Almacenes_Transporta rat ON t.Id_Trayecto = rat.Id_Trayecto
            JOIN Almacenes a ON rat.Id_Almacen = a.Id_Almacen
            WHERE r.Id_Ruta = @IdRutaDelTransporte";

                using (MySqlCommand commandTotal = new MySqlCommand(queryTotalAlmacenes, conn))
                {
                    commandTotal.Parameters.AddWithValue("@IdRutaDelTransporte", idRutaDelTransporte);

                    totalAlmacenesEnRuta = (int)commandTotal.ExecuteScalar();
                }
                
                string queryAlmacenesEntregados = @"
            SELECT COUNT(DISTINCT ral.Id_Almacen) AS AlmacenesEntregados
            FROM Rel_Almacenes_Transporta rat
            JOIN Almacenes a ON rat.Id_Almacen = a.Id_Almacen
            WHERE rat.Matricula = @MatriculaDelCamion AND
                  rat.EstadoEntrega = 1";

                using (MySqlCommand commandEntregados = new MySqlCommand(queryAlmacenesEntregados, conn))
                {
                    commandEntregados.Parameters.AddWithValue("@MatriculaDelCamion", matriculaDelCamion);

                    almacenesEntregados = (int)commandEntregados.ExecuteScalar();
                }

                int almacenesRestantes = totalAlmacenesEnRuta - almacenesEntregados;
                int demoraEstimada = almacenesRestantes * 1; // Asume 1 hora por almacen restante.

                return demoraEstimada;

            }


        }

        private void txtPedido_TextChanged(object sender, EventArgs e)
        {

        }
    } 
} 
