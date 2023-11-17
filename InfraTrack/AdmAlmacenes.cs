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
        private string userRol;

        public AdmAlmacenes(string rol)
        {
            InitializeComponent();
            userRol = rol;
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
            using (MySqlConnection conn = LogIn.GetConnectionByRole(userRol))
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(NombreAlmacen))
                    {
                        conn.Open();
                        string query = "SELECT * FROM almacenes WHERE Nombre = @Nombre";

                        if (checkboxIncluirChofer.Checked)
                        {
                            query = @"SELECT lt.Id_Lote, tr.Matricula, d.Nombre_Departamento
                                    FROM Lotes lt
                                    JOIN transporta tr ON lt.Id_Lote = tr.Id_Lote
                                    JOIN rel_almacenes_transporta rat ON lt.Id_Lote = rat.Id_Lote
                                    JOIN Almacenes al ON rat.Id_Almacen = al.Id_Almacen
                                    JOIN Ciudad ci ON al.Ciudad = ci.Id_Ciudad
                                    JOIN Departamento d ON ci.Id_Departamento = d.Id_Departamento
                                    WHERE d.Nombre_Departamento = 'NombreDelDepartamento';
";
                        }

                        if (checkboxIncluirLote.Checked)
                        {
                            query = @"
                                SELECT 
                                Almacenes.*
                                FROM Almacenes
                                WHERE Almacenes.Nombre LIKE @Nombre";
                        }

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
    
        private void button3_Click(object sender, EventArgs e)
        {
            string idChofer = txtCedula.Text;
            string matricula = txtMatricula.Text;

            if (!string.IsNullOrWhiteSpace(idChofer))
            {
                var confirmResult = MessageBox.Show("¿Desea eliminar el usuario con ID: " + idChofer + "?",
                                                    "Confirmar eliminación",
                                                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    bool eliminado = EliminarUsuario(idChofer);
                    if (eliminado)
                    {
                        MessageBox.Show("Usuario eliminado con éxito.");
                        
                    }
                }
            }
            
            else if (!string.IsNullOrWhiteSpace(matricula))
            {
                var confirmResult = MessageBox.Show("¿Desea eliminar el transporte con matrícula: " + matricula + "?",
                                                    "Confirmar eliminación",
                                                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    bool eliminado = EliminarTransporte(matricula);
                    if (eliminado)
                    {
                        MessageBox.Show("Transporte eliminado con éxito.");
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese datos validos.");
            }
        }

        private void btnBuscarAdmin_Click(object sender, EventArgs e)
        {
            string idChofer = txtCedula.Text;
            string matricula = txtMatricula.Text;

            if (!string.IsNullOrWhiteSpace(idChofer) && string.IsNullOrWhiteSpace(matricula))
            {
                DataTable dtChofer = BuscarChofer(idChofer);
                dataGridViewChofer.DataSource = dtChofer;
            }
            else if (string.IsNullOrWhiteSpace(idChofer) && !string.IsNullOrWhiteSpace(matricula))
            {
                DataTable dtTransporte = BuscarTransporte(matricula);
                dataGridViewChofer.DataSource = dtTransporte;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores correctamente.");
            }
        }


        private DataTable BuscarChofer(string idChofer)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = LogIn.GetConnectionByRole(userRol))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Usuario WHERE Cedula = @Cedula;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cedula", idChofer);

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return dt;
        }

        private DataTable BuscarTransporte(string matricula)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = LogIn.GetConnectionByRole(userRol))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Transporte WHERE Matricula = @Matricula;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Matricula", matricula);

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return dt;
        }


        private bool ExisteTransporte(string matricula)
        {
            using (MySqlConnection conn = LogIn.GetConnectionByRole(userRol))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Transporte WHERE Matricula = @Matricula;";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Matricula", matricula);
                    int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                    return resultado > 0;
                }
            }
        }
        
        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            string idChofer = txtCedula.Text;
            string matricula = txtMatricula.Text;
            string nombre = txtNombre.Text;

            if (!string.IsNullOrWhiteSpace(idChofer) && !string.IsNullOrWhiteSpace(matricula))
            {
                if (!ExisteTransporte(matricula))
                {
                    var result = MessageBox.Show("El transporte no existe. ¿Desea ingresar un transporte default?", "Confirmar", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        InsertarTransporteDefault(matricula);
                    }
                    else
                    {
                        return;
                    }
                }
                AsociarChoferConTransporte(idChofer, matricula);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese ambos campos para ingresar la información.");
            }
        }

        private void InsertarTransporteDefault(string matricula)
        {
            using (MySqlConnection conn = LogIn.GetConnectionByRole(userRol))
            {
                conn.Open();
                string query = @"
            INSERT INTO Transporte (Matricula, Estado, Modelo, Marca, CapacidadDeCarga)
            VALUES (@Matricula, NULL, 'TK430', 'BMW', 200);";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Matricula", matricula);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private bool EliminarUsuario(string idChofer)
        {
            using (MySqlConnection conn = LogIn.GetConnectionByRole(userRol))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Usuario WHERE Cedula = @Cedula;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cedula", idChofer);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
                    return false;
                }
            }
        }

        private bool EliminarTransporte(string matricula)
        {
            using (MySqlConnection conn = LogIn.GetConnectionByRole(userRol))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Transporte WHERE Matricula = @Matricula;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Matricula", matricula);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el transporte: " + ex.Message);
                    return false;
                }
            }
        }

        private void AsociarChoferConTransporte(string idChofer, string matricula)
        {
            using (MySqlConnection conn = LogIn.GetConnectionByRole(userRol))
            {
                conn.Open();
                string query = @"
            INSERT INTO Conduce (Cedula, Matricula)
            VALUES (@Cedula, @Matricula);";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cedula", idChofer);
                    cmd.Parameters.AddWithValue("@Matricula", matricula);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
