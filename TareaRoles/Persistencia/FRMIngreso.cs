using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaRoles.Persistencia
{
    public partial class FRMIngreso : Form
    {
        public FRMIngreso()
        {
            InitializeComponent();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            var usuarios = new Persistencia.FRMUsuarios();
            usuarios.Show();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            this.Hide();
            var roles = new Persistencia.FRMRoles();
            roles.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
