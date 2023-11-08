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
        private string cadenaConexion = "server=localhost;port=3306;database=usuarios;uid=root;pwd=negritoBD123;";

        public Cliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuscarLotes();
        }

        private void BuscarLotes()
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    if (!string.IsNullOrWhiteSpace(txtPedido.Text))
                    {
                        string query = "SELECT * FROM Pedidos WHERE Id_Pedido = @Id_Pedido";
                        using (MySqlCommand cmd = new MySqlCommand(query, conexion))
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
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
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
    } 
} 
