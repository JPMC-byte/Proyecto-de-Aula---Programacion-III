namespace Clinica
{
    partial class FrmContraseña
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EntrarSistema = new System.Windows.Forms.Button();
            this.txtContraseñasistema = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.EntrarSistema);
            this.groupBox1.Controls.Add(this.txtContraseñasistema);
            this.groupBox1.Location = new System.Drawing.Point(22, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese la Contraseña";
            // 
            // EntrarSistema
            // 
            this.EntrarSistema.Location = new System.Drawing.Point(71, 84);
            this.EntrarSistema.Name = "EntrarSistema";
            this.EntrarSistema.Size = new System.Drawing.Size(75, 23);
            this.EntrarSistema.TabIndex = 1;
            this.EntrarSistema.Text = "Entrar";
            this.EntrarSistema.UseVisualStyleBackColor = true;
            this.EntrarSistema.Click += new System.EventHandler(this.EntrarSistema_Click);
            // 
            // txtContraseñasistema
            // 
            this.txtContraseñasistema.Location = new System.Drawing.Point(52, 46);
            this.txtContraseñasistema.Name = "txtContraseñasistema";
            this.txtContraseñasistema.PasswordChar = '*';
            this.txtContraseñasistema.Size = new System.Drawing.Size(125, 20);
            this.txtContraseñasistema.TabIndex = 0;
            // 
            // FrmContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 173);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmContraseña";
            this.Text = "Contraseña";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtContraseñasistema;
        private System.Windows.Forms.Button EntrarSistema;
    }
}