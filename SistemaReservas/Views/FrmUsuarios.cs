using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaReservas.Services;
using System;
using System.Windows.Forms;

namespace SistemaReservas.Views
{
    public partial class FrmUsuarios : Form
    {
        private readonly UsuarioService _service = new UsuarioService();
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            AuthorizationService.AplicarPermisos(this.Controls);
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = _service.ObtenerUsuarios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Agregar usuario (implementación pendiente)");
            // Aquí podrías abrir un formulario de edición o limpieza de campos
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                MessageBox.Show("Editar usuario seleccionado (implementación pendiente)");
                // Obtener datos del usuario seleccionado y abrir formulario de edición
            }
            else
            {
                MessageBox.Show("Selecciona un usuario para editar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                DialogResult confirm = MessageBox.Show("¿Estás seguro de eliminar este usuario?", "Confirmación", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    MessageBox.Show("Eliminar usuario (implementación pendiente)");
                    // Llamar al servicio/repo para eliminar y volver a cargar
                }
            }
            else
            {
                MessageBox.Show("Selecciona un usuario para eliminar");
            }
        }
    }
}

