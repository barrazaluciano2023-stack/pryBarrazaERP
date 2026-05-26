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
    public partial class frmVerAuditoria : Form
    {
        public frmVerAuditoria()
        {
            InitializeComponent();
        }

        private void frmVerAuditoria_Load(object sender, EventArgs e)
        {
            clsAuditoria clsAuditoria = new clsAuditoria();
            clsAuditoria.CargarIngresos(dtvIngresos);
        }
    }
}
