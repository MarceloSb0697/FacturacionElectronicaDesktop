using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionElectronicaDesktop.Modelo.Entidades
{
    public class Productos
    {
        public string CodigoUnidadMedida { get; set; }

        public string CodigoProducto { get; set; }

        public string DescripcionProducto { get; set; }

        public string CodigoMoneda { get; set; }

        public string ValorUnitario { get; set; }

        public string PrecioUnitario { get; set; }


        public Productos()
        {

        }

        public Productos(string CodigoUnidadMedida, string CodigoProducto, string DescripcionProducto, string CodigoMoneda, string ValorUnitario, string PrecioUnitario)
        {
            this.CodigoUnidadMedida = CodigoUnidadMedida;
            this.CodigoProducto = CodigoProducto;
            this.DescripcionProducto = DescripcionProducto;
            this.CodigoMoneda = CodigoMoneda;
            this.ValorUnitario = ValorUnitario;
            this.PrecioUnitario = PrecioUnitario;
        }

        public Productos(string CodigoProducto)
        {
            this.CodigoProducto = CodigoProducto;
        }
    }
}
