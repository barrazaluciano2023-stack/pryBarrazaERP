namespace pryBarrazaERP
{
    partial class frmRegistrarUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUsuarioRedSocial = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbRedSocial = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chbActivo = new System.Windows.Forms.CheckBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(159, 112);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(212, 20);
            this.txtDni.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(161, 75);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(212, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(161, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(212, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbProvincia);
            this.groupBox1.Controls.Add(this.cmbLocalidad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(426, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 137);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Domicilio:";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Items.AddRange(new object[] {
            "Buenos Aires",
            "Catamarca",
            "Chaco",
            "Chubut",
            "Córdoba",
            "Corrientes",
            "Entre Ríos",
            "Formosa",
            "Jujuy",
            "La Pampa",
            "La Rioja",
            "Mendoza",
            "Misiones",
            "Neuquén",
            "Río Negro",
            "Salta",
            "San Juan",
            "San Luis",
            "Santa Cruz",
            "Santa Fe",
            "Santiago del Estero",
            "Tierra del Fuego",
            "Tucumán"});
            this.cmbProvincia.Location = new System.Drawing.Point(203, 62);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(86, 21);
            this.cmbProvincia.TabIndex = 1;
            this.cmbProvincia.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(204, 105);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(86, 21);
            this.cmbLocalidad.TabIndex = 2;
            this.cmbLocalidad.SelectedIndexChanged += new System.EventHandler(this.cmbLocalidad_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Provincia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Localidad:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(160, 18);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(130, 20);
            this.txtDireccion.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dirección:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUsuarioRedSocial);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbRedSocial);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtMail);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(426, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 162);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contacto:";
            // 
            // txtUsuarioRedSocial
            // 
            this.txtUsuarioRedSocial.Location = new System.Drawing.Point(182, 121);
            this.txtUsuarioRedSocial.Name = "txtUsuarioRedSocial";
            this.txtUsuarioRedSocial.Size = new System.Drawing.Size(121, 20);
            this.txtUsuarioRedSocial.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Usuario red social:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(201, 49);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Telefono:";
            // 
            // cmbRedSocial
            // 
            this.cmbRedSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRedSocial.FormattingEnabled = true;
            this.cmbRedSocial.Items.AddRange(new object[] {
            "Instagram",
            "Twiter",
            "Facebook"});
            this.cmbRedSocial.Location = new System.Drawing.Point(180, 84);
            this.cmbRedSocial.Name = "cmbRedSocial";
            this.cmbRedSocial.Size = new System.Drawing.Size(121, 21);
            this.cmbRedSocial.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Red Social:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(201, 17);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mail:";
            // 
            // chbActivo
            // 
            this.chbActivo.AutoSize = true;
            this.chbActivo.Location = new System.Drawing.Point(276, 261);
            this.chbActivo.Name = "chbActivo";
            this.chbActivo.Size = new System.Drawing.Size(95, 17);
            this.chbActivo.TabIndex = 3;
            this.chbActivo.Text = "Usuario Activo";
            this.chbActivo.UseVisualStyleBackColor = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(161, 145);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(212, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Usuario:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(161, 183);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(212, 20);
            this.txtContraseña.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Contraseña:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 227);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Perfil:";
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Items.AddRange(new object[] {
            "admin",
            "usuario",
            "Recursos Humanos"});
            this.cmbPerfil.Location = new System.Drawing.Point(170, 219);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(203, 21);
            this.cmbPerfil.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbPerfil);
            this.groupBox3.Controls.Add(this.chbActivo);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtContraseña);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtUsuario);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.txtApellido);
            this.groupBox3.Controls.Add(this.txtDni);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(25, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 284);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Personales";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(495, 406);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(615, 406);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(128, 23);
            this.btnRegistrarUsuario.TabIndex = 3;
            this.btnRegistrarUsuario.Text = "Registrar Usuario";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = true;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // frmRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.btnRegistrarUsuario);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regitrar un nuevo usuario";
            this.Load += new System.EventHandler(this.frmPersonal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        // WebView2 eliminado
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbActivo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbRedSocial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtUsuarioRedSocial;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrarUsuario;
    }
}