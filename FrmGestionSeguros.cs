using System;
using System.Windows.Forms;

namespace SistemaGestionSeguros
{
    /// <summary>
    /// Formulario principal que actúa como contenedor y gestor de navegación de la aplicación.
    /// </summary>
    public partial class FrmGestionSeguros : Form
    {
        public FrmGestionSeguros()
        {
            InitializeComponent();
            // Establece la vista inicial del sistema al cargar el formulario
            PresentarModulo(new UC_AgregarCliente());
        }

        /// <summary>
        /// Gestiona el intercambio dinámico de módulos dentro del panel principal.
        /// </summary>
        /// <param name="modulo">Instancia del UserControl a visualizar.</param>
        private void PresentarModulo(UserControl modulo)
        {
            pnlPrincipal.Controls.Clear();
            modulo.Dock = DockStyle.Fill;
            pnlPrincipal.Controls.Add(modulo);
        }

        // --- Gestión de Eventos de Navegación ---

        private void menuCliente_Click(object sender, EventArgs e)
        {
            PresentarModulo(new UC_AgregarCliente());
        }

        private void menuPoliza_Click(object sender, EventArgs e)
        {
            PresentarModulo(new UC_AgregarPoliza());
        }

        private void menuConsulta_Click(object sender, EventArgs e)
        {
            PresentarModulo(new UC_ConsultarPoliza());
        }

        private void menuSimulacion_Click(object sender, EventArgs e)
        {
            PresentarModulo(new UC_Simulacion());
        }

        private void menuListado_Click(object sender, EventArgs e)
        {
            PresentarModulo(new UC_ListadoGeneral());
        }
    }
}