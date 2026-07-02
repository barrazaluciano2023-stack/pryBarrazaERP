namespace pryBarrazaERP
{
    partial class frmVerInfoExtra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerInfoExtra));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.dgvContactoExtra = new System.Windows.Forms.DataGridView();
            this.dgvDomiciliosExtras = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactoExtra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomiciliosExtras)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbUsuario);
            this.groupBox3.Location = new System.Drawing.Point(60, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(635, 80);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccione el usuario al que desea cargar información extra";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(38, 36);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(539, 21);
            this.cmbUsuario.TabIndex = 0;
            this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
            // 
            // dgvContactoExtra
            // 
            this.dgvContactoExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactoExtra.Location = new System.Drawing.Point(74, 123);
            this.dgvContactoExtra.Name = "dgvContactoExtra";
            this.dgvContactoExtra.Size = new System.Drawing.Size(680, 142);
            this.dgvContactoExtra.TabIndex = 2;
            // 
            // dgvDomiciliosExtras
            // 
            this.dgvDomiciliosExtras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDomiciliosExtras.Location = new System.Drawing.Point(74, 296);
            this.dgvDomiciliosExtras.Name = "dgvDomiciliosExtras";
            this.dgvDomiciliosExtras.Size = new System.Drawing.Size(680, 142);
            this.dgvDomiciliosExtras.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Medios de contacto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Domicilios:";
            // 
            // frmVerInfoExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDomiciliosExtras);
            this.Controls.Add(this.dgvContactoExtra);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVerInfoExtra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "informacion extra de usuario";
            this.Load += new System.EventHandler(this.frmVerInfoExtra_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactoExtra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomiciliosExtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.DataGridView dgvContactoExtra;
        private System.Windows.Forms.DataGridView dgvDomiciliosExtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}