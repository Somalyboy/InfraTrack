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
        public AdmCamioneros a = new AdmCamioneros();
        public InfraTrackApp()
        {
            InitializeComponent();
            ocultarPaneles();
        }

        LogIn login = new LogIn();

        public void ocultarPaneles()
        {
            btnCliente.Visible = false;
            btnCamionero.Visible = false;
            btnFuncionario.Visible = false;
            btnAlm.Visible = false;
           
        }

        private void Mostrar1()
        {
            btnCliente.Visible = true;
            btnCamionero.Visible = true;

        }

        private void Mostrar2()
        {
            btnAlm.Visible = true;
           
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
            Mostrar1();
        }

        private void btnBackOffice_Click(object sender, EventArgs e)
        {
            Mostrar2();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
                login.Show();
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
            btnFuncionario.Visible = true;
            
        }

        private void InfraTrackApp_Load(object sender, EventArgs e)
        {

        }

        public void CamionerorVentana()
        {
            Camionero c = new Camionero();
            c.Visible = false;
        }
    }
}
