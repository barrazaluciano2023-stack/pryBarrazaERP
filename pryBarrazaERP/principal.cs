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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            CConexion objetoConeccionBaseDatos = new CConexion();
            objetoConeccionBaseDatos.ConectarBaseDatos();
        }
    }
}
