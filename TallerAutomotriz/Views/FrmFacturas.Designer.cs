namespace TallerAutomotriz.Views
{
    partial class FrmFacturas
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
            dgv = new DataGridView();
            cmbVehiculo = new ComboBox();
            cmbEmpleado = new ComboBox();
            cmbServicio = new ComboBox();
            dtpFecha = new DateTimePicker();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(33, 14);
            dgv.Margin = new Padding(5);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(699, 247);
            dgv.TabIndex = 0;
            dgv.SelectionChanged += dgv_SelectionChanged;
            // 
            // cmbVehiculo
            // 
            cmbVehiculo.FormattingEnabled = true;
            cmbVehiculo.Location = new Point(165, 305);
            cmbVehiculo.Name = "cmbVehiculo";
            cmbVehiculo.Size = new Size(329, 39);
            cmbVehiculo.TabIndex = 1;
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(165, 366);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(329, 39);
            cmbEmpleado.TabIndex = 2;
            // 
            // cmbServicio
            // 
            cmbServicio.FormattingEnabled = true;
            cmbServicio.Location = new Point(165, 426);
            cmbServicio.Name = "cmbServicio";
            cmbServicio.Size = new Size(329, 39);
            cmbServicio.TabIndex = 3;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(165, 481);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 38);
            dtpFecha.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(590, 305);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(142, 39);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(590, 366);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(142, 39);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(590, 426);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(142, 39);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 308);
            label1.Name = "label1";
            label1.Size = new Size(113, 31);
            label1.TabIndex = 8;
            label1.Text = "Vehiculo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 369);
            label2.Name = "label2";
            label2.Size = new Size(126, 31);
            label2.TabIndex = 9;
            label2.Text = "Empleado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 426);
            label3.Name = "label3";
            label3.Size = new Size(106, 31);
            label3.TabIndex = 10;
            label3.Text = "Servicio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 481);
            label4.Name = "label4";
            label4.Size = new Size(81, 31);
            label4.TabIndex = 11;
            label4.Text = "Fecha:";
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(590, 480);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(142, 39);
            btnAtras.TabIndex = 12;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // FrmFacturas
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 549);
            Controls.Add(btnAtras);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(dtpFecha);
            Controls.Add(cmbServicio);
            Controls.Add(cmbEmpleado);
            Controls.Add(cmbVehiculo);
            Controls.Add(dgv);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "FrmFacturas";
            Text = "FrmFacturas";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private ComboBox cmbVehiculo;
        private ComboBox cmbEmpleado;
        private ComboBox cmbServicio;
        private DateTimePicker dtpFecha;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAtras;
    }
}