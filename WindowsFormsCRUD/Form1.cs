using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCRUD
{
    public partial class Form1 : Form
    {
        private Aplicacion.UsuarioService _usuarioService = new Aplicacion.UsuarioService();
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

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(listBox1.SelectedValue.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}
