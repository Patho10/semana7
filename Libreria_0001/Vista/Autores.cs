using Libreria_01.Controlador;
using Libreria_01.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria_0001.Vista
{
    public partial class Autores : Form
    {
        private readonly AutorController _autorController;
        public Autores()
        {
            InitializeComponent();
            _autorController = new AutorController();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var autor = new AutorModel
            {
                Id = txtID.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                Ciudad = txtCiudad.Text.Trim(),
                Estado = txtEstado.Text.Trim(),
                CodigoPostal = txtCodigo.Text.Trim(),
                Contrato = chkContrato.Checked
            };
            if (!ValidarAutor(autor, out string mensajeError))
            {
                MessageBox.Show(mensajeError, "Error de validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_autorController.Crear(autor))
                {
                    MessageBox.Show("Autor agregado correctamente", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar autor: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Ingrese el ID del autor a eliminar", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = txtID.Text.Trim();

            if (MessageBox.Show("¿Está seguro de eliminar este autor?", "Confirmar",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (_autorController.Eliminar(id))
                    {
                        MessageBox.Show("Autor eliminado correctamente", "Éxito",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el autor con el ID especificado", "Advertencia",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar autor: {ex.Message}", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool ValidarAutor(AutorModel autor, out string mensajeError)
        {
            mensajeError = string.Empty;
            var errores = new List<string>();

            if (string.IsNullOrWhiteSpace(autor.Id))
                errores.Add("El ID del autor es requerido.");

            if (string.IsNullOrWhiteSpace(autor.Apellido))
                errores.Add("El apellido del autor es requerido.");

            if (string.IsNullOrWhiteSpace(autor.Nombre))
                errores.Add("El nombre del autor es requerido.");

            if (errores.Count > 0)
            {
                mensajeError = string.Join("\n", errores);
                return false;
            }

            return true;
        }
        private void LimpiarCampos()
        {
            txtID.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtCiudad.Clear();
            txtEstado.Clear();
            txtCodigo.Clear();
            chkContrato.Checked = false;
        }
    }
}
