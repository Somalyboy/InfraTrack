namespace InfraTrack
{
    partial class AdmAlmacenes
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlmacen = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewAlmacen = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.checkboxIncluirChofer = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkboxIncluirLote = new System.Windows.Forms.CheckBox();
            this.dataGridViewChofer = new System.Windows.Forms.DataGridView();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlmacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChofer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administracion De Almacenes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "IdAlamcen:";
            // 
            // txtAlmacen
            // 
            this.txtAlmacen.Location = new System.Drawing.Point(118, 66);
            this.txtAlmacen.Name = "txtAlmacen";
            this.txtAlmacen.Size = new System.Drawing.Size(86, 20);
            this.txtAlmacen.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(220, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewAlmacen
            // 
            this.dataGridViewAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlmacen.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewAlmacen.Location = new System.Drawing.Point(24, 109);
            this.dataGridViewAlmacen.Name = "dataGridViewAlmacen";
            this.dataGridViewAlmacen.Size = new System.Drawing.Size(397, 82);
            this.dataGridViewAlmacen.TabIndex = 9;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEliminar.Location = new System.Drawing.Point(346, 387);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkboxIncluirChofer
            // 
            this.checkboxIncluirChofer.AutoSize = true;
            this.checkboxIncluirChofer.Location = new System.Drawing.Point(301, 63);
            this.checkboxIncluirChofer.Name = "checkboxIncluirChofer";
            this.checkboxIncluirChofer.Size = new System.Drawing.Size(85, 17);
            this.checkboxIncluirChofer.TabIndex = 11;
            this.checkboxIncluirChofer.Text = "IncluirChofer";
            this.checkboxIncluirChofer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label3.Location = new System.Drawing.Point(50, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Administracion Camion/Chofer";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBuscar.Location = new System.Drawing.Point(346, 245);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscarAdmin_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(103, 247);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(86, 20);
            this.txtCedula.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(20, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "IdChofer:";
            // 
            // checkboxIncluirLote
            // 
            this.checkboxIncluirLote.AutoSize = true;
            this.checkboxIncluirLote.Location = new System.Drawing.Point(301, 86);
            this.checkboxIncluirLote.Name = "checkboxIncluirLote";
            this.checkboxIncluirLote.Size = new System.Drawing.Size(75, 17);
            this.checkboxIncluirLote.TabIndex = 16;
            this.checkboxIncluirLote.Text = "IncluirLote";
            this.checkboxIncluirLote.UseVisualStyleBackColor = true;
            // 
            // dataGridViewChofer
            // 
            this.dataGridViewChofer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChofer.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewChofer.Location = new System.Drawing.Point(24, 299);
            this.dataGridViewChofer.Name = "dataGridViewChofer";
            this.dataGridViewChofer.Size = new System.Drawing.Size(397, 82);
            this.dataGridViewChofer.TabIndex = 17;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(243, 247);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(86, 20);
            this.txtMatricula.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(195, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Mat:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnIngresar.Location = new System.Drawing.Point(346, 270);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 21;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(20, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(103, 271);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(86, 20);
            this.txtNombre.TabIndex = 23;
            // 
            // AdmAlmacenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(453, 423);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewChofer);
            this.Controls.Add(this.checkboxIncluirLote);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkboxIncluirChofer);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataGridViewAlmacen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAlmacen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdmAlmacenes";
            this.Text = "q";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlmacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChofer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlmacen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewAlmacen;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox checkboxIncluirChofer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkboxIncluirLote;
        private System.Windows.Forms.DataGridView dataGridViewChofer;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
    }
}