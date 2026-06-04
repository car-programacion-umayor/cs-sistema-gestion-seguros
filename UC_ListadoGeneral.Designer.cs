namespace SistemaGestionSeguros
{
    partial class UC_ListadoGeneral
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEncabezadoListado = new System.Windows.Forms.Label();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEncabezadoListado
            // 
            this.lblEncabezadoListado.AutoSize = true;
            this.lblEncabezadoListado.Location = new System.Drawing.Point(394, 32);
            this.lblEncabezadoListado.Name = "lblEncabezadoListado";
            this.lblEncabezadoListado.Size = new System.Drawing.Size(151, 13);
            this.lblEncabezadoListado.TabIndex = 0;
            this.lblEncabezadoListado.Text = "Listado de Pólizas contratadas";
            // 
            // dgvListado
            // 
            this.dgvListado.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(18, 98);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(911, 177);
            this.dgvListado.TabIndex = 1;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(818, 55);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(99, 23);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar Listado";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // UC_ListadoGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEncabezadoListado);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dgvListado);
            this.Name = "UC_ListadoGeneral";
            this.Size = new System.Drawing.Size(963, 340);
            this.Load += new System.EventHandler(this.UC_ListadoGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEncabezadoListado;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Button btnCargar;
    }
}
