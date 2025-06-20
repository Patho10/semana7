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
    public partial class FRMCliente : Form
    {
        private ClienteService servicio = new ClienteService();
        private Datos.ClientesDTO _cliente;

        public FRMCliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear instancia del cliente con datos del formulario
                ClientesDTO cliente = new ClientesDTO
                {
                    Nombre = txtNombre.Text,
                    Correo = txtCorreo.Text
                };

                // Llamar al servicio para insertar
                string resultado = servicio.insertar(cliente);

                // Mostrar mensaje de resultado
                MessageBox.Show("Cliente agregado correctamente: " + resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar cliente: " + ex.Message);
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lstClientes.Items.Clear();
            var clientes = servicio.ObtenerClientes();
            foreach (var c in clientes)
            {
                lstClientes.Items.Add($"ID: {c.Id} | {c.Nombre} - {c.Correo}");
            }
        }
    }
    }

