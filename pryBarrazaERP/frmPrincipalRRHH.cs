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
        public frmPrincipalRRHH()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            MessageBox.Show("Sesion Cerrada, adios");
            Environment.Exit(0);
        }
    }
}
