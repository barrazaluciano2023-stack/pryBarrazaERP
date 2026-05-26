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
            this.dtvIngresos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtvIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvIngresos
            // 
            this.dtvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvIngresos.Location = new System.Drawing.Point(12, 76);
            this.dtvIngresos.Name = "dtvIngresos";
            this.dtvIngresos.Size = new System.Drawing.Size(785, 371);
            this.dtvIngresos.TabIndex = 0;
            // 
            // frmVerAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtvIngresos);
            this.Name = "frmVerAuditoria";
            this.Text = "frmVerAuditoria";
            this.Load += new System.EventHandler(this.frmVerAuditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvIngresos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvIngresos;
    }
}