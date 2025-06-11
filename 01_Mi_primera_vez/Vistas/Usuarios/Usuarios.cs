using _01_Mi_primera_vez.Controladores;
using _01_Mi_primera_vez.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Mi_primera_vez.Vistas.Usuarios
{
    public partial class Usuarios : Form
    {
        private Controladores.UsuariosController _usuariosController = new Controladores.UsuariosController();
        private static UsuariosController _instancia;

        public Usuarios()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevoUsuario = new UsuarioModelo
            {
                Nombre = txtNombre.Text,
                Correo = txtCorreo.Text
            };

            _usuariosController.AgregarUsuario(nuevoUsuario); 

            MessageBox.Show("Usuario agregado correctamente.");

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lstUsuarios.Items.Clear();

            var lista = _usuariosController.ObtenerUsuarios();  

            MessageBox.Show("Usuarios encontrados: " + lista.Count); 

            foreach (var usuario in lista)
            {
                lstUsuarios.Items.Add(usuario); 


            }
        }
    }
}
