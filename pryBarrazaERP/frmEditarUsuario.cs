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
    public partial class frmEditarUsuario : Form
    {
        public frmEditarUsuario(string usuario)
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {

            CConexion conexion = new CConexion();

            cmbUsuarios.DataSource =
                conexion.ListarUsuarios();

            cmbUsuarios.DisplayMember =
                "NombreCompleto";

            cmbUsuarios.ValueMember =
                "IdUsuario";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int idUsuario =
            Convert.ToInt32(cmbUsuarios.SelectedValue);

            CConexion conexion = new CConexion();

            DataTable tabla =
                conexion.ObtenerDatosUsuario(idUsuario);

            if (tabla.Rows.Count > 0)
            {
                DataRow fila = tabla.Rows[0];

                txtNombre.Text = fila["Nombre"].ToString();
                txtApellido.Text = fila["Apellido"].ToString();
                txtDni.Text = fila["dni"].ToString();
                txtUsuario.Text = fila["usuario"].ToString();
                txtContraseña.Text = fila["Contrasena"].ToString();

                txtMail.Text = fila["mail"].ToString();
                txtTelefono.Text = fila["telefono"].ToString();

                txtDireccion.Text = fila["direccion"].ToString();
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            int idUsuario =
            Convert.ToInt32(cmbUsuarios.SelectedValue);

            CConexion conexion = new CConexion();

            conexion.ActualizarUsuario(
                idUsuario,
                txtNombre.Text,
                txtApellido.Text,
                txtDni.Text,
                txtUsuario.Text,
                txtContraseña.Text,
                cmbPerfil.Text,
                chbActivo.Checked);

            conexion.ActualizarContacto(
                idUsuario,
                txtMail.Text,
                txtTelefono.Text,
                cmbRedSocial.Text,
                txtUsuarioRedSocial.Text);

            conexion.ActualizarDireccion(
                idUsuario,
                txtDireccion.Text,
                cmbProvincia.Text,
                cmbLocalidad.Text);
            
            MessageBox.Show("Datos actualizados correctamente");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
