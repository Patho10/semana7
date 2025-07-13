namespace Alertas_Timer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            dgvListaAllertas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListaAllertas).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(692, 339);
            button1.Name = "button1";
            button1.Size = new Size(138, 64);
            button1.TabIndex = 0;
            button1.Text = "Detener";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(159, 339);
            button2.Name = "button2";
            button2.Size = new Size(138, 64);
            button2.TabIndex = 1;
            button2.Text = "Iniciar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dgvListaAllertas
            // 
            dgvListaAllertas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaAllertas.Location = new Point(78, 27);
            dgvListaAllertas.Name = "dgvListaAllertas";
            dgvListaAllertas.RowHeadersWidth = 51;
            dgvListaAllertas.Size = new Size(881, 265);
            dgvListaAllertas.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 493);
            Controls.Add(dgvListaAllertas);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaAllertas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
        private DataGridView dgvListaAllertas;
    }
}
