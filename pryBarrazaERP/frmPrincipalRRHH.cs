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
        clsAuditoria auditoria = new clsAuditoria();
        public frmPrincipalRRHH(string nombreUsuario)
        {
            InitializeComponent();
            usuario = nombreUsuario;
            lblBienvenido.Text = "Bienvenido: " + usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
         

            auditoria.GrabarMovimiento(
                usuario,
                "frmPrincipalRRHH",
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

        private void frmPrincipalRRHH_Load(object sender, EventArgs e)
        {
            auditoria.GrabarMovimiento(
               usuario,
               "frmPrincipalRRHH",
               "Ingreso al sistema");

        }

        private void btmAgregarUsuario_Click(object sender, EventArgs e)
        {
            auditoria.GrabarMovimiento(
              usuario,
              "frmPrincipalRRHH",
              "Abrio registrar usuario");
            frmRegistrarUsuario registrarUsuario = new frmRegistrarUsuario();
            registrarUsuario.ShowDialog();
        }

        private void btnEditUsuario_Click(object sender, EventArgs e)
        {
            auditoria.GrabarMovimiento(
            usuario,
            "frmPrincipalRRHH",
            "Abrio editar usuario");

            frmEditarUsuario editarUsuario = new frmEditarUsuario(usuario);
            editarUsuario.ShowDialog();
        }

        private void btnInfoExtraUsuario_Click(object sender, EventArgs e)
        {
            auditoria.GrabarMovimiento(
            usuario,
            "frmPrincipalRRHH",
            "Abrio agregar informacion extra de usuario");
            frmInfoExtra infoExtra = new frmInfoExtra();
            infoExtra.ShowDialog();
        }

        private void btnVerInfo_Click(object sender, EventArgs e)
        {
            auditoria.GrabarMovimiento(
            usuario,
            "frmPrincipalRRHH",
            "Abrio ver info extra de  usuario");

            frmVerInfoExtra verInfoExtra = new frmVerInfoExtra(usuario);
            verInfoExtra.ShowDialog();
        }
    }
}
