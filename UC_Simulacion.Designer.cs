namespace SistemaGestionSeguros
{
    partial class UC_Simulacion
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
            this.lblValorUfHoy = new System.Windows.Forms.Label();
            this.lblIndicadorCodigo = new System.Windows.Forms.Label();
            this.lblTextoResultado = new System.Windows.Forms.Label();
            this.txtCodigoSimular = new System.Windows.Forms.TextBox();
            this.txtValorUfHoy = new System.Windows.Forms.TextBox();
            this.lblResultadoPesos = new System.Windows.Forms.Label();
            this.btnSimularYGuardar = new System.Windows.Forms.Button();
            this.dgvSimulaciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValorUfHoy
            // 
            this.lblValorUfHoy.AutoSize = true;
            this.lblValorUfHoy.Location = new System.Drawing.Point(51, 102);
            this.lblValorUfHoy.Name = "lblValorUfHoy";
            this.lblValorUfHoy.Size = new System.Drawing.Size(88, 13);
            this.lblValorUfHoy.TabIndex = 0;
            this.lblValorUfHoy.Text = "Valor UF Hoy ($):";
            // 
            // lblIndicadorCodigo
            // 
            this.lblIndicadorCodigo.AutoSize = true;
            this.lblIndicadorCodigo.Location = new System.Drawing.Point(51, 69);
            this.lblIndicadorCodigo.Name = "lblIndicadorCodigo";
            this.lblIndicadorCodigo.Size = new System.Drawing.Size(127, 13);
            this.lblIndicadorCodigo.TabIndex = 1;
            this.lblIndicadorCodigo.Text = "Ingrese Código de Póliza:";
            // 
            // lblTextoResultado
            // 
            this.lblTextoResultado.AutoSize = true;
            this.lblTextoResultado.Location = new System.Drawing.Point(62, 182);
            this.lblTextoResultado.Name = "lblTextoResultado";
            this.lblTextoResultado.Size = new System.Drawing.Size(58, 13);
            this.lblTextoResultado.TabIndex = 2;
            this.lblTextoResultado.Text = "Resultado:";
            // 
            // txtCodigoSimular
            // 
            this.txtCodigoSimular.Location = new System.Drawing.Point(185, 66);
            this.txtCodigoSimular.Name = "txtCodigoSimular";
            this.txtCodigoSimular.Size = new System.Drawing.Size(162, 20);
            this.txtCodigoSimular.TabIndex = 3;
            // 
            // txtValorUfHoy
            // 
            this.txtValorUfHoy.Location = new System.Drawing.Point(185, 95);
            this.txtValorUfHoy.Name = "txtValorUfHoy";
            this.txtValorUfHoy.Size = new System.Drawing.Size(162, 20);
            this.txtValorUfHoy.TabIndex = 6;
            // 
            // lblResultadoPesos
            // 
            this.lblResultadoPesos.AutoSize = true;
            this.lblResultadoPesos.Location = new System.Drawing.Point(170, 182);
            this.lblResultadoPesos.Name = "lblResultadoPesos";
            this.lblResultadoPesos.Size = new System.Drawing.Size(22, 13);
            this.lblResultadoPesos.TabIndex = 7;
            this.lblResultadoPesos.Text = "$ 0";
            // 
            // btnSimularYGuardar
            // 
            this.btnSimularYGuardar.Location = new System.Drawing.Point(143, 132);
            this.btnSimularYGuardar.Name = "btnSimularYGuardar";
            this.btnSimularYGuardar.Size = new System.Drawing.Size(126, 23);
            this.btnSimularYGuardar.TabIndex = 8;
            this.btnSimularYGuardar.Text = "Simular y Guardar";
            this.btnSimularYGuardar.Click += new System.EventHandler(this.btnSimularYGuardar_Click);
            // 
            // dgvSimulaciones
            // 
            this.dgvSimulaciones.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSimulaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimulaciones.Location = new System.Drawing.Point(23, 210);
            this.dgvSimulaciones.Name = "dgvSimulaciones";
            this.dgvSimulaciones.Size = new System.Drawing.Size(867, 90);
            this.dgvSimulaciones.TabIndex = 9;
            // 
            // UC_Simulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblIndicadorCodigo);
            this.Controls.Add(this.txtCodigoSimular);
            this.Controls.Add(this.lblValorUfHoy);
            this.Controls.Add(this.txtValorUfHoy);
            this.Controls.Add(this.btnSimularYGuardar);
            this.Controls.Add(this.lblResultadoPesos);
            this.Controls.Add(this.lblTextoResultado);
            this.Controls.Add(this.dgvSimulaciones);
            this.Name = "UC_Simulacion";
            this.Size = new System.Drawing.Size(950, 492);
            this.Load += new System.EventHandler(this.UC_Simulacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorUfHoy;
        private System.Windows.Forms.Label lblIndicadorCodigo;
        private System.Windows.Forms.Label lblTextoResultado;
        private System.Windows.Forms.TextBox txtCodigoSimular;
        private System.Windows.Forms.TextBox txtValorUfHoy;
        private System.Windows.Forms.Label lblResultadoPesos;
        private System.Windows.Forms.Button btnSimularYGuardar;
        private System.Windows.Forms.DataGridView dgvSimulaciones;
    }
}
