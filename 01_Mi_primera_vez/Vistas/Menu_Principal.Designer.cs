namespace _01_Mi_primera_vez.Vistas
{
    partial class Menu_Principal
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
            this.btn_calculadora = new System.Windows.Forms.Button();
            this.btn_agenda = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_calculadora
            // 
            this.btn_calculadora.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_calculadora.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_calculadora.Location = new System.Drawing.Point(0, 0);
            this.btn_calculadora.Margin = new System.Windows.Forms.Padding(5);
            this.btn_calculadora.Name = "btn_calculadora";
            this.btn_calculadora.Size = new System.Drawing.Size(178, 527);
            this.btn_calculadora.TabIndex = 0;
            this.btn_calculadora.Text = "Calculadora ";
            this.btn_calculadora.UseVisualStyleBackColor = true;
            this.btn_calculadora.Click += new System.EventHandler(this.btn_calculadora_Click);
            // 
            // btn_agenda
            // 
            this.btn_agenda.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_agenda.Location = new System.Drawing.Point(713, 0);
            this.btn_agenda.Margin = new System.Windows.Forms.Padding(5);
            this.btn_agenda.Name = "btn_agenda";
            this.btn_agenda.Size = new System.Drawing.Size(178, 527);
            this.btn_agenda.TabIndex = 1;
            this.btn_agenda.Text = "Agenda";
            this.btn_agenda.UseVisualStyleBackColor = true;
            this.btn_agenda.Click += new System.EventHandler(this.btn_agenda_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_calculadora);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 527);
            this.panel1.TabIndex = 2;
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(891, 527);
            this.Controls.Add(this.btn_agenda);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Menu_Principal";
            this.Text = "Menu Principal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_calculadora;
        private System.Windows.Forms.Button btn_agenda;
        private System.Windows.Forms.Panel panel1;
    }
}