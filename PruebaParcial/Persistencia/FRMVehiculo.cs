using PruebaParcial.Aplicacion;
using PruebaParcial.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace PruebaParcial.Persistencia
{
    public partial class FRMVehiculo : Form
    {
        private VehiculoService servicio = new VehiculoService();
        public FRMVehiculo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text) ||
        string.IsNullOrWhiteSpace(txtModelo.Text) ||
        string.IsNullOrWhiteSpace(txtAnio.Text) ||
        string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            if (!int.TryParse(txtAnio.Text, out int anio))
            {
                MessageBox.Show("El campo 'Año' debe ser un número entero.");
                return;
            }

            // Reemplazar coma por punto y usar cultura invariable
            txtPrecio.Text = txtPrecio.Text.Replace(",", ".");

            if (!decimal.TryParse(txtPrecio.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal precio))
            {
                MessageBox.Show("El campo 'Precio' debe ser un número decimal válido (ej: 20000.00).");
                return;
            }

            VehiculoDTO vehiculo = new VehiculoDTO
            {
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Anio = anio,
                PrecioPorDia = precio
            };

            servicio.insertar(vehiculo);
            MessageBox.Show("Vehículo agregado correctamente");
        }
    }
}
