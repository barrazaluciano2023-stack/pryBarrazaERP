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
    public partial class frmInfoExtra : Form
    {
        int idUsuario = 0;
        public frmInfoExtra()
        {
            InitializeComponent();

            this.AcceptButton = btnCargarContacto;
            this.AcceptButton = btnCargarDireccion;
        }
        
        private void frmInfoExtra_Load(object sender, EventArgs e)

        {
            CConexion conexion = new CConexion();

            cmbUsuario.DataSource =
                conexion.ObtenerUsuarios();

            cmbUsuario.DisplayMember = "UsuarioCompleto";

            cmbUsuario.ValueMember = "IdUsuario";

            cmbUsuario.SelectedIndex = -1;
            cmbLocalidad.SelectedIndex = -1;
        }
        

        private void btnCargarContacto_Click(object sender, EventArgs e)
        {

            if (cmbUsuario.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un usuario");
                return;
            }

            idUsuario =
                Convert.ToInt32(cmbUsuario.SelectedValue);

            CConexion conexion = new CConexion();

            conexion.registrarContactoExtra(
                idUsuario,
                txtMail.Text,
                txtTelefono.Text,
                cmbRedSocial.Text,
                txtUsuarioRedSocial.Text);

            MessageBox.Show(
                "Contacto registrado correctamente");
            txtMail.Clear();
            txtTelefono.Clear();
            txtUsuarioRedSocial.Clear();
            cmbRedSocial.SelectedIndex = -1;

        }

        private void btnCargarDireccion_Click(object sender, EventArgs e)
        {
            if (cmbUsuario.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un usuario");
                return;
            }

            int idUsuario =
                Convert.ToInt32(cmbUsuario.SelectedValue);

            CConexion conexion = new CConexion();

            conexion.registrarDireccion2(
                idUsuario,
                txtDireccion.Text,
                cmbProvincia.Text,
                cmbLocalidad.Text);
            txtDireccion.Clear();
            cmbProvincia.SelectedIndex = -1;
            cmbLocalidad.SelectedIndex = -1;


            MessageBox.Show(
                "Domicilio registrado correctamente");

        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CConexion conexion = new CConexion();

            cmbLocalidad.DataSource =
                conexion.ObtenerLocalidades(cmbProvincia.Text);

            cmbLocalidad.DisplayMember = "Localidad";
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
