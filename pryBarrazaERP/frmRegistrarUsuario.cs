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
            // TextBox
            txtNombre.TextChanged += Control_TextChanged;
            txtApellido.TextChanged += Control_TextChanged;
            txtDni.TextChanged += Control_TextChanged;
            txtUsuario.TextChanged += Control_TextChanged;
            txtContraseña.TextChanged += Control_TextChanged;
            txtDireccion.TextChanged += Control_TextChanged;
            txtMail.TextChanged += Control_TextChanged;
            txtTelefono.TextChanged += Control_TextChanged;
            txtUsuarioRedSocial.TextChanged += Control_TextChanged;

            // ComboBox
            cmbPerfil.SelectedIndexChanged += ComboBox_Changed;
            cmbProvincia.SelectedIndexChanged += ComboBox_Changed;
            cmbLocalidad.SelectedIndexChanged += ComboBox_Changed;
            cmbLocalidad.TextChanged += ComboBox_Changed;
            cmbRedSocial.SelectedIndexChanged += ComboBox_Changed;

            // Sólo números
            txtDni.KeyPress += SoloNumeros;
            txtTelefono.KeyPress += SoloNumeros;
        }

        private void Control_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text.Trim() != "")
            {
                txt.BackColor = Color.White;
                errorProvider1.SetError(txt, "");
            }
        }
        private void ComboBox_Changed(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            if (!string.IsNullOrWhiteSpace(cmb.Text))
            {
                cmb.BackColor = Color.White;
                errorProvider1.SetError(cmb, "");
            }
        }
        private void frmPersonal_Load(object sender, EventArgs e)
        {
            
        }
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // Código de WebView2 y mapa eliminado

        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CConexion conexion = new CConexion();

            cmbLocalidad.DataSource =
                conexion.ObtenerLocalidades(cmbProvincia.Text);

            cmbLocalidad.DisplayMember = "Localidad";
        }

      

        private bool ValidarCampos()
        {
            bool valido = true;
            bool hayCamposVacios = false;
            string errores = "";

            errorProvider1.Clear();

            // Restaurar colores
            LimpiarColor(this);

            // ==========================
            // DATOS PERSONALES
            // ==========================

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.BackColor = Color.LightPink;
                errorProvider1.SetError(txtNombre, "Campo obligatorio");
                hayCamposVacios = true;
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                txtApellido.BackColor = Color.LightPink;
                errorProvider1.SetError(txtApellido, "Campo obligatorio");
                hayCamposVacios = true;
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                txtDni.BackColor = Color.LightPink;
                errorProvider1.SetError(txtDni, "Campo obligatorio");
                hayCamposVacios = true;
                valido = false;
            }
            else if (txtDni.Text.Length < 7 || txtDni.Text.Length > 8)
            {
                txtDni.BackColor = Color.LightPink;
                errorProvider1.SetError(txtDni,
                    "El DNI debe tener entre 7 y 8 dígitos");

                errores += "• El DNI debe tener entre 7 y 8 dígitos.\n";
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.BackColor = Color.LightPink;
                errorProvider1.SetError(txtUsuario, "Campo obligatorio");
                hayCamposVacios = true;
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                txtContraseña.BackColor = Color.LightPink;
                errorProvider1.SetError(txtContraseña, "Campo obligatorio");
                hayCamposVacios = true;
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(cmbPerfil.Text))
            {
                cmbPerfil.BackColor = Color.LightPink;
                errorProvider1.SetError(cmbPerfil, "Campo obligatorio");
                hayCamposVacios = true;
                valido = false;
            }

            // ==========================
            // CONTACTO
            // ==========================

            if (string.IsNullOrWhiteSpace(txtMail.Text))
            {
                txtMail.BackColor = Color.LightPink;
                errorProvider1.SetError(txtMail, "Campo obligatorio");
                hayCamposVacios = true;
                valido = false;
            }
            else
            {
                try
                {
                    var mail =
                        new System.Net.Mail.MailAddress(txtMail.Text);
                }
                catch
                {
                    txtMail.BackColor = Color.LightPink;
                    errorProvider1.SetError(txtMail, "Mail inválido");

                    errores += "• El correo electrónico no es válido, .....@....com\n";
                    valido = false;
                }
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                txtTelefono.BackColor = Color.LightPink;
                errorProvider1.SetError(txtTelefono, "Campo obligatorio");
                hayCamposVacios = true;
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(cmbRedSocial.Text))
            {
                cmbRedSocial.BackColor = Color.LightPink;
                errorProvider1.SetError(cmbRedSocial, "Campo obligatorio");
                hayCamposVacios = true;
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtUsuarioRedSocial.Text))
            {
                txtUsuarioRedSocial.BackColor = Color.LightPink;
                errorProvider1.SetError(txtUsuarioRedSocial, "Campo obligatorio");
                hayCamposVacios = true;
                valido = false;
            }

            // ==========================
            // DOMICILIO
            // ==========================

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                txtDireccion.BackColor = Color.LightPink;
                errorProvider1.SetError(txtDireccion, "Campo obligatorio");
                hayCamposVacios = true;
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(cmbProvincia.Text))
            {
                cmbProvincia.BackColor = Color.LightPink;
                errorProvider1.SetError(cmbProvincia, "Campo obligatorio");
                hayCamposVacios = true;
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(cmbLocalidad.Text))
            {
                cmbLocalidad.BackColor = Color.LightPink;
                errorProvider1.SetError(cmbLocalidad, "Campo obligatorio");
                hayCamposVacios = true;
                valido = false;
            }

            // ==========================
            // MENSAJE FINAL
            // ==========================

            if (hayCamposVacios)
            {
                errores =
                    "Hay campos obligatorios sin completar.\n\n" +
                    "Revise los controles marcados en rojo.\n\n" +
                    errores;
            }

            if (!valido)
            {
                MessageBox.Show(
                    errores,
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            return valido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();

            txtMail.Clear();
            txtTelefono.Clear();
            txtUsuarioRedSocial.Clear();

            txtDireccion.Clear();

            cmbPerfil.SelectedIndex = -1;
            cmbProvincia.SelectedIndex = -1;
            cmbLocalidad.DataSource = null;
            cmbRedSocial.SelectedIndex = -1;

            chbActivo.Checked = false;

            errorProvider1.Clear();

            txtNombre.Focus();
        }



        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            CConexion conexion = new CConexion();

            if (conexion.ExisteDni(txtDni.Text))
            {
                MessageBox.Show(
                    "Ya existe un usuario con ese DNI",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idUsuario = conexion.RegistrarUsuario(
                txtNombre.Text,
                txtApellido.Text,
                txtDni.Text,
                txtUsuario.Text,
                txtContraseña.Text,
                cmbPerfil.Text,
                chbActivo.Checked);

            if (idUsuario > 0)
            {
                conexion.registrarDireccion(
                    idUsuario,
                    txtDireccion.Text,
                    cmbProvincia.Text,
                    cmbLocalidad.Text);

                conexion.registrarContacto(
                    idUsuario,
                    txtMail.Text,
                    txtTelefono.Text,
                    cmbRedSocial.Text,
                    txtUsuarioRedSocial.Text);

                MessageBox.Show(
                    "Usuario registrado correctamente");

                LimpiarCampos();
            }
        }
        private void LimpiarColor(Control control)
        {
            foreach (Control c in control.Controls)
            {
                LimpiarColor(c);
            }

            if (control is TextBox || control is ComboBox)
            {
                control.BackColor = Color.White;
            }
        }

        private void cmbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
