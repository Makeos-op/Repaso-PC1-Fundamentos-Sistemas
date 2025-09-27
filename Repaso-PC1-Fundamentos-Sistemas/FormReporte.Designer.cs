namespace Repaso_PC1_Fundamentos_Sistemas
{
    partial class FormReporte
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
            this.dgAlmancen = new System.Windows.Forms.DataGridView();
            this.btnAlmacenes_por_tipo = new System.Windows.Forms.Button();
            this.btnAlmacenSinServicios = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlmancen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAlmancen
            // 
            this.dgAlmancen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlmancen.Location = new System.Drawing.Point(49, 139);
            this.dgAlmancen.Name = "dgAlmancen";
            this.dgAlmancen.RowHeadersWidth = 51;
            this.dgAlmancen.RowTemplate.Height = 24;
            this.dgAlmancen.Size = new System.Drawing.Size(709, 248);
            this.dgAlmancen.TabIndex = 10;
            // 
            // btnAlmacenes_por_tipo
            // 
            this.btnAlmacenes_por_tipo.Location = new System.Drawing.Point(589, 40);
            this.btnAlmacenes_por_tipo.Name = "btnAlmacenes_por_tipo";
            this.btnAlmacenes_por_tipo.Size = new System.Drawing.Size(157, 65);
            this.btnAlmacenes_por_tipo.TabIndex = 11;
            this.btnAlmacenes_por_tipo.Text = "Almacenes por tipo";
            this.btnAlmacenes_por_tipo.UseVisualStyleBackColor = true;
            this.btnAlmacenes_por_tipo.Click += new System.EventHandler(this.btnAlmacenes_por_tipo_Click);
            // 
            // btnAlmacenSinServicios
            // 
            this.btnAlmacenSinServicios.Location = new System.Drawing.Point(67, 40);
            this.btnAlmacenSinServicios.Name = "btnAlmacenSinServicios";
            this.btnAlmacenSinServicios.Size = new System.Drawing.Size(171, 65);
            this.btnAlmacenSinServicios.TabIndex = 12;
            this.btnAlmacenSinServicios.Text = "Almacenes sin servicios registrados";
            this.btnAlmacenSinServicios.UseVisualStyleBackColor = true;
            this.btnAlmacenSinServicios.Click += new System.EventHandler(this.btnAlmacenSinServicios_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(24, 414);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 24);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Atras";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Insumos",
            "Productos terminados",
            "Tránsito",
            "Distribución"});
            this.cbTipo.Location = new System.Drawing.Point(315, 61);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(268, 24);
            this.cbTipo.TabIndex = 14;
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAlmacenSinServicios);
            this.Controls.Add(this.btnAlmacenes_por_tipo);
            this.Controls.Add(this.dgAlmancen);
            this.Name = "FormReporte";
            this.Text = "FormReporte";
            ((System.ComponentModel.ISupportInitialize)(this.dgAlmancen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAlmancen;
        private System.Windows.Forms.Button btnAlmacenes_por_tipo;
        private System.Windows.Forms.Button btnAlmacenSinServicios;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cbTipo;
    }
}