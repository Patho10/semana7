namespace SistemaReservas.Views
{
    partial class FrmReservas
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
            dgvReservas = new DataGridView();
            btnNuevaReserva = new Button();
            btnEditarReserva = new Button();
            btnCancelarReserva = new Button();
            btnConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            SuspendLayout();
            // 
            // dgvReservas
            // 
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.Location = new Point(38, 12);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.RowHeadersWidth = 51;
            dgvReservas.Size = new Size(1098, 188);
            dgvReservas.TabIndex = 0;
            // 
            // btnNuevaReserva
            // 
            btnNuevaReserva.Location = new Point(38, 228);
            btnNuevaReserva.Name = "btnNuevaReserva";
            btnNuevaReserva.Size = new Size(270, 67);
            btnNuevaReserva.TabIndex = 1;
            btnNuevaReserva.Tag = "pasajero, administrador";
            btnNuevaReserva.Text = "Nueva reserva";
            btnNuevaReserva.UseVisualStyleBackColor = true;
            btnNuevaReserva.Click += btnNuevaReserva_Click;
            // 
            // btnEditarReserva
            // 
            btnEditarReserva.Location = new Point(314, 228);
            btnEditarReserva.Name = "btnEditarReserva";
            btnEditarReserva.Size = new Size(270, 67);
            btnEditarReserva.TabIndex = 2;
            btnEditarReserva.Tag = "administrador";
            btnEditarReserva.Text = "Editar reserva";
            btnEditarReserva.UseVisualStyleBackColor = true;
            btnEditarReserva.Click += btnEditarReserva_Click;
            // 
            // btnCancelarReserva
            // 
            btnCancelarReserva.Location = new Point(590, 228);
            btnCancelarReserva.Name = "btnCancelarReserva";
            btnCancelarReserva.Size = new Size(270, 67);
            btnCancelarReserva.TabIndex = 3;
            btnCancelarReserva.Tag = "administrador, pasajero";
            btnCancelarReserva.Text = "Cancelar reserva";
            btnCancelarReserva.UseVisualStyleBackColor = true;
            btnCancelarReserva.Click += btnCancelarReserva_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(866, 228);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(270, 67);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Tag = "administrador";
            btnConfirmar.Text = "Confirmar reserva";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FrmReservas
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 323);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelarReserva);
            Controls.Add(btnEditarReserva);
            Controls.Add(btnNuevaReserva);
            Controls.Add(dgvReservas);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "FrmReservas";
            Text = "FrmReservas";
            Load += FrmReservas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvReservas;
        private Button btnNuevaReserva;
        private Button btnEditarReserva;
        private Button btnCancelarReserva;
        private Button btnConfirmar;
    }
}