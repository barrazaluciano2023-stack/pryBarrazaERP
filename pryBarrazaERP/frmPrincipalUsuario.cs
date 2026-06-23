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
    public partial class frmPrincipalUsuario : Form
    {
        private string usuarioLogueado;
        public frmPrincipalUsuario(string usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
            lblBienvenido.Text = "Bienvenido: " + usuarioLogueado;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Sesion Cerrada con exito");
            frmLogin login = new frmLogin();
            login.ShowDialog();
            
        }

        private void btnEditUsuario_Click(object sender, EventArgs e)
        {
            frmActualizarMiPerfil frmActualizarMiPerfil = new frmActualizarMiPerfil(usuarioLogueado);
            frmActualizarMiPerfil.ShowDialog();
        }

        private void frmPrincipalUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
