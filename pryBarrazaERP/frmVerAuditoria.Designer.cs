namespace pryBarrazaERP
{
    partial class frmVerAuditoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerAuditoria));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbUsuarioIngresos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtvIngresos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbUsuarioMovimientos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDesdeIngresos = new System.Windows.Forms.DateTimePicker();
            this.dtpHastaIngresos = new System.Windows.Forms.DateTimePicker();
            this.dtpHastaMovimientos = new System.Windows.Forms.DateTimePicker();
            this.dtpDesdeMovimientos = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvIngresos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 449);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtpHastaIngresos);
            this.tabPage1.Controls.Add(this.dtpDesdeIngresos);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbUsuarioIngresos);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtvIngresos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingresos al sistema";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cmbUsuarioIngresos
            // 
            this.cmbUsuarioIngresos.FormattingEnabled = true;
            this.cmbUsuarioIngresos.Location = new System.Drawing.Point(517, 22);
            this.cmbUsuarioIngresos.Name = "cmbUsuarioIngresos";
            this.cmbUsuarioIngresos.Size = new System.Drawing.Size(189, 21);
            this.cmbUsuarioIngresos.TabIndex = 3;
            this.cmbUsuarioIngresos.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarioIngresos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione el usuario:";
            // 
            // dtvIngresos
            // 
            this.dtvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvIngresos.Location = new System.Drawing.Point(24, 85);
            this.dtvIngresos.Name = "dtvIngresos";
            this.dtvIngresos.Size = new System.Drawing.Size(718, 312);
            this.dtvIngresos.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtpHastaMovimientos);
            this.tabPage2.Controls.Add(this.dtpDesdeMovimientos);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cmbUsuarioMovimientos);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dgvMovimientos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movimientos en el sistema";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbUsuarioMovimientos
            // 
            this.cmbUsuarioMovimientos.FormattingEnabled = true;
            this.cmbUsuarioMovimientos.Location = new System.Drawing.Point(550, 22);
            this.cmbUsuarioMovimientos.Name = "cmbUsuarioMovimientos";
            this.cmbUsuarioMovimientos.Size = new System.Drawing.Size(200, 21);
            this.cmbUsuarioMovimientos.TabIndex = 5;
            this.cmbUsuarioMovimientos.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarioMovimientos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione el usuario:";
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientos.Location = new System.Drawing.Point(40, 154);
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.Size = new System.Drawing.Size(675, 245);
            this.dgvMovimientos.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Desde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hasta:";
            // 
            // dtpDesdeIngresos
            // 
            this.dtpDesdeIngresos.Location = new System.Drawing.Point(156, 19);
            this.dtpDesdeIngresos.Name = "dtpDesdeIngresos";
            this.dtpDesdeIngresos.Size = new System.Drawing.Size(201, 20);
            this.dtpDesdeIngresos.TabIndex = 6;
            this.dtpDesdeIngresos.ValueChanged += new System.EventHandler(this.dtpDesdeIngresos_ValueChanged);
            // 
            // dtpHastaIngresos
            // 
            this.dtpHastaIngresos.Location = new System.Drawing.Point(156, 59);
            this.dtpHastaIngresos.Name = "dtpHastaIngresos";
            this.dtpHastaIngresos.Size = new System.Drawing.Size(201, 20);
            this.dtpHastaIngresos.TabIndex = 7;
            this.dtpHastaIngresos.ValueChanged += new System.EventHandler(this.dtpHastaIngresos_ValueChanged);
            // 
            // dtpHastaMovimientos
            // 
            this.dtpHastaMovimientos.Location = new System.Drawing.Point(115, 62);
            this.dtpHastaMovimientos.Name = "dtpHastaMovimientos";
            this.dtpHastaMovimientos.Size = new System.Drawing.Size(201, 20);
            this.dtpHastaMovimientos.TabIndex = 11;
            this.dtpHastaMovimientos.ValueChanged += new System.EventHandler(this.dtpHastaMovimientos_ValueChanged);
            // 
            // dtpDesdeMovimientos
            // 
            this.dtpDesdeMovimientos.Location = new System.Drawing.Point(115, 22);
            this.dtpDesdeMovimientos.Name = "dtpDesdeMovimientos";
            this.dtpDesdeMovimientos.Size = new System.Drawing.Size(201, 20);
            this.dtpDesdeMovimientos.TabIndex = 10;
            this.dtpDesdeMovimientos.ValueChanged += new System.EventHandler(this.dtpDesdeMovimientos_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hasta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Desde:";
            // 
            // frmVerAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVerAuditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auditoria del Sistema";
            this.Load += new System.EventHandler(this.frmVerAuditoria_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvIngresos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtvIngresos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.ComboBox cmbUsuarioIngresos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUsuarioMovimientos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHastaIngresos;
        private System.Windows.Forms.DateTimePicker dtpDesdeIngresos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHastaMovimientos;
        private System.Windows.Forms.DateTimePicker dtpDesdeMovimientos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}