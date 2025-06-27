using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //operador +=
            lblEstado.Click += lblEstado_Click;
            txtDigitos.KeyPress += txtDigitos_KeyPress;
            btnIniciarTimer.Click += btnIniciarTimer_Click;
            timer1.Tick += timer1_Tick;

            // Configuración inicial del timer
            timer1.Interval = 1000; 
        }


        private void lblEstado_Click(object sender, EventArgs e)
        {
            lblEstado.Text = "Estado: ¡Has hecho clic!";      // Evento: cuando se hace clic en el Label
        }

        private void txtDigitos_KeyPress(object sender, KeyPressEventArgs e)   // Evento: cuando se presiona una tecla en el TextBox
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))     // Validar que sea un dígito o tecla de control (como borrar)
            {
                e.Handled = true; // No permite escribir letras o símbolos
            }
        }

        private void btnIniciarTimer_Click(object sender, EventArgs e)
        {
            lblEstado.Text = "Estado: Timer iniciado";                  // Evento: clic en el botón del Panel
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblEstado.Text = "Estado: " + DateTime.Now.ToLongTimeString();   // Evento: se activa cada vez que el timer hace "tick"
        }
    }
}
