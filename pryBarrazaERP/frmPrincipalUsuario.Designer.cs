namespace pryBarrazaERP
{
    partial class frmPrincipalUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEditInformacionPersonal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnEditInformacionPersonal);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 448);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryBarrazaERP.Properties.Resources.minimalist_building_logo_in_flat_style_png;
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnEditInformacionPersonal
            // 
            this.btnEditInformacionPersonal.Location = new System.Drawing.Point(22, 283);
            this.btnEditInformacionPersonal.Name = "btnEditInformacionPersonal";
            this.btnEditInformacionPersonal.Size = new System.Drawing.Size(173, 23);
            this.btnEditInformacionPersonal.TabIndex = 12;
            this.btnEditInformacionPersonal.Text = "Editar Informacion Personal";
            this.btnEditInformacionPersonal.UseVisualStyleBackColor = true;
            this.btnEditInformacionPersonal.Click += new System.EventHandler(this.btnEditUsuario_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cerrar Sesión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(280, 9);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(159, 32);
            this.lblBienvenido.TabIndex = 12;
            this.lblBienvenido.Text = "Bienvenido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(721, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Usuario";
            // 
            // frmPrincipalUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBienvenido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipalUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.frmPrincipalUsuario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditInformacionPersonal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}