using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionElectronicaDesktop.Entidades
{
    public class FacturacionElectronica
    {
        public int NumeroFactura { get; set; }

        public string RucEmsior { get; set; }

        public string RazonEmisor { get; set; }

        public string NumeroSerie { get; set; }

        public string NumeroCorrelativo { get; set; }

        public string CodigoDocumentElectronico { get; set; }

        public string NumeroRuc { get; set; }

        public string RazonSocial { get; set; }

        public DateTime FechaEmision { get; set; }

        public string CodigoOperacion { get; set; }

        public string CodigoMoneda { get; set; }

        public string TipoCambio { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public string Estado { get; set; }

        public string Exonerada { get; set; }

        public string Inafecta { get; set; }

        public string Gravada { get; set; }

        public string IGV { get; set; }

        public string Gratuita { get; set; }

        public string TotalBoleta { get; set; }

        public string Observacion { get; set; }

        public string CodigoNotaCredito { get; set; }

        public string CodigoNotaDebito { get; set; }

    }
}
