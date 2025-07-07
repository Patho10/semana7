using Ferreteria.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria.Controllers;

namespace Ferreteria.Views
{
    public partial class FRMHerramientas : Form
    {
        public FRMHerramientas()
        {
            InitializeComponent();
        }

        private void FRMHerramientas_Load(object sender, EventArgs e)
        {
            HerramientaController Ctrl = new HerramientaController();
            int? idSeleccionado = null;

        public HerramientasForm()
        {
            InitializeComponent();
            CargarHerramientas();

            btnAgregar.Click += btnAgregar_Click;
            btnActualizar.Click += btnActualizar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            dataGridViewDATOS.SelectionChanged += dataGridViewDATOS_SelectionChanged;
        }

        private void CargarHerramientas()
        {
            dataGridViewDATOS.DataSource = null;
            dataGridViewDATOS.DataSource = herramientaCtrl.ObtenerHerramientas();
            dataGridViewDATOS.ClearSelection();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtTipo.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            dateTimePickerExpiacion.Value = DateTime.Today;
            checkBox1.Checked = false;
            idSeleccionado = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Campo obligatorio.");
                return;
            }

            var herramienta = new Herramienta
            {
                Nombre = txtNombre.Text,
                Tipo = txtTipo.Text,
                Descripcion = txtDescripcion.Text,
                Precio = decimal.TryParse(txtPrecio.Text, out decimal precio) ? precio : 0,
                Stock = int.TryParse(txtStock.Text, out int stock) ? stock : 0,
                FechaEntrada = dateTimePickerExpiacion.Value,
                Activo = checkBox1.Checked
            };

            herramientaCtrl.AgregarHerramienta(herramienta);
            MessageBox.Show("Herramienta agregada.");
            CargarHerramientas();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == null)
            {
                MessageBox.Show("Selecciona una herramienta.");
                return;
            }

            var herramienta = new Herramienta
            {
                HerramientaId = idSeleccionado.Value,
                Nombre = txtNombre.Text,
                Tipo = txtTipo.Text,
                Descripcion = txtDescripcion.Text,
                Precio = decimal.TryParse(txtPrecio.Text, out decimal precio) ? precio : 0,
                Stock = int.TryParse(txtStock.Text, out int stock) ? stock : 0,
                FechaEntrada = dateTimePickerExpiacion.Value,
                Activo = checkBox1.Checked
            };

            herramientaCtrl.ActualizarHerramienta(herramienta);
            MessageBox.Show("Herramienta actualizada.");
            CargarHerramientas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == null)
            {
                MessageBox.Show("Selecciona una herramienta.");
                return;
            }

            herramientaCtrl.EliminarHerramienta(idSeleccionado.Value);
            MessageBox.Show("Herramienta eliminada.");
            CargarHerramientas();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dataGridViewDATOS_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDATOS.SelectedRows.Count > 0)
            {
                var fila = dataGridViewDATOS.SelectedRows[0];
                var herramienta = fila.DataBoundItem as Herramienta;
                if (herramienta != null)
                {
                    idSeleccionado = herramienta.HerramientaId;
                    txtNombre.Text = herramienta.Nombre;
                    txtTipo.Text = herramienta.Tipo;
                    txtDescripcion.Text = herramienta.Descripcion;
                    txtPrecio.Text = herramienta.Precio.ToString("0.00");
                    txtStock.Text = herramienta.Stock.ToString();
                    dateTimePickerExpiacion.Value = herramienta.FechaEntrada;
                    checkBox1.Checked = herramienta.Activo;
                }
            }
        }
    }
    }
}
