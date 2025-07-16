namespace TallerAutomotriz.Views
{
    partial class FrmEmpleados
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
            txtNombre = new TextBox();
            txtCargo = new TextBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            btnAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(32, 15);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(622, 228);
            dgv.TabIndex = 0;
            dgv.SelectionChanged += dgv_SelectionChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(145, 266);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(309, 38);
            txtNombre.TabIndex = 1;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(145, 321);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(309, 38);
            txtCargo.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(512, 266);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(142, 38);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(512, 320);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(142, 38);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(512, 364);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(142, 43);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 269);
            label1.Name = "label1";
            label1.Size = new Size(108, 31);
            label1.TabIndex = 6;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 321);
            label2.Name = "label2";
            label2.Size = new Size(83, 31);
            label2.TabIndex = 7;
            label2.Text = "Cargo:";
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(213, 369);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(142, 38);
            btnAtras.TabIndex = 8;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // FrmEmpleados
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 438);
            Controls.Add(btnAtras);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(txtCargo);
            Controls.Add(txtNombre);
            Controls.Add(dgv);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "FrmEmpleados";
            Text = "FrmEmpleados";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private TextBox txtNombre;
        private TextBox txtCargo;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label label1;
        private Label label2;
        private Button btnAtras;
    }
}