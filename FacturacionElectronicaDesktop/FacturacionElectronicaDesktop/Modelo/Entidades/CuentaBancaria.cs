using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionElectronicaDesktop.Modelo.Entidades
{
    public class CuentaBancaria
    {
        public string IdCuentaBancaria { get; set; }
        public string CodigoMoneda { get; set; }
        public string IdTipoCuenta { get; set; }
        public string NombreBanco { get; set; }
        public string Titular { get; set; }
        public string NumeroCuenta { get; set; }
    }
}
