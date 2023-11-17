namespace InfraTrack
{
    partial class Funcionario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPaquete = new System.Windows.Forms.TextBox();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCamion = new System.Windows.Forms.Button();
            this.btnConsultarDisponibilidad = new System.Windows.Forms.Button();
            this.comboBoxCamiones = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridViewLote = new System.Windows.Forms.DataGridView();
            this.btnVerLote = new System.Windows.Forms.Button();
            this.dataGridViewDisponibilidad = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisponibilidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABM Lotes/Paquetes";
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(151, 54);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(121, 20);
            this.txtLote.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Lote";
            // 
            // txtPaquete
            // 
            this.txtPaquete.Location = new System.Drawing.Point(151, 84);
            this.txtPaquete.Name = "txtPaquete";
            this.txtPaquete.Size = new System.Drawing.Size(121, 20);
            this.txtPaquete.TabIndex = 4;
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(151, 126);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDestino.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ingrese Camión";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(12, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID Paquete";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(12, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ingrese Destino";
            // 
            // btnCamion
            // 
            this.btnCamion.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCamion.Location = new System.Drawing.Point(278, 214);
            this.btnCamion.Name = "btnCamion";
            this.btnCamion.Size = new System.Drawing.Size(201, 23);
            this.btnCamion.TabIndex = 11;
            this.btnCamion.Text = "SELECCIONAR CAMION";
            this.btnCamion.UseVisualStyleBackColor = false;
            this.btnCamion.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnConsultarDisponibilidad
            // 
            this.btnConsultarDisponibilidad.BackColor = System.Drawing.Color.DarkOrange;
            this.btnConsultarDisponibilidad.Location = new System.Drawing.Point(278, 124);
            this.btnConsultarDisponibilidad.Name = "btnConsultarDisponibilidad";
            this.btnConsultarDisponibilidad.Size = new System.Drawing.Size(201, 23);
            this.btnConsultarDisponibilidad.TabIndex = 13;
            this.btnConsultarDisponibilidad.Text = "CONSULTAR DISPONIBILIDAD";
            this.btnConsultarDisponibilidad.UseVisualStyleBackColor = false;
            this.btnConsultarDisponibilidad.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBoxCamiones
            // 
            this.comboBoxCamiones.FormattingEnabled = true;
            this.comboBoxCamiones.Location = new System.Drawing.Point(151, 216);
            this.comboBoxCamiones.Name = "comboBoxCamiones";
            this.comboBoxCamiones.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCamiones.TabIndex = 12;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEliminar.Location = new System.Drawing.Point(366, 52);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnIngresar.Location = new System.Drawing.Point(366, 81);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(113, 23);
            this.btnIngresar.TabIndex = 15;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.dataGridViewLote);
            this.panel1.Controls.Add(this.btnVerLote);
            this.panel1.Location = new System.Drawing.Point(9, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 138);
            this.panel1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "ID Lote";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 14);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 21;
            // 
            // dataGridViewLote
            // 
            this.dataGridViewLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLote.Location = new System.Drawing.Point(7, 40);
            this.dataGridViewLote.Name = "dataGridViewLote";
            this.dataGridViewLote.Size = new System.Drawing.Size(463, 83);
            this.dataGridViewLote.TabIndex = 20;
            // 
            // btnVerLote
            // 
            this.btnVerLote.BackColor = System.Drawing.Color.DarkOrange;
            this.btnVerLote.Location = new System.Drawing.Point(357, 12);
            this.btnVerLote.Name = "btnVerLote";
            this.btnVerLote.Size = new System.Drawing.Size(102, 23);
            this.btnVerLote.TabIndex = 19;
            this.btnVerLote.Text = "VISUALIZAR LOTE";
            this.btnVerLote.UseVisualStyleBackColor = false;
            this.btnVerLote.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // dataGridViewDisponibilidad
            // 
            this.dataGridViewDisponibilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisponibilidad.Location = new System.Drawing.Point(9, 153);
            this.dataGridViewDisponibilidad.Name = "dataGridViewDisponibilidad";
            this.dataGridViewDisponibilidad.Size = new System.Drawing.Size(470, 57);
            this.dataGridViewDisponibilidad.TabIndex = 23;
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(505, 395);
            this.Controls.Add(this.dataGridViewDisponibilidad);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnConsultarDisponibilidad);
            this.Controls.Add(this.comboBoxCamiones);
            this.Controls.Add(this.btnCamion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxDestino);
            this.Controls.Add(this.txtPaquete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Funcionario";
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.Funcionario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisponibilidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPaquete;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCamion;
        private System.Windows.Forms.Button btnConsultarDisponibilidad;
        private System.Windows.Forms.ComboBox comboBoxCamiones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridViewLote;
        private System.Windows.Forms.Button btnVerLote;
        private System.Windows.Forms.DataGridView dataGridViewDisponibilidad;
    }
}