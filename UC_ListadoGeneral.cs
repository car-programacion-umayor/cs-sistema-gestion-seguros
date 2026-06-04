using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SistemaGestionSeguros
{
    public partial class UC_ListadoGeneral : UserControl
    {
        public UC_ListadoGeneral()
        {
            InitializeComponent();
        }

        // Cargar los datos en la tabla principal
        private void btnCargar_Click(object sender, EventArgs e)
        {
            // Limpiar la tabla antes de mostrar los datos actualizados
            dgvListado.DataSource = null;

            // Consultar los datos de la lista global usando LINQ
            // Combinar la información de Póliza y Cliente para el listado
            var datosParaTabla = from Poliza p in VariableGlobal.lista.OfType<Poliza>()
                                 select new
                                 {
                                     Nro_Póliza = p.Codigo,
                                     Titular = p.ClienteAsociado.Nombre + " " + p.ClienteAsociado.Apellido,
                                     RUT_Cliente = p.ClienteAsociado.Rut,
                                     Contacto = p.ClienteAsociado.Telefono,
                                     Tipo_Seguro = p.Tipo,
                                     Vigencia_Años = p.Vigencia,
                                     Costo_UF = p.ValorUF.ToString("N0"),
                                     Cobertura_UF = p.CoberturaUF.ToString("N0"),
                                 };

            // Pasar los datos encontrados al control de la pantalla
            dgvListado.DataSource = datosParaTabla.ToList();

            // Ajustar el tamaño de las columnas de forma automática
            dgvListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void UC_ListadoGeneral_Load(object sender, EventArgs e)
        {

        }
    }
}