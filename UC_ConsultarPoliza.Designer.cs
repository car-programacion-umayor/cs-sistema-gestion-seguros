namespace SistemaGestionSeguros
{
    partial class UC_ConsultarPoliza
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
            this.lblEncabezadoBusqueda = new System.Windows.Forms.Label();
            this.lblCriterioBusqueda = new System.Windows.Forms.Label();
            this.txtCriterioBusqueda = new System.Windows.Forms.TextBox();
            this.btnEjecutarBusqueda = new System.Windows.Forms.Button();
            this.dgvListaFiltrada = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFiltrada)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEncabezadoBusqueda
            // 
            this.lblEncabezadoBusqueda.AutoSize = true;
            this.lblEncabezadoBusqueda.ForeColor = System.Drawing.Color.Black;
            this.lblEncabezadoBusqueda.Location = new System.Drawing.Point(326, 29);
            this.lblEncabezadoBusqueda.Name = "lblEncabezadoBusqueda";
            this.lblEncabezadoBusqueda.Size = new System.Drawing.Size(176, 13);
            this.lblEncabezadoBusqueda.TabIndex = 0;
            this.lblEncabezadoBusqueda.Text = "Consultas de Pólizas por Asegurado";
            // 
            // lblCriterioBusqueda
            // 
            this.lblCriterioBusqueda.AutoSize = true;
            this.lblCriterioBusqueda.Location = new System.Drawing.Point(62, 70);
            this.lblCriterioBusqueda.Name = "lblCriterioBusqueda";
            this.lblCriterioBusqueda.Size = new System.Drawing.Size(161, 13);
            this.lblCriterioBusqueda.TabIndex = 1;
            this.lblCriterioBusqueda.Text = "Ingrese RUT o código de Póliza:";
            // 
            // txtCriterioBusqueda
            // 
            this.txtCriterioBusqueda.Location = new System.Drawing.Point(239, 63);
            this.txtCriterioBusqueda.Name = "txtCriterioBusqueda";
            this.txtCriterioBusqueda.Size = new System.Drawing.Size(154, 20);
            this.txtCriterioBusqueda.TabIndex = 2;
            // 
            // btnEjecutarBusqueda
            // 
            this.btnEjecutarBusqueda.Location = new System.Drawing.Point(460, 60);
            this.btnEjecutarBusqueda.Name = "btnEjecutarBusqueda";
            this.btnEjecutarBusqueda.Size = new System.Drawing.Size(155, 23);
            this.btnEjecutarBusqueda.TabIndex = 3;
            this.btnEjecutarBusqueda.Text = "Buscar Registros";
            this.btnEjecutarBusqueda.UseVisualStyleBackColor = true;
            this.btnEjecutarBusqueda.Click += new System.EventHandler(this.btnEjecutarBusqueda_Click);
            // 
            // dgvListaFiltrada
            // 
            this.dgvListaFiltrada.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvListaFiltrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaFiltrada.Location = new System.Drawing.Point(28, 113);
            this.dgvListaFiltrada.Name = "dgvListaFiltrada";
            this.dgvListaFiltrada.Size = new System.Drawing.Size(851, 167);
            this.dgvListaFiltrada.TabIndex = 4;
            // 
            // UC_ConsultarPoliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEncabezadoBusqueda);
            this.Controls.Add(this.lblCriterioBusqueda);
            this.Controls.Add(this.txtCriterioBusqueda);
            this.Controls.Add(this.btnEjecutarBusqueda);
            this.Controls.Add(this.dgvListaFiltrada);
            this.Name = "UC_ConsultarPoliza";
            this.Size = new System.Drawing.Size(974, 528);
            this.Load += new System.EventHandler(this.UC_ConsultarPoliza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFiltrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEncabezadoBusqueda;
        private System.Windows.Forms.Label lblCriterioBusqueda;
        private System.Windows.Forms.TextBox txtCriterioBusqueda;
        private System.Windows.Forms.Button btnEjecutarBusqueda;
        private System.Windows.Forms.DataGridView dgvListaFiltrada;
    }
}
