using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _01_Mi_primera_vez.Vistas
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void btn_calculadora_Click(object sender, EventArgs e)
        {
              //var frm_calculadora = new Vistas.Calculadora();
              //frm_calculadora.Show();
              //frm_calculadora.ShowDialog();

          Vistas.Calculadora frm_calculadora = new Vistas.Calculadora();
            frm_calculadora.ShowDialog();

        }

        private void btn_agenda_Click(object sender, EventArgs e)
        {
            Vistas.Agenda.Agenda frm_agenda = new Vistas.Agenda.Agenda();
            frm_agenda.ShowDialog();    
        }
    }
}
