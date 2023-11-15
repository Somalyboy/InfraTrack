using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfraTrack
{
    public partial class InfraTrackApp : Form
    {
        
        private bool usuariosVisible = false;
        private bool backOfficeVisible = false;
        

        public AdmCamioneros a = new AdmCamioneros();
        public InfraTrackApp()
        {
            InitializeComponent();
            ocultarTodo();
            
        }
        
        public void ocultarTodo()
        {
            btnCamionero.Visible = false;
            btnFuncionario.Visible = false;
            btnAlm.Visible = false;
            btnVolver.Visible = true;
            btnBackOffice.Visible = false;
            btnUsuarios.Enabled = false;


        }
        
        public void habilitarUsuario()
        {
            btnUsuarios.Enabled = true;
        }

        private void Mostrar1()
        {
          
            MostrarUsuarios();
        }

        private void MostrarUsuarios()
        {
            btnCliente.Visible = true;
            btnCamionero.Visible = true;
            btnFuncionario.Visible = true;
            btnBackOffice.Visible = true;
        }

    private void Mostrar2()
        {
            btnAlm.Visible = backOfficeVisible;

        }

        public void HabilitarPorRol(string rol)
        {
            switch (rol)
            {
                case "admin":

                    break;
                case "usuario":
                    btnCamionero.Enabled = false;
                    btnFuncionario.Enabled = false;
                    btnAlm.Enabled = false;
                    break;

                case "chofer":
                    btnFuncionario.Enabled = false;
                    btnAlm.Enabled = false;
                    break;

                case "funcionario":
                    btnCamionero.Enabled = false;
                    break;
            }
        }

        public void ComenzarTrayecto()
        {
            abrirForm(new AdmCamioneros());
        }

        public void abrirForm(object subform)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form f = subform as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(f);
            this.panelContenedor.Tag = f;
            f.Show();

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            usuariosVisible = !usuariosVisible;
            MostrarUsuarios();
        }

        private void btnBackOffice_Click(object sender, EventArgs e)
        {
            backOfficeVisible = !backOfficeVisible;
            Mostrar2();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
                abrirForm(new Cliente());
            

            }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCamionero_Click(object sender, EventArgs e)
        {
            abrirForm(new Camionero());
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            abrirForm(new Funcionario());
        }

        private void btnCam_Click(object sender, EventArgs e)
        {
            abrirForm(new AdmCamioneros());
        }

        private void btnAlm_Click(object sender, EventArgs e)
        {
            abrirForm(new AdmAlmacenes());
            
            
        }

        private void InfraTrackApp_Load(object sender, EventArgs e)
        {

        }

        public void CamionerorVentana()
        {
            Camionero c = new Camionero();
            c.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            LogIn loginForm = new LogIn(this);
            loginForm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            LogIn loginForm = new LogIn(this);
            loginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
