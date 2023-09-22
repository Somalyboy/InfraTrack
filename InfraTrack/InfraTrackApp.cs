﻿using System;
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
        public InfraTrackApp()
        {
            InitializeComponent();
            ocultarPaneles();
        }

        LogIn login = new LogIn();

        private void ocultarPaneles()
        {
            btnCliente.Visible = false;
            btnCamionero.Visible = false;
            btnFuncionario.Visible = false;
            btnAlm.Visible = false;
            btnCam.Visible = false;
        }

        private void Mostrar1()
        {
            btnCliente.Visible = true;
            btnCamionero.Visible = true;
            btnFuncionario.Visible = true;

        }

        private void Mostrar2()
        {
            btnAlm.Visible = true;
            btnCam.Visible = true;
        }

        private void abrirForm(object subform)
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
    }
}
