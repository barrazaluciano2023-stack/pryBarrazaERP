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
    public partial class frmPrincipalRRHH : Form
    {
        string usuario;
        public frmPrincipalRRHH(string nombreUsuario)
        {
            InitializeComponent();
            usuario = nombreUsuario;
            lblBienvenido.Text = "Bienvenido: " + usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            MessageBox.Show("Sesion Cerrada con exito");
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void frmPrincipalRRHH_Load(object sender, EventArgs e)
        {

        }

        private void btmAgregarUsuario_Click(object sender, EventArgs e)
        {
            frmRegistrarUsuario registrarUsuario = new frmRegistrarUsuario();
            registrarUsuario.ShowDialog();
        }

        private void btnEditUsuario_Click(object sender, EventArgs e)
        {
            frmEditarUsuario editarUsuario = new frmEditarUsuario(usuario);
            editarUsuario.ShowDialog();
        }
    }
}
