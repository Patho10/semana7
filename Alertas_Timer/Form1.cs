using Alertas_Timer.Controllers;
using Alertas_Timer.Models;
namespace Alertas_Timer
{
    public partial class Form1 : Form
    {
        private readonly AlertaController _alertaController;
        public Form1()
        {

            InitializeComponent();
            _alertaController = new AlertaController();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //dgvListaAllertas.Columns["Id"].Visible = false;
            dgvListaAllertas.AutoGenerateColumns = false;
            dgvListaAllertas.Columns.Clear();
            /*var lista_alertas = new List<AlertaModel>();
         lista_alertas = _alertaController.todos();
         var colId = new DataGridViewTextBoxColumn();
         colId.HeaderText = "Id";
         colId.DataPropertyName = "Id";
         dgvListaAllertas.Columns.Add(colId);

         var colTipo = new DataGridViewTextBoxColumn();
         colTipo.HeaderText = "Tipo de Alerta";
         colTipo.DataPropertyName = "tipo";   //este debe se igual al de la base de datos
         dgvListaAllertas.Columns.Add(colTipo);

         var colSrvidor = new DataGridViewTextBoxColumn();
         colSrvidor.HeaderText = "Ubicacion Servidor";
         colSrvidor.DataPropertyName = "servidores.ubicacion";   //este debe se igual al de la base de datos
         dgvListaAllertas.Columns.Add(colSrvidor);

         */
            dgvListaAllertas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Id",
                DataPropertyName = "Id",
            });
            dgvListaAllertas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Tipo de Alerta",
                DataPropertyName = "tipo",
            });
            dgvListaAllertas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Ubicacion del Servidor",
                DataPropertyName = "ubicacion_servidor",
            });
            dgvListaAllertas.DataSource = _alertaController.todos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 5000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
