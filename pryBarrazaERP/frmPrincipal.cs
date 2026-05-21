using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBarrazaERP
{
    public partial class frmPrincipal : Form
    {
        string usuario;
        public frmPrincipal(string nombreUsuario)
        {
            InitializeComponent();
            usuario = nombreUsuario;
            lblBienvenido.Text = "Bienvenido, " + usuario;
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            

        }

        private void principal_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void btmAgregarUsuario_Click(object sender, EventArgs e)
        {
            frmUsuario frmUsuario = new frmUsuario();
            frmUsuario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmContacto frmContacto = new frmContacto();
            frmContacto.ShowDialog();
        }
    }
}

