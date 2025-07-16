namespace TallerAutomotriz.Views
{
    partial class FrmClientes
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
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            btnAgregar = new Button();
            btnActulizar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(227, 12);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(401, 188);
            dgv.TabIndex = 0;
            dgv.SelectionChanged += dgv_SelectionChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(227, 258);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(401, 38);
            txtNombre.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(227, 319);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(401, 38);
            txtTelefono.TabIndex = 2;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(227, 380);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(401, 38);
            txtDireccion.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(653, 258);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(130, 38);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActulizar
            // 
            btnActulizar.Location = new Point(653, 319);
            btnActulizar.Name = "btnActulizar";
            btnActulizar.Size = new Size(130, 38);
            btnActulizar.TabIndex = 5;
            btnActulizar.Text = "Actualizar";
            btnActulizar.UseVisualStyleBackColor = true;
            btnActulizar.Click += btnActulizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(653, 379);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 38);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 261);
            label1.Name = "label1";
            label1.Size = new Size(108, 31);
            label1.TabIndex = 7;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 319);
            label2.Name = "label2";
            label2.Size = new Size(113, 31);
            label2.TabIndex = 8;
            label2.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 387);
            label3.Name = "label3";
            label3.Size = new Size(122, 31);
            label3.TabIndex = 9;
            label3.Text = "Direccion:";
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(377, 440);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(131, 45);
            btnAtras.TabIndex = 10;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 514);
            Controls.Add(btnAtras);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnActulizar);
            Controls.Add(btnAgregar);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(dgv);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "FrmClientes";
            Text = "FrmClientes";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private Button btnAgregar;
        private Button btnActulizar;
        private Button btnEliminar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAtras;
    }
}