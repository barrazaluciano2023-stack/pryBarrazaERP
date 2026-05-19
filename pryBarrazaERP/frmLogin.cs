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
            while (intentos < 3)
            {
                if (txtUsuario.Text == "admin" && txtContraseña.Text == "admin" && txtUsuario.Text != "" && txtContraseña.Text != "")
                {
                    MessageBox.Show("Bienvenido al sistema");
                    frmPrincipal principal = new frmPrincipal();
                    principal.Show();
                    this.Hide();
                    break;
                }
                else
                {
                    if (txtUsuario.Text == "" || txtContraseña.Text == "")
                    {
                        MessageBox.Show("Por favor, complete ambos campos.");
                        txtUsuario.Focus();
                        break;
                    }
                    intentos++;
                    MessageBox.Show("Usuario o contraseña incorrectos. Intento " + intentos + " de 3.");
                    txtUsuario.Clear();
                    txtContraseña.Clear();
                    txtUsuario.Focus();
                    break;
                }
            }
            if (intentos > 3)
            {
                MessageBox.Show("Has excedido el número de intentos. El programa se cerrará.");
                Application.Exit();
            }
        }
    }
}
