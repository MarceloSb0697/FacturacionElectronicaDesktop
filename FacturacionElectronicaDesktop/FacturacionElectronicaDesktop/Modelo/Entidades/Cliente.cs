using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionElectronicaDesktop.Entidades
{
    public class Cliente
    {
        public string NumeroRuc { get; set; }

        public string CodigoDocumento { get; set; }

        public string RazonSocial { get; set; }

        public string Direccion { get; set; }

        public string Email { get; set; }

        public string TelefonoMovil { get; set; }

        public string TelefonoFijo { get; set; }
    }
}
