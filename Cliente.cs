using System;

namespace SistemaGestionSeguros
{
    /// <summary>
    /// Representa la entidad Cliente y gestiona la información personal del titular de la póliza.
    /// </summary>
    public class Cliente
    {
        // Miembros privados para la gestión interna de datos
        private string rut;
        private string nombre;
        private string apellido;
        private string telefono;

        // Propiedades públicas para el acceso y asignación de información
        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Cliente con los datos de contacto requeridos.
        /// </summary>
        public Cliente(string rut, string nombre, string apellido, string telefono)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
        }
    }
}