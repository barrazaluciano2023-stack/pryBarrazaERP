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
        clsAuditoria auditoria = new clsAuditoria();
        string usuarioLogueado;
        public frmPrincipalUsuario(string usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
            lblBienvenido.Text = "Bienvenido: " + usuarioLogueado;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            auditoria.GrabarMovimiento(
                usuarioLogueado,
                "frmPrincipalUsuario",
                "Cerró Sesión");

            DialogResult respuesta = MessageBox.Show(
                "¿Desea Cerrar Sesion?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                this.Close();
                frmLogin login = new frmLogin();

                login.ShowDialog();
            }

        }

        private void btnEditUsuario_Click(object sender, EventArgs e)
        {
            auditoria.GrabarMovimiento(
                usuarioLogueado,
                "frmPrincipalUsuario",
                "Abrio para editar su informacion");

            frmActualizarMiPerfil frmActualizarMiPerfil = new frmActualizarMiPerfil(usuarioLogueado);
            frmActualizarMiPerfil.ShowDialog();
        }

        private void frmPrincipalUsuario_Load(object sender, EventArgs e)
        {
           auditoria.GrabarMovimiento(
                usuarioLogueado,
                "frmPrincipalUsuario",
                "inicio Sesion");
        }
    }
}
