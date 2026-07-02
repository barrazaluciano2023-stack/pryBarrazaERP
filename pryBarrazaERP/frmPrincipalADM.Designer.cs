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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalADM));
            this.lblHora = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.btmAgregarUsuario = new System.Windows.Forms.Button();
            this.btnVerAuditoria = new System.Windows.Forms.Button();
            this.btnCerrasSesion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInfoExtraUsuario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEditUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerInfo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btmAgregarUsuario.Location = new System.Drawing.Point(26, 233);
            this.btmAgregarUsuario.Name = "btmAgregarUsuario";
            this.btmAgregarUsuario.Size = new System.Drawing.Size(173, 23);
            this.btmAgregarUsuario.TabIndex = 8;
            this.btmAgregarUsuario.Text = "Agregar Usuario";
            this.btmAgregarUsuario.UseVisualStyleBackColor = true;
            this.btmAgregarUsuario.Click += new System.EventHandler(this.btmAgregarUsuario_Click);
            // 
            // btnVerAuditoria
            // 
            this.btnVerAuditoria.Location = new System.Drawing.Point(26, 386);
            this.btnVerAuditoria.Name = "btnVerAuditoria";
            this.btnVerAuditoria.Size = new System.Drawing.Size(173, 23);
            this.btnVerAuditoria.TabIndex = 11;
            this.btnVerAuditoria.Text = "Ver Tabla Auditoria";
            this.btnVerAuditoria.UseVisualStyleBackColor = true;
            this.btnVerAuditoria.Click += new System.EventHandler(this.btnVerAuditoria_Click);
            // 
            // btnCerrasSesion
            // 
            this.btnCerrasSesion.Location = new System.Drawing.Point(26, 422);
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
            this.panel1.Controls.Add(this.btnVerInfo);
            this.panel1.Controls.Add(this.btnInfoExtraUsuario);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnEditUsuario);
            this.panel1.Controls.Add(this.btnCerrasSesion);
            this.panel1.Controls.Add(this.btnVerAuditoria);
            this.panel1.Controls.Add(this.btmAgregarUsuario);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 448);
            this.panel1.TabIndex = 11;
            // 
            // btnInfoExtraUsuario
            // 
            this.btnInfoExtraUsuario.Location = new System.Drawing.Point(26, 310);
            this.btnInfoExtraUsuario.Name = "btnInfoExtraUsuario";
            this.btnInfoExtraUsuario.Size = new System.Drawing.Size(173, 23);
            this.btnInfoExtraUsuario.TabIndex = 14;
            this.btnInfoExtraUsuario.Text = "Agregar Informacion de usuario";
            this.btnInfoExtraUsuario.UseVisualStyleBackColor = true;
            this.btnInfoExtraUsuario.Click += new System.EventHandler(this.btnInfoExtraUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryBarrazaERP.Properties.Resources.minimalist_building_logo_in_flat_style_png;
            this.pictureBox1.Location = new System.Drawing.Point(15, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnEditUsuario
            // 
            this.btnEditUsuario.Location = new System.Drawing.Point(26, 272);
            this.btnEditUsuario.Name = "btnEditUsuario";
            this.btnEditUsuario.Size = new System.Drawing.Size(173, 23);
            this.btnEditUsuario.TabIndex = 12;
            this.btnEditUsuario.Text = "Editar Usuario";
            this.btnEditUsuario.UseVisualStyleBackColor = true;
            this.btnEditUsuario.Click += new System.EventHandler(this.btnEditUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(660, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Administrador";
            // 
            // btnVerInfo
            // 
            this.btnVerInfo.Location = new System.Drawing.Point(26, 348);
            this.btnVerInfo.Name = "btnVerInfo";
            this.btnVerInfo.Size = new System.Drawing.Size(173, 23);
            this.btnVerInfo.TabIndex = 17;
            this.btnVerInfo.Text = "Ver Informacion Extra de usuario";
            this.btnVerInfo.UseVisualStyleBackColor = true;
            this.btnVerInfo.Click += new System.EventHandler(this.btnVerInfo_Click);
            // 
            // frmPrincipalADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.lblHora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipalADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.principal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInfoExtraUsuario;
        private System.Windows.Forms.Button btnVerInfo;
    }
}