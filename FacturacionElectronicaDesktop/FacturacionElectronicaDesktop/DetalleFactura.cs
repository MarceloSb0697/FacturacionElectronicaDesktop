//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FacturacionElectronicaDesktop
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleFactura
    {
        public int codigo_detalle { get; set; }
        public int num_factura { get; set; }
        public Nullable<int> codigo_producto { get; set; }
        public Nullable<int> cantidad { get; set; }
        public Nullable<int> codigo_tipo_igv { get; set; }
        public Nullable<decimal> valor_unitario { get; set; }
        public Nullable<decimal> subtotal { get; set; }
        public Nullable<decimal> total_producto { get; set; }
    
        public virtual Productos Productos { get; set; }
        public virtual FacturacionElectronica FacturacionElectronica { get; set; }
    }
}
