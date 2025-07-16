using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerAutomotriz.Controllers;
using TallerAutomotriz.Models;

namespace TallerAutomotriz.Views
{
    public partial class FrmClientes : Form
    {
        private readonly ClienteController _ctrl = new();
        public FrmClientes()
        {
            InitializeComponent();
            CargarLista();
        }
        private void CargarLista()
        {
            dgv.DataSource = null;
            dgv.DataSource = _ctrl.ObtenerTodos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _ctrl.Agregar(new Cliente
            {
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text
            });
            CargarLista();
        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;
            var id = (int)dgv.CurrentRow.Cells["Id"].Value;
            _ctrl.Actualizar(new Cliente
            {
                Id = id,
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text
            });
            CargarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;
            var id = (int)dgv.CurrentRow.Cells["Id"].Value;
            _ctrl.Eliminar(id);
            CargarLista();
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                txtNombre.Text = dgv.CurrentRow.Cells["Nombre"].Value?.ToString() ?? "";
                txtTelefono.Text = dgv.CurrentRow.Cells["Telefono"].Value?.ToString() ?? "";
                txtDireccion.Text = dgv.CurrentRow.Cells["Direccion"].Value?.ToString() ?? "";
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


