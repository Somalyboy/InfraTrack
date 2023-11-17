namespace InfraTrack
{
    partial class AdmCamioneros
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
            this.txtIdCamion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewCamionero = new System.Windows.Forms.DataGridView();
            this.txtTrayecto = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewTrayecto = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamionero)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrayecto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese ID de su camión ";
            // 
            // txtIdCamion
            // 
            this.txtIdCamion.Location = new System.Drawing.Point(204, 9);
            this.txtIdCamion.Name = "txtIdCamion";
            this.txtIdCamion.Size = new System.Drawing.Size(105, 20);
            this.txtIdCamion.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(326, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "BUSCAR VIAJES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(14, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ingrese ID de viaje:";
            // 
            // dataGridViewCamionero
            // 
            this.dataGridViewCamionero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCamionero.Location = new System.Drawing.Point(18, 38);
            this.dataGridViewCamionero.Name = "dataGridViewCamionero";
            this.dataGridViewCamionero.Size = new System.Drawing.Size(413, 109);
            this.dataGridViewCamionero.TabIndex = 15;
            // 
            // txtTrayecto
            // 
            this.txtTrayecto.Location = new System.Drawing.Point(170, 173);
            this.txtTrayecto.Name = "txtTrayecto";
            this.txtTrayecto.Size = new System.Drawing.Size(100, 20);
            this.txtTrayecto.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(276, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "COMENZAR TRAYECTO";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewTrayecto);
            this.panel1.Location = new System.Drawing.Point(18, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 114);
            this.panel1.TabIndex = 28;
            // 
            // dataGridViewTrayecto
            // 
            this.dataGridViewTrayecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrayecto.Location = new System.Drawing.Point(-2, -5);
            this.dataGridViewTrayecto.Name = "dataGridViewTrayecto";
            this.dataGridViewTrayecto.Size = new System.Drawing.Size(415, 116);
            this.dataGridViewTrayecto.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkOrange;
            this.button6.Location = new System.Drawing.Point(448, 304);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 23);
            this.button6.TabIndex = 29;
            this.button6.Text = "Salir";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // AdmCamioneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(544, 339);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTrayecto);
            this.Controls.Add(this.dataGridViewCamionero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIdCamion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdmCamioneros";
            this.Load += new System.EventHandler(this.AdmCamioneros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamionero)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrayecto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCamion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewCamionero;
        private System.Windows.Forms.TextBox txtTrayecto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridViewTrayecto;
    }
}