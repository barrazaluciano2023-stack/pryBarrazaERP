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
    public partial class frmLogin : Form

    {
        public frmLogin()
        {
            InitializeComponent();
        }
        int intentos = 0;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CConexion conexion = new CConexion();

            if (txtUsuario.Text == "" || txtContraseña.Text == "")
            {
                MessageBox.Show("Por favor, complete ambos campos.");
                txtUsuario.Focus();
                return;
            }
            bool acceso = conexion.login(txtUsuario.Text, txtContraseña.Text);
            if (acceso == true)
            {

                frmPrincipal principal = new frmPrincipal(txtUsuario.Text);
                principal.Show();

                this.Hide();//Cierra el formulario de login pero no la aplicación
            }
            else
            {
                intentos++;

                MessageBox.Show("Datos incorrectos ");

                txtUsuario.Clear();
                txtContraseña.Clear();
                txtUsuario.Focus();

                if (intentos >= 3)
                {
                    MessageBox.Show("Excediste el numero de intentos");
                    Application.Exit();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


