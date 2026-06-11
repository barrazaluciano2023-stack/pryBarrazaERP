using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// WebView2 eliminado

namespace pryBarrazaERP
{
    public partial class frmRegistrarUsuario : Form
    {
        // Campos de coordenadas eliminados (antes usados por WebView2)

        public frmRegistrarUsuario()
        {
            InitializeComponent();
            // Mapa eliminado
        }
        

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            
        }
        // Código de WebView2 y mapa eliminado

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CConexion conexion = new CConexion();

            cmbLocalidad.DataSource =
                conexion.ObtenerLocalidades(cmbProvincia.Text);

            cmbLocalidad.DisplayMember = "Localidad";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmInfoExtra frmInfoExtra = new frmInfoExtra();
            frmInfoExtra.ShowDialog();
           
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
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
            CConexion conexion = new CConexion();

            int idUsuario = conexion.RegistrarUsuario(
                txtNombre.Text,
                txtApellido.Text,
                txtDni.Text,
                txtUsuario.Text,
                txtContraseña.Text,
                cmbPerfil.Text,
                chbActivo.Checked
            );

            if (idUsuario > 0)
            {
                conexion.registrarDireccion(
                    idUsuario,
                    txtDireccion.Text,
                    cmbProvincia.Text,
                    cmbLocalidad.Text
                );

                conexion.registrarContacto(
                    idUsuario,
                    txtMail.Text,
                    txtTelefono.Text,
                    cmbRedSocial.Text,
                    txtUsuarioRedSocial.Text
                );

                MessageBox.Show("Usuario registrado correctamente");
                this.Close();
            }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCargarContacto_Click(object sender, EventArgs e)
        {
            CConexion conexion = new CConexion();

            int idUsuario =
                conexion.ObtenerIdUsuarioPorDni(txtDni.Text);

            if (idUsuario == 0)
            {
                MessageBox.Show("No existe un usuario con ese DNI");
                return;
            }

            conexion.registrarContactoExtra(
                idUsuario,
                txtMail.Text,
                txtTelefono.Text,
                cmbRedSocial.Text
            );

            MessageBox.Show("Contacto Extra registrado");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CConexion conexion = new CConexion();

            int idUsuario =
                conexion.ObtenerIdUsuarioPorDni(txtDni.Text);

            if (idUsuario == 0)
            {
                MessageBox.Show("No existe un usuario con ese DNI");
                return;
            }

            conexion.registrarDireccion2(
                idUsuario,
                txtDireccion.Text,
                cmbProvincia.Text,
                cmbLocalidad.Text
            );

            MessageBox.Show("Domicilio Extra registrado");
        }
    }
}
