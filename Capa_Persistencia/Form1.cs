using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Persistencia
{
    public partial class Form1 : Form
    {
        private Capa_Aplicacion.Usuarios.UsuarioService _usuarioService = new Capa_Aplicacion.Usuarios.UsuarioService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = _usuarioService.todos().ToList();
            listBox1.ValueMember = "UsuarioId";
            listBox1.DisplayMember = "Nombre";
        }
    }
}
