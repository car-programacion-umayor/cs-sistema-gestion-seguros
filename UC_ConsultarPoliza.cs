using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SistemaGestionSeguros
{
    /// <summary>
    /// Componente encargado de la recuperación y filtrado de registros mediante consultas dinámicas.
    /// </summary>
    public partial class UC_ConsultarPoliza : UserControl
    {
        public UC_ConsultarPoliza()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ejecuta el proceso de filtrado de datos basándose en parámetros de identidad o referencia de póliza.
        /// </summary>
        private void btnEjecutarBusqueda_Click(object sender, EventArgs e)
        {
            // Normalización del parámetro de entrada para asegurar la coincidencia de datos
            string criterioBusqueda = txtCriterioBusqueda.Text.Trim();

            // Validación de integridad del parámetro requerido para la operación de búsqueda
            if (string.IsNullOrEmpty(criterioBusqueda))
            {
                MessageBox.Show("Operación cancelada: Ingrese un RUT de cliente o un Código de póliza para iniciar la búsqueda.",
                                "Validación de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Implementación de consulta LINQ sobre la estructura de datos global.
                // Extrae información relacionada mediante la interoperabilidad entre Clientes y Pólizas.
                var resultadoConsulta = from Poliza p in VariableGlobal.lista.OfType<Poliza>()
                                        where p.ClienteAsociado.Rut == criterioBusqueda || p.Codigo == criterioBusqueda
                                        select new
                                        {
                                            Rut = p.ClienteAsociado.Rut,
                                            Titular = p.ClienteAsociado.Nombre + " " + p.ClienteAsociado.Apellido,
                                            Codigo_Poliza = p.Codigo,
                                            Tipo_Seguro = p.Tipo,
                                            Vigencia_Años = p.Vigencia,
                                            Valor_UF = p.ValorUF.ToString("N0"),
                                            Cobertura_UF = p.CoberturaUF.ToString("N0")
                                        };

                var listaFinal = resultadoConsulta.ToList();

                // Gestión de la actualización de la interfaz según los resultados obtenidos
                if (listaFinal.Count > 0)
                {
                    dgvListaFiltrada.DataSource = listaFinal;
                    dgvListaFiltrada.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    // Restablecimiento del control visual ante la ausencia de coincidencias
                    dgvListaFiltrada.DataSource = null;
                    MessageBox.Show($"Búsqueda finalizada: No se hallaron registros vinculados a '{criterioBusqueda}'.",
                                    "Búsqueda sin Coincidencias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Notificación de error en la capa de procesamiento de datos
                MessageBox.Show("Error sistémico al procesar la consulta: " + ex.Message,
                                "Falla Operativa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_ConsultarPoliza_Load(object sender, EventArgs e)
        {

        }
    }
}