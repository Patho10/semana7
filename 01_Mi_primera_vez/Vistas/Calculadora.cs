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
    public partial class Calculadora : Form
    {

        public string valor_caja = "0";
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Resultado.Text + "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Resultado.Text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Resultado.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Resultado.Text + "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Resultado.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Resultado.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Resultado.Text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Resultado.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Resultado.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Resultado.Text + "9";
        }

        private void btn_mas_Click(object sender, EventArgs e)
        {
            valor_caja = txt_Resultado.Text;
            txt_Resultado.Text = "";
            lst_Operaciones.Items.Add(valor_caja);
            lst_Operaciones.Items.Add("+");
        }

        private void btn_menos_Click(object sender, EventArgs e)
        {

        }

        private void btn_multiplicacion_Click(object sender, EventArgs e)
        {

        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {

        }

        private void btn_retroceder_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.Text.Length > 0)
            {
                /*var valor_caja = txt_Resultado.Text; //1500
                var resultado_final = ""; //150

                resultado_final = valor_caja.Substring(0, valor_caja.Length - 1);

                txt_Resultado.Text = resultado_final;*/
                txt_Resultado.Text = txt_Resultado.Text.Substring(0, txt_Resultado.Text.Length - 1);

            }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = "";
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            var valor_2 = txt_Resultado.Text;
            var resultado = Convert.ToInt32(valor_caja) + Convert.ToInt32(valor_2);
            txt_Resultado.Text = resultado.ToString();
            lst_Operaciones.Items.Add(valor_2);
            lst_Operaciones.Items.Add("= " + resultado);

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (lst_Operaciones.SelectedIndex != -1)
                {
                lst_Operaciones.Items.RemoveAt(lst_Operaciones.SelectedIndex);
            }
        }
    }
}
