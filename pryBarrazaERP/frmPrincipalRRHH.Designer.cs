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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalRRHH));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVerInfo = new System.Windows.Forms.Button();
            this.btnInfoExtraUsuario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEditUsuario = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btmAgregarUsuario = new System.Windows.Forms.Button();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnVerInfo);
            this.panel1.Controls.Add(this.btnInfoExtraUsuario);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnEditUsuario);
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.btmAgregarUsuario);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 448);
            this.panel1.TabIndex = 13;
            // 
            // btnVerInfo
            // 
            this.btnVerInfo.Location = new System.Drawing.Point(24, 365);
            this.btnVerInfo.Name = "btnVerInfo";
            this.btnVerInfo.Size = new System.Drawing.Size(173, 23);
            this.btnVerInfo.TabIndex = 16;
            this.btnVerInfo.Text = "Ver Informacion Extra de usuario";
            this.btnVerInfo.UseVisualStyleBackColor = true;
            this.btnVerInfo.Click += new System.EventHandler(this.btnVerInfo_Click);
            // 
            // btnInfoExtraUsuario
            // 
            this.btnInfoExtraUsuario.Location = new System.Drawing.Point(24, 325);
            this.btnInfoExtraUsuario.Name = "btnInfoExtraUsuario";
            this.btnInfoExtraUsuario.Size = new System.Drawing.Size(173, 23);
            this.btnInfoExtraUsuario.TabIndex = 15;
            this.btnInfoExtraUsuario.Text = "Agregar Informacion de usuario";
            this.btnInfoExtraUsuario.UseVisualStyleBackColor = true;
            this.btnInfoExtraUsuario.Click += new System.EventHandler(this.btnInfoExtraUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryBarrazaERP.Properties.Resources.minimalist_building_logo_in_flat_style_png;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnEditUsuario
            // 
            this.btnEditUsuario.Location = new System.Drawing.Point(24, 286);
            this.btnEditUsuario.Name = "btnEditUsuario";
            this.btnEditUsuario.Size = new System.Drawing.Size(173, 23);
            this.btnEditUsuario.TabIndex = 12;
            this.btnEditUsuario.Text = "Editar Usuario";
            this.btnEditUsuario.UseVisualStyleBackColor = true;
            this.btnEditUsuario.Click += new System.EventHandler(this.btnEditUsuario_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(24, 405);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(173, 23);
            this.btnCerrarSesion.TabIndex = 10;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btmAgregarUsuario
            // 
            this.btmAgregarUsuario.Location = new System.Drawing.Point(24, 243);
            this.btmAgregarUsuario.Name = "btmAgregarUsuario";
            this.btmAgregarUsuario.Size = new System.Drawing.Size(173, 23);
            this.btmAgregarUsuario.TabIndex = 8;
            this.btmAgregarUsuario.Text = "Agregar Usuario";
            this.btmAgregarUsuario.UseVisualStyleBackColor = true;
            this.btmAgregarUsuario.Click += new System.EventHandler(this.btmAgregarUsuario_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(622, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Recursos Humanos";
            // 
            // frmPrincipalRRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBienvenido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipalRRHH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recursos Humanos";
            this.Load += new System.EventHandler(this.frmPrincipalRRHH_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditUsuario;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btmAgregarUsuario;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInfoExtraUsuario;
        private System.Windows.Forms.Button btnVerInfo;
    }
}