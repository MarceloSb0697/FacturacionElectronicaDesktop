using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionElectronicaDesktop.Entidades
{
    public class Productos
    {
        public Productos()
        {

        }

        public Productos(string CodigoProducto)
        {
            this.CodigoProducto = CodigoProducto;
        }

        public string CodigoUnidadMedida { get; set; }

        public string CodigoProducto { get; set; }

        public string DescripcionProducto { get; set; }

        public string CodigoMoneda { get; set; }

        public string ValorUnitario { get; set; }

        public string PrecioUnitario { get; set; }
    }
}
