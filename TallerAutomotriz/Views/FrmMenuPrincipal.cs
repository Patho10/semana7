using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerAutomotriz.Views
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            new FrmClientes().ShowDialog();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            new FrmVehiculo().ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            new FrmEmpleados().ShowDialog();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            new FrmServicios().ShowDialog();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            new FrmFacturas().ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
