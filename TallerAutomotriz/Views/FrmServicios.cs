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
    public partial class FrmServicios : Form
    {
        private readonly ServicioController _ctrl = new();
        public FrmServicios()
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
            _ctrl.Agregar(new Servicio
            {
                Descripcion = txtDescripcion.Text,
                Costo = nudCosto.Value
            });
            CargarLista();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;
            _ctrl.Actualizar(new Servicio
            {
                Id = (int)dgv.CurrentRow.Cells["Id"].Value,
                Descripcion = txtDescripcion.Text,
                Costo = nudCosto.Value
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
                txtDescripcion.Text = dgv.CurrentRow.Cells["Descripcion"].Value?.ToString() ?? "";
                nudCosto.Value = Convert.ToDecimal(dgv.CurrentRow.Cells["Costo"].Value);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
