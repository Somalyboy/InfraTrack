namespace InfraTrack
{
    partial class InfraTrackApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfraTrackApp));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnCamionero = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAlm = new System.Windows.Forms.Button();
            this.btnBackOffice = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Orange;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.btnVolver);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(104, 420);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFuncionario);
            this.panel1.Controls.Add(this.btnCamionero);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnCliente);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 185);
            this.panel1.TabIndex = 1;
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnFuncionario.Location = new System.Drawing.Point(-3, 129);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(101, 44);
            this.btnFuncionario.TabIndex = 3;
            this.btnFuncionario.Text = "Almacenero";
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Visible = false;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnCamionero
            // 
            this.btnCamionero.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCamionero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCamionero.Location = new System.Drawing.Point(-3, 89);
            this.btnCamionero.Name = "btnCamionero";
            this.btnCamionero.Size = new System.Drawing.Size(101, 44);
            this.btnCamionero.TabIndex = 2;
            this.btnCamionero.Text = "Camionero";
            this.btnCamionero.UseVisualStyleBackColor = false;
            this.btnCamionero.Visible = false;
            this.btnCamionero.Click += new System.EventHandler(this.btnCamionero_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUsuarios.Font = new System.Drawing.Font("Arial", 10.25F);
            this.btnUsuarios.Location = new System.Drawing.Point(-3, 3);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(98, 39);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCliente.Location = new System.Drawing.Point(-6, 48);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(101, 44);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Visible = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAlm);
            this.panel2.Controls.Add(this.btnBackOffice);
            this.panel2.Location = new System.Drawing.Point(3, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(95, 135);
            this.panel2.TabIndex = 2;
            // 
            // btnAlm
            // 
            this.btnAlm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAlm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAlm.Location = new System.Drawing.Point(-3, 39);
            this.btnAlm.Name = "btnAlm";
            this.btnAlm.Size = new System.Drawing.Size(101, 44);
            this.btnAlm.TabIndex = 2;
            this.btnAlm.Text = "AdmAlmacenes";
            this.btnAlm.UseVisualStyleBackColor = false;
            this.btnAlm.Visible = false;
            this.btnAlm.Click += new System.EventHandler(this.btnAlm_Click);
            // 
            // btnBackOffice
            // 
            this.btnBackOffice.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBackOffice.Font = new System.Drawing.Font("Arial", 10.25F);
            this.btnBackOffice.Location = new System.Drawing.Point(-3, 3);
            this.btnBackOffice.Name = "btnBackOffice";
            this.btnBackOffice.Size = new System.Drawing.Size(98, 39);
            this.btnBackOffice.TabIndex = 1;
            this.btnBackOffice.Text = "BackOffice";
            this.btnBackOffice.UseVisualStyleBackColor = false;
            this.btnBackOffice.Click += new System.EventHandler(this.btnBackOffice_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelContenedor.BackgroundImage")));
            this.panelContenedor.Controls.Add(this.btnLogin);
            this.panelContenedor.Location = new System.Drawing.Point(104, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(501, 420);
            this.panelContenedor.TabIndex = 1;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 10.25F);
            this.btnLogin.Location = new System.Drawing.Point(390, 369);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(98, 39);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "LogIn";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnVolver.Location = new System.Drawing.Point(3, 335);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(66, 27);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Visible = false;
            this.btnVolver.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button1.Location = new System.Drawing.Point(3, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InfraTrackApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(604, 420);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaximumSize = new System.Drawing.Size(620, 459);
            this.Name = "InfraTrackApp";
            this.Text = "INFRATRACK-APP";
            this.Load += new System.EventHandler(this.InfraTrackApp_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnCamionero;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAlm;
        private System.Windows.Forms.Button btnBackOffice;
        private System.Windows.Forms.Panel panelContenedor;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button button1;
    }
}