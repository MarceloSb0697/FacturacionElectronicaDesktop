using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionElectronicaDesktop.Entidades
{
    public class DetalleFactura
    {
        public int NumeroDetalle { get; set; }

        public int NumeroFactura { get; set; }

        public string CodigoProducto { get; set; }

        public string Cantidad { get; set; }

        public string CodigoTipoIGV { get; set; }

        public string ValorUnitario { get; set; }

        public string Subtotal { get; set; }

        public string TotalProducto { get; set; }

        public DetalleFactura()
        {

        }

        public DetalleFactura(int NumeroFactura, string CodigoProducto, string Cantidad, string CodigoTipoIGV,
            string ValorUnirario, string Subtotal, string TotalProducto)
        {
            this.NumeroFactura = NumeroFactura;
            this.CodigoProducto = CodigoProducto;
            this.Cantidad = Cantidad;
            this.CodigoTipoIGV = CodigoTipoIGV;
            this.ValorUnitario = ValorUnitario;
            this.Subtotal = Subtotal;
            this.TotalProducto = TotalProducto;
        }
    }
}
