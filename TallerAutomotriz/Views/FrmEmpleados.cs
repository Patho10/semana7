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
    public partial class FrmEmpleados : Form
    {
        private readonly EmpleadoController _ctrl = new();
        public FrmEmpleados()
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
            _ctrl.Agregar(new Empleado
            {
                Nombre = txtNombre.Text,
                Cargo = txtCargo.Text
            });
            CargarLista();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;
            _ctrl.Actualizar(new Empleado
            {
                Id = (int)dgv.CurrentRow.Cells["Id"].Value,
                Nombre = txtNombre.Text,
                Cargo = txtCargo.Text
            });
            CargarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;
            _ctrl.Eliminar((int)dgv.CurrentRow.Cells["Id"].Value);
            CargarLista();
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                txtNombre.Text = dgv.CurrentRow.Cells["Nombre"].Value?.ToString() ?? "";
                txtCargo.Text = dgv.CurrentRow.Cells["Cargo"].Value?.ToString() ?? "";
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
