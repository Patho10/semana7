using PruebaParcial.Aplicacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PruebaParcial.Datos;
namespace PruebaParcial.Persistencia
{
    public partial class FRMAlquiler : Form
    {
        private AlquilerService servicio = new AlquilerService();
        public FRMAlquiler()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                AlquilerDTO alquiler = new AlquilerDTO
                {
                    ClienteId = int.Parse(txtClienteId.Text),
                    VehiculoId = int.Parse(txtVehiculoId.Text),
                    FechaInicio = dtInicio.Value.Date,
                    FechaFin = dtFin.Value.Date
                };

                servicio.AgregarAlquiler(alquiler);
                MessageBox.Show("Alquiler agregado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            lstAlquiler.Items.Clear();
            var alquileres = servicio.ObtenerAlquileres();
            foreach (var a in alquileres)
            {
                lstAlquiler.Items.Add($"ID: {a.Id} | Cliente: {a.ClienteId} - Vehículo: {a.VehiculoId} - {a.FechaInicio.ToShortDateString()} al {a.FechaFin.ToShortDateString()}");
            }
        }
    }
}
