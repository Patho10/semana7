using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mysql.Persistencias.Usuarios
{
    public partial class FRMListaUsuario : Form
    {
        private readonly Aplicacion.UsuarioService _usuarioService = new Aplicacion.UsuarioService();
        public FRMListaUsuario()
        {
            InitializeComponent();
        }

        private void FRMListaUsuario_Load(object sender, EventArgs e)
        {
            this.cargalista();
        }
        public void cargalista()
        {
            lstUsuarios.DataSource = _usuarioService.todos().ToList();
            lstUsuarios.DisplayMember = "Nombre";
            lstUsuarios.ValueMember = "UsuarioId";
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            var fRMNuevoUsuario = new FRMNuevoUsuario();
            fRMNuevoUsuario.ShowDialog();
        }
        private void FRMListaUsuario_Activated(object sender, EventArgs e)
        {
            this.cargalista();  
        }
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un usaurio de la lista");
                return;
            }

            if (_usuarioService.elimnar(Convert.ToInt32(lstUsuarios.SelectedValue)) == "ok")
            {
                MessageBox.Show("Se elimino con exito");
                this.cargalista();
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar");
            }
        }


    }
}
