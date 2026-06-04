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
            CConexion conexion = new CConexion();

            conexion.RegistrarUsuario(
                txtNombre.Text,
                txtApellido.Text,
                txtDni.Text,
                txtUsuario.Text,
                txtContraseña.Text,
                cmbPerfil.Text, 
                chbActivo.Checked
            );
            conexion.registrarDireccion(
                txtDireccion.Text,
                cmbProvincia.Text,
                cmbLocalidad.Text
            );
            conexion.registrarContacto(
                txtMail.Text,
                txtTelefono.Text,
                cmbRedSocial.Text,
                txtUsuarioRedSocial.Text
            );

            MessageBox.Show("Usuario registrado correctamente");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
