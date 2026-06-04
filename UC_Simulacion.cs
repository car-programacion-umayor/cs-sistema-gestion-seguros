using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SistemaGestionSeguros
{
    public partial class UC_Simulacion : UserControl
    {
        public UC_Simulacion()
        {
            InitializeComponent();
        }

        private void btnSimularYGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturar parámetros de entrada para la simulación
                string codigoBusqueda = txtCodigoSimular.Text.Trim();
                double valorUfActual;

                // Verificar que el valor de la UF sea un número válido
                if (!double.TryParse(txtValorUfHoy.Text, out valorUfActual))
                {
                    MessageBox.Show("Ingresar un valor de UF válido para realizar el cálculo.");
                    return;
                }

                // Localizar la póliza en la estructura global mediante su código
                var polizaEncontrada = VariableGlobal.lista.OfType<Poliza>()
                    .FirstOrDefault(p => p.Codigo == codigoBusqueda);

                if (polizaEncontrada != null)
                {
                    // Calcular el valor en pesos y actualizar el objeto
                    double resultadoPesos = polizaEncontrada.ValorUF * valorUfActual;
                    polizaEncontrada.ValorSimuladoPesos = resultadoPesos;

                    // Mostrar el resultado en la interfaz gráfica
                    lblResultadoPesos.Text = resultadoPesos.ToString("C0");

                    // Refrescar el historial de cálculos realizados
                    var historialSimulacion = from Poliza p in VariableGlobal.lista.OfType<Poliza>()
                                              where p.ValorSimuladoPesos > 0
                                              select new
                                              {
                                                  Código = p.Codigo,
                                                  Tipo = p.Tipo,
                                                  Valor_UF = valorUfActual.ToString("N0"),
                                                  Total_Pesos = p.ValorSimuladoPesos.ToString("C0")
                                              };

                    // Asignar los resultados al control de datos
                    dgvSimulaciones.DataSource = historialSimulacion.ToList();
                }
                else
                {
                    // Notificar en caso de no encontrar el código solicitado
                    MessageBox.Show("Póliza no encontrada con el código: " + codigoBusqueda);
                }
            }
            catch (Exception ex)
            {
                // Gestionar cualquier error durante el proceso
                MessageBox.Show("Error al procesar la simulación: " + ex.Message);
            }
        }

        private void UC_Simulacion_Load(object sender, EventArgs e)
        {

        }
    }
}