using SistemaReservas.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaReservas.Views
{
    public partial class FrmReservas : Form
    {

        private readonly ReservaService _service = new ReservaService();
        public FrmReservas()
        {
            InitializeComponent();
        }

        private void FrmReservas_Load(object sender, EventArgs e)
        {
            AuthorizationService.AplicarPermisos(this.Controls);
            CargarReservas();
        }

        private void CargarReservas()
        {
            dgvReservas.DataSource = _service.ObtenerReservas();
        }

        private void btnNuevaReserva_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Crear nueva reserva (implementación pendiente)");
            // Aquí podrías abrir un formulario con campos para nueva reserva
        }

        private void btnEditarReserva_Click(object sender, EventArgs e)
        {
            if (dgvReservas.CurrentRow != null)
            {
                MessageBox.Show("Editar reserva seleccionada (implementación pendiente)");
                // Obtener datos de la reserva y abrir para edición
            }
            else
            {
                MessageBox.Show("Selecciona una reserva para editar");
            }
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            if (dgvReservas.CurrentRow != null)
            {
                DialogResult confirm = MessageBox.Show("¿Deseas cancelar esta reserva?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    MessageBox.Show("Cancelar reserva (implementación pendiente)");
                    // Cambiar el estado a "cancelada" en la BD
                }
            }
            else
            {
                MessageBox.Show("Selecciona una reserva para cancelar");
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.CurrentRow != null)
            {
                DialogResult confirm = MessageBox.Show("¿Deseas confirmar esta reserva?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    MessageBox.Show("Confirmar reserva (implementación pendiente)");
                    // Cambiar el estado a "confirmada"
                }
            }
            else
            {
                MessageBox.Show("Selecciona una reserva para confirmar");
            }
        }
    }
}
