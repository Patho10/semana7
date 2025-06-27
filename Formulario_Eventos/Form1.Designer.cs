namespace Formulario_Eventos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtDigitos = new System.Windows.Forms.TextBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnIniciarTimer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(62, 33);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(300, 29);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Estado: Esperando Click";
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // txtDigitos
            // 
            this.txtDigitos.Location = new System.Drawing.Point(67, 90);
            this.txtDigitos.Name = "txtDigitos";
            this.txtDigitos.Size = new System.Drawing.Size(295, 34);
            this.txtDigitos.TabIndex = 1;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.btnIniciarTimer);
            this.panelContenedor.Location = new System.Drawing.Point(67, 144);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(295, 125);
            this.panelContenedor.TabIndex = 2;
            // 
            // btnIniciarTimer
            // 
            this.btnIniciarTimer.Location = new System.Drawing.Point(61, 22);
            this.btnIniciarTimer.Name = "btnIniciarTimer";
            this.btnIniciarTimer.Size = new System.Drawing.Size(165, 68);
            this.btnIniciarTimer.TabIndex = 0;
            this.btnIniciarTimer.Text = "Iniciar";
            this.btnIniciarTimer.UseVisualStyleBackColor = true;
            this.btnIniciarTimer.Click += new System.EventHandler(this.btnIniciarTimer_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 362);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.txtDigitos);
            this.Controls.Add(this.lblEstado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtDigitos;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnIniciarTimer;
        private System.Windows.Forms.Timer timer1;
    }
}

