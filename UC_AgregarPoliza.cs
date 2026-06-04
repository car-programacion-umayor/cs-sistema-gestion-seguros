using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaGestionSeguros
{
    /// <summary>
    /// Gestiona la creación de pólizas y su vinculación con la entidad Cliente mediante colaboración.
    /// </summary>
    public partial class UC_AgregarPoliza : UserControl
    {
        private Random random = new Random();
        private Cliente clienteSeleccionado;

        public UC_AgregarPoliza()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Carga las opciones del ComboBox de tipos de póliza.
        /// </summary>
        private void CargarTiposPoliza()
        {
            cmbTipoPoliza.Items.Add("Automóvil");
            cmbTipoPoliza.Items.Add("Hogar");
            cmbTipoPoliza.Items.Add("Vida");
            cmbTipoPoliza.Items.Add("Salud");
            cmbTipoPoliza.Items.Add("Viaje");

            cmbTipoPoliza.SelectedIndex = 0; // Selecciona el primer tipo por defecto
        }
        private string GenerarCodigoPoliza(string tipoPoliza)
        {
            string prefijo = "";

            switch (tipoPoliza)
            {
                case "Automóvil":
                    prefijo = "AUTO";
                    break;
                case "Hogar":
                    prefijo = "HOGAR";
                    break;
                case "Vida":
                    prefijo = "VIDA";
                    break;
                case "Salud":
                    prefijo = "SALUD";
                    break;
                case "Viaje":
                    prefijo = "VIAJE";
                    break;
            }

            int numeroAleatorio = random.Next(1000, 9999);
            return $"{prefijo}-{numeroAleatorio}";
        }
        /// <summary>
        /// Botón para generar el código automáticamente.
        /// </summary>

        /// <summary>
        /// Carga los valores de referencia de la poliza según el tipo seleccionado y actualiza los campos correspondientes.
        /// </summary>
        
        private void CargarValoresReferenciales()
        {

            if (cmbTipoPoliza.SelectedItem == null)
                return;

            string tipoSeleccionado = cmbTipoPoliza.SelectedItem.ToString();

            switch (tipoSeleccionado)
            {
                case "Automóvil":
                    txtValorUF.Text = "1.20";
                    txtCoberturaUF.Text = "500";
                    break;
                case "Hogar":
                    txtValorUF.Text = "0.85";
                    txtCoberturaUF.Text = "350";
                    break;
                case "Vida":
                    txtValorUF.Text = "0.95";
                    txtCoberturaUF.Text = "700";
                    break;
                case "Salud":
                    txtValorUF.Text = "1.10";
                    txtCoberturaUF.Text = "150";
                    break;
                case "Viaje":
                    txtValorUF.Text = "100";
                    txtCoberturaUF.Text = "200";
                    break;
                default:
                    txtValorUF.Text = "";
                    txtCoberturaUF.Text = "";
                    break;
            }
        }
        private void btnGenerarCodigo_Click(object sender, EventArgs e)
        {
            if (cmbTipoPoliza.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de póliza antes de generar el código.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string tipoSeleccionado = cmbTipoPoliza.SelectedItem.ToString();
            txtCodigo.Text = GenerarCodigoPoliza(tipoSeleccionado);
        }

        /// <summary> 
        /// Ejecuta la lógica de instanciación, vinculación y persistencia global de la póliza.
        /// </summary>
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de estado: Asegura que exista un cliente en memoria antes de proceder
                if (clienteSeleccionado == null)
                {
                    MessageBox.Show("Debe buscar y seleccionar un cliente antes de registrar la póliza.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                if (cmbTipoPoliza.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un tipo de póliza.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                {
                    MessageBox.Show("Debe generar el código de la póliza.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtVigencia.Text))
                {
                    MessageBox.Show("Debe ingresar la vigencia.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                // Captura y conversión de datos desde la interfaz
                string cod = txtCodigo.Text.Trim();
                string tipo = cmbTipoPoliza.SelectedItem.ToString();
                int vigencia = int.Parse(txtVigencia.Text);
                double valor = double.Parse(txtValorUF.Text);
                double cobertura = double.Parse(txtCoberturaUF.Text);

                // Instanciación de la entidad Póliza
                Poliza nuevaPoliza = new Poliza(cod, tipo, vigencia, valor, cobertura);


                // Implementación de Colaboración de Clases: Asignación de la referencia del titular
                nuevaPoliza.ClienteAsociado = clienteSeleccionado;

                // Almacenamiento en la estructura de datos dinámica global
                VariableGlobal.lista.Add(nuevaPoliza);

                // Confirmación de operación exitosa con resumen de vinculación
                string resumen = $"Vínculo Exitoso:\n\nTitular: {nuevaPoliza.ClienteAsociado.Nombre} {nuevaPoliza.ClienteAsociado.Apellido}\nN° Póliza: {nuevaPoliza.Codigo}";
                MessageBox.Show(resumen, "Sistema de Gestión", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
            }
            catch (FormatException)
            {
                MessageBox.Show("Error de formato: Ingrese valores numéricos válidos en Vigencia, Valor y Cobertura.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado en el procesamiento: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Restablece el estado de los componentes de entrada para un nuevo registro.
        /// </summary>
        private void LimpiarFormulario()
        {
            clienteSeleccionado = null;

            cmbTipoPoliza.SelectedIndex = 0;
            txtCodigo.Clear();
            txtVigencia.Clear();

            CargarValoresReferenciales();
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_AgregarPoliza_Load(object sender, EventArgs e)
        {
            CargarTiposPoliza();
            txtCodigo.ReadOnly = true;
            txtCoberturaUF.ReadOnly = true;
            clienteSeleccionado = VariableGlobal.UltimoCliente;

            if (clienteSeleccionado != null)
            {
                lblClienteResultado.Text = $"Cliente actual: {clienteSeleccionado.Nombre} {clienteSeleccionado.Apellido}";
            }
            else
            {
                lblClienteResultado.Text = "Cliente: no seleccionado";
            }
            CargarValoresReferenciales();
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tipoPoliza_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            CargarValoresReferenciales();
        }

        private void lblCriterioBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string rutBuscado = txtRutBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(rutBuscado))
            {
                MessageBox.Show("Ingrese el RUT del cliente.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            clienteSeleccionado = VariableGlobal.lista
                .OfType<Cliente>()
                .FirstOrDefault(c => c.Rut.Trim().Equals(rutBuscado, StringComparison.OrdinalIgnoreCase));

            if (clienteSeleccionado != null)
            {
                lblClienteResultado.Text = $"Cliente: {clienteSeleccionado.Nombre} {clienteSeleccionado.Apellido}";
            }
            else
            {
                lblClienteResultado.Text = "Cliente: no encontrado";
                MessageBox.Show("No se encontró un cliente con ese RUT.",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}