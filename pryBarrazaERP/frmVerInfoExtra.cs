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
    public partial class frmVerInfoExtra : Form
       
    {
        string usuario;
        CConexion conexion = new CConexion();
        public frmVerInfoExtra(string nombreUsuario)
        {
            InitializeComponent();
            usuario = nombreUsuario;
        }
        
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void frmVerInfoExtra_Load(object sender, EventArgs e)
        {
            cmbUsuario.SelectedIndexChanged += cmbUsuario_SelectedIndexChanged;

            cmbUsuario.DataSource =
                conexion.ObtenerUsuarios();

            cmbUsuario.DisplayMember = "UsuarioCompleto";

            cmbUsuario.ValueMember = "IdUsuario";

            cmbUsuario.SelectedIndex = -1;
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsuario.SelectedValue == null)
                return;

            if (cmbUsuario.SelectedValue is DataRowView)
                return;

            int idUsuario = Convert.ToInt32(cmbUsuario.SelectedValue);

            dgvContactoExtra.DataSource = conexion.ObtenerContactosExtras(idUsuario);
            dgvDomiciliosExtras.DataSource = conexion.ObtenerDomiciliosExtras(idUsuario);
        }
        
    }
}
