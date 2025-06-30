using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaRoles.Persistencia
{
    public partial class FRMRoles : Form
    {
        private readonly Aplicacion.RolesService _rolesService = new Aplicacion.RolesService();
        public FRMRoles()
        {
            InitializeComponent();
        }
        private void FRMRoles_Load(object sender, EventArgs e)
        {
            this.cargaLista();
        }
        public void cargaLista()
        {
            lstRoles.DataSource = _rolesService.todos().ToList();
            lstRoles.DisplayMember = "Detalle";
            lstRoles.ValueMember = "RolesId";
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Faciltar un titulo");
            }
            else
            {
                var rol = new Datos.RolesDTO
                {
                    Detalle = txtNombre.Text.Trim(),

                };
                if (_rolesService.insertar(rol) == "ok")
                {
                    MessageBox.Show("guardado");
                    this.cargaLista();
                }
                else
                {
                    MessageBox.Show("¡Error!");
                    txtNombre.Text = "";
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstRoles.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un rol.");
                txtNombre.Text = "";
                return;
            }
            else
            {
                btnEditar.Enabled = false;
                btnInsertar.Enabled = false;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Desea editar el rol?", "Confirmar",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {

                var rolactualizar = new Datos.RolesDTO
                {
                    RolesId = (int)lstRoles.SelectedValue,
                    Detalle = txtNombre.Text.Trim()
                };
                if (_rolesService.actualizar(rolactualizar) == "ok")
                {
                    MessageBox.Show("Guardado.");
                    this.cargaLista();
                    btnEditar.Enabled = true;
                    btnInsertar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnGuardar.Enabled = false;
                    txtNombre.Text = "";
                }
                else
                {
                    MessageBox.Show("Error al actualizar.");
                    btnEditar.Enabled = true;
                    btnInsertar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnGuardar.Enabled = false;
                    txtNombre.Text = "";
                }
            }
            else
            {
                btnEditar.Enabled = true;
                btnInsertar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
                txtNombre.Text = "";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstRoles.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un rol");
                return;
            }
            DialogResult confirmacion = MessageBox.Show("¿Estás seguro de eliminarlo?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (confirmacion == DialogResult.Yes)
            {
                if (_rolesService.eliminar(Convert.ToInt32(lstRoles.SelectedValue)) == "ok")
                {
                    MessageBox.Show("Se ha eliminado.");
                    this.cargaLista();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            var ingreso = new Persistencia.FRMIngreso();
            ingreso.Show();
        }

        private void lstRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Datos.RolesDTO seleccion = (Datos.RolesDTO)lstRoles.SelectedItem;
            txtNombre.Text = seleccion.Detalle;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnInsertar.PerformClick();
            }
        }
    }
}
