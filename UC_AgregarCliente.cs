using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaGestionSeguros
{
    /// <summary>
    /// Componente de interfaz para la captura y validación inicial de datos del titular.
    /// </summary>
    public partial class UC_AgregarCliente : UserControl
    {
        public UC_AgregarCliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Procesa la información del formulario, instancia la entidad Cliente y gestiona su persistencia temporal.
        /// </summary>
        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Recuperación de valores desde los componentes de entrada
                string rut = txtRut.Text.Trim();
                string nom = txtNombre.Text.Trim();
                string ape = txtApellido.Text.Trim();
                string tel = txtTelefono.Text.Trim();

                // Validación de integridad de datos obligatorios
                if (string.IsNullOrEmpty(rut) || string.IsNullOrEmpty(nom))
                {
                    MessageBox.Show("Operación cancelada: Se requiere RUT y Nombre como campos obligatorios.", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Verificamos que el cliente no exista previamente en la lista global para evitar duplicados
                bool existeCliente = VariableGlobal.lista
            .OfType<Cliente>()
            .Any(c => c.Rut.Trim().Equals(rut, StringComparison.OrdinalIgnoreCase));

                if (existeCliente)
                {
                    MessageBox.Show("Ya existe un cliente registrado con ese RUT.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    LimpiarFormulario();
                    return;
                }
                // Instanciación de la entidad Cliente mediante constructor especializado
                Cliente nuevoCliente = new Cliente(rut, nom, ape, tel);

                // Gestión de la persistencia temporal para colaboración con el módulo de Pólizas
                VariableGlobal.UltimoCliente = nuevoCliente;
                VariableGlobal.lista.Add(nuevoCliente);

                MessageBox.Show("Registro exitoso: Los datos del cliente han sido capturados.\nProceda al módulo 'Agregar Pólizas' para completar el registro.", "Sistema de Seguros", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el procesamiento de datos: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Restablece el estado inicial de los componentes de entrada de texto.
        /// </summary>
        private void LimpiarFormulario()
        {
            txtRut.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
        }

        private void UC_AgregarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}