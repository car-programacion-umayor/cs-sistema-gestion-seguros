using System;
using System.Collections;

namespace SistemaGestionSeguros
{
    /// <summary>
    /// Gestiona la persistencia temporal de datos y la transferencia de información entre módulos.
    /// </summary>
    public static class VariableGlobal
    {
        /// <summary>
        /// Referencia temporal de la entidad Cliente para procesos de colaboración entre clases.
        /// </summary>
        public static Cliente UltimoCliente;

        /// <summary>
        /// Estructura de datos dinámica para el almacenamiento global de las pólizas registradas.
        /// </summary>
        public static ArrayList lista = new ArrayList();
    }
}