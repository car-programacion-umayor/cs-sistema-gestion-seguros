namespace SistemaGestionSeguros
{
    partial class UC_AgregarPoliza
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblVigencia = new System.Windows.Forms.Label();
            this.lblValorUF = new System.Windows.Forms.Label();
            this.lblCoberturaUF = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtVigencia = new System.Windows.Forms.TextBox();
            this.txtValorUF = new System.Windows.Forms.TextBox();
            this.txtCoberturaUF = new System.Windows.Forms.TextBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.cmbTipoPoliza = new System.Windows.Forms.ComboBox();
            this.btnGenerarCodigo = new System.Windows.Forms.Button();
            this.lblCriterioBusqueda = new System.Windows.Forms.Label();
            this.txtRutBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblClienteResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(33, 167);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(71, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código Póliza";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(33, 106);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(59, 13);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo Póliza";
            // 
            // lblVigencia
            // 
            this.lblVigencia.AutoSize = true;
            this.lblVigencia.Location = new System.Drawing.Point(33, 189);
            this.lblVigencia.Name = "lblVigencia";
            this.lblVigencia.Size = new System.Drawing.Size(80, 13);
            this.lblVigencia.TabIndex = 2;
            this.lblVigencia.Text = "Vigencia (años)";
            // 
            // lblValorUF
            // 
            this.lblValorUF.AutoSize = true;
            this.lblValorUF.Location = new System.Drawing.Point(33, 214);
            this.lblValorUF.Name = "lblValorUF";
            this.lblValorUF.Size = new System.Drawing.Size(85, 13);
            this.lblValorUF.TabIndex = 3;
            this.lblValorUF.Text = "Valor Póliza (UF)";
            // 
            // lblCoberturaUF
            // 
            this.lblCoberturaUF.AutoSize = true;
            this.lblCoberturaUF.Location = new System.Drawing.Point(33, 240);
            this.lblCoberturaUF.Name = "lblCoberturaUF";
            this.lblCoberturaUF.Size = new System.Drawing.Size(76, 13);
            this.lblCoberturaUF.TabIndex = 4;
            this.lblCoberturaUF.Text = "Cobertura (UF)";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(127, 160);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(179, 20);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtVigencia
            // 
            this.txtVigencia.Location = new System.Drawing.Point(127, 186);
            this.txtVigencia.Name = "txtVigencia";
            this.txtVigencia.Size = new System.Drawing.Size(179, 20);
            this.txtVigencia.TabIndex = 7;
            // 
            // txtValorUF
            // 
            this.txtValorUF.Location = new System.Drawing.Point(127, 211);
            this.txtValorUF.Name = "txtValorUF";
            this.txtValorUF.ReadOnly = true;
            this.txtValorUF.Size = new System.Drawing.Size(179, 20);
            this.txtValorUF.TabIndex = 8;
            // 
            // txtCoberturaUF
            // 
            this.txtCoberturaUF.Location = new System.Drawing.Point(127, 237);
            this.txtCoberturaUF.Name = "txtCoberturaUF";
            this.txtCoberturaUF.ReadOnly = true;
            this.txtCoberturaUF.Size = new System.Drawing.Size(179, 20);
            this.txtCoberturaUF.TabIndex = 9;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(145, 279);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(125, 23);
            this.btnFinalizar.TabIndex = 10;
            this.btnFinalizar.Text = "Finalizar Registro";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // cmbTipoPoliza
            // 
            this.cmbTipoPoliza.FormattingEnabled = true;
            this.cmbTipoPoliza.Location = new System.Drawing.Point(127, 99);
            this.cmbTipoPoliza.Name = "cmbTipoPoliza";
            this.cmbTipoPoliza.Size = new System.Drawing.Size(179, 21);
            this.cmbTipoPoliza.TabIndex = 11;
            this.cmbTipoPoliza.SelectedIndexChanged += new System.EventHandler(this.tipoPoliza_SelectedIndexChanged);
            // 
            // btnGenerarCodigo
            // 
            this.btnGenerarCodigo.Location = new System.Drawing.Point(145, 131);
            this.btnGenerarCodigo.Name = "btnGenerarCodigo";
            this.btnGenerarCodigo.Size = new System.Drawing.Size(142, 23);
            this.btnGenerarCodigo.TabIndex = 12;
            this.btnGenerarCodigo.Text = "Generar Codigo de poliza";
            this.btnGenerarCodigo.UseVisualStyleBackColor = true;
            this.btnGenerarCodigo.Click += new System.EventHandler(this.btnGenerarCodigo_Click);
            // 
            // lblCriterioBusqueda
            // 
            this.lblCriterioBusqueda.AutoSize = true;
            this.lblCriterioBusqueda.Location = new System.Drawing.Point(22, 44);
            this.lblCriterioBusqueda.Name = "lblCriterioBusqueda";
            this.lblCriterioBusqueda.Size = new System.Drawing.Size(119, 13);
            this.lblCriterioBusqueda.TabIndex = 13;
            this.lblCriterioBusqueda.Text = "Ingrese RUT del cliente";
            this.lblCriterioBusqueda.Click += new System.EventHandler(this.lblCriterioBusqueda_Click);
            // 
            // txtRutBuscar
            // 
            this.txtRutBuscar.Location = new System.Drawing.Point(147, 41);
            this.txtRutBuscar.Name = "txtRutBuscar";
            this.txtRutBuscar.Size = new System.Drawing.Size(154, 20);
            this.txtRutBuscar.TabIndex = 14;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(307, 41);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(142, 23);
            this.btnBuscarCliente.TabIndex = 15;
            this.btnBuscarCliente.Text = "Consultar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblClienteResultado
            // 
            this.lblClienteResultado.AutoSize = true;
            this.lblClienteResultado.Location = new System.Drawing.Point(144, 64);
            this.lblClienteResultado.Name = "lblClienteResultado";
            this.lblClienteResultado.Size = new System.Drawing.Size(0, 13);
            this.lblClienteResultado.TabIndex = 17;
            // 
            // UC_AgregarPoliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCriterioBusqueda);
            this.Controls.Add(this.txtRutBuscar);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.lblClienteResultado);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbTipoPoliza);
            this.Controls.Add(this.btnGenerarCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblVigencia);
            this.Controls.Add(this.txtVigencia);
            this.Controls.Add(this.lblValorUF);
            this.Controls.Add(this.txtValorUF);
            this.Controls.Add(this.lblCoberturaUF);
            this.Controls.Add(this.txtCoberturaUF);
            this.Controls.Add(this.btnFinalizar);
            this.Name = "UC_AgregarPoliza";
            this.Size = new System.Drawing.Size(623, 334);
            this.Load += new System.EventHandler(this.UC_AgregarPoliza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblVigencia;
        private System.Windows.Forms.Label lblValorUF;
        private System.Windows.Forms.Label lblCoberturaUF;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtVigencia;
        private System.Windows.Forms.TextBox txtValorUF;
        private System.Windows.Forms.TextBox txtCoberturaUF;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.ComboBox cmbTipoPoliza;
        private System.Windows.Forms.Button btnGenerarCodigo;
        private System.Windows.Forms.Label lblCriterioBusqueda;
        private System.Windows.Forms.TextBox txtRutBuscar;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblClienteResultado;
    }
}
