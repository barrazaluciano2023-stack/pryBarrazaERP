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
        
        public frmInfoExtra()
        {
            InitializeComponent();
        }
        
        private void frmInfoExtra_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarContacto_Click(object sender, EventArgs e)
        {
            CConexion conexion = new CConexion();

            int idUsuario =
                conexion.ObtenerIdUsuarioPorDni(txtDniContacto.Text);

            if (idUsuario == 0)
            {
                MessageBox.Show("No existe un usuario con ese DNI");
                return;
            }

            conexion.registrarContactoExtra(
                idUsuario,
                txtMailextra.Text,
                txtTelefonoExtra.Text,
                cmbRedSocialextra.Text
            );

            MessageBox.Show("Contacto Extra registrado");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CConexion conexion = new CConexion();

            int idUsuario =
                conexion.ObtenerIdUsuarioPorDni(txtdniDomicilio.Text);

            if (idUsuario == 0)
            {
                MessageBox.Show("No existe un usuario con ese DNI");
                return;
            }

            conexion.registrarDireccion2(
                idUsuario,
                txtDireccionExtra.Text,
                cmbProvinciaExtra.Text,
                cmbLocalidadExtra.Text
            );

            MessageBox.Show("Domicilio Extra registrado");
        }
    }
}
