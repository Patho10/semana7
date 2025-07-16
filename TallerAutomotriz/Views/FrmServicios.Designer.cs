namespace TallerAutomotriz.Views
{
    partial class FrmServicios
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
            txtDescripcion = new TextBox();
            nudCosto = new NumericUpDown();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            btnAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCosto).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(72, 27);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(623, 221);
            dgv.TabIndex = 0;
            dgv.SelectionChanged += dgv_SelectionChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(224, 273);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(305, 38);
            txtDescripcion.TabIndex = 1;
            // 
            // nudCosto
            // 
            nudCosto.Location = new Point(224, 332);
            nudCosto.Name = "nudCosto";
            nudCosto.Size = new Size(196, 38);
            nudCosto.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(544, 273);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(151, 38);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(544, 321);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(151, 44);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(544, 376);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(151, 44);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 276);
            label1.Name = "label1";
            label1.Size = new Size(146, 31);
            label1.TabIndex = 6;
            label1.Text = "Descripcion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 334);
            label2.Name = "label2";
            label2.Size = new Size(81, 31);
            label2.TabIndex = 7;
            label2.Text = "Costo:";
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(378, 379);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(151, 41);
            btnAtras.TabIndex = 8;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // FrmServicios
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 438);
            Controls.Add(btnAtras);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(nudCosto);
            Controls.Add(txtDescripcion);
            Controls.Add(dgv);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "FrmServicios";
            Text = "FrmServicios";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCosto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private TextBox txtDescripcion;
        private NumericUpDown nudCosto;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label label1;
        private Label label2;
        private Button btnAtras;
    }
}