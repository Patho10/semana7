namespace TallerAutomotriz.Views
{
    partial class FrmVehiculo
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
            txtPlaca = new TextBox();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            cmbClientes = new ComboBox();
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
            dgv.Location = new Point(36, 2);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(591, 188);
            dgv.TabIndex = 0;
            dgv.SelectionChanged += dgv_SelectionChanged;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(163, 215);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(246, 38);
            txtPlaca.TabIndex = 1;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(163, 271);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(246, 38);
            txtMarca.TabIndex = 2;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(163, 327);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(246, 38);
            txtModelo.TabIndex = 3;
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(163, 386);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(246, 39);
            cmbClientes.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(473, 215);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(154, 38);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(473, 271);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(154, 38);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(473, 327);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(154, 38);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 222);
            label1.Name = "label1";
            label1.Size = new Size(76, 31);
            label1.TabIndex = 8;
            label1.Text = "Placa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 278);
            label2.Name = "label2";
            label2.Size = new Size(86, 31);
            label2.TabIndex = 9;
            label2.Text = "Marca:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 327);
            label3.Name = "label3";
            label3.Size = new Size(103, 31);
            label3.TabIndex = 10;
            label3.Text = "Modelo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 389);
            label4.Name = "label4";
            label4.Size = new Size(95, 31);
            label4.TabIndex = 11;
            label4.Text = "Cliente:";
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(473, 386);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(154, 38);
            btnAtras.TabIndex = 12;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // FrmVehiculo
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 444);
            Controls.Add(btnAtras);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(cmbClientes);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(txtPlaca);
            Controls.Add(dgv);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "FrmVehiculo";
            Text = "FrmVehiculo";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private TextBox txtPlaca;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private ComboBox cmbClientes;
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