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
    public partial class frmActualizarMiPerfil : Form
    {
        private string usuarioLogueado;
        private int idUsuario;

        public frmActualizarMiPerfil(string usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
            txtDni.Enabled = false;
            cmbPerfil.Enabled = false;
            chbActivo.Enabled = false;
            this.AcceptButton = btnGuardarCambios;

        }

        private void frmActualizarMiPerfil_Load(object sender, EventArgs e)
        {
            clsAuditoria auditoria = new clsAuditoria();


            CConexion conexion = new CConexion();

            idUsuario =
                conexion.ObtenerIdUsuarioPorNombreUsuario(usuarioLogueado);

            DataTable tabla =
                conexion.ObtenerDatosUsuario(idUsuario);

            if (tabla.Rows.Count > 0)
            {
                DataRow fila = tabla.Rows[0];

                txtNombre.Text = fila["Nombre"].ToString();
                txtApellido.Text = fila["Apellido"].ToString();
                txtDni.Text = fila["DNI"].ToString();
                txtUsuario.Text = fila["usuario"].ToString();
                txtContraseña.Text = fila["Contrasena"].ToString();

                cmbPerfil.Text = fila["Perfil"].ToString();

                chbActivo.Checked =
                    Convert.ToBoolean(fila["activo"]);

                txtDireccion.Text =
                    fila["direccion"].ToString();

                cmbProvincia.Text =
                    fila["provincia"].ToString();

                cmbLocalidad.Text =
                    fila["localidad"].ToString();

                txtMail.Text =
                    fila["mail"].ToString();

                txtTelefono.Text =
                    fila["telefono"].ToString();

                cmbRedSocial.Text =
                    fila["redSocial"].ToString();

                txtUsuarioRedSocial.Text =
                    fila["usuarioRedSocial"].ToString();
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
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

            MessageBox.Show(
                "Datos actualizados correctamente",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Close();
            clsAuditoria auditoria = new clsAuditoria();



            auditoria.GrabarMovimiento(
                usuarioLogueado,
                "frmActualizarMiPerfil",
                "Edito su perfil");
        }

        private void btnCancelar_Click(object sender, EventArgs e) 
        {
            this.Close();
        }
    }
}
