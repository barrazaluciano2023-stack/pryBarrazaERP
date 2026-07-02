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

        private void FiltrarIngresos()
        {
            string filtro = "";

            // Usuario
            if (cmbUsuarioIngresos.Text != "Todos")
            {
                filtro = $"usuario = '{cmbUsuarioIngresos.Text}'";
            }

            // Fechas
            DateTime desde = dtpDesdeIngresos.Value.Date;
            DateTime hasta = dtpHastaIngresos.Value.Date.AddDays(1).AddSeconds(-1);

            string fechaDesde =
                "#" + desde.ToString("MM/dd/yyyy HH:mm:ss") + "#";

            string fechaHasta =
                "#" + hasta.ToString("MM/dd/yyyy HH:mm:ss") + "#";

            if (filtro != "")
                filtro += " AND ";

            filtro += $"fechaHora >= {fechaDesde} AND fechaHora <= {fechaHasta}";

            dtIngresos.DefaultView.RowFilter = filtro;
        }

        private void cmbUsuarioIngresos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarIngresos();
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
            FiltrarMovimientos();
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

        private void dtpDesdeIngresos_ValueChanged(object sender, EventArgs e)
        {
            FiltrarIngresos();
        }

        private void dtpHastaIngresos_ValueChanged(object sender, EventArgs e)
        {
            FiltrarIngresos();
        }
        private void FiltrarMovimientos()
        {
            string filtro = "";

            if (cmbUsuarioMovimientos.Text != "Todos")
            {
                filtro = $"Usuario = '{cmbUsuarioMovimientos.Text}'";
            }

            DateTime desde = dtpDesdeMovimientos.Value.Date;
            DateTime hasta = dtpHastaMovimientos.Value.Date.AddDays(1).AddSeconds(-1);

            string fechaDesde =
                "#" + desde.ToString("MM/dd/yyyy HH:mm:ss") + "#";

            string fechaHasta =
                "#" + hasta.ToString("MM/dd/yyyy HH:mm:ss") + "#";

            if (filtro != "")
                filtro += " AND ";

            filtro += $"FechaHora >= {fechaDesde} AND FechaHora <= {fechaHasta}";

            dtMovimientos.DefaultView.RowFilter = filtro;
        }

        private void dtpDesdeMovimientos_ValueChanged(object sender, EventArgs e)
        {
            FiltrarMovimientos();
        }

        private void dtpHastaMovimientos_ValueChanged(object sender, EventArgs e)
        {
            FiltrarMovimientos();
        }
    }
}
