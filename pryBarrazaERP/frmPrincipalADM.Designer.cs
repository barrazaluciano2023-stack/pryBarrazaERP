namespace pryBarrazaERP
{
    partial class frmPrincipalADM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        
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
            this.components = new System.ComponentModel.Container();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.btmAgregarUsuario = new System.Windows.Forms.Button();
            this.btnVerAuditoria = new System.Windows.Forms.Button();
            this.btnCerrasSesion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditUsuario = new System.Windows.Forms.Button();
            this.btnEditarPerfilUsuario = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(12, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(10, 13);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = ".";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(279, 9);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(159, 32);
            this.lblBienvenido.TabIndex = 6;
            this.lblBienvenido.Text = "Bienvenido:";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(638, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(10, 13);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = ".";
            // 
            // btmAgregarUsuario
            // 
            this.btmAgregarUsuario.Location = new System.Drawing.Point(26, 18);
            this.btmAgregarUsuario.Name = "btmAgregarUsuario";
            this.btmAgregarUsuario.Size = new System.Drawing.Size(173, 23);
            this.btmAgregarUsuario.TabIndex = 8;
            this.btmAgregarUsuario.Text = "Agregar Usuario";
            this.btmAgregarUsuario.UseVisualStyleBackColor = true;
            this.btmAgregarUsuario.Click += new System.EventHandler(this.btmAgregarUsuario_Click);
            // 
            // btnVerAuditoria
            // 
            this.btnVerAuditoria.Location = new System.Drawing.Point(26, 67);
            this.btnVerAuditoria.Name = "btnVerAuditoria";
            this.btnVerAuditoria.Size = new System.Drawing.Size(173, 23);
            this.btnVerAuditoria.TabIndex = 11;
            this.btnVerAuditoria.Text = "Ver Tabla Auditoria";
            this.btnVerAuditoria.UseVisualStyleBackColor = true;
            this.btnVerAuditoria.Click += new System.EventHandler(this.btnVerAuditoria_Click);
            // 
            // btnCerrasSesion
            // 
            this.btnCerrasSesion.Location = new System.Drawing.Point(26, 415);
            this.btnCerrasSesion.Name = "btnCerrasSesion";
            this.btnCerrasSesion.Size = new System.Drawing.Size(173, 23);
            this.btnCerrasSesion.TabIndex = 10;
            this.btnCerrasSesion.Text = "Cerrar Sesión";
            this.btnCerrasSesion.UseVisualStyleBackColor = true;
            this.btnCerrasSesion.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnEditarPerfilUsuario);
            this.panel1.Controls.Add(this.btnEditUsuario);
            this.panel1.Controls.Add(this.btnCerrasSesion);
            this.panel1.Controls.Add(this.btnVerAuditoria);
            this.panel1.Controls.Add(this.btmAgregarUsuario);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 448);
            this.panel1.TabIndex = 11;
            // 
            // btnEditUsuario
            // 
            this.btnEditUsuario.Location = new System.Drawing.Point(26, 120);
            this.btnEditUsuario.Name = "btnEditUsuario";
            this.btnEditUsuario.Size = new System.Drawing.Size(173, 23);
            this.btnEditUsuario.TabIndex = 12;
            this.btnEditUsuario.Text = "Editar Usuario";
            this.btnEditUsuario.UseVisualStyleBackColor = true;
            // 
            // btnEditarPerfilUsuario
            // 
            this.btnEditarPerfilUsuario.Location = new System.Drawing.Point(26, 168);
            this.btnEditarPerfilUsuario.Name = "btnEditarPerfilUsuario";
            this.btnEditarPerfilUsuario.Size = new System.Drawing.Size(173, 23);
            this.btnEditarPerfilUsuario.TabIndex = 13;
            this.btnEditarPerfilUsuario.Text = "Editar Perfil de usuario";
            this.btnEditarPerfilUsuario.UseVisualStyleBackColor = true;
            this.btnEditarPerfilUsuario.Click += new System.EventHandler(this.btnEditarPerfilUsuario_Click);
            // 
            // frmPrincipalADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.lblHora);
            this.Name = "frmPrincipalADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "principal";
            this.Load += new System.EventHandler(this.principal_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btmAgregarUsuario;
        private System.Windows.Forms.Button btnVerAuditoria;
        private System.Windows.Forms.Button btnCerrasSesion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditUsuario;
        private System.Windows.Forms.Button btnEditarPerfilUsuario;
    }
}