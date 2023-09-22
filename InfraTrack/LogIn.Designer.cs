namespace InfraTrack
{
    partial class LogIn
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
            this.btnConect = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConect
            // 
            this.btnConect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnConect.Location = new System.Drawing.Point(68, 168);
            this.btnConect.Name = "btnConect";
            this.btnConect.Size = new System.Drawing.Size(101, 40);
            this.btnConect.TabIndex = 0;
            this.btnConect.Text = "Conect";
            this.btnConect.UseVisualStyleBackColor = true;
            this.btnConect.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(102, 49);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(121, 20);
            this.txtid.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(102, 123);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(121, 20);
            this.txtpassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(243, 220);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnConect);
            this.Name = "LogIn";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConect;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

