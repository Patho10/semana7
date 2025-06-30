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
    public partial class FRMUsuarios : Form
    {
        private readonly Aplicacion.UsuarioService _usuarioService = new Aplicacion.UsuarioService();
        private readonly Aplicacion.RolesService _rolesService = new Aplicacion.RolesService();
        public FRMUsuarios()
        {
            InitializeComponent();
        }

        private void FRMUsuarios_Load(object sender, EventArgs e)
        {
            this.cargaLista();
        }
        private void _todosRoles()
        {
            cmbUsuario.DataSource = _rolesService.todos();
            cmbUsuario.DisplayMember = "Detalle";
            cmbUsuario.ValueMember = "RolesId";
        }

        public void cargaLista()
        {
            lstUsuarios.DataSource = _usuarioService.todos().ToList();
            lstUsuarios.DisplayMember = "Nombre";
            lstUsuarios.ValueMember = "UsuarioId";

            _todosRoles();

            txtNombre.Text = "";
            txtCorreoElectronico.Text = "";
            txtContrasenia.Text = "";
            cmbUsuario.SelectedIndex = -1;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            var ingreso = new Persistencia.FRMIngreso();
            ingreso.Show();
        }
        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtCorreoElectronico.Text = "";
            txtContrasenia.Text = "";
            cmbUsuario.SelectedIndex = -1;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) ||
               string.IsNullOrEmpty(txtCorreoElectronico.Text) || string.IsNullOrWhiteSpace(txtCorreoElectronico.Text) ||
               string.IsNullOrEmpty(txtContrasenia.Text) || string.IsNullOrWhiteSpace(txtContrasenia.Text))
            {
                MessageBox.Show("¡Complete los campos!");
            }
            else if (cmbUsuario.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un rol");
                return;
            }
            else
            {
                var user = new Datos.UsuariosDTO
                {
                    Nombre = txtNombre.Text.Trim(),
                    correo = txtCorreoElectronico.Text.Trim(),
                    password = txtContrasenia.Text.Trim(),
                    IdRol = (int)cmbUsuario.SelectedValue
                };
                if (_usuarioService.insertar(user) == "ok")
                {
                    MessageBox.Show("Guardado.");
                    this.cargaLista();
                }
                else
                {
                    MessageBox.Show("¡Error!.");
                    limpiarCampos();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un usuario");
                limpiarCampos();
                return;
            }
            btnEditar.Enabled = false;
            btnInsertar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Desea editar el usuario?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                if (lstUsuarios.SelectedItem is Datos.UsuariosDTO seleccion)
                {
                    var usuarioActualizado = new Datos.UsuariosDTO
                    {
                        UsuarioId = seleccion.UsuarioId,
                        Nombre = txtNombre.Text.Trim(),
                        correo = txtCorreoElectronico.Text.Trim(),
                        password = txtContrasenia.Text.Trim(),
                        IdRol = (int)cmbUsuario.SelectedValue
                    };

                    if (_usuarioService.actualizar(usuarioActualizado) == "ok")
                    {
                        MessageBox.Show("Actualizado.");
                        this.cargaLista();
                        btnEditar.Enabled = true;
                        btnInsertar.Enabled = true;
                        btnEliminar.Enabled = true;
                        btnGuardar.Enabled = false;
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error.");
                        btnEditar.Enabled = true;
                        btnInsertar.Enabled = true;
                        btnEliminar.Enabled = true;
                        btnGuardar.Enabled = false;
                        limpiarCampos();
                    }
                }
            }
            else
            {
                btnEditar.Enabled = true;
                btnInsertar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
                limpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }

            int id = (int)lstUsuarios.SelectedValue;

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de eliminar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation
            );

            if (confirmacion == DialogResult.Yes)
            {
                if (_usuarioService.eliminar(id) == "ok")
                {
                    MessageBox.Show("Eliminado");
                    this.cargaLista();
                }
                else
                {
                    MessageBox.Show("Error.");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void cmbRolUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnInsertar.PerformClick();
            }
        }

        private void lstUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedItem is Datos.UsuariosDTO seleccion)
            {
                txtNombre.Text = seleccion.Nombre;
                txtCorreoElectronico.Text = seleccion.correo;
                txtContrasenia.Text = seleccion.password;
                cmbUsuario.SelectedValue = seleccion.IdRol;
            }
        }

        private void cmbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnInsertar.PerformClick();
            }
        }
    }
}
