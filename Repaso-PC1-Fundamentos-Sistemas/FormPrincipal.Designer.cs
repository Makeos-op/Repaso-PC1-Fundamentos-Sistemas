namespace Repaso_PC1_Fundamentos_Sistemas
{
    partial class FormPrincipal
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
            this.RegistroAlmacen = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegistroAlmacen
            // 
            this.RegistroAlmacen.Location = new System.Drawing.Point(128, 89);
            this.RegistroAlmacen.Name = "RegistroAlmacen";
            this.RegistroAlmacen.Size = new System.Drawing.Size(194, 35);
            this.RegistroAlmacen.TabIndex = 0;
            this.RegistroAlmacen.Text = "Registrar Almacen";
            this.RegistroAlmacen.UseVisualStyleBackColor = true;
            this.RegistroAlmacen.Click += new System.EventHandler(this.RegistroAlmacen_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(166, 196);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(110, 37);
            this.Salir.TabIndex = 1;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(128, 146);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(194, 35);
            this.btnReporte.TabIndex = 2;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 328);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.RegistroAlmacen);
            this.Name = "FormPrincipal";
            this.Text = "FormularioPC1-Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RegistroAlmacen;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button btnReporte;
    }
}