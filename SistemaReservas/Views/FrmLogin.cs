using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaReservas.Data;
using SistemaReservas.Models;
using SistemaReservas.Services;
using System;
using System.Windows.Forms;

namespace SistemaReservas.Views
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var repo = new UsuarioRepository();
            var usuarios = repo.ObtenerTodos();
            var encontrado = usuarios.Find(u => u.Email == txtEmail.Text && u.Clave == txtClave.Text);

            if (encontrado != null)
            {
                AuthorizationService.RolActual = encontrado.Rol;
                this.Hide();
                new FrmUsuarios().Show();
            }
            else
            {
                MessageBox.Show("Credenciales inválidas");
            }
        }
    }
}
