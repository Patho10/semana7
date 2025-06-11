using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Mi_primera_vez.Vistas.Clientes
{
    public partial class frmclientes : Form
    {
        Controladores.ClientesController _clientesController = new Controladores.ClientesController();
        public frmclientes()
        {
            InitializeComponent();
        }

        private void lst_ListaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //var id = _clientesController._clienteModelo.Last();  // un cliente
            var id = _clientesController._clienteModelo.Count();
            var cliente = new Modelos.ClienteModelo
            {
                CedulaRuc = txtCedula.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                Nombre = txtNombres.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                ClienteId = id + 1
            };
            var res = _clientesController.Insertar(cliente);
            if (res == "ok")
            {
                MessageBox.Show("Se guardo con exito");
                this.LimpiarCajas();
                this.cargaLista();

            }
            else
            {
                MessageBox.Show("Error al Guardar el cliente. " + res);
            }
        }

        private void frmclientes_Load(object sender, EventArgs e)
        {
            cargaLista();
        }
        public void cargaLista()
        {

            lst_ListaClientes.DataSource = _clientesController.todos().ToList();
            lst_ListaClientes.ValueMember = "ClienteId";
            lst_ListaClientes.DisplayMember = "Nombre";
        }
        public void LimpiarCajas()
        {
            txtCedula.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtNombres.Text = "";
            txtTelefono.Text = "";

            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lst_ListaClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un item de la lista");
                return;
            }

            var cliente = _clientesController.uno(Convert.ToInt32(lst_ListaClientes.SelectedValue));
            txtCedula.Text = cliente.CedulaRuc;
            txtCorreo.Text = cliente.Correo;
            txtDireccion.Text = cliente.Direccion;
            txtNombres.Text = cliente.Nombre;
            txtTelefono.Text = cliente.Telefono;
        }

        private void btnGuardarModificar_Click(object sender, EventArgs e)
        {
            var cliente = new Modelos.ClienteModelo
            {
                CedulaRuc = txtCedula.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                Nombre = txtNombres.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                ClienteId = Convert.ToInt32(lst_ListaClientes.SelectedValue)
            };
            var res = _clientesController.Actualizar(cliente);
            if (res == "ok")
            {
                MessageBox.Show("Se modifico con exito");
                this.LimpiarCajas();
                this.cargaLista();
            }
            else
            {
                MessageBox.Show("Error al Guardar el cliente. " + res);
            }
            }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var res = _clientesController.Eliminar(Convert.ToInt32(lst_ListaClientes.SelectedValue));
            if (res == "ok")
            {
                MessageBox.Show("Se ellimino con exito");
                this.LimpiarCajas();
                this.cargaLista();
            }
            else
            {
                MessageBox.Show("Error al eliminar el cliente. " + res);
            }
        }

    }
    }

