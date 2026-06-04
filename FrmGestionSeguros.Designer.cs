namespace SistemaGestionSeguros
{
    partial class FrmGestionSeguros
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPoliza = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSimulacion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuListado = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(944, 450);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCliente,
            this.menuPoliza,
            this.menuConsulta,
            this.menuSimulacion,
            this.menuListado});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(944, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuPrincipal";
            // 
            // menuCliente
            // 
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(106, 20);
            this.menuCliente.Text = "Agregar Clientes";
            this.menuCliente.Click += new System.EventHandler(this.menuCliente_Click);
            // 
            // menuPoliza
            // 
            this.menuPoliza.Name = "menuPoliza";
            this.menuPoliza.Size = new System.Drawing.Size(100, 20);
            this.menuPoliza.Text = "Agregar Pólizas";
            this.menuPoliza.Click += new System.EventHandler(this.menuPoliza_Click);
            // 
            // menuConsulta
            // 
            this.menuConsulta.Name = "menuConsulta";
            this.menuConsulta.Size = new System.Drawing.Size(238, 20);
            this.menuConsulta.Text = "Consultar por Clientes y Pólizas asociadas";
            this.menuConsulta.Click += new System.EventHandler(this.menuConsulta_Click);
            // 
            // menuSimulacion
            // 
            this.menuSimulacion.Name = "menuSimulacion";
            this.menuSimulacion.Size = new System.Drawing.Size(208, 20);
            this.menuSimulacion.Text = "Simular la adquisición de una póliza";
            this.menuSimulacion.Click += new System.EventHandler(this.menuSimulacion_Click);
            // 
            // menuListado
            // 
            this.menuListado.Name = "menuListado";
            this.menuListado.Size = new System.Drawing.Size(215, 20);
            this.menuListado.Text = "Listado de Cliente y Pólizas asociadas";
            this.menuListado.Click += new System.EventHandler(this.menuListado_Click);
            // 
            // FrmGestionSeguros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.pnlPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmGestionSeguros";
            this.Text = "Gestión de Pólizas - Aseguradora";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.MenuStrip menuPrincipal; // Nombre corregido aquí
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.ToolStripMenuItem menuPoliza;
        private System.Windows.Forms.ToolStripMenuItem menuConsulta;
        private System.Windows.Forms.ToolStripMenuItem menuSimulacion;
        private System.Windows.Forms.ToolStripMenuItem menuListado;
    }
}

