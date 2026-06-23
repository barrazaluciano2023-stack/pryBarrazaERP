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
            this.AcceptButton = btnAceptar;
        }
        int intentos = 0;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            {
                CConexion conexion = new CConexion();
                clsAuditoria grabarUsuario = new clsAuditoria();

                if (txtUsuario.Text.Trim() == "" ||
                    txtContraseña.Text.Trim() == "")
                {
                    MessageBox.Show(
                        "Por favor, complete ambos campos.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtUsuario.Focus();
                    return;
                }

                string perfil =
                    conexion.ObtenerPerfil(
                        txtUsuario.Text.Trim(),
                        txtContraseña.Text.Trim());

                DateTime fechaYHora = DateTime.Now;

                if (perfil != "")
                {
                    grabarUsuario.GrabarDatos(
                        txtUsuario.Text,
                        txtContraseña.Text,
                        fechaYHora.ToString(),
                        intentos.ToString());

                    if (perfil == "admin")
                    {
                        frmPrincipalADM principal =
                            new frmPrincipalADM(txtUsuario.Text);

                        principal.Show();
                    }
                    else if (perfil == "Recursos Humanos")
                    {
                        frmPrincipalRRHH principal =
                            new frmPrincipalRRHH(txtUsuario.Text);

                        principal.Show();
                    }
                    else if (perfil == "usuario")
                    {
                        frmPrincipalUsuario principal =
                            new frmPrincipalUsuario(txtUsuario.Text);

                        principal.Show();
                    }

                    this.Hide();
                }
                else
                {
                    intentos++;
                    if (intentos >= 3)
                    {
                        MessageBox.Show(
                            "Ha superado la cantidad máxima de intentos permitidos.",
                            "Acceso bloqueado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);

                        Application.Exit();
                    }

                    MessageBox.Show(
                        "Usuario o contraseña incorrectos.",
                        "Acceso denegado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txtContraseña.Clear();
                    txtContraseña.Focus();
                }
            }
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {

            DialogResult respuesta = MessageBox.Show(
                "¿Desea salir del sistema?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chbVerContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVerContraseña.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }
    }
}


