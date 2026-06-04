namespace pryBarrazaERP
{
    partial class frmPrincipalRRHH
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditUsuario = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btmAgregarUsuario = new System.Windows.Forms.Button();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnEditUsuario);
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.btmAgregarUsuario);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 448);
            this.panel1.TabIndex = 13;
            // 
            // btnEditUsuario
            // 
            this.btnEditUsuario.Location = new System.Drawing.Point(26, 66);
            this.btnEditUsuario.Name = "btnEditUsuario";
            this.btnEditUsuario.Size = new System.Drawing.Size(173, 23);
            this.btnEditUsuario.TabIndex = 12;
            this.btnEditUsuario.Text = "Editar Usuario";
            this.btnEditUsuario.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(26, 119);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(173, 23);
            this.btnCerrarSesion.TabIndex = 10;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btmAgregarUsuario
            // 
            this.btmAgregarUsuario.Location = new System.Drawing.Point(26, 18);
            this.btmAgregarUsuario.Name = "btmAgregarUsuario";
            this.btmAgregarUsuario.Size = new System.Drawing.Size(173, 23);
            this.btmAgregarUsuario.TabIndex = 8;
            this.btmAgregarUsuario.Text = "Agregar Usuario";
            this.btmAgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(279, 9);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(159, 32);
            this.lblBienvenido.TabIndex = 12;
            this.lblBienvenido.Text = "Bienvenido:";
            // 
            // frmPrincipalRRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBienvenido);
            this.Name = "frmPrincipalRRHH";
            this.Text = "frmPrincipalRRHH";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditUsuario;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btmAgregarUsuario;
        private System.Windows.Forms.Label lblBienvenido;
    }
}