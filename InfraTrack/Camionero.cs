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
            /*AdmCamioneros a = new AdmCamioneros();
            app.CamionerorVentana();
            app.abrirForm(a);*/
            
            a.Show();
            app.ocultarPaneles();
            
        }

        public void ComenTrayecto_Click(object sender, EventArgs e)
        {
           
        }
    }
}
