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
    public partial class frmPrincipalADM : Form
    {
        string usuario;
        public frmPrincipalADM(string nombreUsuario)
        {
            InitializeComponent();
            usuario = nombreUsuario;
            lblBienvenido.Text = "Bienvenido:  " + usuario;
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
            frmRegistrarUsuario frmRegistrarUsuario = new frmRegistrarUsuario();
            frmRegistrarUsuario.ShowDialog();
        }


        private void btnVerAuditoria_Click(object sender, EventArgs e)
        {
            frmVerAuditoria frmVerAuditoria = new frmVerAuditoria();
            frmVerAuditoria.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Sesion Cerrada,adios");
            Environment.Exit(0);
        }
    }
}

