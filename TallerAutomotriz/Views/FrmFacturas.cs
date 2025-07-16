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
    public partial class FrmFacturas : Form
    {
        private readonly FacturaController _ctrlF = new();
        private readonly VehiculoController _ctrlV = new();
        private readonly EmpleadoController _ctrlE = new();
        private readonly ServicioController _ctrlS = new();
        public FrmFacturas()
        {
            InitializeComponent();
            cmbVehiculo.DataSource = _ctrlV.ObtenerTodos();
            cmbVehiculo.DisplayMember = "Placa"; cmbVehiculo.ValueMember = "Id";

            cmbEmpleado.DataSource = _ctrlE.ObtenerTodos();
            cmbEmpleado.DisplayMember = "Nombre"; cmbEmpleado.ValueMember = "Id";

            cmbServicio.DataSource = _ctrlS.ObtenerTodos();
            cmbServicio.DisplayMember = "Descripcion"; cmbServicio.ValueMember = "Id";

            CargarLista();
        }
        private void CargarLista()
        {
            dgv.DataSource = null;
            dgv.DataSource = _ctrlF.ObtenerTodas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _ctrlF.Agregar(new Factura
            {
                Fecha = dtpFecha.Value,
                VehiculoId = Convert.ToInt32(cmbVehiculo.SelectedValue),
                EmpleadoId = Convert.ToInt32(cmbEmpleado.SelectedValue),
                ServicioId = Convert.ToInt32(cmbServicio.SelectedValue)
            });
            CargarLista();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;
            _ctrlF.Actualizar(new Factura
            {
                Id = (int)dgv.CurrentRow.Cells["Id"].Value,
                Fecha = dtpFecha.Value,
                VehiculoId = Convert.ToInt32(cmbVehiculo.SelectedValue),
                EmpleadoId = Convert.ToInt32(cmbEmpleado.SelectedValue),
                ServicioId = Convert.ToInt32(cmbServicio.SelectedValue)
            });
            CargarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;
            _ctrlF.Eliminar((int)dgv.CurrentRow.Cells["Id"].Value);
            CargarLista();
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                dtpFecha.Value = Convert.ToDateTime(dgv.CurrentRow.Cells["Fecha"].Value);
                cmbVehiculo.SelectedValue = (int)dgv.CurrentRow.Cells["VehiculoId"].Value;
                cmbEmpleado.SelectedValue = (int)dgv.CurrentRow.Cells["EmpleadoId"].Value;
                cmbServicio.SelectedValue = (int)dgv.CurrentRow.Cells["ServicioId"].Value;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
