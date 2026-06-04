using System;

namespace SistemaGestionSeguros
{
    /// <summary>
    /// Representa la entidad Póliza y gestiona la integridad de sus datos asociados.
    /// </summary>
    [Serializable]
    public class Poliza
    {
        // Miembros privados de la clase
        private Cliente _clienteAsociado;
        private string _codigo;
        private string _tipo;
        private int _vigencia;
        private double _valorUF;
        private double _coberturaUF;
        private double _valorSimuladoPesos;

        // Propiedades públicas para el acceso y mutación de datos
        public Cliente ClienteAsociado { get => _clienteAsociado; set => _clienteAsociado = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public int Vigencia { get => _vigencia; set => _vigencia = value; }
        public double ValorUF { get => _valorUF; set => _valorUF = value; }
        public double CoberturaUF { get => _coberturaUF; set => _coberturaUF = value; }
        public double ValorSimuladoPesos { get => _valorSimuladoPesos; set => _valorSimuladoPesos = value; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Póliza con los parámetros básicos requeridos.
        /// </summary>
        public Poliza(string codigo, string tipo, int vigencia, double valorUF, double coberturaUF)
        {
            this._codigo = codigo;
            this._tipo = tipo;
            this._vigencia = vigencia;
            this._valorUF = valorUF;
            this._coberturaUF = coberturaUF;
            this._valorSimuladoPesos = 0;
        }

        /// <summary>
        /// Genera una cadena representativa del objeto para visualización en interfaz.
        /// </summary>
        /// <returns>Descripción formateada de la póliza.</returns>
        public override string ToString()
        {
            return $"Póliza: {this._tipo} (Cód: {this._codigo})";
        }
    }
}