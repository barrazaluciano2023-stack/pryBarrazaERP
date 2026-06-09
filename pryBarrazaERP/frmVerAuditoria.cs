using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBarrazaERP
{
    public partial class frmVerAuditoria : Form
    {
        public frmVerAuditoria()
        {
            InitializeComponent();
        }
        DataTable dtIngresos = new DataTable();
        DataTable dtMovimientos = new DataTable();


        private void frmVerAuditoria_Load(object sender, EventArgs e)
        {
            clsAuditoria auditoria = new clsAuditoria();

            // Cargar ingresos
            dtIngresos = auditoria.ObtenerIngresos();
            dtvIngresos.DataSource = dtIngresos;

            // Cargar movimientos
            dtMovimientos = auditoria.ObtenerMovimientos();
            dgvMovimientos.DataSource = dtMovimientos;




            DataTable usuarios = auditoria.ObtenerUsuarios();

            // Agregar opción Todos
            DataRow fila = usuarios.NewRow();
            fila["usuario"] = "Todos";

            usuarios.Rows.InsertAt(fila, 0);

            cmbUsuarioIngresos.DataSource = usuarios.Copy();
            cmbUsuarioIngresos.DisplayMember = "usuario";

            cmbUsuarioMovimientos.DataSource = usuarios.Copy();
            cmbUsuarioMovimientos.DisplayMember = "usuario";
        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cmbUsuarioIngresos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtIngresos.Rows.Count > 0)
            {
                if (cmbUsuarioIngresos.Text == "Todos")
                {
                    dtIngresos.DefaultView.RowFilter = "";
                }
                else
                {
                    dtIngresos.DefaultView.RowFilter =
                        $"usuario = '{cmbUsuarioIngresos.Text}'";
                }
            }
        }

        private void cmbUsuarioMovimientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtMovimientos.Rows.Count > 0)
            {
                if (cmbUsuarioMovimientos.Text == "Todos")
                {
                    dtMovimientos.DefaultView.RowFilter = "";
                }
                else
                {
                    dtMovimientos.DefaultView.RowFilter =
                        $"Usuario = '{cmbUsuarioMovimientos.Text}'";
                }
            }
        }
    }
}
