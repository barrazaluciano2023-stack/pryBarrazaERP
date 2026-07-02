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
        String usuario = "";
        clsAuditoria auditoria = new clsAuditoria();
        public frmEditarUsuario(string usuarioCargado)
        {
            InitializeComponent();
            this.AcceptButton = btnGuardarCambios;
            usuario = usuarioCargado;
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
            cmbUsuarios.SelectedIndex = -1;


            auditoria.GrabarMovimiento(
                usuario,
                "frmEditarUsuario",
                "Abrio formulario de Editar Usuario");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int idUsuario =
            Convert.ToInt32(cmbUsuarios.SelectedValue);

            CConexion conexion = new CConexion();

            DataTable tabla = conexion.ObtenerDatosUsuario(idUsuario);

            if (tabla.Rows.Count > 0)
            {
                DataRow fila = tabla.Rows[0];

                txtNombre.Text = fila["Nombre"].ToString();
                txtApellido.Text = fila["Apellido"].ToString();
                txtDni.Text = fila["dni"].ToString();
                txtUsuario.Text = fila["usuario"].ToString();
                txtContraseña.Text = fila["Contrasena"].ToString();
                cmbPerfil.Text = fila["Perfil"].ToString();
                chbActivo.Checked = Convert.ToBoolean(fila["Activo"]);


                txtMail.Text = fila["mail"].ToString();
                txtTelefono.Text = fila["telefono"].ToString();
                cmbRedSocial.Text= fila["redSocial"].ToString();
                txtUsuarioRedSocial.Text= fila["usuarioRedSocial"].ToString();

                txtDireccion.Text = fila["direccion"].ToString();
                cmbProvincia.Text = fila["provincia"].ToString();
                cmbLocalidad.Text = fila["localidad"].ToString();
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show(
                    "Debe completar todos los campos obligatorios",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
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

            auditoria.GrabarMovimiento(
                usuario,
                "frmEditarUsuario",
                "Edito el usuario de id:" + idUsuario);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CConexion conexion = new CConexion();

            cmbLocalidad.DataSource =
                conexion.ObtenerLocalidades(cmbProvincia.Text);

            cmbLocalidad.DisplayMember = "Localidad";
        }

        private bool ValidarCampos()
        {
            bool valido = true;

            errorProvider1.Clear();

            // Restaurar colores
            txtNombre.BackColor = Color.White;
            txtApellido.BackColor = Color.White;
            txtDni.BackColor = Color.White;
            txtUsuario.BackColor = Color.White;
            txtContraseña.BackColor = Color.White;
            txtDireccion.BackColor = Color.White;
            txtMail.BackColor = Color.White;
            txtTelefono.BackColor = Color.White;
            txtUsuarioRedSocial.BackColor = Color.White;

            cmbPerfil.BackColor = Color.White;
            cmbProvincia.BackColor = Color.White;
            cmbLocalidad.BackColor = Color.White;
            cmbRedSocial.BackColor = Color.White;

            // Validaciones

            if (txtNombre.Text.Trim() == "")
            {
                txtNombre.BackColor = Color.LightPink;
                errorProvider1.SetError(txtNombre, "Ingrese un nombre");
                valido = false;
            }

            if (txtApellido.Text.Trim() == "")
            {
                txtApellido.BackColor = Color.LightPink;
                errorProvider1.SetError(txtApellido, "Ingrese un apellido");
                valido = false;
            }

            if (txtDni.Text.Trim() == "")
            {
                txtDni.BackColor = Color.LightPink;
                errorProvider1.SetError(txtDni, "Ingrese un DNI");
                valido = false;
            }

            if (txtUsuario.Text.Trim() == "")
            {
                txtUsuario.BackColor = Color.LightPink;
                errorProvider1.SetError(txtUsuario, "Ingrese un usuario");
                valido = false;
            }

            if (txtContraseña.Text.Trim() == "")
            {
                txtContraseña.BackColor = Color.LightPink;
                errorProvider1.SetError(txtContraseña, "Ingrese una contraseña");
                valido = false;
            }

            if (cmbPerfil.Text == "")
            {
                cmbPerfil.BackColor = Color.LightPink;
                errorProvider1.SetError(cmbPerfil, "Seleccione un perfil");
                valido = false;
            }

            if (txtDireccion.Text.Trim() == "")
            {
                txtDireccion.BackColor = Color.LightPink;
                errorProvider1.SetError(txtDireccion, "Ingrese una dirección");
                valido = false;
            }

            if (cmbProvincia.Text == "")
            {
                cmbProvincia.BackColor = Color.LightPink;
                errorProvider1.SetError(cmbProvincia, "Seleccione una provincia");
                valido = false;
            }

            if (cmbLocalidad.Text == "")
            {
                cmbLocalidad.BackColor = Color.LightPink;
                errorProvider1.SetError(cmbLocalidad, "Seleccione una localidad");
                valido = false;
            }

            if (txtMail.Text.Trim() == "")
            {
                txtMail.BackColor = Color.LightPink;
                errorProvider1.SetError(txtMail, "Ingrese un mail");
                valido = false;
            }

            if (txtTelefono.Text.Trim() == "")
            {
                txtTelefono.BackColor = Color.LightPink;
                errorProvider1.SetError(txtTelefono, "Ingrese un teléfono");
                valido = false;
            }

            if (cmbRedSocial.Text == "")
            {
                cmbRedSocial.BackColor = Color.LightPink;
                errorProvider1.SetError(cmbRedSocial, "Seleccione una red social");
                valido = false;
            }

            if (txtUsuarioRedSocial.Text.Trim() == "")
            {
                txtUsuarioRedSocial.BackColor = Color.LightPink;
                errorProvider1.SetError(txtUsuarioRedSocial, "Ingrese el usuario de la red social");
                valido = false;
            }

            return valido;
        }

        private void ValidarControl(Control control, ref bool valido)
        {
            // Recorrer controles dentro de GroupBox
            foreach (Control c in control.Controls)
            {
                ValidarControl(c, ref valido);
            }

            if (control is TextBox)
            {
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    control.BackColor = Color.LightPink;
                    errorProvider1.SetError(control, "Campo obligatorio");
                    valido = false;
                }
                else
                {
                    control.BackColor = Color.White;
                    errorProvider1.SetError(control, "");
                }
            }

            if (control is ComboBox)
            {
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    control.BackColor = Color.LightPink;
                    errorProvider1.SetError(control, "Seleccione una opción");
                    valido = false;
                }
                else
                {
                    control.BackColor = Color.White;
                    errorProvider1.SetError(control, "");
                }
            }
        }

    }
}
