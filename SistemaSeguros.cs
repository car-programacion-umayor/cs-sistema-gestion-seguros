using System;
using System.Collections;

namespace SistemaGestionSeguros
{
    /// <summary>
    /// Proporciona la lógica de negocio para la gestión y vinculación de entidades del sistema.
    /// </summary>
    internal class SistemaSeguros
    {
        /// <summary>
        /// Repositorio dinámico para el almacenamiento centralizado de registros de seguros.
        /// </summary>
        public static ArrayList ListaSeguros = new ArrayList();

        /// <summary>
        /// Gestiona la vinculación entre una instancia de Cliente y una instancia de Póliza.
        /// </summary>
        /// <param name="objCliente">Objeto que contiene la información del titular.</param>
        /// <param name="objPoliza">Objeto que contiene las condiciones de la póliza.</param>
        public static void RegistrarSeguro(Cliente objCliente, Poliza objPoliza)
        {
            // Ejecuta la persistencia del registro mediante la interoperabilidad de clases
            ListaSeguros.Add(new { Cliente = objCliente, Poliza = objPoliza });
        }
    }
}