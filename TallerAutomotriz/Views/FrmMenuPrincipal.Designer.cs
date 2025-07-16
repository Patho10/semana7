namespace TallerAutomotriz.Views
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClientes = new Button();
            btnVehiculos = new Button();
            btnEmpleados = new Button();
            btnServicios = new Button();
            btnFacturas = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(55, 68);
            btnClientes.Margin = new Padding(5);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(173, 145);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnVehiculos
            // 
            btnVehiculos.Location = new Point(55, 331);
            btnVehiculos.Margin = new Padding(5);
            btnVehiculos.Name = "btnVehiculos";
            btnVehiculos.Size = new Size(173, 145);
            btnVehiculos.TabIndex = 1;
            btnVehiculos.Text = "Vehiculos";
            btnVehiculos.UseVisualStyleBackColor = true;
            btnVehiculos.Click += btnVehiculos_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.Location = new Point(260, 199);
            btnEmpleados.Margin = new Padding(5);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(173, 145);
            btnEmpleados.TabIndex = 2;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnServicios
            // 
            btnServicios.Location = new Point(467, 68);
            btnServicios.Margin = new Padding(5);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(164, 145);
            btnServicios.TabIndex = 3;
            btnServicios.Text = "Servicios";
            btnServicios.UseVisualStyleBackColor = true;
            btnServicios.Click += btnServicios_Click;
            // 
            // btnFacturas
            // 
            btnFacturas.Location = new Point(467, 331);
            btnFacturas.Margin = new Padding(5);
            btnFacturas.Name = "btnFacturas";
            btnFacturas.Size = new Size(164, 145);
            btnFacturas.TabIndex = 4;
            btnFacturas.Text = "Facturas";
            btnFacturas.UseVisualStyleBackColor = true;
            btnFacturas.Click += btnFacturas_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(260, 401);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(173, 63);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(687, 517);
            Controls.Add(btnSalir);
            Controls.Add(btnFacturas);
            Controls.Add(btnServicios);
            Controls.Add(btnEmpleados);
            Controls.Add(btnVehiculos);
            Controls.Add(btnClientes);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "FrmMenuPrincipal";
            Text = "FrmMenuPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
        private Button btnVehiculos;
        private Button btnEmpleados;
        private Button btnServicios;
        private Button btnFacturas;
        private Button btnSalir;
    }
}