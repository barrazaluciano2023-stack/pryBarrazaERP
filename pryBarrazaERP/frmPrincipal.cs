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
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            

        }

        private void principal_Load(object sender, EventArgs e)
        {
            CConexion objetoConeccionBaseDatos = new CConexion();
            objetoConeccionBaseDatos.ConectarBaseDatos();
            if (objetoConeccionBaseDatos != null)
            {
                //sstConexion.Text = objetoConeccionBaseDatos.estadoConexion;
                //lblConexion.Text = objetoConeccionBaseDatos.estadoConexion;
                //lblConexion.ForeColor = System.Drawing.Color.Green;
                //lblConexion.Text = "Estado Conexion: Conexion Exitosa";
            }
            else
            {
                //lblConexion.ForeColor = System.Drawing.Color.Red;
                //lblConexion.Text = "Estado Conexion: Conexion Fallida";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

