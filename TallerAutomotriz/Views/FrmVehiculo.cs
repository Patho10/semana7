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
    public partial class FrmVehiculo : Form
    {
        private readonly VehiculoController _ctrlV = new();
        private readonly ClienteController _ctrlC = new();
        public FrmVehiculo()
        {
            InitializeComponent();
            cmbClientes.DataSource = _ctrlC.ObtenerTodos();
            cmbClientes.DisplayMember = "Nombre"; cmbClientes.ValueMember = "Id";
            CargarLista();
        }
        private void CargarLista()
        {
            dgv.DataSource = null;
            dgv.DataSource = _ctrlV.ObtenerTodos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _ctrlV.Agregar(new Vehiculo
            {
                Placa = txtPlaca.Text,
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                ClienteId = Convert.ToInt32(cmbClientes.SelectedValue)
            });
            CargarLista();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;
            _ctrlV.Actualizar(new Vehiculo
            {
                Id = (int)dgv.CurrentRow.Cells["Id"].Value,
                Placa = txtPlaca.Text,
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                ClienteId = Convert.ToInt32(cmbClientes.SelectedValue)
            });
            CargarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;
            _ctrlV.Eliminar((int)dgv.CurrentRow.Cells["Id"].Value);
            CargarLista();
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                txtPlaca.Text = dgv.CurrentRow.Cells["Placa"].Value?.ToString() ?? "";
                txtMarca.Text = dgv.CurrentRow.Cells["Marca"].Value?.ToString() ?? "";
                txtModelo.Text = dgv.CurrentRow.Cells["Modelo"].Value?.ToString() ?? "";
                cmbClientes.SelectedValue = Convert.ToInt32(dgv.CurrentRow.Cells["ClienteId"].Value);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

